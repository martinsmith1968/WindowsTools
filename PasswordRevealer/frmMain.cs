using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PasswordRevealer
{
    public partial class frmMain : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool EnumChildWindows(IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);


        public const int EM_SETPASSWORDCHAR = 204;

        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        /// <summary>
        /// Loads the settings.
        /// </summary>
        private void LoadSettings()
        {
            if (Properties.Settings.Default.IsUpgraded)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.IsUpgraded = false;
            }

            try
            {
                this.Location = Properties.Settings.Default.Main_Location;
            }
            catch { }

            try
            {
                this.chkWindowOnTop.Checked = Properties.Settings.Default.Main_WindowOnTop;
                SetTopMost(this.chkWindowOnTop.Checked);
            }
            catch { }
        }

        /// <summary>
        /// Saves the settings.
        /// </summary>
        private void SaveSettings()
        {
            Properties.Settings.Default.IsUpgraded = false;
            Properties.Settings.Default.Main_Location = this.Location;
            Properties.Settings.Default.Main_WindowOnTop = chkWindowOnTop.Checked;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Sets the top most.
        /// </summary>
        /// <param name="topMost">if set to <c>true</c> [top most].</param>
        private void SetTopMost(bool topMost)
        {
            this.TopMost = topMost;
        }

        /// <summary>
        /// Setups the progress.
        /// </summary>
        private void SetupProgress()
        {
            SetupProgress(0, 0);
        }

        /// <summary>
        /// Setups the progress.
        /// </summary>
        /// <param name="min">The min.</param>
        /// <param name="max">The max.</param>
        private void SetupProgress(int min, int max)
        {
            if (max <= min)
            {
                pgbProgress.Visible = false;
            }
            else
            {
                pgbProgress.Minimum = min;
                pgbProgress.Value = min;
                pgbProgress.Maximum = max;
                pgbProgress.Visible = true;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName;

            btnTest.Enabled = System.Diagnostics.Debugger.IsAttached;
            btnTest.Visible = btnTest.Enabled;

            if (btnTest.Enabled)
            {
                int space = (btnReveal.Parent.ClientSize.Width - btnReveal.Width - btnTest.Width) / 3;
                btnReveal.Left = space;
                btnTest.Left = btnTest.Parent.ClientSize.Width - btnTest.Width - space;
            }
            else
            {
                btnReveal.Left = (btnReveal.Parent.ClientSize.Width - btnReveal.Width) / 2;
            }

            SetupProgress();

            LoadSettings();
        }

        /// <summary>
        /// Handles the KeyPress event of the frmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs"/> instance containing the event data.</param>
        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((Keys)e.KeyChar)
            {
                case Keys.Escape:
                    Close();
                    e.Handled = true;
                    break;
            }
        }

        /// <summary>
        /// Handles the FormClosed event of the frmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosedEventArgs"/> instance containing the event data.</param>
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        /// <summary>
        /// Handles the CheckedChanged event of the chkWindowOnTop control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void chkWindowOnTop_CheckedChanged(object sender, EventArgs e)
        {
            SetTopMost(chkWindowOnTop.Checked);
        }

        /// <summary>
        /// Handles the Click event of the btnReveal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnReveal_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
#if false
            PasswordRevealer.Windows windows = new Windows(true, true);

            SetupProgress(0, windows.Count);

            foreach (Window window in windows)
            {
                pgbProgress.Increment(1);
                pgbProgress.Refresh();

                Window.SendMessage(window.hWnd, Window.EM_SETPASSWORDCHAR, 0, 0);
                Window.InvalidateRect(window.hWnd, IntPtr.Zero, false);
            }

            SetupProgress();
#endif

                // note in other situations, it is important to keep
                // callBackPtr as a member variable so it doesnt GC while you're calling EnumWindows
                EnumWindowsProc ewp = new EnumWindowsProc(ProcessMain);
                EnumWindows(ewp, IntPtr.Zero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Processes the main.
        /// </summary>
        /// <param name="hWnd">The h WND.</param>
        /// <param name="lParam">The l param.</param>
        /// <returns></returns>
        public static bool ProcessMain(IntPtr hWnd, IntPtr lParam)
        {
            EnumWindowsProc ewp = new EnumWindowsProc(ProcessChild);
            EnumChildWindows(hWnd, ewp, IntPtr.Zero);
            return true;
        }

        /// <summary>
        /// Reports the specified HWND.
        /// </summary>
        /// <param name="hwnd">The HWND.</param>
        /// <param name="lParam">The l param.</param>
        /// <returns></returns>
        public static bool ProcessChild(IntPtr hWnd, IntPtr lParam)
        {
            SendMessage(hWnd, EM_SETPASSWORDCHAR, 0, 0);
            InvalidateRect(hWnd, IntPtr.Zero, false);
            return true;
        }

        /// <summary>
        /// Handles the Click event of the btnTest control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            frmTestForm frm = new frmTestForm();
            frm.Show();
        }
    }
}

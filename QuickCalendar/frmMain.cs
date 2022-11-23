using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuickCalendar
{
    public partial class frmMain : Form
    {
        private bool _InDateChanged = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ApplySettings()
        {
            mcalCalendar.ShowToday = Properties.Settings.Default.Calendar_ShowToday;
            mcalCalendar.ShowTodayCircle = Properties.Settings.Default.Calendar_ShowTodayCircle;
            mcalCalendar.ShowWeekNumbers = Properties.Settings.Default.Calendar_ShowWeekNumbers;
            mcalCalendar.FirstDayOfWeek = Properties.Settings.Default.Calendar_FirstDayOfWeek;
        }

        private Size CalculateCalendarSize(int width, int height)
        {
            Size dimensions = new Size(
                            (mcalCalendar.SingleMonthSize.Width * width) + mcalCalendar.Margin.Horizontal,
                            (mcalCalendar.SingleMonthSize.Height * height) + tsMain.Height + ssMain.Height + mcalCalendar.Margin.Top
                            );

            return dimensions;
        }

        private void ShowSelection()
        {
            if (mcalCalendar.SelectionRange.Start < mcalCalendar.SelectionRange.End)
            {
                tslblSelection.Text = string.Format("{0} Days Selected", (mcalCalendar.SelectionRange.End - mcalCalendar.SelectionRange.Start).Days + 1);
            }
            else
            {
                tslblSelection.Text = string.Format("Day {0}", mcalCalendar.SelectionStart.DayOfYear);
            }
        }

        private void ShowInfoText()
        {
            ShowInfoText(string.Empty);
        }
        private void ShowInfoText(string text)
        {
            tslblInfo.Text = text;
        }

        private void SelectDate(DateTime dt)
        {
            mcalCalendar.SelectionRange = new SelectionRange(dt, dt);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            //ShowSelection();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Application.Idle += new EventHandler(Application_Idle);

            Text = ProductName;

            mcalCalendar.Dock = DockStyle.Fill;
            mcalCalendar.MaxSelectionCount = int.MaxValue;

            /*
            mcalCalendar.AddAnnuallyBoldedDate(new DateTime(DateTime.Today.Year, 12, 25));
            mcalCalendar.AddAnnuallyBoldedDate(new DateTime(DateTime.Today.Year, 08, 11));
            mcalCalendar.AddBoldedDate(new DateTime(DateTime.Today.Year, 04, 06));
            mcalCalendar.AddMonthlyBoldedDate(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 13));
            mcalCalendar.RemoveAllBoldedDates();
             * */

            // Upgrade User Settings ?
            if (Properties.Settings.Default.App_UpgradePending)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.App_UpgradePending = false;
            }
            if (!Properties.Settings.Default.Main_Location.IsEmpty)
                Location = new Point(Properties.Settings.Default.Main_Location.X, Properties.Settings.Default.Main_Location.Y);
            if (!Properties.Settings.Default.Main_Size.IsEmpty)
                Size = new Size(Properties.Settings.Default.Main_Size.Width, Properties.Settings.Default.Main_Size.Height);

            ApplySettings();

            tsmnuViewToday.PerformClick();
            ShowSelection();
            ShowInfoText();
        }

        private void tsmnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmnuHelpAbout_Click(object sender, EventArgs e)
        {
            using (AboutBox frm = new AboutBox())
            {
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void tsmnuEditPreferences_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();  // Ensure Form positions are not overwritten

            using (frmPreferences frm = new frmPreferences())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    ApplySettings();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Properties.Settings.Default.Main_Location = new Point(Location.X, Location.Y);
                Properties.Settings.Default.Main_Size = new Size(Size.Width, Size.Height);
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message, "Debug");
            }
        }

        private void tsmnuViewToday_Click(object sender, EventArgs e)
        {
            SelectDate(DateTime.Today);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tsmnuFileExit.PerformClick();
            }
        }

        private void tsmnuViewGotoDate_Click(object sender, EventArgs e)
        {
            DateTime dt = mcalCalendar.SelectionStart;
            if (frmDatePicker.SelectDate(ref dt) == DialogResult.OK)
            {
                SelectDate(dt);
                //mcalCalendar.SelectionStart = dt;
                //mcalCalendar.SelectionEnd = dt;
            }
        }

        private void mcalCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            ShowSelection();
        }

        private void tsmnuViewResizeYearWide4X3_Click(object sender, EventArgs e)
        {
            ClientSize = CalculateCalendarSize(4, 3);
        }

        private void tsmnuViewResizeYearTall3X4_Click(object sender, EventArgs e)
        {
            ClientSize = CalculateCalendarSize(3, 4);
        }

        private void mcalCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!Properties.Settings.Default.YearViewStartsWithFirstMonth)
                return;
            if (_InDateChanged)
                return;

            try
            {
                _InDateChanged = true;

                int displayMonths = mcalCalendar.CalendarDimensions.Width * mcalCalendar.CalendarDimensions.Height;
                if (displayMonths >= 12)
                {
                    SelectionRange selectionRange = mcalCalendar.GetDisplayRange(true);
                    while (selectionRange.Start.Month > 1)
                    {
                        mcalCalendar.Focus();
                        if (selectionRange.Start.Year < mcalCalendar.SelectionStart.Year)
                        {
                            SendKeys.SendWait("{PGDN}");
                        }
                        else
                        {
                            SendKeys.SendWait("{PGUP}");
                        }

                        selectionRange = mcalCalendar.GetDisplayRange(true);
                    }
                }
            }
            catch
            {
            }
            finally
            {
                _InDateChanged = false;
            }
        }
    }
}

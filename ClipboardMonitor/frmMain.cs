using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NRA.Util;

namespace ClipboardMonitor
{
    /// <summary>
    ///
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        ///
        /// </summary>
        private CustomLogListener logListener = null;

        /// <summary>
        /// A reference to the Log instance
        /// </summary>
        private LogWriter Log = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the frmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            Log = LogWriter.Instance;

            this.logListener = new CustomLogListener();
            this.logListener.OnLogStart += new CustomLogListener.LogStartDelegate(logListener_OnLogStart);
            this.logListener.OnLogFinish += new CustomLogListener.LogFinishDelegate(logListener_OnLogFinish);
            this.logListener.OnLogMessage += new CustomLogListener.LogMessageDelegate(logListener_OnLogMessage);

            Log.AddListener(this.logListener);

            grpRules.Dock = DockStyle.Fill;

            Log.WriteLine("Main Form started");
        }

        /// <summary>
        /// Logs the listener_ on log message.
        /// </summary>
        /// <param name="args">The <see cref="NRA.Util.CustomLogEventArgs"/> instance containing the event data.</param>
        void logListener_OnLogMessage(CustomLogEventArgs args)
        {
            ListViewItem item = new ListViewItem();
            item.Text = args.Timestamp.ToString(LogWriter.FORMAT_TIME_WITH_MILLISECOND);
            item.SubItems.Add(args.Severity.ToString());
            item.SubItems.Add(args.Text);

            lvwLog.Items.Add(item);

            item.Selected = true;
            item.Focused = true;
            item.EnsureVisible();
        }

        /// <summary>
        /// Logs the listener_ on log finish.
        /// </summary>
        void logListener_OnLogFinish()
        {
            CustomLogEventArgs args = new CustomLogEventArgs(DateTime.Now, Severity.Information, "*** Log Finished ***");

            logListener_OnLogMessage(args);
        }

        /// <summary>
        /// Logs the listener_ on log start.
        /// </summary>
        void logListener_OnLogStart()
        {
            CustomLogEventArgs args = new CustomLogEventArgs(DateTime.Now, Severity.Information, "*** Log Started ***");

            logListener_OnLogMessage(args);
        }

        /// <summary>
        /// Handles the Click event of the mnuHelpExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuHelpExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the Click event of the mnuHelpAbout control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            Log.WriteLine(Severity.Debug, "Help -> About");

            using (var frm = new frmAbout())
            {
                frm.ShowDialog();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace WebBrowser
{
    public partial class frmBrowser : Form
    {
        private int _TabCount = 0;
        Dictionary<string, BrowserPage> _Pages = new Dictionary<string,BrowserPage>();

        #region Settings

        private void LoadUserSettings()
        {
            try
            {
                if (Properties.Settings.Default.IsUpgraded)
                {
                    Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.IsUpgraded = true;
                }

                Location = Properties.Settings.Default.MainForm_Location;
                Size = Properties.Settings.Default.MainForm_Size;
                WindowState = Properties.Settings.Default.MainForm_WindowState;

                cboURL.Items.Clear();
                if (Properties.Settings.Default.URLHistory != null)
                {
                    foreach(string s in Properties.Settings.Default.URLHistory)
                        cboURL.Items.Add(s);
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void SaveUserSettings()
        {
            try
            {
                Properties.Settings.Default.IsUpgraded = false;

                if (WindowState == FormWindowState.Normal)
                {
                    Properties.Settings.Default.MainForm_Location = Location;
                    Properties.Settings.Default.MainForm_Size = Size;
                }
                else
                {
                    Properties.Settings.Default.MainForm_Location = RestoreBounds.Location;
                    Properties.Settings.Default.MainForm_Size = RestoreBounds.Size;
                }
                Properties.Settings.Default.MainForm_WindowState = WindowState;

                Properties.Settings.Default.URLHistory = new System.Collections.Specialized.StringCollection();
                foreach(object o in cboURL.Items)
                    Properties.Settings.Default.URLHistory.Add(Convert.ToString(o));

                Properties.Settings.Default.Save();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        #endregion

        public frmBrowser()
        {
            InitializeComponent();
        }

        private void frmBrowser_Load(object sender, EventArgs e)
        {
            tbcBrowser.Dock = DockStyle.Fill;

            LoadUserSettings();

            NewTab();
        }

        private void frmBrowser_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveUserSettings();
        }

        private int NewTab()
        {
            ++_TabCount;

            _Pages.Add(_TabCount.ToString(), new BrowserPage(tbcBrowser, _TabCount));

            return _TabCount;
        }

        private int GetActiveIndex()
        {
            int index = 0;

            TabPage tbp = tbcBrowser.SelectedTab;
            if (tbp != null)
            {
                if (tbp.Tag != null)
                    index = Convert.ToInt32(tbp.Tag);
            }

            return index;
        }

        private BrowserPage GetBrowserPage()
        {
            return GetBrowserPage(GetActiveIndex());
        }
        private BrowserPage GetBrowserPage(int tabNumber)
        {
            return _Pages[tabNumber.ToString()];
        }

        private void RetrievePage(string url)
        {
            RetrievePage(new Uri(url));
        }
        private void RetrievePage(Uri uri)
        {
            int index = GetActiveIndex();
            if (index == 0)
                index = NewTab();

            BrowserPage browserPage = GetBrowserPage(index);
            if (browserPage != null)
            {
                browserPage.URI = uri;

                WebClient client = new WebClient();

                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
                client.DownloadStringAsync(uri, index);
            }
        }

        void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            int index = Convert.ToInt32(e.UserState);

            BrowserPage browserPage = GetBrowserPage(index);
            if (browserPage != null)
            {
                if (e.Error != null)
                    browserPage.SetError(e.Error.Message);
                else
                    browserPage.SetResult(e.Result);
            }
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            int index = Convert.ToInt32(e.UserState);

            BrowserPage browserPage = GetBrowserPage(index);
            if (browserPage != null)
            {
                browserPage.ReceivedBytesLabel.Text = e.BytesReceived.ToString();
                browserPage.TotalBytesLabel.Text = e.TotalBytesToReceive.ToString();
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string url = cboURL.Text.Trim();

            if (!string.IsNullOrEmpty(url))
            {
                while (cboURL.Items.Contains(url))
                    cboURL.Items.Remove(url);

                cboURL.Items.Insert(0, url);
                cboURL.Text = url;
                cboURL.Select();

                RetrievePage(url);
            }
        }

        private void tsmnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmnuTabNew_Click(object sender, EventArgs e)
        {
            NewTab();
        }

        private void tsmnuTabClose_Click(object sender, EventArgs e)
        {
            //tbcBrowser.TabPages.Remove(
        }
    }
}

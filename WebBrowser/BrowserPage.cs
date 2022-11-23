using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WebBrowser
{
    public class BrowserPage
    {
        public readonly int TabNumber;
        public readonly TabPage TabPage;
        public readonly RichTextBox RichTextBox;
        public readonly StatusStrip StatusStrip;
        public readonly ToolStripStatusLabel StatusLabel;
        public readonly ToolStripStatusLabel ReceivedBytesLabel;
        public readonly ToolStripStatusLabel TotalBytesLabel;

        private Uri _URI;
        public Uri URI
        {
            get { return _URI; }
            set { _URI = value; UpdateTabName(); }
        }

        public BrowserPage(TabControl tbc, int tabNumber)
        {
            TabNumber = tabNumber;
            TabPage = new TabPage(string.Format("Unknown{0}", TabNumber));
            RichTextBox = new RichTextBox();
            StatusStrip = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            ReceivedBytesLabel = new ToolStripStatusLabel();
            TotalBytesLabel = new ToolStripStatusLabel();

            Configure(tbc);
        }

        public void Configure(TabControl tbc)
        {
            TabPage.Name = string.Format("tbpBrowser{0}", TabNumber);
            TabPage.Tag = TabNumber;
            tbc.TabPages.Add(TabPage);

            StatusStrip.Name = string.Format("ssBrowser{0}", TabNumber);
            StatusStrip.Parent = TabPage;
            StatusStrip.Dock = DockStyle.Bottom;

            StatusLabel.Name = string.Format("tslblStatusLabel{0}", TabNumber);
            StatusLabel.Owner = StatusStrip;
            StatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            StatusLabel.Spring = true;

            ReceivedBytesLabel.Name = string.Format("tslblReceivedBytes{0}", TabNumber);
            ReceivedBytesLabel.Owner = StatusStrip;
            ReceivedBytesLabel.TextAlign = ContentAlignment.MiddleCenter;
            ReceivedBytesLabel.Spring = false;
            ReceivedBytesLabel.AutoSize = true;

            TotalBytesLabel.Name = string.Format("tslblTotalBytes{0}", TabNumber);
            TotalBytesLabel.Owner = StatusStrip;
            TotalBytesLabel.TextAlign = ContentAlignment.MiddleCenter;
            TotalBytesLabel.Spring = false;
            TotalBytesLabel.AutoSize = true;

            RichTextBox.Name = string.Format("rtbBrowser{0}", TabNumber);
            RichTextBox.Parent = TabPage;
            RichTextBox.Dock = DockStyle.Fill;
            RichTextBox.Font = new Font("Consolas", 9);
            RichTextBox.ReadOnly = true;

            tbc.SelectTab(TabPage);
        }

        public void SetStatusText(string text)
        {
            StatusLabel.Text = text;
            StatusLabel.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
        }

        public void SetError(string errorText)
        {
            SetStatusText(errorText);
            StatusLabel.ForeColor = Color.Red;
        }

        public void SetResult(string contents)
        {
            RichTextBox.Text = contents;
            UpdateTabName();
        }

        public void UpdateTabName()
        {
            if (URI != null && URI.AbsoluteUri.Length > 0)
            {
                TabPage.Text = URI.PathAndQuery.Substring(0, URI.PathAndQuery.Length - URI.Query.Length);
            }
        }
    }
}

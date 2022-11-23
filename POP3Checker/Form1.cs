using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pop3;

namespace POP3Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetStatusText()
        {
            SetStatusText(string.Empty);
        }

        private void SetStatusText(string text)
        {
            sslStatusText.Text        = text;
            sslStatusText.ToolTipText = text;
        }

        private void ShowMessage()
        {
            ShowMessage(string.Empty);
        }

        private void ShowMessage(string detail)
        {
            if (!string.IsNullOrEmpty(detail))
            {
                detail = detail.Replace("\n", Environment.NewLine);
            }

            txtMessage.Text = detail;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panMessages.Dock = DockStyle.Fill;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                Pop3.Pop3Client client = new Pop3Client(txtUserName.Text, txtPassword.Text, txtServerName.Text);

                client.OpenInbox();

                while (client.NextEmail())
                {
                    AddEmail(client);
                }

                client.CloseConnection();
            }
            catch (Exception ex)
            {
                SetStatusText(string.Format("Error: {0}", ex.Message));
            }
        }

        private void AddEmail(Pop3Client client)
        {
            ListViewItem item = new ListViewItem();

            item.Text = client.Subject;
            item.SubItems.Add(client.From);
            item.SubItems.Add(client.To);
            item.SubItems.Add(client.Position.ToString());
            item.SubItems.Add(client.Body.Length.ToString());

            item.Tag = client.Body;

            lvwMessages.Items.Add(item);
        }

        private void lvwMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMessages.SelectedItems.Count == 0)
            {
                ShowMessage(null);
            }
            else
            {
                ShowMessage(Convert.ToString(lvwMessages.SelectedItems[0].Tag));
            }
        }
    }
}

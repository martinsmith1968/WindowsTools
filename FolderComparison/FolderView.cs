using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FolderComparison
{
    public partial class FolderView : UserControl
    {
        private string _FolderName = string.Empty;

        public void Activate(bool on)
        {
            if (on)
            {
                lblFolder.Font = new Font(lblFolder.Font, lblFolder.Font.Style | FontStyle.Bold);
            }
            else
            {
                lblFolder.Font = new Font(lblFolder.Font, lblFolder.Font.Style & ~FontStyle.Bold);
            }
        }

        public string FolderName
        {
            get { return _FolderName; }
            set { SetFolderName(value); }
        }

        public FolderView()
        {
            InitializeComponent();
        }

        private void SetFolderName(string folderName)
        {
            _FolderName = folderName;

            lblFolder.Text = _FolderName;

            RefreshFileList();
        }

        private void RefreshFileList()
        {
            lvwFiles.Items.Clear();

            try
            {
                foreach (string fileName in Directory.GetFiles(_FolderName))
                {
                    FileInfo fi = new FileInfo(fileName);

                    ListViewItem item = new ListViewItem(fi.Name);

                    item.SubItems.Add(fi.Extension);
                    item.SubItems.Add(fi.Length.ToString());
                    item.SubItems.Add(string.Format("{0} {1}", fi.LastWriteTime.ToShortDateString(), fi.LastWriteTime.ToShortTimeString()));
                    item.SubItems.Add(fi.Attributes.ToString());

                    item.Tag = fi;

                    lvwFiles.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void FolderView_Load(object sender, EventArgs e)
        {
            lvwFiles.Dock = DockStyle.Fill;
        }
    }
}

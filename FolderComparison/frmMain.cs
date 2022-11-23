using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FolderComparison
{
    public partial class frmMain : Form
    {
        bool _Shown = false;

        public string LeftFolder
        {
            get { return fvLeft.FolderName; }
            set { fvLeft.FolderName = value; }
        }

        public string RightFolder
        {
            get { return fvRight.FolderName; }
            set { fvRight.FolderName = value; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void ActivateFolderView(FolderView fv, bool on)
        {
            if (fv != null)
            {
                fv.Activate(on);
            }
        }

        private void SetSplitterPercentage(int percentage)
        {
            if (percentage >= 0 && percentage <= 100)
            {
                Control ctlParent = splFolders.Parent;

                int width = (ctlParent.ClientSize.Width - splFolders.Width) / 2;

                panFolderLeft.Width = width;
            }
        }

        private bool SelectFolders()
        {
            using (frmSelection selection = new frmSelection())
            {
                if (selection.ShowDialog() == DialogResult.Cancel)
                    return false;

                fvLeft.FolderName = @"H:\informix.msmith";
                fvRight.FolderName = @"H:\informix.trunk";
    
                return true;
            }
        }

        private void frmComparison_Load(object sender, EventArgs e)
        {
            panFileLists.Dock = DockStyle.Fill;
            panFolderLeft.Dock = DockStyle.Left;
            panFolderRight.Dock = DockStyle.Fill;
        }

        private void splFolders_DoubleClick(object sender, EventArgs e)
        {
            SetSplitterPercentage(50);
        }

        private void panSummaryLeft_Enter(object sender, EventArgs e)
        {
            ActivateFolderView(fvRight, false);
            ActivateFolderView(fvLeft, true);
        }

        private void panSummaryRight_Enter(object sender, EventArgs e)
        {
            ActivateFolderView(fvLeft, false);
            ActivateFolderView(fvRight, true);
        }

        private void fvLeft_Enter(object sender, EventArgs e)
        {
            ActivateFolderView(fvRight, false);
            ActivateFolderView(fvLeft, true);
        }

        private void fvRight_Enter(object sender, EventArgs e)
        {
            ActivateFolderView(fvLeft, false);
            ActivateFolderView(fvRight, true);
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LeftFolder) || string.IsNullOrEmpty(RightFolder))
            {
                if (!SelectFolders())
                    Close();
            }
        }
    }
}

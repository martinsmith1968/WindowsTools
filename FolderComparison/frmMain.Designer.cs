namespace FolderComparison
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panFileLists = new System.Windows.Forms.Panel();
            this.splFolders = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panFolderRight = new System.Windows.Forms.Panel();
            this.panFolderLeft = new System.Windows.Forms.Panel();
            this.panSummaryLeft = new System.Windows.Forms.Panel();
            this.panSummaryRight = new System.Windows.Forms.Panel();
            this.fvRight = new FolderComparison.FolderView();
            this.fvLeft = new FolderComparison.FolderView();
            this.panFileLists.SuspendLayout();
            this.panFolderRight.SuspendLayout();
            this.panFolderLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFileLists
            // 
            this.panFileLists.Controls.Add(this.panFolderRight);
            this.panFileLists.Controls.Add(this.splFolders);
            this.panFileLists.Controls.Add(this.panFolderLeft);
            this.panFileLists.Dock = System.Windows.Forms.DockStyle.Top;
            this.panFileLists.Location = new System.Drawing.Point(0, 49);
            this.panFileLists.Name = "panFileLists";
            this.panFileLists.Size = new System.Drawing.Size(696, 293);
            this.panFileLists.TabIndex = 0;
            // 
            // splFolders
            // 
            this.splFolders.Location = new System.Drawing.Point(246, 0);
            this.splFolders.Name = "splFolders";
            this.splFolders.Size = new System.Drawing.Size(5, 293);
            this.splFolders.TabIndex = 1;
            this.splFolders.TabStop = false;
            this.splFolders.DoubleClick += new System.EventHandler(this.splFolders_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(696, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(696, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panFolderRight
            // 
            this.panFolderRight.Controls.Add(this.fvRight);
            this.panFolderRight.Controls.Add(this.panSummaryRight);
            this.panFolderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panFolderRight.Location = new System.Drawing.Point(396, 0);
            this.panFolderRight.Name = "panFolderRight";
            this.panFolderRight.Size = new System.Drawing.Size(300, 293);
            this.panFolderRight.TabIndex = 2;
            // 
            // panFolderLeft
            // 
            this.panFolderLeft.Controls.Add(this.fvLeft);
            this.panFolderLeft.Controls.Add(this.panSummaryLeft);
            this.panFolderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panFolderLeft.Location = new System.Drawing.Point(0, 0);
            this.panFolderLeft.Name = "panFolderLeft";
            this.panFolderLeft.Size = new System.Drawing.Size(246, 293);
            this.panFolderLeft.TabIndex = 3;
            // 
            // panSummaryLeft
            // 
            this.panSummaryLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panSummaryLeft.Location = new System.Drawing.Point(0, 227);
            this.panSummaryLeft.Name = "panSummaryLeft";
            this.panSummaryLeft.Size = new System.Drawing.Size(246, 66);
            this.panSummaryLeft.TabIndex = 1;
            this.panSummaryLeft.Enter += new System.EventHandler(this.panSummaryLeft_Enter);
            // 
            // panSummaryRight
            // 
            this.panSummaryRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panSummaryRight.Location = new System.Drawing.Point(0, 227);
            this.panSummaryRight.Name = "panSummaryRight";
            this.panSummaryRight.Size = new System.Drawing.Size(300, 66);
            this.panSummaryRight.TabIndex = 2;
            this.panSummaryRight.Enter += new System.EventHandler(this.panSummaryRight_Enter);
            // 
            // fvRight
            // 
            this.fvRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fvRight.FolderName = "";
            this.fvRight.Location = new System.Drawing.Point(0, 0);
            this.fvRight.Name = "fvRight";
            this.fvRight.Size = new System.Drawing.Size(300, 227);
            this.fvRight.TabIndex = 0;
            this.fvRight.Enter += new System.EventHandler(this.fvRight_Enter);
            // 
            // fvLeft
            // 
            this.fvLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fvLeft.FolderName = "";
            this.fvLeft.Location = new System.Drawing.Point(0, 0);
            this.fvLeft.Name = "fvLeft";
            this.fvLeft.Size = new System.Drawing.Size(246, 227);
            this.fvLeft.TabIndex = 0;
            this.fvLeft.Enter += new System.EventHandler(this.fvLeft_Enter);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 452);
            this.Controls.Add(this.panFileLists);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmComparison";
            this.Load += new System.EventHandler(this.frmComparison_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.panFileLists.ResumeLayout(false);
            this.panFolderRight.ResumeLayout(false);
            this.panFolderLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panFileLists;
        private System.Windows.Forms.Splitter splFolders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panFolderLeft;
        private FolderView fvLeft;
        private System.Windows.Forms.Panel panFolderRight;
        private FolderView fvRight;
        private System.Windows.Forms.Panel panSummaryRight;
        private System.Windows.Forms.Panel panSummaryLeft;
    }
}
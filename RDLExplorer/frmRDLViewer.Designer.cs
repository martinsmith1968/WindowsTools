namespace RDLExplorer
{
    partial class frmRDLViewer
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.panReportHeader = new System.Windows.Forms.Panel();
            this.panReportDetails = new System.Windows.Forms.Panel();
            this.tbcReportDetails = new System.Windows.Forms.TabControl();
            this.tbpDataSets = new System.Windows.Forms.TabPage();
            this.panDataSetDetails = new System.Windows.Forms.Panel();
            this.lstDataSetQuery = new System.Windows.Forms.ListView();
            this.colDataSetQueryProperty = new System.Windows.Forms.ColumnHeader();
            this.colDataSetQueryValue = new System.Windows.Forms.ColumnHeader();
            this.splDataSets = new System.Windows.Forms.Splitter();
            this.lstDataSets = new System.Windows.Forms.ListBox();
            this.msMain.SuspendLayout();
            this.panReportDetails.SuspendLayout();
            this.tbcReportDetails.SuspendLayout();
            this.tbpDataSets.SuspendLayout();
            this.panDataSetDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuFile,
            this.tsmnuHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(782, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmnuFile
            // 
            this.tsmnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuFileOpen,
            this.toolStripSeparator1,
            this.tsmnuFileExit});
            this.tsmnuFile.Name = "tsmnuFile";
            this.tsmnuFile.Size = new System.Drawing.Size(37, 20);
            this.tsmnuFile.Text = "&File";
            // 
            // tsmnuFileOpen
            // 
            this.tsmnuFileOpen.Name = "tsmnuFileOpen";
            this.tsmnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmnuFileOpen.Size = new System.Drawing.Size(155, 22);
            this.tsmnuFileOpen.Text = "&Open...";
            this.tsmnuFileOpen.Click += new System.EventHandler(this.tsmnuFileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // tsmnuFileExit
            // 
            this.tsmnuFileExit.Name = "tsmnuFileExit";
            this.tsmnuFileExit.Size = new System.Drawing.Size(155, 22);
            this.tsmnuFileExit.Text = "E&xit";
            this.tsmnuFileExit.Click += new System.EventHandler(this.tsmnuFileExit_Click);
            // 
            // tsmnuHelp
            // 
            this.tsmnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuHelpAbout});
            this.tsmnuHelp.Name = "tsmnuHelp";
            this.tsmnuHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmnuHelp.Text = "&Help";
            // 
            // tsmnuHelpAbout
            // 
            this.tsmnuHelpAbout.Name = "tsmnuHelpAbout";
            this.tsmnuHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.tsmnuHelpAbout.Text = "&About...";
            this.tsmnuHelpAbout.Click += new System.EventHandler(this.tsmnuHelpAbout_Click);
            // 
            // ssMain
            // 
            this.ssMain.Location = new System.Drawing.Point(0, 424);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(782, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsMain
            // 
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(782, 25);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "toolStrip1";
            // 
            // panReportHeader
            // 
            this.panReportHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panReportHeader.Location = new System.Drawing.Point(0, 49);
            this.panReportHeader.Name = "panReportHeader";
            this.panReportHeader.Size = new System.Drawing.Size(782, 79);
            this.panReportHeader.TabIndex = 4;
            // 
            // panReportDetails
            // 
            this.panReportDetails.Controls.Add(this.tbcReportDetails);
            this.panReportDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panReportDetails.Location = new System.Drawing.Point(0, 128);
            this.panReportDetails.Name = "panReportDetails";
            this.panReportDetails.Padding = new System.Windows.Forms.Padding(4);
            this.panReportDetails.Size = new System.Drawing.Size(782, 263);
            this.panReportDetails.TabIndex = 5;
            // 
            // tbcReportDetails
            // 
            this.tbcReportDetails.Controls.Add(this.tbpDataSets);
            this.tbcReportDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcReportDetails.Location = new System.Drawing.Point(4, 4);
            this.tbcReportDetails.Name = "tbcReportDetails";
            this.tbcReportDetails.SelectedIndex = 0;
            this.tbcReportDetails.Size = new System.Drawing.Size(774, 234);
            this.tbcReportDetails.TabIndex = 0;
            // 
            // tbpDataSets
            // 
            this.tbpDataSets.Controls.Add(this.panDataSetDetails);
            this.tbpDataSets.Controls.Add(this.splDataSets);
            this.tbpDataSets.Controls.Add(this.lstDataSets);
            this.tbpDataSets.Location = new System.Drawing.Point(4, 22);
            this.tbpDataSets.Name = "tbpDataSets";
            this.tbpDataSets.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDataSets.Size = new System.Drawing.Size(766, 208);
            this.tbpDataSets.TabIndex = 0;
            this.tbpDataSets.Text = "DataSets";
            this.tbpDataSets.UseVisualStyleBackColor = true;
            // 
            // panDataSetDetails
            // 
            this.panDataSetDetails.Controls.Add(this.lstDataSetQuery);
            this.panDataSetDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDataSetDetails.Location = new System.Drawing.Point(171, 3);
            this.panDataSetDetails.Name = "panDataSetDetails";
            this.panDataSetDetails.Size = new System.Drawing.Size(592, 169);
            this.panDataSetDetails.TabIndex = 2;
            // 
            // lstDataSetQuery
            // 
            this.lstDataSetQuery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDataSetQueryProperty,
            this.colDataSetQueryValue});
            this.lstDataSetQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstDataSetQuery.FullRowSelect = true;
            this.lstDataSetQuery.Location = new System.Drawing.Point(0, 0);
            this.lstDataSetQuery.MultiSelect = false;
            this.lstDataSetQuery.Name = "lstDataSetQuery";
            this.lstDataSetQuery.Size = new System.Drawing.Size(592, 97);
            this.lstDataSetQuery.TabIndex = 0;
            this.lstDataSetQuery.UseCompatibleStateImageBehavior = false;
            this.lstDataSetQuery.View = System.Windows.Forms.View.Details;
            // 
            // colDataSetQueryProperty
            // 
            this.colDataSetQueryProperty.Text = "";
            // 
            // colDataSetQueryValue
            // 
            this.colDataSetQueryValue.Text = "";
            // 
            // splDataSets
            // 
            this.splDataSets.Location = new System.Drawing.Point(167, 3);
            this.splDataSets.Name = "splDataSets";
            this.splDataSets.Size = new System.Drawing.Size(4, 202);
            this.splDataSets.TabIndex = 1;
            this.splDataSets.TabStop = false;
            // 
            // lstDataSets
            // 
            this.lstDataSets.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstDataSets.FormattingEnabled = true;
            this.lstDataSets.Location = new System.Drawing.Point(3, 3);
            this.lstDataSets.Name = "lstDataSets";
            this.lstDataSets.Size = new System.Drawing.Size(164, 199);
            this.lstDataSets.TabIndex = 0;
            this.lstDataSets.SelectedIndexChanged += new System.EventHandler(this.lstDataSets_SelectedIndexChanged);
            // 
            // frmRDLViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 446);
            this.Controls.Add(this.panReportDetails);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.panReportHeader);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmRDLViewer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRDLViewer_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.panReportDetails.ResumeLayout(false);
            this.tbcReportDetails.ResumeLayout(false);
            this.tbpDataSets.ResumeLayout(false);
            this.panDataSetDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmnuFile;
        private System.Windows.Forms.ToolStripMenuItem tsmnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsmnuHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmnuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panReportHeader;
        private System.Windows.Forms.Panel panReportDetails;
        private System.Windows.Forms.TabControl tbcReportDetails;
        private System.Windows.Forms.TabPage tbpDataSets;
        private System.Windows.Forms.ListBox lstDataSets;
        private System.Windows.Forms.Panel panDataSetDetails;
        private System.Windows.Forms.Splitter splDataSets;
        private System.Windows.Forms.ListView lstDataSetQuery;
        private System.Windows.Forms.ColumnHeader colDataSetQueryProperty;
        private System.Windows.Forms.ColumnHeader colDataSetQueryValue;
    }
}


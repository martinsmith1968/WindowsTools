namespace ClipboardMonitor
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.grpRules = new System.Windows.Forms.GroupBox();
            this.splRulesLog = new System.Windows.Forms.Splitter();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.lvwLog = new System.Windows.Forms.ListView();
            this.colLogTimestamp = new System.Windows.Forms.ColumnHeader();
            this.colLogSeverity = new System.Windows.Forms.ColumnHeader();
            this.colLogText = new System.Windows.Forms.ColumnHeader();
            this.mnuMain.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(531, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuHelpExit
            // 
            this.mnuHelpExit.Name = "mnuHelpExit";
            this.mnuHelpExit.Size = new System.Drawing.Size(92, 22);
            this.mnuHelpExit.Text = "E&xit";
            this.mnuHelpExit.Click += new System.EventHandler(this.mnuHelpExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuHelpAbout.Text = "&About...";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // ssMain
            // 
            this.ssMain.Location = new System.Drawing.Point(0, 302);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(531, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsMain
            // 
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(531, 25);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "toolStrip1";
            // 
            // grpRules
            // 
            this.grpRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRules.Location = new System.Drawing.Point(0, 49);
            this.grpRules.Name = "grpRules";
            this.grpRules.Padding = new System.Windows.Forms.Padding(4);
            this.grpRules.Size = new System.Drawing.Size(531, 98);
            this.grpRules.TabIndex = 3;
            this.grpRules.TabStop = false;
            this.grpRules.Text = "Rules";
            // 
            // splRulesLog
            // 
            this.splRulesLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splRulesLog.Location = new System.Drawing.Point(0, 182);
            this.splRulesLog.Name = "splRulesLog";
            this.splRulesLog.Size = new System.Drawing.Size(531, 3);
            this.splRulesLog.TabIndex = 4;
            this.splRulesLog.TabStop = false;
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.lvwLog);
            this.grpLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpLog.Location = new System.Drawing.Point(0, 185);
            this.grpLog.Name = "grpLog";
            this.grpLog.Padding = new System.Windows.Forms.Padding(4);
            this.grpLog.Size = new System.Drawing.Size(531, 117);
            this.grpLog.TabIndex = 5;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // lvwLog
            // 
            this.lvwLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLogTimestamp,
            this.colLogSeverity,
            this.colLogText});
            this.lvwLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwLog.FullRowSelect = true;
            this.lvwLog.Location = new System.Drawing.Point(4, 17);
            this.lvwLog.MultiSelect = false;
            this.lvwLog.Name = "lvwLog";
            this.lvwLog.Size = new System.Drawing.Size(523, 96);
            this.lvwLog.TabIndex = 0;
            this.lvwLog.UseCompatibleStateImageBehavior = false;
            this.lvwLog.View = System.Windows.Forms.View.Details;
            // 
            // colLogTimestamp
            // 
            this.colLogTimestamp.Text = "Timestamp";
            this.colLogTimestamp.Width = 90;
            // 
            // colLogSeverity
            // 
            this.colLogSeverity.Text = "Severity";
            this.colLogSeverity.Width = 75;
            // 
            // colLogText
            // 
            this.colLogText.Text = "Text";
            this.colLogText.Width = 300;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 324);
            this.Controls.Add(this.grpRules);
            this.Controls.Add(this.splRulesLog);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.ssMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.GroupBox grpRules;
        private System.Windows.Forms.Splitter splRulesLog;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.ListView lvwLog;
        private System.Windows.Forms.ColumnHeader colLogTimestamp;
        private System.Windows.Forms.ColumnHeader colLogSeverity;
        private System.Windows.Forms.ColumnHeader colLogText;
    }
}


namespace WebBrowser
{
    partial class frmBrowser
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
            this.grpURL = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboURL = new System.Windows.Forms.ComboBox();
            this.tbcBrowser = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuTab = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuTabNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuTabClose = new System.Windows.Forms.ToolStripMenuItem();
            this.grpURL.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpURL
            // 
            this.grpURL.Controls.Add(this.btnGo);
            this.grpURL.Controls.Add(this.label1);
            this.grpURL.Controls.Add(this.cboURL);
            this.grpURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpURL.Location = new System.Drawing.Point(0, 24);
            this.grpURL.Name = "grpURL";
            this.grpURL.Size = new System.Drawing.Size(824, 51);
            this.grpURL.TabIndex = 0;
            this.grpURL.TabStop = false;
            this.grpURL.Text = "URL";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(737, 17);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&URL :";
            // 
            // cboURL
            // 
            this.cboURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboURL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboURL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboURL.FormattingEnabled = true;
            this.cboURL.Location = new System.Drawing.Point(53, 19);
            this.cboURL.Name = "cboURL";
            this.cboURL.Size = new System.Drawing.Size(678, 21);
            this.cboURL.TabIndex = 0;
            // 
            // tbcBrowser
            // 
            this.tbcBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcBrowser.Location = new System.Drawing.Point(0, 75);
            this.tbcBrowser.Name = "tbcBrowser";
            this.tbcBrowser.SelectedIndex = 0;
            this.tbcBrowser.Size = new System.Drawing.Size(824, 255);
            this.tbcBrowser.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuFile,
            this.tsmnuTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmnuFile
            // 
            this.tsmnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuFileExit});
            this.tsmnuFile.Name = "tsmnuFile";
            this.tsmnuFile.Size = new System.Drawing.Size(37, 20);
            this.tsmnuFile.Text = "&File";
            // 
            // tsmnuFileExit
            // 
            this.tsmnuFileExit.Name = "tsmnuFileExit";
            this.tsmnuFileExit.Size = new System.Drawing.Size(92, 22);
            this.tsmnuFileExit.Text = "E&xit";
            this.tsmnuFileExit.Click += new System.EventHandler(this.tsmnuFileExit_Click);
            // 
            // tsmnuTab
            // 
            this.tsmnuTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuTabNew,
            this.tsmnuTabClose});
            this.tsmnuTab.Name = "tsmnuTab";
            this.tsmnuTab.Size = new System.Drawing.Size(39, 20);
            this.tsmnuTab.Text = "&Tab";
            // 
            // tsmnuTabNew
            // 
            this.tsmnuTabNew.Name = "tsmnuTabNew";
            this.tsmnuTabNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsmnuTabNew.Size = new System.Drawing.Size(139, 22);
            this.tsmnuTabNew.Text = "&New";
            this.tsmnuTabNew.Click += new System.EventHandler(this.tsmnuTabNew_Click);
            // 
            // tsmnuTabClose
            // 
            this.tsmnuTabClose.Name = "tsmnuTabClose";
            this.tsmnuTabClose.Size = new System.Drawing.Size(139, 22);
            this.tsmnuTabClose.Text = "&Close";
            this.tsmnuTabClose.Click += new System.EventHandler(this.tsmnuTabClose_Click);
            // 
            // frmBrowser
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 411);
            this.Controls.Add(this.tbcBrowser);
            this.Controls.Add(this.grpURL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBrowser";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBrowser_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBrowser_FormClosed);
            this.grpURL.ResumeLayout(false);
            this.grpURL.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboURL;
        private System.Windows.Forms.TabControl tbcBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmnuFile;
        private System.Windows.Forms.ToolStripMenuItem tsmnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsmnuTab;
        private System.Windows.Forms.ToolStripMenuItem tsmnuTabNew;
        private System.Windows.Forms.ToolStripMenuItem tsmnuTabClose;
    }
}


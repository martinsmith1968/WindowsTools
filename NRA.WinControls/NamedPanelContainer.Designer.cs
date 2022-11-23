namespace NRA.WinControls
{
    partial class NamedPanelContainer
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panPages = new System.Windows.Forms.Panel();
            this.lstPages = new System.Windows.Forms.ListBox();
            this.blPages = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panPageDetail = new System.Windows.Forms.Panel();
            this.extendedTabControl1 = new NRA.WinControls.ExtendedTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panPages.SuspendLayout();
            this.panPageDetail.SuspendLayout();
            this.extendedTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPages
            // 
            this.panPages.Controls.Add(this.lstPages);
            this.panPages.Controls.Add(this.blPages);
            this.panPages.Dock = System.Windows.Forms.DockStyle.Left;
            this.panPages.Location = new System.Drawing.Point(0, 0);
            this.panPages.Name = "panPages";
            this.panPages.Size = new System.Drawing.Size(106, 186);
            this.panPages.TabIndex = 0;
            // 
            // lstPages
            // 
            this.lstPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPages.FormattingEnabled = true;
            this.lstPages.Location = new System.Drawing.Point(0, 23);
            this.lstPages.Name = "lstPages";
            this.lstPages.Size = new System.Drawing.Size(106, 160);
            this.lstPages.TabIndex = 1;
            // 
            // blPages
            // 
            this.blPages.Dock = System.Windows.Forms.DockStyle.Top;
            this.blPages.Location = new System.Drawing.Point(0, 0);
            this.blPages.Name = "blPages";
            this.blPages.Size = new System.Drawing.Size(106, 23);
            this.blPages.TabIndex = 0;
            this.blPages.Text = "Pages";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(106, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 186);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panPageDetail
            // 
            this.panPageDetail.Controls.Add(this.extendedTabControl1);
            this.panPageDetail.Controls.Add(this.lblPageTitle);
            this.panPageDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPageDetail.Location = new System.Drawing.Point(109, 0);
            this.panPageDetail.Name = "panPageDetail";
            this.panPageDetail.Size = new System.Drawing.Size(250, 186);
            this.panPageDetail.TabIndex = 2;
            // 
            // extendedTabControl1
            // 
            this.extendedTabControl1.Controls.Add(this.tabPage1);
            this.extendedTabControl1.Controls.Add(this.tabPage2);
            this.extendedTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extendedTabControl1.Location = new System.Drawing.Point(0, 23);
            this.extendedTabControl1.Name = "extendedTabControl1";
            this.extendedTabControl1.SelectedIndex = 0;
            this.extendedTabControl1.Size = new System.Drawing.Size(250, 163);
            this.extendedTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(242, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(188, 76);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPageTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(250, 23);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "label1";
            // 
            // NamedPanelContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panPageDetail);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panPages);
            this.Name = "NamedPanelContainer";
            this.Size = new System.Drawing.Size(359, 186);
            this.panPages.ResumeLayout(false);
            this.panPageDetail.ResumeLayout(false);
            this.extendedTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPages;
        private System.Windows.Forms.ListBox lstPages;
        private System.Windows.Forms.Label blPages;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panPageDetail;
        private System.Windows.Forms.Label lblPageTitle;
        private ExtendedTabControl extendedTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

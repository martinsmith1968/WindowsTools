namespace WinHider
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panWindows = new System.Windows.Forms.Panel();
            this.lvwWindows = new System.Windows.Forms.ListView();
            this.colWINDOWTITLE = new System.Windows.Forms.ColumnHeader();
            this.colPROCESSNAME = new System.Windows.Forms.ColumnHeader();
            this.colSTATE = new System.Windows.Forms.ColumnHeader();
            this.imlProcessIcons = new System.Windows.Forms.ImageList(this.components);
            this.panButtonBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSetText = new System.Windows.Forms.Button();
            this.panWindows.SuspendLayout();
            this.panButtonBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panWindows
            // 
            this.panWindows.Controls.Add(this.lvwWindows);
            this.panWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.panWindows.Location = new System.Drawing.Point(0, 0);
            this.panWindows.Name = "panWindows";
            this.panWindows.Padding = new System.Windows.Forms.Padding(4);
            this.panWindows.Size = new System.Drawing.Size(390, 144);
            this.panWindows.TabIndex = 0;
            // 
            // lvwWindows
            // 
            this.lvwWindows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colWINDOWTITLE,
            this.colPROCESSNAME,
            this.colSTATE});
            this.lvwWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwWindows.FullRowSelect = true;
            this.lvwWindows.HideSelection = false;
            this.lvwWindows.Location = new System.Drawing.Point(4, 4);
            this.lvwWindows.MultiSelect = false;
            this.lvwWindows.Name = "lvwWindows";
            this.lvwWindows.Size = new System.Drawing.Size(382, 136);
            this.lvwWindows.SmallImageList = this.imlProcessIcons;
            this.lvwWindows.TabIndex = 0;
            this.lvwWindows.UseCompatibleStateImageBehavior = false;
            this.lvwWindows.View = System.Windows.Forms.View.Details;
            this.lvwWindows.DoubleClick += new System.EventHandler(this.lvwWindows_DoubleClick);
            this.lvwWindows.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwWindows_ColumnClick);
            // 
            // colWINDOWTITLE
            // 
            this.colWINDOWTITLE.Tag = "WINDOWTITLE";
            this.colWINDOWTITLE.Text = "Window Title";
            this.colWINDOWTITLE.Width = 210;
            // 
            // colPROCESSNAME
            // 
            this.colPROCESSNAME.Tag = "PROCESSNAME";
            this.colPROCESSNAME.Text = "Process Name";
            this.colPROCESSNAME.Width = 90;
            // 
            // colSTATE
            // 
            this.colSTATE.Tag = "STATE";
            this.colSTATE.Text = "State";
            this.colSTATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imlProcessIcons
            // 
            this.imlProcessIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlProcessIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.imlProcessIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panButtonBar
            // 
            this.panButtonBar.Controls.Add(this.btnSetText);
            this.panButtonBar.Controls.Add(this.btnClose);
            this.panButtonBar.Controls.Add(this.btnShowHide);
            this.panButtonBar.Controls.Add(this.btnConfigure);
            this.panButtonBar.Controls.Add(this.btnRefresh);
            this.panButtonBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panButtonBar.Location = new System.Drawing.Point(390, 0);
            this.panButtonBar.Name = "panButtonBar";
            this.panButtonBar.Padding = new System.Windows.Forms.Padding(4);
            this.panButtonBar.Size = new System.Drawing.Size(89, 185);
            this.panButtonBar.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(7, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowHide
            // 
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowHide.Location = new System.Drawing.Point(7, 65);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(75, 23);
            this.btnShowHide.TabIndex = 2;
            this.btnShowHide.Text = "&Show / Hide";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfigure.Location = new System.Drawing.Point(7, 36);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(75, 23);
            this.btnConfigure.TabIndex = 1;
            this.btnConfigure.Text = "C&onfigure...";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(7, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSetText
            // 
            this.btnSetText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetText.Location = new System.Drawing.Point(7, 94);
            this.btnSetText.Name = "btnSetText";
            this.btnSetText.Size = new System.Drawing.Size(75, 23);
            this.btnSetText.TabIndex = 3;
            this.btnSetText.Text = "Set &Text...";
            this.btnSetText.UseVisualStyleBackColor = true;
            this.btnSetText.Click += new System.EventHandler(this.btnSetText_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(479, 185);
            this.Controls.Add(this.panWindows);
            this.Controls.Add(this.panButtonBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.panWindows.ResumeLayout(false);
            this.panButtonBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panWindows;
        private System.Windows.Forms.Panel panButtonBar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lvwWindows;
        private System.Windows.Forms.ColumnHeader colWINDOWTITLE;
        private System.Windows.Forms.ColumnHeader colSTATE;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.ColumnHeader colPROCESSNAME;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ImageList imlProcessIcons;
        private System.Windows.Forms.Button btnSetText;
    }
}


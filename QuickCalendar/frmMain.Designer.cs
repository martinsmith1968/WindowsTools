namespace QuickCalendar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuEditPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuViewResize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuViewResizeYearWide4X3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuViewResizeYearTall3X4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmnuViewToday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuViewGotoDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbtnFileExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnViewToday = new System.Windows.Forms.ToolStripButton();
            this.tsbtnViewGotoDate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEditPreferences = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnHelpAbout = new System.Windows.Forms.ToolStripButton();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tslblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.imlMenu = new System.Windows.Forms.ImageList(this.components);
            this.mcalCalendar = new System.Windows.Forms.MonthCalendar();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuFile,
            this.tsmnuEdit,
            this.tsmnuView,
            this.tsmnuHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(354, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
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
            this.tsmnuFileExit.Image = global::QuickCalendar.Properties.Resources.ClosePreviewHS;
            this.tsmnuFileExit.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsmnuFileExit.Name = "tsmnuFileExit";
            this.tsmnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.tsmnuFileExit.Size = new System.Drawing.Size(129, 22);
            this.tsmnuFileExit.Text = "E&xit";
            this.tsmnuFileExit.Click += new System.EventHandler(this.tsmnuFileExit_Click);
            // 
            // tsmnuEdit
            // 
            this.tsmnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuEditPreferences});
            this.tsmnuEdit.Name = "tsmnuEdit";
            this.tsmnuEdit.Size = new System.Drawing.Size(39, 20);
            this.tsmnuEdit.Text = "&Edit";
            // 
            // tsmnuEditPreferences
            // 
            this.tsmnuEditPreferences.Image = global::QuickCalendar.Properties.Resources.PropertiesHS;
            this.tsmnuEditPreferences.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsmnuEditPreferences.Name = "tsmnuEditPreferences";
            this.tsmnuEditPreferences.Size = new System.Drawing.Size(144, 22);
            this.tsmnuEditPreferences.Text = "&Preferences...";
            this.tsmnuEditPreferences.Click += new System.EventHandler(this.tsmnuEditPreferences_Click);
            // 
            // tsmnuView
            // 
            this.tsmnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuViewResize,
            this.toolStripSeparator4,
            this.tsmnuViewToday,
            this.tsmnuViewGotoDate});
            this.tsmnuView.Name = "tsmnuView";
            this.tsmnuView.Size = new System.Drawing.Size(44, 20);
            this.tsmnuView.Text = "&View";
            // 
            // tsmnuViewResize
            // 
            this.tsmnuViewResize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuViewResizeYearWide4X3,
            this.tsmnuViewResizeYearTall3X4});
            this.tsmnuViewResize.Name = "tsmnuViewResize";
            this.tsmnuViewResize.Size = new System.Drawing.Size(148, 22);
            this.tsmnuViewResize.Text = "&Resize";
            // 
            // tsmnuViewResizeYearWide4X3
            // 
            this.tsmnuViewResizeYearWide4X3.Name = "tsmnuViewResizeYearWide4X3";
            this.tsmnuViewResizeYearWide4X3.Size = new System.Drawing.Size(197, 22);
            this.tsmnuViewResizeYearWide4X3.Text = "Year View - Wide (4 x 3)";
            this.tsmnuViewResizeYearWide4X3.Click += new System.EventHandler(this.tsmnuViewResizeYearWide4X3_Click);
            // 
            // tsmnuViewResizeYearTall3X4
            // 
            this.tsmnuViewResizeYearTall3X4.Name = "tsmnuViewResizeYearTall3X4";
            this.tsmnuViewResizeYearTall3X4.Size = new System.Drawing.Size(197, 22);
            this.tsmnuViewResizeYearTall3X4.Text = "Year View - Tall (3 x 4)";
            this.tsmnuViewResizeYearTall3X4.Click += new System.EventHandler(this.tsmnuViewResizeYearTall3X4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmnuViewToday
            // 
            this.tsmnuViewToday.Image = global::QuickCalendar.Properties.Resources.clock;
            this.tsmnuViewToday.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsmnuViewToday.Name = "tsmnuViewToday";
            this.tsmnuViewToday.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsmnuViewToday.Size = new System.Drawing.Size(148, 22);
            this.tsmnuViewToday.Text = "&Today";
            this.tsmnuViewToday.Click += new System.EventHandler(this.tsmnuViewToday_Click);
            // 
            // tsmnuViewGotoDate
            // 
            this.tsmnuViewGotoDate.Image = global::QuickCalendar.Properties.Resources.Calendar_schedule;
            this.tsmnuViewGotoDate.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsmnuViewGotoDate.Name = "tsmnuViewGotoDate";
            this.tsmnuViewGotoDate.Size = new System.Drawing.Size(148, 22);
            this.tsmnuViewGotoDate.Text = "&Go to Date...";
            this.tsmnuViewGotoDate.Click += new System.EventHandler(this.tsmnuViewGotoDate_Click);
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
            this.tsmnuHelpAbout.Image = global::QuickCalendar.Properties.Resources.HELP;
            this.tsmnuHelpAbout.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsmnuHelpAbout.Name = "tsmnuHelpAbout";
            this.tsmnuHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.tsmnuHelpAbout.Text = "&About...";
            this.tsmnuHelpAbout.Click += new System.EventHandler(this.tsmnuHelpAbout_Click);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFileExit,
            this.toolStripSeparator1,
            this.tsbtnViewToday,
            this.tsbtnViewGotoDate,
            this.toolStripSeparator3,
            this.tsbtnEditPreferences,
            this.toolStripSeparator2,
            this.tsbtnHelpAbout});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(354, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbtnFileExit
            // 
            this.tsbtnFileExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFileExit.Image = global::QuickCalendar.Properties.Resources.ClosePreviewHS;
            this.tsbtnFileExit.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbtnFileExit.Name = "tsbtnFileExit";
            this.tsbtnFileExit.Size = new System.Drawing.Size(23, 22);
            this.tsbtnFileExit.Text = "Exit";
            this.tsbtnFileExit.ToolTipText = "Exit";
            this.tsbtnFileExit.Click += new System.EventHandler(this.tsmnuFileExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnViewToday
            // 
            this.tsbtnViewToday.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnViewToday.Image = global::QuickCalendar.Properties.Resources.clock;
            this.tsbtnViewToday.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnViewToday.Name = "tsbtnViewToday";
            this.tsbtnViewToday.Size = new System.Drawing.Size(23, 22);
            this.tsbtnViewToday.Text = "Today";
            this.tsbtnViewToday.Click += new System.EventHandler(this.tsmnuViewToday_Click);
            // 
            // tsbtnViewGotoDate
            // 
            this.tsbtnViewGotoDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnViewGotoDate.Image = global::QuickCalendar.Properties.Resources.Calendar_schedule;
            this.tsbtnViewGotoDate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnViewGotoDate.Name = "tsbtnViewGotoDate";
            this.tsbtnViewGotoDate.Size = new System.Drawing.Size(23, 22);
            this.tsbtnViewGotoDate.Text = "toolStripButton1";
            this.tsbtnViewGotoDate.Click += new System.EventHandler(this.tsmnuViewGotoDate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnEditPreferences
            // 
            this.tsbtnEditPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditPreferences.Image = global::QuickCalendar.Properties.Resources.PropertiesHS;
            this.tsbtnEditPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditPreferences.Name = "tsbtnEditPreferences";
            this.tsbtnEditPreferences.Size = new System.Drawing.Size(23, 22);
            this.tsbtnEditPreferences.Text = "Preferences";
            this.tsbtnEditPreferences.Click += new System.EventHandler(this.tsmnuEditPreferences_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnHelpAbout
            // 
            this.tsbtnHelpAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnHelpAbout.Image = global::QuickCalendar.Properties.Resources.HELP;
            this.tsbtnHelpAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHelpAbout.Name = "tsbtnHelpAbout";
            this.tsbtnHelpAbout.Size = new System.Drawing.Size(23, 22);
            this.tsbtnHelpAbout.Text = "About";
            this.tsbtnHelpAbout.ToolTipText = "About";
            this.tsbtnHelpAbout.Click += new System.EventHandler(this.tsmnuHelpAbout_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblInfo,
            this.tslblSelection});
            this.ssMain.Location = new System.Drawing.Point(0, 206);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(354, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "stsStatus";
            // 
            // tslblInfo
            // 
            this.tslblInfo.Name = "tslblInfo";
            this.tslblInfo.Size = new System.Drawing.Size(233, 17);
            this.tslblInfo.Spring = true;
            // 
            // tslblSelection
            // 
            this.tslblSelection.Name = "tslblSelection";
            this.tslblSelection.Size = new System.Drawing.Size(106, 17);
            this.tslblSelection.Text = "No Range Selected";
            // 
            // imlMenu
            // 
            this.imlMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlMenu.ImageStream")));
            this.imlMenu.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imlMenu.Images.SetKeyName(0, "HELP.BMP");
            this.imlMenu.Images.SetKeyName(1, "ClosePreviewHS.bmp");
            this.imlMenu.Images.SetKeyName(2, "PropertiesHS.bmp");
            // 
            // mcalCalendar
            // 
            this.mcalCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.mcalCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mcalCalendar.Location = new System.Drawing.Point(0, 49);
            this.mcalCalendar.Name = "mcalCalendar";
            this.mcalCalendar.TabIndex = 3;
            this.mcalCalendar.TitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mcalCalendar.TitleForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.mcalCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcalCalendar_DateSelected);
            this.mcalCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcalCalendar_DateChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 228);
            this.Controls.Add(this.mcalCalendar);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msMain;
		private System.Windows.Forms.ToolStripMenuItem tsmnuFile;
		private System.Windows.Forms.ToolStripMenuItem tsmnuFileExit;
		private System.Windows.Forms.ToolStripMenuItem tsmnuHelp;
		private System.Windows.Forms.ToolStripMenuItem tsmnuHelpAbout;
		private System.Windows.Forms.ToolStrip tsMain;
		private System.Windows.Forms.StatusStrip ssMain;
		private System.Windows.Forms.ToolStripButton tsbtnFileExit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbtnHelpAbout;
		private System.Windows.Forms.ImageList imlMenu;
		private System.Windows.Forms.MonthCalendar mcalCalendar;
		private System.Windows.Forms.ToolStripMenuItem tsmnuEdit;
		private System.Windows.Forms.ToolStripMenuItem tsmnuEditPreferences;
		private System.Windows.Forms.ToolStripButton tsbtnEditPreferences;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripStatusLabel tslblInfo;
		private System.Windows.Forms.ToolStripStatusLabel tslblSelection;
		private System.Windows.Forms.ToolStripMenuItem tsmnuView;
		private System.Windows.Forms.ToolStripMenuItem tsmnuViewToday;
		private System.Windows.Forms.ToolStripMenuItem tsmnuViewGotoDate;
        private System.Windows.Forms.ToolStripButton tsbtnViewToday;
        private System.Windows.Forms.ToolStripButton tsbtnViewGotoDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmnuViewResize;
        private System.Windows.Forms.ToolStripMenuItem tsmnuViewResizeYearWide4X3;
        private System.Windows.Forms.ToolStripMenuItem tsmnuViewResizeYearTall3X4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
	}
}


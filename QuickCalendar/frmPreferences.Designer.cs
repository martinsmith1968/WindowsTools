namespace QuickCalendar
{
	partial class frmPreferences
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.tbcPreferences = new System.Windows.Forms.TabControl();
			this.tbpGeneral = new System.Windows.Forms.TabPage();
			this.tbpCalendar = new System.Windows.Forms.TabPage();
			this.cboCalendar_FirstDayOfWeek = new System.Windows.Forms.ComboBox();
			this.lblCalendar_FirstDayOfWeek = new System.Windows.Forms.Label();
			this.chkCalendar_ShowWeekNumbers = new System.Windows.Forms.CheckBox();
			this.chkCalendar_ShowTodayCircle = new System.Windows.Forms.CheckBox();
			this.chkCalendar_ShowToday = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tbcPreferences.SuspendLayout();
			this.tbpCalendar.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnOK, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 235);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 29);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(210, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(129, 3);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// tbcPreferences
			// 
			this.tbcPreferences.Controls.Add(this.tbpGeneral);
			this.tbcPreferences.Controls.Add(this.tbpCalendar);
			this.tbcPreferences.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbcPreferences.Location = new System.Drawing.Point(2, 2);
			this.tbcPreferences.Name = "tbcPreferences";
			this.tbcPreferences.SelectedIndex = 0;
			this.tbcPreferences.Size = new System.Drawing.Size(288, 233);
			this.tbcPreferences.TabIndex = 1;
			// 
			// tbpGeneral
			// 
			this.tbpGeneral.Location = new System.Drawing.Point(4, 22);
			this.tbpGeneral.Name = "tbpGeneral";
			this.tbpGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tbpGeneral.Size = new System.Drawing.Size(280, 207);
			this.tbpGeneral.TabIndex = 0;
			this.tbpGeneral.Text = "General";
			this.tbpGeneral.UseVisualStyleBackColor = true;
			// 
			// tbpCalendar
			// 
			this.tbpCalendar.Controls.Add(this.cboCalendar_FirstDayOfWeek);
			this.tbpCalendar.Controls.Add(this.lblCalendar_FirstDayOfWeek);
			this.tbpCalendar.Controls.Add(this.chkCalendar_ShowWeekNumbers);
			this.tbpCalendar.Controls.Add(this.chkCalendar_ShowTodayCircle);
			this.tbpCalendar.Controls.Add(this.chkCalendar_ShowToday);
			this.tbpCalendar.Location = new System.Drawing.Point(4, 22);
			this.tbpCalendar.Name = "tbpCalendar";
			this.tbpCalendar.Padding = new System.Windows.Forms.Padding(3);
			this.tbpCalendar.Size = new System.Drawing.Size(280, 207);
			this.tbpCalendar.TabIndex = 1;
			this.tbpCalendar.Text = "Calendar";
			this.tbpCalendar.UseVisualStyleBackColor = true;
			// 
			// cboCalendar_FirstDayOfWeek
			// 
			this.cboCalendar_FirstDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCalendar_FirstDayOfWeek.FormattingEnabled = true;
			this.cboCalendar_FirstDayOfWeek.Location = new System.Drawing.Point(138, 84);
			this.cboCalendar_FirstDayOfWeek.Name = "cboCalendar_FirstDayOfWeek";
			this.cboCalendar_FirstDayOfWeek.Size = new System.Drawing.Size(136, 21);
			this.cboCalendar_FirstDayOfWeek.TabIndex = 5;
			// 
			// lblCalendar_FirstDayOfWeek
			// 
			this.lblCalendar_FirstDayOfWeek.Location = new System.Drawing.Point(8, 84);
			this.lblCalendar_FirstDayOfWeek.Name = "lblCalendar_FirstDayOfWeek";
			this.lblCalendar_FirstDayOfWeek.Size = new System.Drawing.Size(109, 20);
			this.lblCalendar_FirstDayOfWeek.TabIndex = 4;
			this.lblCalendar_FirstDayOfWeek.Text = "&First Day of Week";
			this.lblCalendar_FirstDayOfWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkCalendar_ShowWeekNumbers
			// 
			this.chkCalendar_ShowWeekNumbers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkCalendar_ShowWeekNumbers.Location = new System.Drawing.Point(8, 58);
			this.chkCalendar_ShowWeekNumbers.Name = "chkCalendar_ShowWeekNumbers";
			this.chkCalendar_ShowWeekNumbers.Size = new System.Drawing.Size(144, 20);
			this.chkCalendar_ShowWeekNumbers.TabIndex = 3;
			this.chkCalendar_ShowWeekNumbers.Text = "Show &Week Numbers";
			this.chkCalendar_ShowWeekNumbers.UseVisualStyleBackColor = true;
			// 
			// chkCalendar_ShowTodayCircle
			// 
			this.chkCalendar_ShowTodayCircle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkCalendar_ShowTodayCircle.Location = new System.Drawing.Point(8, 32);
			this.chkCalendar_ShowTodayCircle.Name = "chkCalendar_ShowTodayCircle";
			this.chkCalendar_ShowTodayCircle.Size = new System.Drawing.Size(144, 20);
			this.chkCalendar_ShowTodayCircle.TabIndex = 2;
			this.chkCalendar_ShowTodayCircle.Text = "Show Today &Circle";
			this.chkCalendar_ShowTodayCircle.UseVisualStyleBackColor = true;
			// 
			// chkCalendar_ShowToday
			// 
			this.chkCalendar_ShowToday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkCalendar_ShowToday.Location = new System.Drawing.Point(8, 6);
			this.chkCalendar_ShowToday.Name = "chkCalendar_ShowToday";
			this.chkCalendar_ShowToday.Size = new System.Drawing.Size(144, 20);
			this.chkCalendar_ShowToday.TabIndex = 1;
			this.chkCalendar_ShowToday.Text = "Show Today";
			this.chkCalendar_ShowToday.UseVisualStyleBackColor = true;
			// 
			// frmPreferences
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.tbcPreferences);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPreferences";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preferences";
			this.Load += new System.EventHandler(this.frmPreferences_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tbcPreferences.ResumeLayout(false);
			this.tbpCalendar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TabControl tbcPreferences;
		private System.Windows.Forms.TabPage tbpGeneral;
		private System.Windows.Forms.TabPage tbpCalendar;
		private System.Windows.Forms.CheckBox chkCalendar_ShowToday;
		private System.Windows.Forms.CheckBox chkCalendar_ShowTodayCircle;
		private System.Windows.Forms.CheckBox chkCalendar_ShowWeekNumbers;
		private System.Windows.Forms.ComboBox cboCalendar_FirstDayOfWeek;
		private System.Windows.Forms.Label lblCalendar_FirstDayOfWeek;
	}
}
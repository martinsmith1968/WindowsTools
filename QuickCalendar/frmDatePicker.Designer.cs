namespace QuickCalendar
{
	partial class frmDatePicker
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
			this.pnlButtonBar = new System.Windows.Forms.Panel();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblDateTime = new System.Windows.Forms.Label();
			this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
			this.lblDescription = new System.Windows.Forms.Label();
			this.pnlButtonBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlButtonBar
			// 
			this.pnlButtonBar.Controls.Add(this.btnCancel);
			this.pnlButtonBar.Controls.Add(this.btnOK);
			this.pnlButtonBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlButtonBar.Location = new System.Drawing.Point(0, 132);
			this.pnlButtonBar.Name = "pnlButtonBar";
			this.pnlButtonBar.Size = new System.Drawing.Size(292, 36);
			this.pnlButtonBar.TabIndex = 0;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(133, 7);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(214, 7);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lblDateTime
			// 
			this.lblDateTime.AutoSize = true;
			this.lblDateTime.Location = new System.Drawing.Point(12, 58);
			this.lblDateTime.Name = "lblDateTime";
			this.lblDateTime.Size = new System.Drawing.Size(30, 13);
			this.lblDateTime.TabIndex = 0;
			this.lblDateTime.Text = "&Date";
			// 
			// dtpDateTime
			// 
			this.dtpDateTime.Location = new System.Drawing.Point(80, 54);
			this.dtpDateTime.Name = "dtpDateTime";
			this.dtpDateTime.Size = new System.Drawing.Size(200, 20);
			this.dtpDateTime.TabIndex = 1;
			// 
			// lblDescription
			// 
			this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDescription.Location = new System.Drawing.Point(12, 9);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(268, 39);
			this.lblDescription.TabIndex = 2;
			// 
			// frmDatePicker
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(292, 168);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.dtpDateTime);
			this.Controls.Add(this.lblDateTime);
			this.Controls.Add(this.pnlButtonBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDatePicker";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmDatePicker";
			this.Load += new System.EventHandler(this.frmDatePicker_Load);
			this.pnlButtonBar.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlButtonBar;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblDateTime;
		private System.Windows.Forms.DateTimePicker dtpDateTime;
		private System.Windows.Forms.Label lblDescription;
	}
}
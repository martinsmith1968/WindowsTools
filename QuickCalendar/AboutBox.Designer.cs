namespace QuickCalendar
{
	partial class AboutBox
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
            this.picApplicationIcon = new System.Windows.Forms.PictureBox();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.pnlButtonBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lvwDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.picApplicationIcon)).BeginInit();
            this.pnlButtonBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // picApplicationIcon
            // 
            this.picApplicationIcon.Location = new System.Drawing.Point(11, 10);
            this.picApplicationIcon.Name = "picApplicationIcon";
            this.picApplicationIcon.Size = new System.Drawing.Size(48, 48);
            this.picApplicationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApplicationIcon.TabIndex = 0;
            this.picApplicationIcon.TabStop = false;
            this.picApplicationIcon.DoubleClick += new System.EventHandler(this.picApplicationIcon_DoubleClick);
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAppTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(65, 10);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(364, 20);
            this.lblAppTitle.TabIndex = 1;
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAppVersion.Location = new System.Drawing.Point(65, 38);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(364, 20);
            this.lblAppVersion.TabIndex = 2;
            // 
            // pnlButtonBar
            // 
            this.pnlButtonBar.Controls.Add(this.btnClose);
            this.pnlButtonBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonBar.Location = new System.Drawing.Point(0, 267);
            this.pnlButtonBar.Name = "pnlButtonBar";
            this.pnlButtonBar.Size = new System.Drawing.Size(441, 36);
            this.pnlButtonBar.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(109, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCopyright.Location = new System.Drawing.Point(11, 71);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(418, 20);
            this.lblCopyright.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Location = new System.Drawing.Point(11, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(418, 45);
            this.lblDescription.TabIndex = 5;
            // 
            // lvwDetails
            // 
            this.lvwDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwDetails.FullRowSelect = true;
            this.lvwDetails.Location = new System.Drawing.Point(11, 154);
            this.lvwDetails.Name = "lvwDetails";
            this.lvwDetails.Size = new System.Drawing.Size(418, 107);
            this.lvwDetails.TabIndex = 6;
            this.lvwDetails.UseCompatibleStateImageBehavior = false;
            this.lvwDetails.View = System.Windows.Forms.View.Details;
            this.lvwDetails.Visible = false;
            // 
            // AboutBox
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(441, 303);
            this.Controls.Add(this.lvwDetails);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pnlButtonBar);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.picApplicationIcon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.Load += new System.EventHandler(this.AboutBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picApplicationIcon)).EndInit();
            this.pnlButtonBar.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picApplicationIcon;
		private System.Windows.Forms.Label lblAppTitle;
		private System.Windows.Forms.Label lblAppVersion;
		private System.Windows.Forms.Panel pnlButtonBar;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblCopyright;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.ListView lvwDetails;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
	}
}
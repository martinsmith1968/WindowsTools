namespace POP3Checker
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panMessages = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lvwMessages = new System.Windows.Forms.ListView();
            this.colSubject = new System.Windows.Forms.ColumnHeader();
            this.colFrom = new System.Windows.Forms.ColumnHeader();
            this.colTo = new System.Windows.Forms.ColumnHeader();
            this.colReceived = new System.Windows.Forms.ColumnHeader();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.sslStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.colSize = new System.Windows.Forms.ColumnHeader();
            this.panDetails = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panMessages.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.panDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtServerPort);
            this.panel1.Controls.Add(this.txtServerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 77);
            this.panel1.TabIndex = 0;
            // 
            // panMessages
            // 
            this.panMessages.Controls.Add(this.lvwMessages);
            this.panMessages.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMessages.Location = new System.Drawing.Point(0, 77);
            this.panMessages.Name = "panMessages";
            this.panMessages.Padding = new System.Windows.Forms.Padding(4);
            this.panMessages.Size = new System.Drawing.Size(655, 147);
            this.panMessages.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "S&erver :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "P&ort :";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(61, 10);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(301, 20);
            this.txtServerName.TabIndex = 2;
            this.txtServerName.Text = "mail.force9.net";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(406, 10);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(61, 20);
            this.txtServerPort.TabIndex = 3;
            this.txtServerPort.Text = "110";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&User :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(61, 42);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(169, 20);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Text = "nrasystems+martin.smith";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "P&ass :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(298, 42);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(169, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "mailbox";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(486, 42);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lvwMessages
            // 
            this.lvwMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSubject,
            this.colFrom,
            this.colTo,
            this.colReceived,
            this.colSize});
            this.lvwMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMessages.FullRowSelect = true;
            this.lvwMessages.Location = new System.Drawing.Point(4, 4);
            this.lvwMessages.MultiSelect = false;
            this.lvwMessages.Name = "lvwMessages";
            this.lvwMessages.Size = new System.Drawing.Size(647, 139);
            this.lvwMessages.TabIndex = 0;
            this.lvwMessages.UseCompatibleStateImageBehavior = false;
            this.lvwMessages.View = System.Windows.Forms.View.Details;
            this.lvwMessages.SelectedIndexChanged += new System.EventHandler(this.lvwMessages_SelectedIndexChanged);
            // 
            // colSubject
            // 
            this.colSubject.Text = "Subject";
            this.colSubject.Width = 240;
            // 
            // colFrom
            // 
            this.colFrom.Text = "From";
            this.colFrom.Width = 120;
            // 
            // colTo
            // 
            this.colTo.Text = "To";
            this.colTo.Width = 120;
            // 
            // colReceived
            // 
            this.colReceived.Text = "Received";
            this.colReceived.Width = 75;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslStatusText});
            this.ssMain.Location = new System.Drawing.Point(0, 478);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(655, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // sslStatusText
            // 
            this.sslStatusText.Name = "sslStatusText";
            this.sslStatusText.Size = new System.Drawing.Size(576, 17);
            this.sslStatusText.Spring = true;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panDetails
            // 
            this.panDetails.Controls.Add(this.txtMessage);
            this.panDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panDetails.Location = new System.Drawing.Point(0, 255);
            this.panDetails.Name = "panDetails";
            this.panDetails.Padding = new System.Windows.Forms.Padding(4);
            this.panDetails.Size = new System.Drawing.Size(655, 223);
            this.panDetails.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(4, 4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(647, 215);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 500);
            this.Controls.Add(this.panDetails);
            this.Controls.Add(this.panMessages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panMessages.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.panDetails.ResumeLayout(false);
            this.panDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panMessages;
        private System.Windows.Forms.ListView lvwMessages;
        private System.Windows.Forms.ColumnHeader colSubject;
        private System.Windows.Forms.ColumnHeader colFrom;
        private System.Windows.Forms.ColumnHeader colTo;
        private System.Windows.Forms.ColumnHeader colReceived;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel sslStatusText;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.Panel panDetails;
        private System.Windows.Forms.TextBox txtMessage;
    }
}


namespace PasswordRevealer
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.chkWindowOnTop = new System.Windows.Forms.CheckBox();
            this.btnReveal = new System.Windows.Forms.Button();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInstructions.Location = new System.Drawing.Point(0, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Padding = new System.Windows.Forms.Padding(8);
            this.lblInstructions.Size = new System.Drawing.Size(244, 58);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Bring onto the screen the window containing the password field you want to unhide" +
                " and press \'Reveal\'.";
            // 
            // chkWindowOnTop
            // 
            this.chkWindowOnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkWindowOnTop.Location = new System.Drawing.Point(0, 58);
            this.chkWindowOnTop.Name = "chkWindowOnTop";
            this.chkWindowOnTop.Padding = new System.Windows.Forms.Padding(8);
            this.chkWindowOnTop.Size = new System.Drawing.Size(244, 33);
            this.chkWindowOnTop.TabIndex = 1;
            this.chkWindowOnTop.Text = "Keep this window on &Top";
            this.chkWindowOnTop.UseVisualStyleBackColor = true;
            this.chkWindowOnTop.CheckedChanged += new System.EventHandler(this.chkWindowOnTop_CheckedChanged);
            // 
            // btnReveal
            // 
            this.btnReveal.Location = new System.Drawing.Point(12, 91);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(75, 23);
            this.btnReveal.TabIndex = 2;
            this.btnReveal.Text = "&Reveal";
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // pgbProgress
            // 
            this.pgbProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgbProgress.Location = new System.Drawing.Point(0, 120);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(244, 10);
            this.pgbProgress.TabIndex = 3;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(157, 91);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "&Test...";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 130);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pgbProgress);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.chkWindowOnTop);
            this.Controls.Add(this.lblInstructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.CheckBox chkWindowOnTop;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private System.Windows.Forms.Button btnTest;
    }
}


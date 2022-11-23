namespace NRA.WinControls
{
    partial class InputBox
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.panButtonbar = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panInput = new System.Windows.Forms.Panel();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.panButtonbar.SuspendLayout();
            this.panInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrompt.Location = new System.Drawing.Point(4, 4);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(360, 57);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Please enter a value";
            // 
            // panButtonbar
            // 
            this.panButtonbar.Controls.Add(this.btnCancel);
            this.panButtonbar.Controls.Add(this.btnOK);
            this.panButtonbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtonbar.Location = new System.Drawing.Point(4, 115);
            this.panButtonbar.Name = "panButtonbar";
            this.panButtonbar.Size = new System.Drawing.Size(360, 30);
            this.panButtonbar.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(201, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(282, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panInput
            // 
            this.panInput.Controls.Add(this.txtValue);
            this.panInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panInput.Location = new System.Drawing.Point(4, 61);
            this.panInput.Name = "panInput";
            this.panInput.Padding = new System.Windows.Forms.Padding(4);
            this.panInput.Size = new System.Drawing.Size(360, 36);
            this.panInput.TabIndex = 3;
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Location = new System.Drawing.Point(4, 4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(352, 20);
            this.txtValue.TabIndex = 2;
            // 
            // InputBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(368, 149);
            this.Controls.Add(this.panInput);
            this.Controls.Add(this.panButtonbar);
            this.Controls.Add(this.lblPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InputBox";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputBox";
            this.Load += new System.EventHandler(this.InputBox_Load);
            this.Shown += new System.EventHandler(this.InputBox_Shown);
            this.panButtonbar.ResumeLayout(false);
            this.panInput.ResumeLayout(false);
            this.panInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Panel panButtonbar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panInput;
        private System.Windows.Forms.TextBox txtValue;
    }
}
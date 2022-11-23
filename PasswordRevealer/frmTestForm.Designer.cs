namespace PasswordRevealer
{
    partial class frmTestForm
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(211, 13);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Enter some test text which can be revealed";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 25);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.PasswordChar = '*';
            this.txtText.Size = new System.Drawing.Size(397, 161);
            this.txtText.TabIndex = 1;
            // 
            // frmTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 198);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblPrompt);
            this.Name = "frmTestForm";
            this.Text = "frmTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtText;
    }
}
namespace LogFileWatcher
{
    partial class MainForm
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
            this.tbcContainer = new System.Windows.Forms.TabControl();
            this.tbpTemplate = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbcContainer.SuspendLayout();
            this.tbpTemplate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcContainer
            // 
            this.tbcContainer.Controls.Add(this.tbpTemplate);
            this.tbcContainer.Location = new System.Drawing.Point(44, 49);
            this.tbcContainer.Name = "tbcContainer";
            this.tbcContainer.SelectedIndex = 0;
            this.tbcContainer.Size = new System.Drawing.Size(448, 217);
            this.tbcContainer.TabIndex = 0;
            // 
            // tbpTemplate
            // 
            this.tbpTemplate.Controls.Add(this.panel1);
            this.tbpTemplate.Location = new System.Drawing.Point(4, 22);
            this.tbpTemplate.Name = "tbpTemplate";
            this.tbpTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTemplate.Size = new System.Drawing.Size(440, 191);
            this.tbpTemplate.TabIndex = 0;
            this.tbpTemplate.Text = "tabPage1";
            this.tbpTemplate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 185);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 185);
            this.textBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 318);
            this.Controls.Add(this.tbcContainer);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tbcContainer.ResumeLayout(false);
            this.tbpTemplate.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcContainer;
        private System.Windows.Forms.TabPage tbpTemplate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}


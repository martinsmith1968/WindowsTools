namespace FolderComparison
{
    partial class frmSelection
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
            this.grpFolderSelection = new System.Windows.Forms.GroupBox();
            this.panButtonBar = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dlgFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.grpFolderSelection.SuspendLayout();
            this.panButtonBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFolderSelection
            // 
            this.grpFolderSelection.Controls.Add(this.button4);
            this.grpFolderSelection.Controls.Add(this.comboBox2);
            this.grpFolderSelection.Controls.Add(this.label2);
            this.grpFolderSelection.Controls.Add(this.button3);
            this.grpFolderSelection.Controls.Add(this.comboBox1);
            this.grpFolderSelection.Controls.Add(this.label1);
            this.grpFolderSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFolderSelection.Location = new System.Drawing.Point(4, 4);
            this.grpFolderSelection.Name = "grpFolderSelection";
            this.grpFolderSelection.Size = new System.Drawing.Size(431, 81);
            this.grpFolderSelection.TabIndex = 0;
            this.grpFolderSelection.TabStop = false;
            this.grpFolderSelection.Text = "Folder Selection";
            // 
            // panButtonBar
            // 
            this.panButtonBar.Controls.Add(this.btnCancel);
            this.panButtonBar.Controls.Add(this.btnOK);
            this.panButtonBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtonBar.Location = new System.Drawing.Point(4, 90);
            this.panButtonBar.Name = "panButtonBar";
            this.panButtonBar.Size = new System.Drawing.Size(431, 29);
            this.panButtonBar.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(272, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(353, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dlgFolderBrowser
            // 
            this.dlgFolderBrowser.Description = "Select Folder to compare...";
            this.dlgFolderBrowser.ShowNewFolderButton = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Left :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(338, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = ". . .";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Right :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(50, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(338, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(394, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = ". . .";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmSelection
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(439, 123);
            this.Controls.Add(this.panButtonBar);
            this.Controls.Add(this.grpFolderSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelection";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Folder Selection";
            this.grpFolderSelection.ResumeLayout(false);
            this.grpFolderSelection.PerformLayout();
            this.panButtonBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFolderSelection;
        private System.Windows.Forms.Panel panButtonBar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderBrowser;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
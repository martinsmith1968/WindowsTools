namespace WinHider
{
    partial class Configuration
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
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tbpWindowControl = new System.Windows.Forms.TabPage();
            this.chkWindowControl_ShowUntitled = new System.Windows.Forms.CheckBox();
            this.chkWindowControl_ShowInvisible = new System.Windows.Forms.CheckBox();
            this.tbpListColumns = new System.Windows.Forms.TabPage();
            this.clbColumns = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColMoveDown = new System.Windows.Forms.Button();
            this.btnColMoveUp = new System.Windows.Forms.Button();
            this.panButtonBar = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkWindowControl_ShowApplicationIcons = new System.Windows.Forms.CheckBox();
            this.tbcSettings.SuspendLayout();
            this.tbpWindowControl.SuspendLayout();
            this.tbpListColumns.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panButtonBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tbpWindowControl);
            this.tbcSettings.Controls.Add(this.tbpListColumns);
            this.tbcSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcSettings.Location = new System.Drawing.Point(4, 4);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(299, 145);
            this.tbcSettings.TabIndex = 0;
            // 
            // tbpWindowControl
            // 
            this.tbpWindowControl.Controls.Add(this.chkWindowControl_ShowApplicationIcons);
            this.tbpWindowControl.Controls.Add(this.chkWindowControl_ShowUntitled);
            this.tbpWindowControl.Controls.Add(this.chkWindowControl_ShowInvisible);
            this.tbpWindowControl.Location = new System.Drawing.Point(4, 22);
            this.tbpWindowControl.Name = "tbpWindowControl";
            this.tbpWindowControl.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWindowControl.Size = new System.Drawing.Size(291, 119);
            this.tbpWindowControl.TabIndex = 0;
            this.tbpWindowControl.Text = "Window Control";
            this.tbpWindowControl.UseVisualStyleBackColor = true;
            // 
            // chkWindowControl_ShowUntitled
            // 
            this.chkWindowControl_ShowUntitled.AutoSize = true;
            this.chkWindowControl_ShowUntitled.Location = new System.Drawing.Point(6, 29);
            this.chkWindowControl_ShowUntitled.Name = "chkWindowControl_ShowUntitled";
            this.chkWindowControl_ShowUntitled.Size = new System.Drawing.Size(156, 17);
            this.chkWindowControl_ShowUntitled.TabIndex = 1;
            this.chkWindowControl_ShowUntitled.Text = "Show Windows with no title";
            this.chkWindowControl_ShowUntitled.UseVisualStyleBackColor = true;
            // 
            // chkWindowControl_ShowInvisible
            // 
            this.chkWindowControl_ShowInvisible.AutoSize = true;
            this.chkWindowControl_ShowInvisible.Location = new System.Drawing.Point(6, 6);
            this.chkWindowControl_ShowInvisible.Name = "chkWindowControl_ShowInvisible";
            this.chkWindowControl_ShowInvisible.Size = new System.Drawing.Size(186, 17);
            this.chkWindowControl_ShowInvisible.TabIndex = 0;
            this.chkWindowControl_ShowInvisible.Text = "Show Invisible / Hidden Windows";
            this.chkWindowControl_ShowInvisible.UseVisualStyleBackColor = true;
            // 
            // tbpListColumns
            // 
            this.tbpListColumns.Controls.Add(this.clbColumns);
            this.tbpListColumns.Controls.Add(this.panel1);
            this.tbpListColumns.Location = new System.Drawing.Point(4, 22);
            this.tbpListColumns.Name = "tbpListColumns";
            this.tbpListColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListColumns.Size = new System.Drawing.Size(291, 119);
            this.tbpListColumns.TabIndex = 1;
            this.tbpListColumns.Text = "Columns";
            this.tbpListColumns.UseVisualStyleBackColor = true;
            // 
            // clbColumns
            // 
            this.clbColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbColumns.FormattingEnabled = true;
            this.clbColumns.Location = new System.Drawing.Point(3, 3);
            this.clbColumns.Name = "clbColumns";
            this.clbColumns.Size = new System.Drawing.Size(255, 109);
            this.clbColumns.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnColMoveDown);
            this.panel1.Controls.Add(this.btnColMoveUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(258, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 113);
            this.panel1.TabIndex = 1;
            // 
            // btnColMoveDown
            // 
            this.btnColMoveDown.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnColMoveDown.Location = new System.Drawing.Point(3, 33);
            this.btnColMoveDown.Name = "btnColMoveDown";
            this.btnColMoveDown.Size = new System.Drawing.Size(24, 24);
            this.btnColMoveDown.TabIndex = 1;
            this.btnColMoveDown.Text = "ò";
            this.btnColMoveDown.UseVisualStyleBackColor = true;
            this.btnColMoveDown.Click += new System.EventHandler(this.btnColMoveDown_Click);
            // 
            // btnColMoveUp
            // 
            this.btnColMoveUp.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnColMoveUp.Location = new System.Drawing.Point(3, 3);
            this.btnColMoveUp.Name = "btnColMoveUp";
            this.btnColMoveUp.Size = new System.Drawing.Size(24, 24);
            this.btnColMoveUp.TabIndex = 0;
            this.btnColMoveUp.Text = "ñ";
            this.btnColMoveUp.UseVisualStyleBackColor = true;
            this.btnColMoveUp.Click += new System.EventHandler(this.btnColMoveUp_Click);
            // 
            // panButtonBar
            // 
            this.panButtonBar.Controls.Add(this.btnCancel);
            this.panButtonBar.Controls.Add(this.btnOK);
            this.panButtonBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtonBar.Location = new System.Drawing.Point(4, 155);
            this.panButtonBar.Name = "panButtonBar";
            this.panButtonBar.Size = new System.Drawing.Size(299, 30);
            this.panButtonBar.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(221, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(140, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkWindowControl_ShowApplicationIcons
            // 
            this.chkWindowControl_ShowApplicationIcons.AutoSize = true;
            this.chkWindowControl_ShowApplicationIcons.Location = new System.Drawing.Point(6, 52);
            this.chkWindowControl_ShowApplicationIcons.Name = "chkWindowControl_ShowApplicationIcons";
            this.chkWindowControl_ShowApplicationIcons.Size = new System.Drawing.Size(137, 17);
            this.chkWindowControl_ShowApplicationIcons.TabIndex = 2;
            this.chkWindowControl_ShowApplicationIcons.Text = "Show Application &Icons";
            this.chkWindowControl_ShowApplicationIcons.UseVisualStyleBackColor = true;
            // 
            // Configuration
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(307, 189);
            this.Controls.Add(this.panButtonBar);
            this.Controls.Add(this.tbcSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Configuration";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Configuration_FormClosed);
            this.tbcSettings.ResumeLayout(false);
            this.tbpWindowControl.ResumeLayout(false);
            this.tbpWindowControl.PerformLayout();
            this.tbpListColumns.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panButtonBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.TabPage tbpWindowControl;
        private System.Windows.Forms.TabPage tbpListColumns;
        private System.Windows.Forms.Panel panButtonBar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkWindowControl_ShowUntitled;
        private System.Windows.Forms.CheckBox chkWindowControl_ShowInvisible;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColMoveDown;
        private System.Windows.Forms.Button btnColMoveUp;
        private System.Windows.Forms.CheckedListBox clbColumns;
        private System.Windows.Forms.CheckBox chkWindowControl_ShowApplicationIcons;

    }
}
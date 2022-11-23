namespace UMLGraphEditor
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
            this.tsmnuMain = new System.Windows.Forms.MenuStrip();
            this.tsbtnMain = new System.Windows.Forms.ToolStrip();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.panEditor = new System.Windows.Forms.Panel();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rtfDoctext = new System.Windows.Forms.RichTextBox();
            this.tsmnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuViewRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuMain.SuspendLayout();
            this.panEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // tsmnuMain
            // 
            this.tsmnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuView});
            this.tsmnuMain.Location = new System.Drawing.Point(0, 0);
            this.tsmnuMain.Name = "tsmnuMain";
            this.tsmnuMain.Size = new System.Drawing.Size(487, 24);
            this.tsmnuMain.TabIndex = 0;
            this.tsmnuMain.Text = "menuStrip1";
            // 
            // tsbtnMain
            // 
            this.tsbtnMain.Location = new System.Drawing.Point(0, 24);
            this.tsbtnMain.Name = "tsbtnMain";
            this.tsbtnMain.Size = new System.Drawing.Size(487, 25);
            this.tsbtnMain.TabIndex = 1;
            this.tsbtnMain.Text = "toolStrip1";
            // 
            // ssMain
            // 
            this.ssMain.Location = new System.Drawing.Point(0, 324);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(487, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // panEditor
            // 
            this.panEditor.Controls.Add(this.splitter1);
            this.panEditor.Controls.Add(this.picPreview);
            this.panEditor.Controls.Add(this.rtfDoctext);
            this.panEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panEditor.Location = new System.Drawing.Point(0, 49);
            this.panEditor.Name = "panEditor";
            this.panEditor.Size = new System.Drawing.Size(487, 230);
            this.panEditor.TabIndex = 3;
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.SystemColors.Window;
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPreview.Location = new System.Drawing.Point(0, 0);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(487, 119);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 147);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(487, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // rtfDoctext
            // 
            this.rtfDoctext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtfDoctext.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfDoctext.Location = new System.Drawing.Point(0, 150);
            this.rtfDoctext.Name = "rtfDoctext";
            this.rtfDoctext.Size = new System.Drawing.Size(487, 80);
            this.rtfDoctext.TabIndex = 2;
            this.rtfDoctext.Text = "";
            // 
            // tsmnuView
            // 
            this.tsmnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuViewRefresh});
            this.tsmnuView.Name = "tsmnuView";
            this.tsmnuView.Size = new System.Drawing.Size(44, 20);
            this.tsmnuView.Text = "&View";
            // 
            // tsmnuViewRefresh
            // 
            this.tsmnuViewRefresh.Name = "tsmnuViewRefresh";
            this.tsmnuViewRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmnuViewRefresh.Size = new System.Drawing.Size(152, 22);
            this.tsmnuViewRefresh.Text = "&Refresh";
            this.tsmnuViewRefresh.Click += new System.EventHandler(this.tsmnuViewRefresh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 346);
            this.Controls.Add(this.panEditor);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsbtnMain);
            this.Controls.Add(this.tsmnuMain);
            this.MainMenuStrip = this.tsmnuMain;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tsmnuMain.ResumeLayout(false);
            this.tsmnuMain.PerformLayout();
            this.panEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tsmnuMain;
        private System.Windows.Forms.ToolStrip tsbtnMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Panel panEditor;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.RichTextBox rtfDoctext;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem tsmnuView;
        private System.Windows.Forms.ToolStripMenuItem tsmnuViewRefresh;
    }
}


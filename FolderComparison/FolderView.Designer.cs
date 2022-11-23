namespace FolderComparison
{
    partial class FolderView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panHeader = new System.Windows.Forms.Panel();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.colFileName = new System.Windows.Forms.ColumnHeader();
            this.colFileType = new System.Windows.Forms.ColumnHeader();
            this.colFileSize = new System.Windows.Forms.ColumnHeader();
            this.colDateModified = new System.Windows.Forms.ColumnHeader();
            this.colAttributes = new System.Windows.Forms.ColumnHeader();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.Controls.Add(this.lblFolder);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(434, 25);
            this.panHeader.TabIndex = 1;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoEllipsis = true;
            this.lblFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFolder.Location = new System.Drawing.Point(0, 0);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(434, 25);
            this.lblFolder.TabIndex = 1;
            this.lblFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFolder.UseMnemonic = false;
            // 
            // lvwFiles
            // 
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colFileType,
            this.colFileSize,
            this.colDateModified,
            this.colAttributes});
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwFiles.FullRowSelect = true;
            this.lvwFiles.GridLines = true;
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.Location = new System.Drawing.Point(0, 25);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(434, 222);
            this.lvwFiles.TabIndex = 2;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            // 
            // colFileName
            // 
            this.colFileName.Text = "FileName";
            this.colFileName.Width = 120;
            // 
            // colFileType
            // 
            this.colFileType.Text = "Type";
            this.colFileType.Width = 90;
            // 
            // colFileSize
            // 
            this.colFileSize.Text = "Size";
            this.colFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colDateModified
            // 
            this.colDateModified.Text = "Modified";
            this.colDateModified.Width = 90;
            // 
            // colAttributes
            // 
            this.colAttributes.Text = "Attributes";
            this.colAttributes.Width = 45;
            // 
            // FolderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvwFiles);
            this.Controls.Add(this.panHeader);
            this.Name = "FolderView";
            this.Size = new System.Drawing.Size(434, 325);
            this.Load += new System.EventHandler(this.FolderView_Load);
            this.panHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colFileType;
        private System.Windows.Forms.ColumnHeader colFileSize;
        private System.Windows.Forms.ColumnHeader colDateModified;
        private System.Windows.Forms.ColumnHeader colAttributes;
    }
}

namespace LOCAmender
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
            this.selectFolder = new System.Windows.Forms.Button();
            this.amendFiles = new System.Windows.Forms.Button();
            this.textBoxFolderSelected = new System.Windows.Forms.Label();
            this.completeMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(206, 12);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(117, 23);
            this.selectFolder.TabIndex = 0;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // amendFiles
            // 
            this.amendFiles.Location = new System.Drawing.Point(206, 114);
            this.amendFiles.Name = "amendFiles";
            this.amendFiles.Size = new System.Drawing.Size(113, 23);
            this.amendFiles.TabIndex = 2;
            this.amendFiles.Text = "Amend Files";
            this.amendFiles.UseVisualStyleBackColor = true;
            this.amendFiles.Click += new System.EventHandler(this.amendFiles_Click);
            // 
            // textBoxFolderSelected
            // 
            this.textBoxFolderSelected.Location = new System.Drawing.Point(78, 56);
            this.textBoxFolderSelected.Name = "textBoxFolderSelected";
            this.textBoxFolderSelected.Size = new System.Drawing.Size(373, 23);
            this.textBoxFolderSelected.TabIndex = 4;
            this.textBoxFolderSelected.Text = "Select a Folder";
            this.textBoxFolderSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completeMessage
            // 
            this.completeMessage.Location = new System.Drawing.Point(140, 203);
            this.completeMessage.Name = "completeMessage";
            this.completeMessage.Size = new System.Drawing.Size(243, 23);
            this.completeMessage.TabIndex = 5;
            this.completeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(541, 412);
            this.Controls.Add(this.completeMessage);
            this.Controls.Add(this.textBoxFolderSelected);
            this.Controls.Add(this.amendFiles);
            this.Controls.Add(this.selectFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Letter of Credit Amender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Button amendFiles;
        private System.Windows.Forms.Label textBoxFolderSelected;
        private System.Windows.Forms.Label completeMessage;
    }
}


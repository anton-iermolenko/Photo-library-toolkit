namespace PhotoLibaryToolkit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbModifyDateClone = new System.Windows.Forms.GroupBox();
            this.btnCloneTargetFolderSelect = new System.Windows.Forms.Button();
            this.btnCloneSourceFolderSelect = new System.Windows.Forms.Button();
            this.btnCloneModifyDates = new System.Windows.Forms.Button();
            this.txtTargetExtensionForClone = new System.Windows.Forms.TextBox();
            this.txtSourceExtensionForClone = new System.Windows.Forms.TextBox();
            this.lblFileExtensionForClone = new System.Windows.Forms.Label();
            this.txtTargetPathForClone = new System.Windows.Forms.TextBox();
            this.lblTargetPathForClone = new System.Windows.Forms.Label();
            this.txtSourcePathForClone = new System.Windows.Forms.TextBox();
            this.lblSoucePathForClone = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.gbOrganizeFiles = new System.Windows.Forms.GroupBox();
            this.btnNamingLocationFolderSelect = new System.Windows.Forms.Button();
            this.chkSetDateForAllFiles = new System.Windows.Forms.CheckBox();
            this.chkIncludeSubfolders = new System.Windows.Forms.CheckBox();
            this.chkReviewBeforeApplying = new System.Windows.Forms.CheckBox();
            this.btnOrganizeFolderFiles = new System.Windows.Forms.Button();
            this.txtOrganizationTarget = new System.Windows.Forms.TextBox();
            this.lblOrganizationTarget = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gbModifyDateClone.SuspendLayout();
            this.gbOrganizeFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbModifyDateClone
            // 
            this.gbModifyDateClone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbModifyDateClone.Controls.Add(this.btnCloneTargetFolderSelect);
            this.gbModifyDateClone.Controls.Add(this.btnCloneSourceFolderSelect);
            this.gbModifyDateClone.Controls.Add(this.btnCloneModifyDates);
            this.gbModifyDateClone.Controls.Add(this.txtTargetExtensionForClone);
            this.gbModifyDateClone.Controls.Add(this.txtSourceExtensionForClone);
            this.gbModifyDateClone.Controls.Add(this.lblFileExtensionForClone);
            this.gbModifyDateClone.Controls.Add(this.txtTargetPathForClone);
            this.gbModifyDateClone.Controls.Add(this.lblTargetPathForClone);
            this.gbModifyDateClone.Controls.Add(this.txtSourcePathForClone);
            this.gbModifyDateClone.Controls.Add(this.lblSoucePathForClone);
            this.gbModifyDateClone.Location = new System.Drawing.Point(12, 12);
            this.gbModifyDateClone.Name = "gbModifyDateClone";
            this.gbModifyDateClone.Size = new System.Drawing.Size(575, 95);
            this.gbModifyDateClone.TabIndex = 0;
            this.gbModifyDateClone.TabStop = false;
            this.gbModifyDateClone.Text = "Clone taken dates for files with same name, but different locations";
            // 
            // btnCloneTargetFolderSelect
            // 
            this.btnCloneTargetFolderSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloneTargetFolderSelect.Location = new System.Drawing.Point(358, 60);
            this.btnCloneTargetFolderSelect.Name = "btnCloneTargetFolderSelect";
            this.btnCloneTargetFolderSelect.Size = new System.Drawing.Size(27, 20);
            this.btnCloneTargetFolderSelect.TabIndex = 9;
            this.btnCloneTargetFolderSelect.Text = "..";
            this.btnCloneTargetFolderSelect.UseVisualStyleBackColor = true;
            this.btnCloneTargetFolderSelect.Click += new System.EventHandler(this.btnCloneTargetFolderSelect_Click);
            // 
            // btnCloneSourceFolderSelect
            // 
            this.btnCloneSourceFolderSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloneSourceFolderSelect.Location = new System.Drawing.Point(358, 34);
            this.btnCloneSourceFolderSelect.Name = "btnCloneSourceFolderSelect";
            this.btnCloneSourceFolderSelect.Size = new System.Drawing.Size(27, 20);
            this.btnCloneSourceFolderSelect.TabIndex = 8;
            this.btnCloneSourceFolderSelect.Text = "..";
            this.btnCloneSourceFolderSelect.UseVisualStyleBackColor = true;
            this.btnCloneSourceFolderSelect.Click += new System.EventHandler(this.btnCloneSourceFolderSelect_Click);
            // 
            // btnCloneModifyDates
            // 
            this.btnCloneModifyDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloneModifyDates.Location = new System.Drawing.Point(465, 34);
            this.btnCloneModifyDates.Name = "btnCloneModifyDates";
            this.btnCloneModifyDates.Size = new System.Drawing.Size(92, 46);
            this.btnCloneModifyDates.TabIndex = 7;
            this.btnCloneModifyDates.Text = "Clone dates";
            this.btnCloneModifyDates.UseVisualStyleBackColor = true;
            this.btnCloneModifyDates.Click += new System.EventHandler(this.btnCloneModifyDates_Click);
            // 
            // txtTargetExtensionForClone
            // 
            this.txtTargetExtensionForClone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetExtensionForClone.Location = new System.Drawing.Point(393, 60);
            this.txtTargetExtensionForClone.Name = "txtTargetExtensionForClone";
            this.txtTargetExtensionForClone.Size = new System.Drawing.Size(60, 20);
            this.txtTargetExtensionForClone.TabIndex = 6;
            this.txtTargetExtensionForClone.Text = "mp4";
            // 
            // txtSourceExtensionForClone
            // 
            this.txtSourceExtensionForClone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceExtensionForClone.Location = new System.Drawing.Point(393, 34);
            this.txtSourceExtensionForClone.Name = "txtSourceExtensionForClone";
            this.txtSourceExtensionForClone.Size = new System.Drawing.Size(60, 20);
            this.txtSourceExtensionForClone.TabIndex = 5;
            this.txtSourceExtensionForClone.Text = "avi";
            // 
            // lblFileExtensionForClone
            // 
            this.lblFileExtensionForClone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileExtensionForClone.AutoSize = true;
            this.lblFileExtensionForClone.Location = new System.Drawing.Point(389, 16);
            this.lblFileExtensionForClone.Name = "lblFileExtensionForClone";
            this.lblFileExtensionForClone.Size = new System.Drawing.Size(53, 13);
            this.lblFileExtensionForClone.TabIndex = 4;
            this.lblFileExtensionForClone.Text = "Extension";
            // 
            // txtTargetPathForClone
            // 
            this.txtTargetPathForClone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetPathForClone.Location = new System.Drawing.Point(88, 60);
            this.txtTargetPathForClone.Name = "txtTargetPathForClone";
            this.txtTargetPathForClone.Size = new System.Drawing.Size(264, 20);
            this.txtTargetPathForClone.TabIndex = 3;
            // 
            // lblTargetPathForClone
            // 
            this.lblTargetPathForClone.AutoSize = true;
            this.lblTargetPathForClone.Location = new System.Drawing.Point(5, 63);
            this.lblTargetPathForClone.Name = "lblTargetPathForClone";
            this.lblTargetPathForClone.Size = new System.Drawing.Size(63, 13);
            this.lblTargetPathForClone.TabIndex = 2;
            this.lblTargetPathForClone.Text = "Destination:";
            // 
            // txtSourcePathForClone
            // 
            this.txtSourcePathForClone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourcePathForClone.Location = new System.Drawing.Point(88, 34);
            this.txtSourcePathForClone.Name = "txtSourcePathForClone";
            this.txtSourcePathForClone.Size = new System.Drawing.Size(264, 20);
            this.txtSourcePathForClone.TabIndex = 1;
            // 
            // lblSoucePathForClone
            // 
            this.lblSoucePathForClone.AutoSize = true;
            this.lblSoucePathForClone.Location = new System.Drawing.Point(5, 37);
            this.lblSoucePathForClone.Name = "lblSoucePathForClone";
            this.lblSoucePathForClone.Size = new System.Drawing.Size(44, 13);
            this.lblSoucePathForClone.TabIndex = 0;
            this.lblSoucePathForClone.Text = "Source:";
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(12, 227);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(575, 95);
            this.lbLog.TabIndex = 1;
            // 
            // lblLog
            // 
            this.lblLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 211);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(58, 13);
            this.lblLog.TabIndex = 2;
            this.lblLog.Text = "Activity log";
            // 
            // gbOrganizeFiles
            // 
            this.gbOrganizeFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOrganizeFiles.Controls.Add(this.btnNamingLocationFolderSelect);
            this.gbOrganizeFiles.Controls.Add(this.chkSetDateForAllFiles);
            this.gbOrganizeFiles.Controls.Add(this.chkIncludeSubfolders);
            this.gbOrganizeFiles.Controls.Add(this.chkReviewBeforeApplying);
            this.gbOrganizeFiles.Controls.Add(this.btnOrganizeFolderFiles);
            this.gbOrganizeFiles.Controls.Add(this.txtOrganizationTarget);
            this.gbOrganizeFiles.Controls.Add(this.lblOrganizationTarget);
            this.gbOrganizeFiles.Location = new System.Drawing.Point(12, 113);
            this.gbOrganizeFiles.Name = "gbOrganizeFiles";
            this.gbOrganizeFiles.Size = new System.Drawing.Size(575, 95);
            this.gbOrganizeFiles.TabIndex = 3;
            this.gbOrganizeFiles.TabStop = false;
            this.gbOrganizeFiles.Text = "Autoname files based on taken date";
            // 
            // btnNamingLocationFolderSelect
            // 
            this.btnNamingLocationFolderSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNamingLocationFolderSelect.Location = new System.Drawing.Point(426, 18);
            this.btnNamingLocationFolderSelect.Name = "btnNamingLocationFolderSelect";
            this.btnNamingLocationFolderSelect.Size = new System.Drawing.Size(27, 20);
            this.btnNamingLocationFolderSelect.TabIndex = 11;
            this.btnNamingLocationFolderSelect.Text = "..";
            this.btnNamingLocationFolderSelect.UseVisualStyleBackColor = true;
            this.btnNamingLocationFolderSelect.Click += new System.EventHandler(this.btnNamingLocationFolderSelect_Click);
            // 
            // chkSetDateForAllFiles
            // 
            this.chkSetDateForAllFiles.AutoSize = true;
            this.chkSetDateForAllFiles.Location = new System.Drawing.Point(264, 46);
            this.chkSetDateForAllFiles.Name = "chkSetDateForAllFiles";
            this.chkSetDateForAllFiles.Size = new System.Drawing.Size(181, 17);
            this.chkSetDateForAllFiles.TabIndex = 10;
            this.chkSetDateForAllFiles.Text = "Force file date change for all files";
            this.chkSetDateForAllFiles.UseVisualStyleBackColor = true;
            // 
            // chkIncludeSubfolders
            // 
            this.chkIncludeSubfolders.AutoSize = true;
            this.chkIncludeSubfolders.Checked = true;
            this.chkIncludeSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeSubfolders.Location = new System.Drawing.Point(88, 69);
            this.chkIncludeSubfolders.Name = "chkIncludeSubfolders";
            this.chkIncludeSubfolders.Size = new System.Drawing.Size(112, 17);
            this.chkIncludeSubfolders.TabIndex = 9;
            this.chkIncludeSubfolders.Text = "Include subfolders";
            this.chkIncludeSubfolders.UseVisualStyleBackColor = true;
            // 
            // chkReviewBeforeApplying
            // 
            this.chkReviewBeforeApplying.AutoSize = true;
            this.chkReviewBeforeApplying.Checked = true;
            this.chkReviewBeforeApplying.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReviewBeforeApplying.Location = new System.Drawing.Point(88, 46);
            this.chkReviewBeforeApplying.Name = "chkReviewBeforeApplying";
            this.chkReviewBeforeApplying.Size = new System.Drawing.Size(139, 17);
            this.chkReviewBeforeApplying.TabIndex = 8;
            this.chkReviewBeforeApplying.Text = "Preview before applying";
            this.chkReviewBeforeApplying.UseVisualStyleBackColor = true;
            // 
            // btnOrganizeFolderFiles
            // 
            this.btnOrganizeFolderFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrganizeFolderFiles.Location = new System.Drawing.Point(465, 34);
            this.btnOrganizeFolderFiles.Name = "btnOrganizeFolderFiles";
            this.btnOrganizeFolderFiles.Size = new System.Drawing.Size(92, 46);
            this.btnOrganizeFolderFiles.TabIndex = 7;
            this.btnOrganizeFolderFiles.Text = "Autoname";
            this.btnOrganizeFolderFiles.UseVisualStyleBackColor = true;
            this.btnOrganizeFolderFiles.Click += new System.EventHandler(this.btnOrganizeFolderFiles_Click);
            // 
            // txtOrganizationTarget
            // 
            this.txtOrganizationTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrganizationTarget.Location = new System.Drawing.Point(88, 19);
            this.txtOrganizationTarget.Name = "txtOrganizationTarget";
            this.txtOrganizationTarget.Size = new System.Drawing.Size(332, 20);
            this.txtOrganizationTarget.TabIndex = 1;
            // 
            // lblOrganizationTarget
            // 
            this.lblOrganizationTarget.AutoSize = true;
            this.lblOrganizationTarget.Location = new System.Drawing.Point(5, 22);
            this.lblOrganizationTarget.Name = "lblOrganizationTarget";
            this.lblOrganizationTarget.Size = new System.Drawing.Size(51, 13);
            this.lblOrganizationTarget.TabIndex = 0;
            this.lblOrganizationTarget.Text = "Location:";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 334);
            this.Controls.Add(this.gbOrganizeFiles);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.gbModifyDateClone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(615, 372);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo library tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbModifyDateClone.ResumeLayout(false);
            this.gbModifyDateClone.PerformLayout();
            this.gbOrganizeFiles.ResumeLayout(false);
            this.gbOrganizeFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbModifyDateClone;
        private System.Windows.Forms.TextBox txtSourcePathForClone;
        private System.Windows.Forms.Label lblSoucePathForClone;
        private System.Windows.Forms.TextBox txtTargetPathForClone;
        private System.Windows.Forms.Label lblTargetPathForClone;
        private System.Windows.Forms.Label lblFileExtensionForClone;
        private System.Windows.Forms.TextBox txtTargetExtensionForClone;
        private System.Windows.Forms.TextBox txtSourceExtensionForClone;
        private System.Windows.Forms.Button btnCloneModifyDates;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.GroupBox gbOrganizeFiles;
        private System.Windows.Forms.CheckBox chkReviewBeforeApplying;
        private System.Windows.Forms.Button btnOrganizeFolderFiles;
        private System.Windows.Forms.TextBox txtOrganizationTarget;
        private System.Windows.Forms.Label lblOrganizationTarget;
        private System.Windows.Forms.CheckBox chkIncludeSubfolders;
        private System.Windows.Forms.CheckBox chkSetDateForAllFiles;
        private System.Windows.Forms.Button btnCloneSourceFolderSelect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnCloneTargetFolderSelect;
        private System.Windows.Forms.Button btnNamingLocationFolderSelect;
    }
}


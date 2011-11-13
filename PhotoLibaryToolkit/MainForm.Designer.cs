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
            resources.ApplyResources(this.gbModifyDateClone, "gbModifyDateClone");
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
            this.gbModifyDateClone.Name = "gbModifyDateClone";
            this.gbModifyDateClone.TabStop = false;
            // 
            // btnCloneTargetFolderSelect
            // 
            resources.ApplyResources(this.btnCloneTargetFolderSelect, "btnCloneTargetFolderSelect");
            this.btnCloneTargetFolderSelect.Name = "btnCloneTargetFolderSelect";
            this.btnCloneTargetFolderSelect.UseVisualStyleBackColor = true;
            this.btnCloneTargetFolderSelect.Click += new System.EventHandler(this.btnCloneTargetFolderSelect_Click);
            // 
            // btnCloneSourceFolderSelect
            // 
            resources.ApplyResources(this.btnCloneSourceFolderSelect, "btnCloneSourceFolderSelect");
            this.btnCloneSourceFolderSelect.Name = "btnCloneSourceFolderSelect";
            this.btnCloneSourceFolderSelect.UseVisualStyleBackColor = true;
            this.btnCloneSourceFolderSelect.Click += new System.EventHandler(this.btnCloneSourceFolderSelect_Click);
            // 
            // btnCloneModifyDates
            // 
            resources.ApplyResources(this.btnCloneModifyDates, "btnCloneModifyDates");
            this.btnCloneModifyDates.Name = "btnCloneModifyDates";
            this.btnCloneModifyDates.UseVisualStyleBackColor = true;
            this.btnCloneModifyDates.Click += new System.EventHandler(this.btnCloneModifyDates_Click);
            // 
            // txtTargetExtensionForClone
            // 
            resources.ApplyResources(this.txtTargetExtensionForClone, "txtTargetExtensionForClone");
            this.txtTargetExtensionForClone.Name = "txtTargetExtensionForClone";
            // 
            // txtSourceExtensionForClone
            // 
            resources.ApplyResources(this.txtSourceExtensionForClone, "txtSourceExtensionForClone");
            this.txtSourceExtensionForClone.Name = "txtSourceExtensionForClone";
            // 
            // lblFileExtensionForClone
            // 
            resources.ApplyResources(this.lblFileExtensionForClone, "lblFileExtensionForClone");
            this.lblFileExtensionForClone.Name = "lblFileExtensionForClone";
            // 
            // txtTargetPathForClone
            // 
            resources.ApplyResources(this.txtTargetPathForClone, "txtTargetPathForClone");
            this.txtTargetPathForClone.Name = "txtTargetPathForClone";
            // 
            // lblTargetPathForClone
            // 
            resources.ApplyResources(this.lblTargetPathForClone, "lblTargetPathForClone");
            this.lblTargetPathForClone.Name = "lblTargetPathForClone";
            // 
            // txtSourcePathForClone
            // 
            resources.ApplyResources(this.txtSourcePathForClone, "txtSourcePathForClone");
            this.txtSourcePathForClone.Name = "txtSourcePathForClone";
            // 
            // lblSoucePathForClone
            // 
            resources.ApplyResources(this.lblSoucePathForClone, "lblSoucePathForClone");
            this.lblSoucePathForClone.Name = "lblSoucePathForClone";
            // 
            // lbLog
            // 
            resources.ApplyResources(this.lbLog, "lbLog");
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Name = "lbLog";
            // 
            // lblLog
            // 
            resources.ApplyResources(this.lblLog, "lblLog");
            this.lblLog.Name = "lblLog";
            // 
            // gbOrganizeFiles
            // 
            resources.ApplyResources(this.gbOrganizeFiles, "gbOrganizeFiles");
            this.gbOrganizeFiles.Controls.Add(this.btnNamingLocationFolderSelect);
            this.gbOrganizeFiles.Controls.Add(this.chkSetDateForAllFiles);
            this.gbOrganizeFiles.Controls.Add(this.chkIncludeSubfolders);
            this.gbOrganizeFiles.Controls.Add(this.chkReviewBeforeApplying);
            this.gbOrganizeFiles.Controls.Add(this.btnOrganizeFolderFiles);
            this.gbOrganizeFiles.Controls.Add(this.txtOrganizationTarget);
            this.gbOrganizeFiles.Controls.Add(this.lblOrganizationTarget);
            this.gbOrganizeFiles.Name = "gbOrganizeFiles";
            this.gbOrganizeFiles.TabStop = false;
            // 
            // btnNamingLocationFolderSelect
            // 
            resources.ApplyResources(this.btnNamingLocationFolderSelect, "btnNamingLocationFolderSelect");
            this.btnNamingLocationFolderSelect.Name = "btnNamingLocationFolderSelect";
            this.btnNamingLocationFolderSelect.UseVisualStyleBackColor = true;
            this.btnNamingLocationFolderSelect.Click += new System.EventHandler(this.btnNamingLocationFolderSelect_Click);
            // 
            // chkSetDateForAllFiles
            // 
            resources.ApplyResources(this.chkSetDateForAllFiles, "chkSetDateForAllFiles");
            this.chkSetDateForAllFiles.Name = "chkSetDateForAllFiles";
            this.chkSetDateForAllFiles.UseVisualStyleBackColor = true;
            // 
            // chkIncludeSubfolders
            // 
            resources.ApplyResources(this.chkIncludeSubfolders, "chkIncludeSubfolders");
            this.chkIncludeSubfolders.Checked = true;
            this.chkIncludeSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeSubfolders.Name = "chkIncludeSubfolders";
            this.chkIncludeSubfolders.UseVisualStyleBackColor = true;
            // 
            // chkReviewBeforeApplying
            // 
            resources.ApplyResources(this.chkReviewBeforeApplying, "chkReviewBeforeApplying");
            this.chkReviewBeforeApplying.Checked = true;
            this.chkReviewBeforeApplying.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReviewBeforeApplying.Name = "chkReviewBeforeApplying";
            this.chkReviewBeforeApplying.UseVisualStyleBackColor = true;
            // 
            // btnOrganizeFolderFiles
            // 
            resources.ApplyResources(this.btnOrganizeFolderFiles, "btnOrganizeFolderFiles");
            this.btnOrganizeFolderFiles.Name = "btnOrganizeFolderFiles";
            this.btnOrganizeFolderFiles.UseVisualStyleBackColor = true;
            this.btnOrganizeFolderFiles.Click += new System.EventHandler(this.btnOrganizeFolderFiles_Click);
            // 
            // txtOrganizationTarget
            // 
            resources.ApplyResources(this.txtOrganizationTarget, "txtOrganizationTarget");
            this.txtOrganizationTarget.Name = "txtOrganizationTarget";
            // 
            // lblOrganizationTarget
            // 
            resources.ApplyResources(this.lblOrganizationTarget, "lblOrganizationTarget");
            this.lblOrganizationTarget.Name = "lblOrganizationTarget";
            // 
            // folderBrowserDialog
            // 
            resources.ApplyResources(this.folderBrowserDialog, "folderBrowserDialog");
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOrganizeFiles);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.gbModifyDateClone);
            this.Name = "MainForm";
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


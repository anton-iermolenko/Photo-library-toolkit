namespace PhotoLibaryToolkit
{
    partial class RenamePreview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenamePreview));
            this.dgwRenaming = new System.Windows.Forms.DataGridView();
            this.photoLibraryMapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoLibraryMap = new PhotoLibaryToolkit.Framework.PhotoLibraryMap();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkHideNonRenaming = new System.Windows.Forms.CheckBox();
            this.TakenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentFileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newFileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renameFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DuplicateFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRenaming)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoLibraryMapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoLibraryMap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRenaming
            // 
            this.dgwRenaming.AllowUserToAddRows = false;
            this.dgwRenaming.AllowUserToOrderColumns = true;
            this.dgwRenaming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwRenaming.AutoGenerateColumns = false;
            this.dgwRenaming.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwRenaming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRenaming.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TakenDate,
            this.fileLocationDataGridViewTextBoxColumn,
            this.currentFileNameDataGridViewTextBoxColumn,
            this.newFileNameDataGridViewTextBoxColumn,
            this.Extension,
            this.renameFlagDataGridViewCheckBoxColumn,
            this.DuplicateFlag});
            this.dgwRenaming.DataSource = this.photoLibraryMapBindingSource;
            this.dgwRenaming.Location = new System.Drawing.Point(1, 2);
            this.dgwRenaming.Name = "dgwRenaming";
            this.dgwRenaming.Size = new System.Drawing.Size(1170, 563);
            this.dgwRenaming.TabIndex = 0;
            this.dgwRenaming.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwRenaming_CellFormatting);
            // 
            // photoLibraryMapBindingSource
            // 
            this.photoLibraryMapBindingSource.DataMember = "RenamingQueue";
            this.photoLibraryMapBindingSource.DataSource = this.photoLibraryMap;
            this.photoLibraryMapBindingSource.Filter = "RenameFlag = True";
            this.photoLibraryMapBindingSource.Sort = "TakenDate";
            // 
            // photoLibraryMap
            // 
            this.photoLibraryMap.DataSetName = "PhotoLibraryMap";
            this.photoLibraryMap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(983, 578);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Apply";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1083, 578);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkHideNonRenaming
            // 
            this.chkHideNonRenaming.AutoSize = true;
            this.chkHideNonRenaming.Checked = true;
            this.chkHideNonRenaming.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHideNonRenaming.Location = new System.Drawing.Point(12, 571);
            this.chkHideNonRenaming.Name = "chkHideNonRenaming";
            this.chkHideNonRenaming.Size = new System.Drawing.Size(126, 17);
            this.chkHideNonRenaming.TabIndex = 3;
            this.chkHideNonRenaming.Text = "Hide unchanged files";
            this.chkHideNonRenaming.UseVisualStyleBackColor = true;
            this.chkHideNonRenaming.CheckedChanged += new System.EventHandler(this.chkHideNonRenaming_CheckedChanged);
            // 
            // TakenDate
            // 
            this.TakenDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TakenDate.DataPropertyName = "TakenDate";
            this.TakenDate.HeaderText = "Date taken";
            this.TakenDate.Name = "TakenDate";
            this.TakenDate.Width = 85;
            // 
            // fileLocationDataGridViewTextBoxColumn
            // 
            this.fileLocationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileLocationDataGridViewTextBoxColumn.DataPropertyName = "FileLocation";
            this.fileLocationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.fileLocationDataGridViewTextBoxColumn.Name = "fileLocationDataGridViewTextBoxColumn";
            // 
            // currentFileNameDataGridViewTextBoxColumn
            // 
            this.currentFileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currentFileNameDataGridViewTextBoxColumn.DataPropertyName = "CurrentFileName";
            this.currentFileNameDataGridViewTextBoxColumn.HeaderText = "Current name";
            this.currentFileNameDataGridViewTextBoxColumn.Name = "currentFileNameDataGridViewTextBoxColumn";
            this.currentFileNameDataGridViewTextBoxColumn.Width = 95;
            // 
            // newFileNameDataGridViewTextBoxColumn
            // 
            this.newFileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.newFileNameDataGridViewTextBoxColumn.DataPropertyName = "NewFileName";
            this.newFileNameDataGridViewTextBoxColumn.HeaderText = "New name";
            this.newFileNameDataGridViewTextBoxColumn.Name = "newFileNameDataGridViewTextBoxColumn";
            this.newFileNameDataGridViewTextBoxColumn.Width = 83;
            // 
            // Extension
            // 
            this.Extension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Extension.DataPropertyName = "Extension";
            this.Extension.HeaderText = "Extension";
            this.Extension.Name = "Extension";
            this.Extension.Width = 78;
            // 
            // renameFlagDataGridViewCheckBoxColumn
            // 
            this.renameFlagDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.renameFlagDataGridViewCheckBoxColumn.DataPropertyName = "RenameFlag";
            this.renameFlagDataGridViewCheckBoxColumn.HeaderText = "Include in renaming";
            this.renameFlagDataGridViewCheckBoxColumn.Name = "renameFlagDataGridViewCheckBoxColumn";
            this.renameFlagDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.renameFlagDataGridViewCheckBoxColumn.Width = 114;
            // 
            // DuplicateFlag
            // 
            this.DuplicateFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DuplicateFlag.DataPropertyName = "DuplicateFlag";
            this.DuplicateFlag.HeaderText = "Duplicate taken date";
            this.DuplicateFlag.Name = "DuplicateFlag";
            this.DuplicateFlag.ReadOnly = true;
            this.DuplicateFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DuplicateFlag.Width = 101;
            // 
            // RenamePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 613);
            this.Controls.Add(this.chkHideNonRenaming);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgwRenaming);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RenamePreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview new file names";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRenaming)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoLibraryMapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoLibraryMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRenaming;
        private System.Windows.Forms.BindingSource photoLibraryMapBindingSource;
        private Framework.PhotoLibraryMap photoLibraryMap;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkHideNonRenaming;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakenDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewCheckBoxColumn renameFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DuplicateFlag;
    }
}
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
            resources.ApplyResources(this.dgwRenaming, "dgwRenaming");
            this.dgwRenaming.AllowUserToAddRows = false;
            this.dgwRenaming.AllowUserToOrderColumns = true;
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
            this.dgwRenaming.Name = "dgwRenaming";
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
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkHideNonRenaming
            // 
            resources.ApplyResources(this.chkHideNonRenaming, "chkHideNonRenaming");
            this.chkHideNonRenaming.Checked = true;
            this.chkHideNonRenaming.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHideNonRenaming.Name = "chkHideNonRenaming";
            this.chkHideNonRenaming.UseVisualStyleBackColor = true;
            this.chkHideNonRenaming.CheckedChanged += new System.EventHandler(this.chkHideNonRenaming_CheckedChanged);
            // 
            // TakenDate
            // 
            this.TakenDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TakenDate.DataPropertyName = "TakenDate";
            resources.ApplyResources(this.TakenDate, "TakenDate");
            this.TakenDate.Name = "TakenDate";
            // 
            // fileLocationDataGridViewTextBoxColumn
            // 
            this.fileLocationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileLocationDataGridViewTextBoxColumn.DataPropertyName = "FileLocation";
            resources.ApplyResources(this.fileLocationDataGridViewTextBoxColumn, "fileLocationDataGridViewTextBoxColumn");
            this.fileLocationDataGridViewTextBoxColumn.Name = "fileLocationDataGridViewTextBoxColumn";
            // 
            // currentFileNameDataGridViewTextBoxColumn
            // 
            this.currentFileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currentFileNameDataGridViewTextBoxColumn.DataPropertyName = "CurrentFileName";
            resources.ApplyResources(this.currentFileNameDataGridViewTextBoxColumn, "currentFileNameDataGridViewTextBoxColumn");
            this.currentFileNameDataGridViewTextBoxColumn.Name = "currentFileNameDataGridViewTextBoxColumn";
            // 
            // newFileNameDataGridViewTextBoxColumn
            // 
            this.newFileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.newFileNameDataGridViewTextBoxColumn.DataPropertyName = "NewFileName";
            resources.ApplyResources(this.newFileNameDataGridViewTextBoxColumn, "newFileNameDataGridViewTextBoxColumn");
            this.newFileNameDataGridViewTextBoxColumn.Name = "newFileNameDataGridViewTextBoxColumn";
            // 
            // Extension
            // 
            this.Extension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Extension.DataPropertyName = "Extension";
            resources.ApplyResources(this.Extension, "Extension");
            this.Extension.Name = "Extension";
            // 
            // renameFlagDataGridViewCheckBoxColumn
            // 
            this.renameFlagDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.renameFlagDataGridViewCheckBoxColumn.DataPropertyName = "RenameFlag";
            resources.ApplyResources(this.renameFlagDataGridViewCheckBoxColumn, "renameFlagDataGridViewCheckBoxColumn");
            this.renameFlagDataGridViewCheckBoxColumn.Name = "renameFlagDataGridViewCheckBoxColumn";
            this.renameFlagDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DuplicateFlag
            // 
            this.DuplicateFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DuplicateFlag.DataPropertyName = "DuplicateFlag";
            resources.ApplyResources(this.DuplicateFlag, "DuplicateFlag");
            this.DuplicateFlag.Name = "DuplicateFlag";
            this.DuplicateFlag.ReadOnly = true;
            this.DuplicateFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RenamePreview
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkHideNonRenaming);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgwRenaming);
            this.Name = "RenamePreview";
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
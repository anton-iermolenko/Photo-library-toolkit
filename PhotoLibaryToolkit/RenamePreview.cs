using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoLibaryToolkit
{
    using PhotoLibaryToolkit.Framework;

    public partial class RenamePreview : Form
    {
        public RenamePreview(PhotoLibraryMap dataSource)
        {
            InitializeComponent();

            photoLibraryMapBindingSource.DataSource = dataSource;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            
            if (!e.Cancel)
            {
                photoLibraryMapBindingSource.EndEdit();
            }
        }

        private void dgwRenaming_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == TakenDate.Index)
            {
                e.Value = ((DateTime)e.Value).ToString("yyyy:MM:dd HH:mm:ss");
                e.FormattingApplied = true;
            }
        }

        private void chkHideNonRenaming_CheckedChanged(object sender, EventArgs e)
        {
            photoLibraryMapBindingSource.Filter = chkHideNonRenaming.Checked ? "RenameFlag = True" : "";
        }
    }
}

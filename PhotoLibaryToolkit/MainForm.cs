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
    using System.IO;
    using PhotoLibaryToolkit.Framework;

    public partial class MainForm : Form
    {
        private Toolkit m_toolkit;
        private IPersistanceProvider<MainFormSettings> m_sessionSaver;

        public MainForm()
        {
            InitializeComponent();

            m_toolkit = new Toolkit(new LambdaLogger(LogToListBox));
            m_sessionSaver = new IsolatedStorageProvider<MainFormSettings>();
        }

        private void btnCloneModifyDates_Click(object sender, EventArgs e)
        {
            CleanListBoxLog();

            m_toolkit.CloneModificationDates(txtSourcePathForClone.Text, txtSourceExtensionForClone.Text, txtTargetPathForClone.Text, txtTargetExtensionForClone.Text);
        }

        private void CleanListBoxLog()
        {
            lock (lbLog)
            {
                lbLog.Items.Clear();
            }
            Application.DoEvents();
        }

        private void LogToListBox(string logEntry)
        {
            lock (lbLog)
            {
                lbLog.Items.Insert(0, logEntry);   
            }
            Application.DoEvents();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainFormSettings settings = m_sessionSaver.Load();
            if (settings != null)
            {
                txtSourcePathForClone.Text = settings.SourcePathForClone;
                txtSourceExtensionForClone.Text = settings.SourceExtensionForClone;
                txtTargetPathForClone.Text = settings.TargetPathForClone;
                txtTargetExtensionForClone.Text = settings.TargetExtensionForClone;
                txtOrganizationTarget.Text = settings.OrganizationTarget;
                chkIncludeSubfolders.Checked = settings.IncludeSubfolders;
                chkReviewBeforeApplying.Checked = settings.ReviewBeforeApplying;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (!e.Cancel)
            {
                MainFormSettings settings = new MainFormSettings();
                settings.SourcePathForClone = txtSourcePathForClone.Text;
                settings.SourceExtensionForClone = txtSourceExtensionForClone.Text;
                settings.TargetPathForClone = txtTargetPathForClone.Text;
                settings.TargetExtensionForClone = txtTargetExtensionForClone.Text;
                settings.OrganizationTarget = txtOrganizationTarget.Text;
                settings.IncludeSubfolders = chkIncludeSubfolders.Checked;
                settings.ReviewBeforeApplying = chkReviewBeforeApplying.Checked;

                m_sessionSaver.Save(settings);
            }
        }

        [Serializable]
        private class MainFormSettings
        {
            public string SourcePathForClone { get; set; }
            public string SourceExtensionForClone { get; set; }
            public string TargetPathForClone { get; set; }
            public string TargetExtensionForClone { get; set; }

            public string OrganizationTarget { get; set; }
            public bool IncludeSubfolders { get; set; }
            public bool ReviewBeforeApplying { get; set; }
        }

        private void btnOrganizeFolderFiles_Click(object sender, EventArgs e)
        {
            CleanListBoxLog();

            m_toolkit.OrganizePhotoLibrary(txtOrganizationTarget.Text, chkReviewBeforeApplying.Checked, chkIncludeSubfolders.Checked, chkSetDateForAllFiles.Checked, PerformRenamingReview);
        }

        public bool PerformRenamingReview(PhotoLibraryMap dataSource)
        {
            return new RenamePreview(dataSource).ShowDialog() == DialogResult.OK;
        }

        private void btnTransferFiles_Click(object sender, EventArgs e)
        {
            var d = new FolderBrowserDialog();
            d.ShowDialog();
        }
    }
}

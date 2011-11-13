namespace PhotoLibaryToolkit
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    using Framework;

    public partial class MainForm : Form
    {
        private readonly Toolkit _toolkit;
        private readonly IPersistanceProvider<MainFormSettings> _sessionSaver;

        public MainForm()
        {
            InitializeComponent();

            _toolkit = new Toolkit(new LambdaLogger(LogToListBox));
            _sessionSaver = new IsolatedStorageProvider<MainFormSettings>();
        }

        public bool PerformRenamingReview(PhotoLibraryMap dataSource)
        {
            return new RenamePreview(dataSource).ShowDialog() == DialogResult.OK;
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
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(LogToListBox), logEntry);
                return;
            }

            lock (lbLog)
            {
                lbLog.Items.Insert(0, logEntry);   
            }
            Application.DoEvents();
        }

        private void ChooseFolderFor(Action<string> setTargetFieldValue)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                setTargetFieldValue(folderBrowserDialog.SelectedPath);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainFormSettings settings = _sessionSaver.Load();
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

                _sessionSaver.Save(settings);
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

        private void btnCloneModifyDates_Click(object sender, EventArgs e)
        {
            CleanListBoxLog();

            _toolkit.CloneModificationDates(txtSourcePathForClone.Text, txtSourceExtensionForClone.Text, txtTargetPathForClone.Text, txtTargetExtensionForClone.Text);
        }

        private void btnOrganizeFolderFiles_Click(object sender, EventArgs e)
        {
            CleanListBoxLog();

            _toolkit.OrganizePhotoLibrary(txtOrganizationTarget.Text, chkReviewBeforeApplying.Checked, chkIncludeSubfolders.Checked, chkSetDateForAllFiles.Checked, PerformRenamingReview);
        }

        private void btnCloneSourceFolderSelect_Click(object sender, EventArgs e)
        {
            ChooseFolderFor(p => txtSourcePathForClone.Text = p);
        }

        private void btnCloneTargetFolderSelect_Click(object sender, EventArgs e)
        {
            ChooseFolderFor(p => txtTargetPathForClone.Text = p);
        }

        private void btnNamingLocationFolderSelect_Click(object sender, EventArgs e)
        {
            ChooseFolderFor(p => txtOrganizationTarget.Text = p);
        }
    }
}

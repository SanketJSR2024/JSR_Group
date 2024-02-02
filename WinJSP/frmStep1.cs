using System;
using System.Windows.Forms;

namespace WinJSP
{
    public partial class frmStep1 : UserControl
    {
        public frmStep1()
        {
            InitializeComponent();
        }

        private void btnSaveAndNext_Click(object sender, EventArgs e)
        {
            pnl1.Controls.Clear();
            frmStep2 frmStep = new frmStep2();
            FrmOnSite frmOnSite = new FrmOnSite();
            pnl1.Controls.Add(frmStep);

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    // Display the selected folder name
                    txtInputFolder.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnOutputUpload_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    // Display the selected folder name
                    txtOutFolder.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void pnl1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                pnl1.VerticalScroll.Value = e.NewValue;
            }
        }
    }
}

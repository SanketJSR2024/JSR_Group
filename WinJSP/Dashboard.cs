using System;
using System.Windows.Forms;

namespace WinJSP
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onSiteTestingLiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDashboard.Controls.Clear();
            FrmOnSite frmOnSiteTesting = new FrmOnSite();
            pnlDashboard.Controls.Add(frmOnSiteTesting);
        }

        private void onSiteTestingLiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSetting newProject = new FrmSetting();
            pnlDashboard.Controls.Add(newProject);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manufacturingEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDashboard.Controls.Clear();
        }

        private void bulkImageProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

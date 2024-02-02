using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinJSP
{
    public partial class ImageProcess : UserControl
    {
        public ImageProcess()
        {
            InitializeComponent();
        }

        private void chkExposure_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExposure.Checked)
            {
                txtExposureSet.Visible = true;
            }
            else
            {
                txtExposureSet.Visible = false;
            }
        }

        private void chkImageRename_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImageRename.Checked)
            {
                cmbImageRename.Visible = true;
            }
            else
            {
                chkImageRename.Visible = false;
            }
        }

        private void cmbAcceptance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAcceptance.Text=="New")
            {
                txtAcceptance.Visible = true;
            }
            else
            {
                txtAcceptance.Visible = false;
            }
        }
    }
}

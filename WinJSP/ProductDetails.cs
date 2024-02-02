using System;
using System.Windows.Forms;

namespace WinJSP
{
    public partial class ProductDetails : UserControl
    {
        public ProductDetails()
        {
            InitializeComponent();
            if (lblPDId.Text != string.Empty)
            {
                btnSave.Text = "Edit";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

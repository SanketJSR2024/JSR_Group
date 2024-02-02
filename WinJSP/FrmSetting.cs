using System.Windows.Forms;

namespace WinJSP
{
    public partial class FrmSetting : UserControl
    {
        public FrmSetting()
        {
            InitializeComponent();
            ProductDetails productDetails = new ProductDetails();
            pnlBody.Controls.Add(productDetails);
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
           
        }

        private void btnPD_Click(object sender, System.EventArgs e)
        {
            pnlBody.Controls.Clear();
            ProductDetails productDetails = new ProductDetails();
            pnlBody.Controls.Add(productDetails);
        }

        private void btnIP_Click(object sender, System.EventArgs e)
        {
            pnlBody.Controls.Clear();
            ImageProcess imgProcess = new ImageProcess();
            pnlBody.Controls.Add(imgProcess);
        }

        private void btnTxtImg_Click(object sender, System.EventArgs e)
        {
            pnlBody.Controls.Clear();
            TextImage textImage = new TextImage();
            pnlBody.Controls.Add(textImage);
        }

        private void btnAC_Click(object sender, System.EventArgs e)
        {
            pnlBody.Controls.Clear();
            AcceptanceCriteria acceptanceCriteria = new AcceptanceCriteria();
            pnlBody.Controls.Add(acceptanceCriteria);
        }
    }
}

using System.Windows.Forms;

namespace WinJSP
{
    public partial class FrmOnSite : UserControl
    {
        public FrmOnSite()
        {
            InitializeComponent();
            InitialForm();
        }

        private void InitialForm()
        {
            pnlStep1.Controls.Clear();
            frmStep1 frmStep1 = new frmStep1();
            pnlStep1.Controls.Add(frmStep1);
        }
    }
}

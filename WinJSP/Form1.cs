using System;
using System.Windows.Forms;

namespace WinJSP
{
    public partial class frmJSR : Form
    {
        public frmJSR()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != null && txtPassword.Text != null)
                {
                    if (txtUsername.Text == "admin@gmail.com" && txtPassword.Text == "Admin@*")
                    {
                        this.Hide();
                        Dashboard dashboard = new Dashboard();
                        dashboard.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        Dashboard dashboard = new Dashboard();
                        dashboard.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception)
            {

                throw;
            }


           
        }
    }
}

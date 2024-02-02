using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinJSP
{
    public partial class frmStep2 : UserControl
    {
        public frmStep2()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to allow only image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string imagePath = openFileDialog.FileName;

                try
                {
                    // Display the selected image in the PictureBox
                    picboxImage.Image = Image.FromFile(imagePath);
                    picboxImage.SizeMode = PictureBoxSizeMode.AutoSize;
                    pnlStep2.AutoSize = true;
                    txtUploadImage.Text = imagePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pnlStep2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                pnlStep2.VerticalScroll.Value = e.NewValue;
            }
        }
    }
}

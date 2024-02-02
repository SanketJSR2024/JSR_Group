namespace WinJSP
{
    partial class frmStep2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlStep2 = new System.Windows.Forms.Panel();
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtUploadImage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.pnlStep2.SuspendLayout();
            this.pnlUpload.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStep2
            // 
            this.pnlStep2.AutoScroll = true;
            this.pnlStep2.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.pnlStep2.Controls.Add(this.panel1);
            this.pnlStep2.Controls.Add(this.pnlUpload);
            this.pnlStep2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStep2.Location = new System.Drawing.Point(0, 0);
            this.pnlStep2.Name = "pnlStep2";
            this.pnlStep2.Size = new System.Drawing.Size(1024, 800);
            this.pnlStep2.TabIndex = 0;
            this.pnlStep2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlStep2_Scroll);
            // 
            // pnlUpload
            // 
            this.pnlUpload.Controls.Add(this.picboxImage);
            this.pnlUpload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpload.Location = new System.Drawing.Point(0, 63);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(1024, 737);
            this.pnlUpload.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(318, 14);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(86, 23);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtUploadImage
            // 
            this.txtUploadImage.Location = new System.Drawing.Point(95, 16);
            this.txtUploadImage.Name = "txtUploadImage";
            this.txtUploadImage.Size = new System.Drawing.Size(217, 20);
            this.txtUploadImage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Upload Image";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.txtUploadImage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 40);
            this.panel1.TabIndex = 2;
            // 
            // picboxImage
            // 
            this.picboxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxImage.Location = new System.Drawing.Point(0, 0);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(1024, 737);
            this.picboxImage.TabIndex = 0;
            this.picboxImage.TabStop = false;
            // 
            // frmStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlStep2);
            this.Name = "frmStep2";
            this.Size = new System.Drawing.Size(1024, 800);
            this.pnlStep2.ResumeLayout(false);
            this.pnlStep2.PerformLayout();
            this.pnlUpload.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStep2;
        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtUploadImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxImage;
    }
}

namespace WinJSP
{
    partial class FrmSetting
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
            this.pnlNewProject = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPD = new System.Windows.Forms.Button();
            this.btnTxtImg = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnIP = new System.Windows.Forms.Button();
            this.pnlNewProject.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewProject
            // 
            this.pnlNewProject.Controls.Add(this.panel1);
            this.pnlNewProject.Controls.Add(this.pnlBody);
            this.pnlNewProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNewProject.Location = new System.Drawing.Point(0, 0);
            this.pnlNewProject.Name = "pnlNewProject";
            this.pnlNewProject.Size = new System.Drawing.Size(900, 570);
            this.pnlNewProject.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Location = new System.Drawing.Point(0, 41);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(900, 526);
            this.pnlBody.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIP);
            this.panel1.Controls.Add(this.btnAC);
            this.panel1.Controls.Add(this.btnTxtImg);
            this.panel1.Controls.Add(this.btnPD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 40);
            this.panel1.TabIndex = 2;
            // 
            // btnPD
            // 
            this.btnPD.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPD.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPD.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPD.Location = new System.Drawing.Point(0, 0);
            this.btnPD.Name = "btnPD";
            this.btnPD.Size = new System.Drawing.Size(237, 40);
            this.btnPD.TabIndex = 0;
            this.btnPD.Text = "Personal Details";
            this.btnPD.UseVisualStyleBackColor = false;
            this.btnPD.Click += new System.EventHandler(this.btnPD_Click);
            // 
            // btnTxtImg
            // 
            this.btnTxtImg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTxtImg.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTxtImg.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTxtImg.Location = new System.Drawing.Point(682, 0);
            this.btnTxtImg.Name = "btnTxtImg";
            this.btnTxtImg.Size = new System.Drawing.Size(218, 40);
            this.btnTxtImg.TabIndex = 1;
            this.btnTxtImg.Text = "Text in image";
            this.btnTxtImg.UseVisualStyleBackColor = false;
            this.btnTxtImg.Click += new System.EventHandler(this.btnTxtImg_Click);
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAC.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAC.Location = new System.Drawing.Point(458, 0);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(224, 40);
            this.btnAC.TabIndex = 1;
            this.btnAC.Text = "Acceptance Criteria";
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnIP
            // 
            this.btnIP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnIP.Location = new System.Drawing.Point(237, 0);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(221, 40);
            this.btnIP.TabIndex = 1;
            this.btnIP.Text = "Image Process";
            this.btnIP.UseVisualStyleBackColor = false;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNewProject);
            this.Name = "NewProject";
            this.Size = new System.Drawing.Size(900, 570);
            this.pnlNewProject.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewProject;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPD;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnTxtImg;
    }
}

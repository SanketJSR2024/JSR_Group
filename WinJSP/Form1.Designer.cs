namespace WinJSP
{
    partial class frmJSR
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJSR));
            this.pnlLoginFrm = new System.Windows.Forms.Panel();
            this.pnlLoginDesign = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picImageIcon = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlLoginFrm.SuspendLayout();
            this.pnlLoginDesign.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoginFrm
            // 
            this.pnlLoginFrm.Controls.Add(this.btnMin);
            this.pnlLoginFrm.Controls.Add(this.btnClose);
            this.pnlLoginFrm.Controls.Add(this.pnlLogin);
            this.pnlLoginFrm.Controls.Add(this.pnlLoginDesign);
            this.pnlLoginFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginFrm.Name = "pnlLoginFrm";
            this.pnlLoginFrm.Size = new System.Drawing.Size(800, 450);
            this.pnlLoginFrm.TabIndex = 0;
            // 
            // pnlLoginDesign
            // 
            this.pnlLoginDesign.Controls.Add(this.picImageIcon);
            this.pnlLoginDesign.Location = new System.Drawing.Point(376, 31);
            this.pnlLoginDesign.Name = "pnlLoginDesign";
            this.pnlLoginDesign.Size = new System.Drawing.Size(412, 407);
            this.pnlLoginDesign.TabIndex = 0;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogin.Location = new System.Drawing.Point(12, 31);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(358, 407);
            this.pnlLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(132, 255);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 27);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(107, 156);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 202);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(218, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // picImageIcon
            // 
            this.picImageIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImageIcon.Image = ((System.Drawing.Image)(resources.GetObject("picImageIcon.Image")));
            this.picImageIcon.Location = new System.Drawing.Point(0, 0);
            this.picImageIcon.Name = "picImageIcon";
            this.picImageIcon.Size = new System.Drawing.Size(412, 407);
            this.picImageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImageIcon.TabIndex = 6;
            this.picImageIcon.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(763, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Location = new System.Drawing.Point(733, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(24, 22);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Login with Admin and Other Users";
            // 
            // frmJSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLoginFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJSR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSR INFOTECH";
            this.pnlLoginFrm.ResumeLayout(false);
            this.pnlLoginDesign.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginFrm;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlLoginDesign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picImageIcon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label4;
    }
}


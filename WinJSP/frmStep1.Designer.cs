namespace WinJSP
{
    partial class frmStep1
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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnOutputUpload = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveAndNext = new System.Windows.Forms.Button();
            this.txtOutFolder = new System.Windows.Forms.MaskedTextBox();
            this.txtInputFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderInput = new System.Windows.Forms.FolderBrowserDialog();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btnOutputUpload);
            this.pnl1.Controls.Add(this.btnUpload);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.btnSaveAndNext);
            this.pnl1.Controls.Add(this.txtOutFolder);
            this.pnl1.Controls.Add(this.txtInputFolder);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1024, 800);
            this.pnl1.TabIndex = 0;
            this.pnl1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnl1_Scroll);
            // 
            // btnOutputUpload
            // 
            this.btnOutputUpload.Location = new System.Drawing.Point(507, 210);
            this.btnOutputUpload.Name = "btnOutputUpload";
            this.btnOutputUpload.Size = new System.Drawing.Size(100, 23);
            this.btnOutputUpload.TabIndex = 7;
            this.btnOutputUpload.Text = "Output Upload";
            this.btnOutputUpload.UseVisualStyleBackColor = true;
            this.btnOutputUpload.Click += new System.EventHandler(this.btnOutputUpload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(507, 158);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Input Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Step : 1";
            // 
            // btnSaveAndNext
            // 
            this.btnSaveAndNext.Location = new System.Drawing.Point(429, 278);
            this.btnSaveAndNext.Name = "btnSaveAndNext";
            this.btnSaveAndNext.Size = new System.Drawing.Size(178, 31);
            this.btnSaveAndNext.TabIndex = 4;
            this.btnSaveAndNext.Text = "Save and Next";
            this.btnSaveAndNext.UseVisualStyleBackColor = true;
            this.btnSaveAndNext.Click += new System.EventHandler(this.btnSaveAndNext_Click);
            // 
            // txtOutFolder
            // 
            this.txtOutFolder.Location = new System.Drawing.Point(277, 213);
            this.txtOutFolder.Name = "txtOutFolder";
            this.txtOutFolder.Size = new System.Drawing.Size(224, 20);
            this.txtOutFolder.TabIndex = 3;
            // 
            // txtInputFolder
            // 
            this.txtInputFolder.Location = new System.Drawing.Point(277, 160);
            this.txtInputFolder.Name = "txtInputFolder";
            this.txtInputFolder.Size = new System.Drawing.Size(224, 20);
            this.txtInputFolder.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Output Folder location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Input Folder";
            // 
            // frmStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl1);
            this.Name = "frmStep1";
            this.Size = new System.Drawing.Size(1024, 800);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnSaveAndNext;
        private System.Windows.Forms.MaskedTextBox txtOutFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtInputFolder;
        private System.Windows.Forms.FolderBrowserDialog folderInput;
        private System.Windows.Forms.Button btnOutputUpload;
    }
}

namespace WinJSP
{
    partial class AcceptanceCriteria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefectType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitMeasurement = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AcceptableMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(28, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 399);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SRNo,
            this.DefectType,
            this.UnitMeasurement,
            this.AcceptableMeasurement,
            this.Quantity});
            this.dataGridView1.Location = new System.Drawing.Point(22, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 242);
            this.dataGridView1.TabIndex = 1;
            // 
            // SRNo
            // 
            this.SRNo.HeaderText = "SrNo";
            this.SRNo.MinimumWidth = 100;
            this.SRNo.Name = "SRNo";
            this.SRNo.ReadOnly = true;
            // 
            // DefectType
            // 
            this.DefectType.HeaderText = "Defect Type";
            this.DefectType.Items.AddRange(new object[] {
            "Cell Crack",
            "Tree / Branch crack",
            "Dead Cell",
            "Dark Spot",
            "Finger Interruption",
            "Open Soldering",
            "Backsheet Cut"});
            this.DefectType.MinimumWidth = 250;
            this.DefectType.Name = "DefectType";
            this.DefectType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DefectType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DefectType.Width = 250;
            // 
            // UnitMeasurement
            // 
            this.UnitMeasurement.HeaderText = "Unit of Measurement";
            this.UnitMeasurement.Items.AddRange(new object[] {
            "mm",
            "nos",
            "qty",
            "area in mm2"});
            this.UnitMeasurement.MinimumWidth = 150;
            this.UnitMeasurement.Name = "UnitMeasurement";
            this.UnitMeasurement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitMeasurement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UnitMeasurement.Width = 150;
            // 
            // AcceptableMeasurement
            // 
            this.AcceptableMeasurement.HeaderText = "Acceptable Measurement";
            this.AcceptableMeasurement.MinimumWidth = 150;
            this.AcceptableMeasurement.Name = "AcceptableMeasurement";
            this.AcceptableMeasurement.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity Acceptable per module";
            this.Quantity.MinimumWidth = 120;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 120;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtValue);
            this.panel2.Controls.Add(this.cmbOption);
            this.panel2.Controls.Add(this.lblKey);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(22, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 86);
            this.panel2.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(508, 47);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(228, 20);
            this.txtValue.TabIndex = 7;
            this.txtValue.Visible = false;
            // 
            // cmbOption
            // 
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "Manufacturer Name",
            "Site Name",
            "Factory Line Details"});
            this.cmbOption.Location = new System.Drawing.Point(508, 14);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(228, 21);
            this.cmbOption.TabIndex = 6;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(387, 50);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 5;
            this.lblKey.Text = "Key";
            this.lblKey.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Option";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Criteria Basket Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Acceptance Criteria";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Location = new System.Drawing.Point(742, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 30);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Location = new System.Drawing.Point(649, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 30);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AcceptanceCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AcceptanceCriteria";
            this.Size = new System.Drawing.Size(900, 526);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn DefectType;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptableMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}

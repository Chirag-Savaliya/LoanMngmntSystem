namespace LoanMngmntSystem
{
    partial class frmUsersViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgrdUsrs = new System.Windows.Forms.DataGridView();
            this.lblHdr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbtnPrtclr = new System.Windows.Forms.RadioButton();
            this.rdbtnWhole = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labLstName = new System.Windows.Forms.Label();
            this.cmbxId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrnt = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdUsrs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgrdUsrs);
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 226);
            this.panel1.TabIndex = 0;
            // 
            // dtgrdUsrs
            // 
            this.dtgrdUsrs.AllowUserToAddRows = false;
            this.dtgrdUsrs.AllowUserToDeleteRows = false;
            this.dtgrdUsrs.AllowUserToResizeColumns = false;
            this.dtgrdUsrs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dtgrdUsrs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdUsrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdUsrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column5,
            this.Column4,
            this.Column8});
            this.dtgrdUsrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdUsrs.Location = new System.Drawing.Point(0, 0);
            this.dtgrdUsrs.Name = "dtgrdUsrs";
            this.dtgrdUsrs.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdUsrs.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dtgrdUsrs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrdUsrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdUsrs.Size = new System.Drawing.Size(1247, 226);
            this.dtgrdUsrs.TabIndex = 0;
            // 
            // lblHdr
            // 
            this.lblHdr.AutoSize = true;
            this.lblHdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHdr.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHdr.ForeColor = System.Drawing.Color.Aqua;
            this.lblHdr.Location = new System.Drawing.Point(558, 9);
            this.lblHdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHdr.Name = "lblHdr";
            this.lblHdr.Size = new System.Drawing.Size(170, 25);
            this.lblHdr.TabIndex = 1;
            this.lblHdr.Text = "Users Data Viewer";
            this.lblHdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(198, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 38;
            // 
            // rdbtnPrtclr
            // 
            this.rdbtnPrtclr.AutoSize = true;
            this.rdbtnPrtclr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPrtclr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtnPrtclr.Location = new System.Drawing.Point(772, 63);
            this.rdbtnPrtclr.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnPrtclr.Name = "rdbtnPrtclr";
            this.rdbtnPrtclr.Size = new System.Drawing.Size(128, 23);
            this.rdbtnPrtclr.TabIndex = 40;
            this.rdbtnPrtclr.TabStop = true;
            this.rdbtnPrtclr.Text = "Particular User";
            this.rdbtnPrtclr.UseVisualStyleBackColor = true;
            this.rdbtnPrtclr.CheckedChanged += new System.EventHandler(this.rdbtnPrtclr_CheckedChanged);
            // 
            // rdbtnWhole
            // 
            this.rdbtnWhole.AutoSize = true;
            this.rdbtnWhole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnWhole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtnWhole.Location = new System.Drawing.Point(642, 63);
            this.rdbtnWhole.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnWhole.Name = "rdbtnWhole";
            this.rdbtnWhole.Size = new System.Drawing.Size(89, 23);
            this.rdbtnWhole.TabIndex = 39;
            this.rdbtnWhole.Text = "All Users";
            this.rdbtnWhole.UseVisualStyleBackColor = true;
            this.rdbtnWhole.CheckedChanged += new System.EventHandler(this.rdbtnWhole_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 10);
            this.panel2.TabIndex = 41;
            // 
            // labLstName
            // 
            this.labLstName.AutoSize = true;
            this.labLstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labLstName.Location = new System.Drawing.Point(328, 65);
            this.labLstName.Name = "labLstName";
            this.labLstName.Size = new System.Drawing.Size(307, 19);
            this.labLstName.TabIndex = 42;
            this.labLstName.Text = "Select Option To Generate Cutomers Report";
            // 
            // cmbxId
            // 
            this.cmbxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxId.Enabled = false;
            this.cmbxId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxId.FormattingEnabled = true;
            this.cmbxId.Items.AddRange(new object[] {
            "--Select Customer Id--"});
            this.cmbxId.Location = new System.Drawing.Point(594, 109);
            this.cmbxId.Name = "cmbxId";
            this.cmbxId.Size = new System.Drawing.Size(177, 27);
            this.cmbxId.TabIndex = 43;
            this.cmbxId.SelectedIndexChanged += new System.EventHandler(this.cmbxId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(451, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Select User Id";
            // 
            // btnPrnt
            // 
            this.btnPrnt.BackColor = System.Drawing.Color.Purple;
            this.btnPrnt.ForeColor = System.Drawing.Color.White;
            this.btnPrnt.Location = new System.Drawing.Point(777, 108);
            this.btnPrnt.Name = "btnPrnt";
            this.btnPrnt.Size = new System.Drawing.Size(141, 26);
            this.btnPrnt.TabIndex = 45;
            this.btnPrnt.Text = "PRINT";
            this.btnPrnt.UseVisualStyleBackColor = false;
            this.btnPrnt.Click += new System.EventHandler(this.btnPrnt_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "usrId";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "usrFrstName";
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "usrLstName";
            this.Column3.HeaderText = "Last Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "usrGndr";
            this.Column7.HeaderText = "Gender";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 65;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "usrBrthDate";
            this.Column5.HeaderText = "Birth Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 105;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "usrAddrs";
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 495;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "usrMoNo";
            this.Column8.HeaderText = "Mo No";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // frmUsersViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1249, 381);
            this.Controls.Add(this.btnPrnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxId);
            this.Controls.Add(this.labLstName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rdbtnPrtclr);
            this.Controls.Add(this.rdbtnWhole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHdr);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmUsersViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Data Viewer";
            this.Load += new System.EventHandler(this.frmUsersViewer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdUsrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHdr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbtnPrtclr;
        private System.Windows.Forms.RadioButton rdbtnWhole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labLstName;
        private System.Windows.Forms.ComboBox cmbxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrdUsrs;
        private System.Windows.Forms.Button btnPrnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;

    }
}
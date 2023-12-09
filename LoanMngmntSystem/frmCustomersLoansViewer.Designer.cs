namespace LoanMngmntSystem
{
    partial class frmCustomersLoansViewer
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
            this.dtgrdCstmrsLoans = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHdr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbtnPrtclr = new System.Windows.Forms.RadioButton();
            this.rdbtnWhole = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labLstName = new System.Windows.Forms.Label();
            this.cmbxId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrnt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxLnId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCstmrsLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgrdCstmrsLoans);
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 277);
            this.panel1.TabIndex = 0;
            // 
            // dtgrdCstmrsLoans
            // 
            this.dtgrdCstmrsLoans.AllowUserToAddRows = false;
            this.dtgrdCstmrsLoans.AllowUserToDeleteRows = false;
            this.dtgrdCstmrsLoans.AllowUserToResizeColumns = false;
            this.dtgrdCstmrsLoans.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dtgrdCstmrsLoans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdCstmrsLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdCstmrsLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dtgrdCstmrsLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdCstmrsLoans.Location = new System.Drawing.Point(0, 0);
            this.dtgrdCstmrsLoans.Name = "dtgrdCstmrsLoans";
            this.dtgrdCstmrsLoans.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdCstmrsLoans.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dtgrdCstmrsLoans.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrdCstmrsLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdCstmrsLoans.Size = new System.Drawing.Size(1247, 277);
            this.dtgrdCstmrsLoans.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tblLnApprvlId";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "lnName";
            this.Column2.HeaderText = "Loan Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "lnType";
            this.Column3.HeaderText = "Loan Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "lnIntrstRt";
            this.Column7.HeaderText = "Interest Rate";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "lnInsrnstRt";
            this.Column5.HeaderText = "Insurance Rate";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "lnMaxAmntRt";
            this.Column4.HeaderText = "Maximum Amount Rate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "lnMaxAmnt";
            this.Column6.HeaderText = "Loan Maximum Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 140;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "lnAmnt";
            this.Column8.HeaderText = "Loan Amount";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "lnInsrAmnt";
            this.Column9.HeaderText = "Insurance Amount";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "lnActlAmnt";
            this.Column10.HeaderText = "Actual Amount";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "lnApprvlDt";
            this.Column11.HeaderText = "Approval Date";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 143;
            // 
            // lblHdr
            // 
            this.lblHdr.AutoSize = true;
            this.lblHdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHdr.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHdr.ForeColor = System.Drawing.Color.Aqua;
            this.lblHdr.Location = new System.Drawing.Point(487, 9);
            this.lblHdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHdr.Name = "lblHdr";
            this.lblHdr.Size = new System.Drawing.Size(271, 25);
            this.lblHdr.TabIndex = 1;
            this.lblHdr.Text = "Customers Loans Data Viewer";
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
            this.rdbtnPrtclr.Location = new System.Drawing.Point(777, 64);
            this.rdbtnPrtclr.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnPrtclr.Name = "rdbtnPrtclr";
            this.rdbtnPrtclr.Size = new System.Drawing.Size(130, 23);
            this.rdbtnPrtclr.TabIndex = 40;
            this.rdbtnPrtclr.TabStop = true;
            this.rdbtnPrtclr.Text = "Particular Loan";
            this.rdbtnPrtclr.UseVisualStyleBackColor = true;
            this.rdbtnPrtclr.CheckedChanged += new System.EventHandler(this.rdbtnPrtclr_CheckedChanged);
            // 
            // rdbtnWhole
            // 
            this.rdbtnWhole.AutoSize = true;
            this.rdbtnWhole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnWhole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtnWhole.Location = new System.Drawing.Point(647, 64);
            this.rdbtnWhole.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnWhole.Name = "rdbtnWhole";
            this.rdbtnWhole.Size = new System.Drawing.Size(91, 23);
            this.rdbtnWhole.TabIndex = 39;
            this.rdbtnWhole.Text = "All Loans";
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
            this.labLstName.Location = new System.Drawing.Point(333, 66);
            this.labLstName.Name = "labLstName";
            this.labLstName.Size = new System.Drawing.Size(307, 19);
            this.labLstName.TabIndex = 42;
            this.labLstName.Text = "Select Option To Generate Cutomers Report";
            // 
            // cmbxId
            // 
            this.cmbxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxId.FormattingEnabled = true;
            this.cmbxId.Items.AddRange(new object[] {
            "--Select Customer Id--"});
            this.cmbxId.Location = new System.Drawing.Point(150, 62);
            this.cmbxId.Name = "cmbxId";
            this.cmbxId.Size = new System.Drawing.Size(177, 27);
            this.cmbxId.TabIndex = 43;
            this.cmbxId.SelectedIndexChanged += new System.EventHandler(this.cmbxId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Select Customer Id";
            // 
            // btnPrnt
            // 
            this.btnPrnt.BackColor = System.Drawing.Color.Purple;
            this.btnPrnt.ForeColor = System.Drawing.Color.White;
            this.btnPrnt.Location = new System.Drawing.Point(562, 111);
            this.btnPrnt.Name = "btnPrnt";
            this.btnPrnt.Size = new System.Drawing.Size(141, 26);
            this.btnPrnt.TabIndex = 45;
            this.btnPrnt.Text = "PRINT";
            this.btnPrnt.UseVisualStyleBackColor = false;
            this.btnPrnt.Click += new System.EventHandler(this.btnPrnt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(914, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Select Loan Id";
            // 
            // cmbxLnId
            // 
            this.cmbxLnId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLnId.Enabled = false;
            this.cmbxLnId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxLnId.FormattingEnabled = true;
            this.cmbxLnId.Items.AddRange(new object[] {
            "--Select Loan Id--"});
            this.cmbxLnId.Location = new System.Drawing.Point(1057, 62);
            this.cmbxLnId.Name = "cmbxLnId";
            this.cmbxLnId.Size = new System.Drawing.Size(177, 27);
            this.cmbxLnId.TabIndex = 46;
            this.cmbxLnId.SelectedIndexChanged += new System.EventHandler(this.cmbxLnId_SelectedIndexChanged);
            // 
            // frmCustomersLoansViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1247, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxLnId);
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
            this.Name = "frmCustomersLoansViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Loans Data Viewer";
            this.Load += new System.EventHandler(this.frmCustomersLoansViewer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCstmrsLoans)).EndInit();
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
        private System.Windows.Forms.Button btnPrnt;
        private System.Windows.Forms.DataGridView dtgrdCstmrsLoans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxLnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;

    }
}
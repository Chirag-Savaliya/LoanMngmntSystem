namespace LoanMngmntSystem
{
    partial class frmCustomersInstlmntViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgrdCstmrsInstlmts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHdr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbxId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrnt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxLnId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCstmrsInstlmts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgrdCstmrsInstlmts);
            this.panel1.Location = new System.Drawing.Point(13, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 318);
            this.panel1.TabIndex = 0;
            // 
            // dtgrdCstmrsInstlmts
            // 
            this.dtgrdCstmrsInstlmts.AllowUserToAddRows = false;
            this.dtgrdCstmrsInstlmts.AllowUserToDeleteRows = false;
            this.dtgrdCstmrsInstlmts.AllowUserToResizeColumns = false;
            this.dtgrdCstmrsInstlmts.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dtgrdCstmrsInstlmts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrdCstmrsInstlmts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdCstmrsInstlmts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column8});
            this.dtgrdCstmrsInstlmts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdCstmrsInstlmts.Location = new System.Drawing.Point(0, 0);
            this.dtgrdCstmrsInstlmts.Name = "dtgrdCstmrsInstlmts";
            this.dtgrdCstmrsInstlmts.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdCstmrsInstlmts.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dtgrdCstmrsInstlmts.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgrdCstmrsInstlmts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdCstmrsInstlmts.Size = new System.Drawing.Size(1230, 318);
            this.dtgrdCstmrsInstlmts.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tblLnInstlmntId";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
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
            this.Column3.DataPropertyName = "lnIntrstAmnt";
            this.Column3.HeaderText = "Interest Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "lnPrncplAmnt";
            this.Column7.HeaderText = "Principal Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "lnChrgAmnt";
            this.Column5.HeaderText = "Charge Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "lnTtlInstlmntAmnt";
            this.Column4.HeaderText = "Installment Total Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 220;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "lnRmngActlAmnt";
            this.Column6.HeaderText = "Remaining Actual Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 220;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "lnInstlmntDt";
            this.Column8.HeaderText = "Installment Date";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // lblHdr
            // 
            this.lblHdr.AutoSize = true;
            this.lblHdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHdr.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHdr.ForeColor = System.Drawing.Color.Aqua;
            this.lblHdr.Location = new System.Drawing.Point(446, 9);
            this.lblHdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHdr.Name = "lblHdr";
            this.lblHdr.Size = new System.Drawing.Size(324, 25);
            this.lblHdr.TabIndex = 1;
            this.lblHdr.Text = "Customers Installments Data Viewer";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 10);
            this.panel2.TabIndex = 41;
            // 
            // cmbxId
            // 
            this.cmbxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxId.FormattingEnabled = true;
            this.cmbxId.Items.AddRange(new object[] {
            "--Select Customer Id--"});
            this.cmbxId.Location = new System.Drawing.Point(231, 74);
            this.cmbxId.Name = "cmbxId";
            this.cmbxId.Size = new System.Drawing.Size(177, 27);
            this.cmbxId.TabIndex = 43;
            this.cmbxId.SelectedIndexChanged += new System.EventHandler(this.cmbxId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(88, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Select Customer Id";
            // 
            // btnPrnt
            // 
            this.btnPrnt.BackColor = System.Drawing.Color.Purple;
            this.btnPrnt.ForeColor = System.Drawing.Color.White;
            this.btnPrnt.Location = new System.Drawing.Point(985, 78);
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
            this.label3.Location = new System.Drawing.Point(478, 78);
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
            this.cmbxLnId.Location = new System.Drawing.Point(621, 74);
            this.cmbxLnId.Name = "cmbxLnId";
            this.cmbxLnId.Size = new System.Drawing.Size(177, 27);
            this.cmbxLnId.TabIndex = 46;
            this.cmbxLnId.SelectedIndexChanged += new System.EventHandler(this.cmbxLnId_SelectedIndexChanged);
            // 
            // frmCustomersInstlmntViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1256, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxLnId);
            this.Controls.Add(this.btnPrnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHdr);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCustomersInstlmntViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Installments Data Viewer";
            this.Load += new System.EventHandler(this.frmCustomersInstlmntViewer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCstmrsInstlmts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHdr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrnt;
        private System.Windows.Forms.DataGridView dtgrdCstmrsInstlmts;
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

    }
}
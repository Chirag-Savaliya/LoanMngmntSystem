namespace LoanMngmntSystem
{
    partial class frmLoanInstlmnt
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
            this.lblHdr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLoanAmnt = new System.Windows.Forms.TextBox();
            this.lblFrstName = new System.Windows.Forms.Label();
            this.cmbxCstmrId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxLnnm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLnActlAmnt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLnInsrAmnt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLnAprvlDt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLoanInstlmntAmnt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChrgAmnt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInstlmntDt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLnIntrstAmnt = new System.Windows.Forms.TextBox();
            this.txtLoanPrncplAmnt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAcptInstlmnt = new System.Windows.Forms.Button();
            this.btnCncl = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbxLoanId = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLoanTyp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTtlInstlmntAmnt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurrntDt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMnmInstlmntAmnt = new System.Windows.Forms.TextBox();
            this.txtTtlDys = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRmngLnActulAmnt = new System.Windows.Forms.TextBox();
            this.txtLatIntrstDys = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtActlInrstDys = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtIntrstRt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHdr
            // 
            this.lblHdr.AutoSize = true;
            this.lblHdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHdr.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHdr.ForeColor = System.Drawing.Color.Aqua;
            this.lblHdr.Location = new System.Drawing.Point(503, 5);
            this.lblHdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHdr.Name = "lblHdr";
            this.lblHdr.Size = new System.Drawing.Size(276, 25);
            this.lblHdr.TabIndex = 1;
            this.lblHdr.Text = "Loan Installment Management";
            this.lblHdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 10);
            this.panel1.TabIndex = 2;
            // 
            // txtLoanAmnt
            // 
            this.txtLoanAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanAmnt.Location = new System.Drawing.Point(632, 96);
            this.txtLoanAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoanAmnt.Name = "txtLoanAmnt";
            this.txtLoanAmnt.ReadOnly = true;
            this.txtLoanAmnt.Size = new System.Drawing.Size(118, 22);
            this.txtLoanAmnt.TabIndex = 6;
            this.txtLoanAmnt.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtLoanAmnt.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // lblFrstName
            // 
            this.lblFrstName.AutoSize = true;
            this.lblFrstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFrstName.Location = new System.Drawing.Point(11, 63);
            this.lblFrstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrstName.Name = "lblFrstName";
            this.lblFrstName.Size = new System.Drawing.Size(137, 19);
            this.lblFrstName.TabIndex = 3;
            this.lblFrstName.Text = "Select Customer Id";
            // 
            // cmbxCstmrId
            // 
            this.cmbxCstmrId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCstmrId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxCstmrId.FormattingEnabled = true;
            this.cmbxCstmrId.Location = new System.Drawing.Point(155, 60);
            this.cmbxCstmrId.Name = "cmbxCstmrId";
            this.cmbxCstmrId.Size = new System.Drawing.Size(197, 27);
            this.cmbxCstmrId.TabIndex = 1;
            this.cmbxCstmrId.SelectedIndexChanged += new System.EventHandler(this.cmbxCstmrId_SelectedIndexChanged);
            this.cmbxCstmrId.Enter += new System.EventHandler(this.Cmbx_Enter);
            this.cmbxCstmrId.Leave += new System.EventHandler(this.Cmbx_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(60, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Loan";
            // 
            // cmbxLnnm
            // 
            this.cmbxLnnm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLnnm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxLnnm.FormattingEnabled = true;
            this.cmbxLnnm.Location = new System.Drawing.Point(155, 93);
            this.cmbxLnnm.Name = "cmbxLnnm";
            this.cmbxLnnm.Size = new System.Drawing.Size(197, 27);
            this.cmbxLnnm.TabIndex = 2;
            this.cmbxLnnm.SelectedIndexChanged += new System.EventHandler(this.cmbxLnnm_SelectedIndexChanged);
            this.cmbxLnnm.Enter += new System.EventHandler(this.Cmbx_Enter);
            this.cmbxLnnm.Leave += new System.EventHandler(this.Cmbx_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(46, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type Of Loan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(526, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loan Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(456, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loan Insurance Amount";
            // 
            // txtLnActlAmnt
            // 
            this.txtLnActlAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnActlAmnt.Location = new System.Drawing.Point(632, 163);
            this.txtLnActlAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnActlAmnt.Name = "txtLnActlAmnt";
            this.txtLnActlAmnt.ReadOnly = true;
            this.txtLnActlAmnt.Size = new System.Drawing.Size(118, 22);
            this.txtLnActlAmnt.TabIndex = 8;
            this.txtLnActlAmnt.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtLnActlAmnt.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 194);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 10);
            this.panel2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(480, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Loan Actual Amount";
            // 
            // txtLnInsrAmnt
            // 
            this.txtLnInsrAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnInsrAmnt.Location = new System.Drawing.Point(632, 126);
            this.txtLnInsrAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnInsrAmnt.Name = "txtLnInsrAmnt";
            this.txtLnInsrAmnt.ReadOnly = true;
            this.txtLnInsrAmnt.Size = new System.Drawing.Size(118, 22);
            this.txtLnInsrAmnt.TabIndex = 7;
            this.txtLnInsrAmnt.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtLnInsrAmnt.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(488, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Loan Aproval Date";
            // 
            // txtLnAprvlDt
            // 
            this.txtLnAprvlDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnAprvlDt.Location = new System.Drawing.Point(632, 63);
            this.txtLnAprvlDt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnAprvlDt.Name = "txtLnAprvlDt";
            this.txtLnAprvlDt.ReadOnly = true;
            this.txtLnAprvlDt.Size = new System.Drawing.Size(181, 22);
            this.txtLnAprvlDt.TabIndex = 5;
            this.txtLnAprvlDt.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtLnAprvlDt.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(480, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Enter Amount Of Installment";
            // 
            // txtLoanInstlmntAmnt
            // 
            this.txtLoanInstlmntAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanInstlmntAmnt.Location = new System.Drawing.Point(689, 219);
            this.txtLoanInstlmntAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoanInstlmntAmnt.Name = "txtLoanInstlmntAmnt";
            this.txtLoanInstlmntAmnt.ReadOnly = true;
            this.txtLoanInstlmntAmnt.Size = new System.Drawing.Size(197, 22);
            this.txtLoanInstlmntAmnt.TabIndex = 15;
            this.txtLoanInstlmntAmnt.TextChanged += new System.EventHandler(this.txtLoanInstlmntAmnt_TextChanged);
            this.txtLoanInstlmntAmnt.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtLoanInstlmntAmnt.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(107, 248);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Charge Amount";
            // 
            // txtChrgAmnt
            // 
            this.txtChrgAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChrgAmnt.Location = new System.Drawing.Point(228, 248);
            this.txtChrgAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtChrgAmnt.Name = "txtChrgAmnt";
            this.txtChrgAmnt.ReadOnly = true;
            this.txtChrgAmnt.Size = new System.Drawing.Size(197, 22);
            this.txtChrgAmnt.TabIndex = 13;
            this.txtChrgAmnt.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtChrgAmnt.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(933, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Installment Date";
            // 
            // txtInstlmntDt
            // 
            this.txtInstlmntDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstlmntDt.Location = new System.Drawing.Point(1062, 64);
            this.txtInstlmntDt.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstlmntDt.Name = "txtInstlmntDt";
            this.txtInstlmntDt.ReadOnly = true;
            this.txtInstlmntDt.Size = new System.Drawing.Size(181, 22);
            this.txtInstlmntDt.TabIndex = 9;
            this.txtInstlmntDt.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtInstlmntDt.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(0, 313);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1256, 10);
            this.panel3.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(103, 219);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "Interest Amount";
            // 
            // txtLnIntrstAmnt
            // 
            this.txtLnIntrstAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnIntrstAmnt.Location = new System.Drawing.Point(228, 219);
            this.txtLnIntrstAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnIntrstAmnt.Name = "txtLnIntrstAmnt";
            this.txtLnIntrstAmnt.ReadOnly = true;
            this.txtLnIntrstAmnt.Size = new System.Drawing.Size(197, 22);
            this.txtLnIntrstAmnt.TabIndex = 12;
            this.txtLnIntrstAmnt.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtLnIntrstAmnt.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // txtLoanPrncplAmnt
            // 
            this.txtLoanPrncplAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanPrncplAmnt.Location = new System.Drawing.Point(689, 249);
            this.txtLoanPrncplAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoanPrncplAmnt.Name = "txtLoanPrncplAmnt";
            this.txtLoanPrncplAmnt.ReadOnly = true;
            this.txtLoanPrncplAmnt.Size = new System.Drawing.Size(197, 22);
            this.txtLoanPrncplAmnt.TabIndex = 16;
            this.txtLoanPrncplAmnt.TextChanged += new System.EventHandler(this.txtLoanPrncplAmnt_TextChanged);
            this.txtLoanPrncplAmnt.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtLoanPrncplAmnt.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(559, 249);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 19);
            this.label13.TabIndex = 32;
            this.label13.Text = "Principal Amount";
            // 
            // btnAcptInstlmnt
            // 
            this.btnAcptInstlmnt.BackColor = System.Drawing.Color.Purple;
            this.btnAcptInstlmnt.Enabled = false;
            this.btnAcptInstlmnt.ForeColor = System.Drawing.Color.White;
            this.btnAcptInstlmnt.Location = new System.Drawing.Point(228, 336);
            this.btnAcptInstlmnt.Name = "btnAcptInstlmnt";
            this.btnAcptInstlmnt.Size = new System.Drawing.Size(206, 31);
            this.btnAcptInstlmnt.TabIndex = 21;
            this.btnAcptInstlmnt.Text = "ACCEPT INSTALLMENT";
            this.btnAcptInstlmnt.UseVisualStyleBackColor = false;
            this.btnAcptInstlmnt.Click += new System.EventHandler(this.btnAcptInstlmnt_Click);
            // 
            // btnCncl
            // 
            this.btnCncl.BackColor = System.Drawing.Color.Purple;
            this.btnCncl.ForeColor = System.Drawing.Color.White;
            this.btnCncl.Location = new System.Drawing.Point(1062, 336);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(98, 31);
            this.btnCncl.TabIndex = 22;
            this.btnCncl.Text = "CANCEL";
            this.btnCncl.UseVisualStyleBackColor = false;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(0, 373);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1256, 10);
            this.panel4.TabIndex = 35;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblError.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(225, 401);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(69, 17);
            this.lblError.TabIndex = 36;
            this.lblError.Tag = "";
            this.lblError.Text = "trtttttttttt";
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // cmbxLoanId
            // 
            this.cmbxLoanId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLoanId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxLoanId.FormattingEnabled = true;
            this.cmbxLoanId.Location = new System.Drawing.Point(155, 126);
            this.cmbxLoanId.Name = "cmbxLoanId";
            this.cmbxLoanId.Size = new System.Drawing.Size(197, 27);
            this.cmbxLoanId.TabIndex = 3;
            this.cmbxLoanId.SelectedIndexChanged += new System.EventHandler(this.cmbxLoanId_SelectedIndexChanged);
            this.cmbxLoanId.Enter += new System.EventHandler(this.Cmbx_Enter);
            this.cmbxLoanId.Leave += new System.EventHandler(this.Cmbx_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(42, 129);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 19);
            this.label14.TabIndex = 38;
            this.label14.Text = "Select Loan Id";
            // 
            // txtLoanTyp
            // 
            this.txtLoanTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanTyp.Location = new System.Drawing.Point(155, 162);
            this.txtLoanTyp.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoanTyp.Name = "txtLoanTyp";
            this.txtLoanTyp.ReadOnly = true;
            this.txtLoanTyp.Size = new System.Drawing.Size(197, 22);
            this.txtLoanTyp.TabIndex = 4;
            this.txtLoanTyp.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtLoanTyp.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(504, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Total Installment Amount";
            // 
            // txtTtlInstlmntAmnt
            // 
            this.txtTtlInstlmntAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTtlInstlmntAmnt.Location = new System.Drawing.Point(689, 279);
            this.txtTtlInstlmntAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtTtlInstlmntAmnt.Name = "txtTtlInstlmntAmnt";
            this.txtTtlInstlmntAmnt.ReadOnly = true;
            this.txtTtlInstlmntAmnt.Size = new System.Drawing.Size(197, 22);
            this.txtTtlInstlmntAmnt.TabIndex = 17;
            this.txtTtlInstlmntAmnt.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtTtlInstlmntAmnt.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(803, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "Enter Current Date ( Mm/Dd/Yyyy )";
            // 
            // txtCurrntDt
            // 
            this.txtCurrntDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrntDt.Location = new System.Drawing.Point(1063, 124);
            this.txtCurrntDt.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrntDt.Name = "txtCurrntDt";
            this.txtCurrntDt.Size = new System.Drawing.Size(181, 22);
            this.txtCurrntDt.TabIndex = 10;
            this.txtCurrntDt.TextChanged += new System.EventHandler(this.txtCurrntDt_TextChanged);
            this.txtCurrntDt.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtCurrntDt.Leave += new System.EventHandler(this.Txt_Leve);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(13, 277);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(207, 19);
            this.label15.TabIndex = 45;
            this.label15.Text = "Minimum Installment Amount";
            // 
            // txtMnmInstlmntAmnt
            // 
            this.txtMnmInstlmntAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMnmInstlmntAmnt.Location = new System.Drawing.Point(228, 277);
            this.txtMnmInstlmntAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtMnmInstlmntAmnt.Name = "txtMnmInstlmntAmnt";
            this.txtMnmInstlmntAmnt.ReadOnly = true;
            this.txtMnmInstlmntAmnt.Size = new System.Drawing.Size(197, 22);
            this.txtMnmInstlmntAmnt.TabIndex = 14;
            // 
            // txtTtlDys
            // 
            this.txtTtlDys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTtlDys.Location = new System.Drawing.Point(1062, 280);
            this.txtTtlDys.Margin = new System.Windows.Forms.Padding(4);
            this.txtTtlDys.Name = "txtTtlDys";
            this.txtTtlDys.ReadOnly = true;
            this.txtTtlDys.Size = new System.Drawing.Size(181, 22);
            this.txtTtlDys.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(835, 160);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(220, 19);
            this.label17.TabIndex = 49;
            this.label17.Text = "Remaining Loan Actual Amount";
            // 
            // txtRmngLnActulAmnt
            // 
            this.txtRmngLnActulAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRmngLnActulAmnt.Location = new System.Drawing.Point(1063, 160);
            this.txtRmngLnActulAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtRmngLnActulAmnt.Name = "txtRmngLnActulAmnt";
            this.txtRmngLnActulAmnt.ReadOnly = true;
            this.txtRmngLnActulAmnt.Size = new System.Drawing.Size(181, 22);
            this.txtRmngLnActulAmnt.TabIndex = 11;
            // 
            // txtLatIntrstDys
            // 
            this.txtLatIntrstDys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatIntrstDys.Location = new System.Drawing.Point(1062, 250);
            this.txtLatIntrstDys.Margin = new System.Windows.Forms.Padding(4);
            this.txtLatIntrstDys.Name = "txtLatIntrstDys";
            this.txtLatIntrstDys.ReadOnly = true;
            this.txtLatIntrstDys.Size = new System.Drawing.Size(181, 22);
            this.txtLatIntrstDys.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(914, 217);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 19);
            this.label19.TabIndex = 53;
            this.label19.Text = "Actual Intrest Days";
            // 
            // txtActlInrstDys
            // 
            this.txtActlInrstDys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActlInrstDys.Location = new System.Drawing.Point(1062, 216);
            this.txtActlInrstDys.Margin = new System.Windows.Forms.Padding(4);
            this.txtActlInrstDys.Name = "txtActlInrstDys";
            this.txtActlInrstDys.ReadOnly = true;
            this.txtActlInrstDys.Size = new System.Drawing.Size(181, 22);
            this.txtActlInrstDys.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(923, 280);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 19);
            this.label16.TabIndex = 54;
            this.label16.Text = "Total Intrest Days";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(926, 249);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 19);
            this.label18.TabIndex = 55;
            this.label18.Text = "Late Intrest Days";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(955, 96);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 19);
            this.label20.TabIndex = 57;
            this.label20.Text = "Interest Rate";
            // 
            // txtIntrstRt
            // 
            this.txtIntrstRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntrstRt.Location = new System.Drawing.Point(1062, 94);
            this.txtIntrstRt.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntrstRt.Name = "txtIntrstRt";
            this.txtIntrstRt.ReadOnly = true;
            this.txtIntrstRt.Size = new System.Drawing.Size(181, 22);
            this.txtIntrstRt.TabIndex = 56;
            // 
            // frmLoanInstlmnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1256, 418);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtIntrstRt);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtActlInrstDys);
            this.Controls.Add(this.txtLatIntrstDys);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRmngLnActulAmnt);
            this.Controls.Add(this.txtTtlDys);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMnmInstlmntAmnt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCurrntDt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTtlInstlmntAmnt);
            this.Controls.Add(this.txtLoanTyp);
            this.Controls.Add(this.cmbxLoanId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnCncl);
            this.Controls.Add(this.btnAcptInstlmnt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLoanPrncplAmnt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLnIntrstAmnt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLoanInstlmntAmnt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtChrgAmnt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtInstlmntDt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLnAprvlDt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLnInsrAmnt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLnActlAmnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxLnnm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxCstmrId);
            this.Controls.Add(this.txtLoanAmnt);
            this.Controls.Add(this.lblFrstName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHdr);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLoanInstlmnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Installment Management";
            this.Load += new System.EventHandler(this.frmLoanInstlmnt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHdr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLoanAmnt;
        private System.Windows.Forms.Label lblFrstName;
        private System.Windows.Forms.ComboBox cmbxCstmrId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxLnnm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLnActlAmnt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLnInsrAmnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLnAprvlDt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLoanInstlmntAmnt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChrgAmnt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInstlmntDt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLnIntrstAmnt;
        private System.Windows.Forms.TextBox txtLoanPrncplAmnt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAcptInstlmnt;
        private System.Windows.Forms.Button btnCncl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cmbxLoanId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLoanTyp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTtlInstlmntAmnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCurrntDt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMnmInstlmntAmnt;
        private System.Windows.Forms.TextBox txtTtlDys;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRmngLnActulAmnt;
        private System.Windows.Forms.TextBox txtLatIntrstDys;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtActlInrstDys;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtIntrstRt;
    }
}
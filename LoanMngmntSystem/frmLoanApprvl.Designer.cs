namespace LoanMngmntSystem
{
    partial class frmLoanApprvl
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
            this.txtLnIntrstRt = new System.Windows.Forms.TextBox();
            this.lblFrstName = new System.Windows.Forms.Label();
            this.cmbxCstmrId = new System.Windows.Forms.ComboBox();
            this.cmbxLnTyp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxLnnm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLnMaxAmntRt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLnInsrRt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdhrNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPanNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLnAprvlDt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLnAmnt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLnMaxAmnt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIncmVltnAmnt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLnInsrAmnt = new System.Windows.Forms.TextBox();
            this.txtLnActlAmnt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLnApprv = new System.Windows.Forms.Button();
            this.btnCncl = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHdr
            // 
            this.lblHdr.AutoSize = true;
            this.lblHdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHdr.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHdr.ForeColor = System.Drawing.Color.Aqua;
            this.lblHdr.Location = new System.Drawing.Point(471, 6);
            this.lblHdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHdr.Name = "lblHdr";
            this.lblHdr.Size = new System.Drawing.Size(247, 25);
            this.lblHdr.TabIndex = 1;
            this.lblHdr.Text = "Loan Aproval Management";
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
            // txtLnIntrstRt
            // 
            this.txtLnIntrstRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnIntrstRt.Location = new System.Drawing.Point(1062, 58);
            this.txtLnIntrstRt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnIntrstRt.Name = "txtLnIntrstRt";
            this.txtLnIntrstRt.ReadOnly = true;
            this.txtLnIntrstRt.Size = new System.Drawing.Size(37, 22);
            this.txtLnIntrstRt.TabIndex = 2;
            this.txtLnIntrstRt.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLnIntrstRt.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblFrstName
            // 
            this.lblFrstName.AutoSize = true;
            this.lblFrstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFrstName.Location = new System.Drawing.Point(84, 59);
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
            this.cmbxCstmrId.Location = new System.Drawing.Point(228, 56);
            this.cmbxCstmrId.Name = "cmbxCstmrId";
            this.cmbxCstmrId.Size = new System.Drawing.Size(197, 27);
            this.cmbxCstmrId.TabIndex = 1;
            this.cmbxCstmrId.SelectedIndexChanged += new System.EventHandler(this.cmbxCstmrId_SelectedIndexChanged);
            this.cmbxCstmrId.Enter += new System.EventHandler(this.Cmbx_Enter);
            this.cmbxCstmrId.Leave += new System.EventHandler(this.Cmbx_Leave);
            // 
            // cmbxLnTyp
            // 
            this.cmbxLnTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLnTyp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxLnTyp.FormattingEnabled = true;
            this.cmbxLnTyp.Items.AddRange(new object[] {
            "-- Select Type Of Loan --",
            "Mortgage Loan",
            "Non Mortgage Loan"});
            this.cmbxLnTyp.Location = new System.Drawing.Point(228, 124);
            this.cmbxLnTyp.Name = "cmbxLnTyp";
            this.cmbxLnTyp.Size = new System.Drawing.Size(197, 27);
            this.cmbxLnTyp.TabIndex = 5;
            this.cmbxLnTyp.Enter += new System.EventHandler(this.Cmbx_Enter);
            this.cmbxLnTyp.Leave += new System.EventHandler(this.Cmbx_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(133, 91);
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
            this.cmbxLnnm.Location = new System.Drawing.Point(228, 88);
            this.cmbxLnnm.Name = "cmbxLnnm";
            this.cmbxLnnm.Size = new System.Drawing.Size(197, 27);
            this.cmbxLnnm.TabIndex = 3;
            this.cmbxLnnm.SelectedIndexChanged += new System.EventHandler(this.cmbxLnnm_SelectedIndexChanged);
            this.cmbxLnnm.Enter += new System.EventHandler(this.Cmbx_Enter);
            this.cmbxLnnm.Leave += new System.EventHandler(this.Cmbx_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(96, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Loan Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(917, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loan Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(904, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loan Insurance Rate";
            // 
            // txtLnMaxAmntRt
            // 
            this.txtLnMaxAmntRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnMaxAmntRt.Location = new System.Drawing.Point(1062, 125);
            this.txtLnMaxAmntRt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnMaxAmntRt.Name = "txtLnMaxAmntRt";
            this.txtLnMaxAmntRt.ReadOnly = true;
            this.txtLnMaxAmntRt.Size = new System.Drawing.Size(37, 22);
            this.txtLnMaxAmntRt.TabIndex = 6;
            this.txtLnMaxAmntRt.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLnMaxAmntRt.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 10);
            this.panel2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(847, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Loan Maximum Amount Rate";
            // 
            // txtLnInsrRt
            // 
            this.txtLnInsrRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnInsrRt.Location = new System.Drawing.Point(1062, 90);
            this.txtLnInsrRt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnInsrRt.Name = "txtLnInsrRt";
            this.txtLnInsrRt.ReadOnly = true;
            this.txtLnInsrRt.Size = new System.Drawing.Size(37, 22);
            this.txtLnInsrRt.TabIndex = 4;
            this.txtLnInsrRt.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLnInsrRt.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(5, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Enter Aadhar No Of Customer";
            // 
            // txtAdhrNo
            // 
            this.txtAdhrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdhrNo.Location = new System.Drawing.Point(228, 187);
            this.txtAdhrNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdhrNo.MaxLength = 16;
            this.txtAdhrNo.Name = "txtAdhrNo";
            this.txtAdhrNo.Size = new System.Drawing.Size(197, 22);
            this.txtAdhrNo.TabIndex = 7;
            this.txtAdhrNo.Enter += new System.EventHandler(this.txt_Enter);
            this.txtAdhrNo.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(28, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Enter Pan No Of Customer";
            // 
            // txtPanNo
            // 
            this.txtPanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanNo.Location = new System.Drawing.Point(228, 217);
            this.txtPanNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPanNo.MaxLength = 10;
            this.txtPanNo.Name = "txtPanNo";
            this.txtPanNo.Size = new System.Drawing.Size(197, 22);
            this.txtPanNo.TabIndex = 9;
            this.txtPanNo.Enter += new System.EventHandler(this.txt_Enter);
            this.txtPanNo.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(84, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Loan Aproval Date";
            // 
            // txtLnAprvlDt
            // 
            this.txtLnAprvlDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnAprvlDt.Location = new System.Drawing.Point(228, 247);
            this.txtLnAprvlDt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnAprvlDt.Name = "txtLnAprvlDt";
            this.txtLnAprvlDt.ReadOnly = true;
            this.txtLnAprvlDt.Size = new System.Drawing.Size(197, 22);
            this.txtLnAprvlDt.TabIndex = 11;
            this.txtLnAprvlDt.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLnAprvlDt.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(956, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Loan Amount";
            // 
            // txtLnAmnt
            // 
            this.txtLnAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnAmnt.Location = new System.Drawing.Point(1062, 245);
            this.txtLnAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnAmnt.Name = "txtLnAmnt";
            this.txtLnAmnt.ReadOnly = true;
            this.txtLnAmnt.Size = new System.Drawing.Size(181, 22);
            this.txtLnAmnt.TabIndex = 12;
            this.txtLnAmnt.TextChanged += new System.EventHandler(this.txtLnAmnt_TextChanged);
            this.txtLnAmnt.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLnAmnt.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(762, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Loan Maximum Amount Can Be Approved";
            // 
            // txtLnMaxAmnt
            // 
            this.txtLnMaxAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnMaxAmnt.Location = new System.Drawing.Point(1062, 215);
            this.txtLnMaxAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnMaxAmnt.Name = "txtLnMaxAmnt";
            this.txtLnMaxAmnt.ReadOnly = true;
            this.txtLnMaxAmnt.Size = new System.Drawing.Size(181, 22);
            this.txtLnMaxAmnt.TabIndex = 10;
            this.txtLnMaxAmnt.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLnMaxAmnt.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(680, 187);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(374, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Enter Costumer Income Or Property Valuation Amount";
            // 
            // txtIncmVltnAmnt
            // 
            this.txtIncmVltnAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncmVltnAmnt.Location = new System.Drawing.Point(1062, 185);
            this.txtIncmVltnAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtIncmVltnAmnt.Name = "txtIncmVltnAmnt";
            this.txtIncmVltnAmnt.Size = new System.Drawing.Size(181, 22);
            this.txtIncmVltnAmnt.TabIndex = 8;
            this.txtIncmVltnAmnt.TextChanged += new System.EventHandler(this.txtIncmVltnAmnt_TextChanged);
            this.txtIncmVltnAmnt.Enter += new System.EventHandler(this.txt_Enter);
            this.txtIncmVltnAmnt.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(0, 311);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1256, 10);
            this.panel3.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(52, 278);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "Loan Insurance Amount";
            // 
            // txtLnInsrAmnt
            // 
            this.txtLnInsrAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnInsrAmnt.Location = new System.Drawing.Point(228, 277);
            this.txtLnInsrAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnInsrAmnt.Name = "txtLnInsrAmnt";
            this.txtLnInsrAmnt.ReadOnly = true;
            this.txtLnInsrAmnt.Size = new System.Drawing.Size(197, 22);
            this.txtLnInsrAmnt.TabIndex = 13;
            this.txtLnInsrAmnt.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLnInsrAmnt.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtLnActlAmnt
            // 
            this.txtLnActlAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLnActlAmnt.Location = new System.Drawing.Point(1062, 278);
            this.txtLnActlAmnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnActlAmnt.Name = "txtLnActlAmnt";
            this.txtLnActlAmnt.ReadOnly = true;
            this.txtLnActlAmnt.Size = new System.Drawing.Size(181, 22);
            this.txtLnActlAmnt.TabIndex = 14;
            this.txtLnActlAmnt.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLnActlAmnt.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(910, 279);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 19);
            this.label13.TabIndex = 32;
            this.label13.Text = "Loan Actual Amount";
            // 
            // btnLnApprv
            // 
            this.btnLnApprv.BackColor = System.Drawing.Color.Purple;
            this.btnLnApprv.ForeColor = System.Drawing.Color.White;
            this.btnLnApprv.Location = new System.Drawing.Point(257, 337);
            this.btnLnApprv.Name = "btnLnApprv";
            this.btnLnApprv.Size = new System.Drawing.Size(236, 31);
            this.btnLnApprv.TabIndex = 15;
            this.btnLnApprv.Text = "APPROVE LOAN";
            this.btnLnApprv.UseVisualStyleBackColor = false;
            this.btnLnApprv.Click += new System.EventHandler(this.btnLnApprv_Click);
            // 
            // btnCncl
            // 
            this.btnCncl.BackColor = System.Drawing.Color.Purple;
            this.btnCncl.ForeColor = System.Drawing.Color.White;
            this.btnCncl.Location = new System.Drawing.Point(851, 337);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(98, 31);
            this.btnCncl.TabIndex = 16;
            this.btnCncl.Text = "CANCEL";
            this.btnCncl.UseVisualStyleBackColor = false;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(0, 386);
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
            this.lblError.Location = new System.Drawing.Point(254, 400);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 36;
            this.lblError.Tag = "";
            // 
            // frmLoanApprvl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1256, 420);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnCncl);
            this.Controls.Add(this.btnLnApprv);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLnActlAmnt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLnInsrAmnt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLnAmnt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLnMaxAmnt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIncmVltnAmnt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLnAprvlDt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPanNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdhrNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLnInsrRt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLnMaxAmntRt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxLnnm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxLnTyp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxCstmrId);
            this.Controls.Add(this.txtLnIntrstRt);
            this.Controls.Add(this.lblFrstName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHdr);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLoanApprvl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Approval Management";
            this.Load += new System.EventHandler(this.frmLoanApprvl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHdr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLnIntrstRt;
        private System.Windows.Forms.Label lblFrstName;
        private System.Windows.Forms.ComboBox cmbxCstmrId;
        private System.Windows.Forms.ComboBox cmbxLnTyp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxLnnm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLnMaxAmntRt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLnInsrRt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdhrNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPanNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLnAprvlDt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLnAmnt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLnMaxAmnt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIncmVltnAmnt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLnInsrAmnt;
        private System.Windows.Forms.TextBox txtLnActlAmnt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLnApprv;
        private System.Windows.Forms.Button btnCncl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblError;
    }
}
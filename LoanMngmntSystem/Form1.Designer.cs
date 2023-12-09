namespace LoanMngmntSystem
{
    partial class frmAddNewUser
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
            this.pnlHdr = new System.Windows.Forms.Panel();
            this.lblHdr = new System.Windows.Forms.Label();
            this.lblFrstName = new System.Windows.Forms.Label();
            this.lblAddrs = new System.Windows.Forms.Label();
            this.lblBrthDate = new System.Windows.Forms.Label();
            this.txtFrstName = new System.Windows.Forms.TextBox();
            this.txtAddrs = new System.Windows.Forms.TextBox();
            this.txtBrthDate = new System.Windows.Forms.TextBox();
            this.txtMono = new System.Windows.Forms.TextBox();
            this.txtLstName = new System.Windows.Forms.TextBox();
            this.lblGndr = new System.Windows.Forms.Label();
            this.lblMono = new System.Windows.Forms.Label();
            this.labLstName = new System.Windows.Forms.Label();
            this.pnlMiddl = new System.Windows.Forms.Panel();
            this.pctrProfile = new System.Windows.Forms.PictureBox();
            this.lblPctrProfile = new System.Windows.Forms.Label();
            this.btnUpld = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtCnfrmPass = new System.Windows.Forms.TextBox();
            this.lblCofmPass = new System.Windows.Forms.Label();
            this.pnlLast = new System.Windows.Forms.Panel();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtQuestnAnsr = new System.Windows.Forms.TextBox();
            this.lblQuestnAnsr = new System.Windows.Forms.Label();
            this.txtOwnQuestn = new System.Windows.Forms.TextBox();
            this.lblOwnQuestn = new System.Windows.Forms.Label();
            this.lblSecQuestn = new System.Windows.Forms.Label();
            this.cmbSecQuestn = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnDlte = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbxUsers = new System.Windows.Forms.ComboBox();
            this.chbxAdmin = new System.Windows.Forms.CheckBox();
            this.btnCncl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHdr
            // 
            this.pnlHdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlHdr.Location = new System.Drawing.Point(1, 53);
            this.pnlHdr.MaximumSize = new System.Drawing.Size(1500, 1500);
            this.pnlHdr.Name = "pnlHdr";
            this.pnlHdr.Size = new System.Drawing.Size(1500, 10);
            this.pnlHdr.TabIndex = 0;
            // 
            // lblHdr
            // 
            this.lblHdr.AutoSize = true;
            this.lblHdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHdr.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHdr.ForeColor = System.Drawing.Color.Aqua;
            this.lblHdr.Location = new System.Drawing.Point(471, 9);
            this.lblHdr.Name = "lblHdr";
            this.lblHdr.Size = new System.Drawing.Size(263, 25);
            this.lblHdr.TabIndex = 0;
            this.lblHdr.Text = "New User Registeration Form";
            this.lblHdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrstName
            // 
            this.lblFrstName.AutoSize = true;
            this.lblFrstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFrstName.Location = new System.Drawing.Point(195, 70);
            this.lblFrstName.Name = "lblFrstName";
            this.lblFrstName.Size = new System.Drawing.Size(125, 19);
            this.lblFrstName.TabIndex = 1;
            this.lblFrstName.Text = "Enter First Name";
            // 
            // lblAddrs
            // 
            this.lblAddrs.AutoSize = true;
            this.lblAddrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAddrs.Location = new System.Drawing.Point(187, 155);
            this.lblAddrs.Name = "lblAddrs";
            this.lblAddrs.Size = new System.Drawing.Size(133, 19);
            this.lblAddrs.TabIndex = 2;
            this.lblAddrs.Text = "Enter Full Address";
            // 
            // lblBrthDate
            // 
            this.lblBrthDate.AutoSize = true;
            this.lblBrthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBrthDate.Location = new System.Drawing.Point(105, 115);
            this.lblBrthDate.Name = "lblBrthDate";
            this.lblBrthDate.Size = new System.Drawing.Size(215, 19);
            this.lblBrthDate.TabIndex = 3;
            this.lblBrthDate.Text = "Enter Birth Date (dd/mm/yyyy)";
            // 
            // txtFrstName
            // 
            this.txtFrstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrstName.Location = new System.Drawing.Point(326, 70);
            this.txtFrstName.Name = "txtFrstName";
            this.txtFrstName.Size = new System.Drawing.Size(176, 22);
            this.txtFrstName.TabIndex = 0;
            this.txtFrstName.Enter += new System.EventHandler(this.Set);
            this.txtFrstName.Leave += new System.EventHandler(this.Reset);
            // 
            // txtAddrs
            // 
            this.txtAddrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddrs.Location = new System.Drawing.Point(326, 154);
            this.txtAddrs.Name = "txtAddrs";
            this.txtAddrs.Size = new System.Drawing.Size(176, 22);
            this.txtAddrs.TabIndex = 5;
            this.txtAddrs.Enter += new System.EventHandler(this.Set);
            this.txtAddrs.Leave += new System.EventHandler(this.Reset);
            // 
            // txtBrthDate
            // 
            this.txtBrthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrthDate.Location = new System.Drawing.Point(326, 113);
            this.txtBrthDate.MaxLength = 10;
            this.txtBrthDate.Name = "txtBrthDate";
            this.txtBrthDate.Size = new System.Drawing.Size(176, 22);
            this.txtBrthDate.TabIndex = 2;
            this.txtBrthDate.Enter += new System.EventHandler(this.Set);
            this.txtBrthDate.Leave += new System.EventHandler(this.Reset);
            // 
            // txtMono
            // 
            this.txtMono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMono.Location = new System.Drawing.Point(746, 151);
            this.txtMono.MaxLength = 10;
            this.txtMono.Name = "txtMono";
            this.txtMono.Size = new System.Drawing.Size(176, 22);
            this.txtMono.TabIndex = 6;
            this.txtMono.Enter += new System.EventHandler(this.Set);
            this.txtMono.Leave += new System.EventHandler(this.Reset);
            // 
            // txtLstName
            // 
            this.txtLstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLstName.Location = new System.Drawing.Point(746, 70);
            this.txtLstName.Name = "txtLstName";
            this.txtLstName.Size = new System.Drawing.Size(176, 22);
            this.txtLstName.TabIndex = 1;
            this.txtLstName.Enter += new System.EventHandler(this.Set);
            this.txtLstName.Leave += new System.EventHandler(this.Reset);
            // 
            // lblGndr
            // 
            this.lblGndr.AutoSize = true;
            this.lblGndr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGndr.Location = new System.Drawing.Point(637, 117);
            this.lblGndr.Name = "lblGndr";
            this.lblGndr.Size = new System.Drawing.Size(104, 19);
            this.lblGndr.TabIndex = 9;
            this.lblGndr.Text = "Select Gendar";
            // 
            // lblMono
            // 
            this.lblMono.AutoSize = true;
            this.lblMono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMono.Location = new System.Drawing.Point(619, 151);
            this.lblMono.Name = "lblMono";
            this.lblMono.Size = new System.Drawing.Size(122, 19);
            this.lblMono.TabIndex = 8;
            this.lblMono.Text = "Enter Mobile No";
            // 
            // labLstName
            // 
            this.labLstName.AutoSize = true;
            this.labLstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labLstName.Location = new System.Drawing.Point(616, 70);
            this.labLstName.Name = "labLstName";
            this.labLstName.Size = new System.Drawing.Size(124, 19);
            this.labLstName.TabIndex = 7;
            this.labLstName.Text = "Enter Last Name";
            // 
            // pnlMiddl
            // 
            this.pnlMiddl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlMiddl.Location = new System.Drawing.Point(1, 255);
            this.pnlMiddl.Name = "pnlMiddl";
            this.pnlMiddl.Size = new System.Drawing.Size(1500, 10);
            this.pnlMiddl.TabIndex = 13;
            // 
            // pctrProfile
            // 
            this.pctrProfile.BackColor = System.Drawing.Color.White;
            this.pctrProfile.Location = new System.Drawing.Point(1008, 93);
            this.pctrProfile.Name = "pctrProfile";
            this.pctrProfile.Size = new System.Drawing.Size(111, 119);
            this.pctrProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrProfile.TabIndex = 14;
            this.pctrProfile.TabStop = false;
            // 
            // lblPctrProfile
            // 
            this.lblPctrProfile.AutoSize = true;
            this.lblPctrProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPctrProfile.Location = new System.Drawing.Point(986, 66);
            this.lblPctrProfile.Name = "lblPctrProfile";
            this.lblPctrProfile.Size = new System.Drawing.Size(149, 19);
            this.lblPctrProfile.TabIndex = 15;
            this.lblPctrProfile.Text = "Select Profile Picture";
            // 
            // btnUpld
            // 
            this.btnUpld.BackColor = System.Drawing.Color.Purple;
            this.btnUpld.ForeColor = System.Drawing.Color.White;
            this.btnUpld.Location = new System.Drawing.Point(1022, 218);
            this.btnUpld.Name = "btnUpld";
            this.btnUpld.Size = new System.Drawing.Size(84, 31);
            this.btnUpld.TabIndex = 7;
            this.btnUpld.Text = "UPLOAD";
            this.btnUpld.UseVisualStyleBackColor = false;
            this.btnUpld.Click += new System.EventHandler(this.btnUpld_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(12, 284);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 19);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Enter Email ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(180, 284);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 22);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Enter += new System.EventHandler(this.Set);
            this.txtEmail.Leave += new System.EventHandler(this.Reset);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(711, 284);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(176, 22);
            this.txtPass.TabIndex = 9;
            this.txtPass.Enter += new System.EventHandler(this.Set);
            this.txtPass.Leave += new System.EventHandler(this.Reset);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPass.Location = new System.Drawing.Point(528, 284);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(113, 19);
            this.lblPass.TabIndex = 19;
            this.lblPass.Text = "Enter Password";
            // 
            // txtCnfrmPass
            // 
            this.txtCnfrmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnfrmPass.Location = new System.Drawing.Point(1065, 284);
            this.txtCnfrmPass.Name = "txtCnfrmPass";
            this.txtCnfrmPass.Size = new System.Drawing.Size(176, 22);
            this.txtCnfrmPass.TabIndex = 10;
            this.txtCnfrmPass.Enter += new System.EventHandler(this.Set);
            this.txtCnfrmPass.Leave += new System.EventHandler(this.Reset);
            // 
            // lblCofmPass
            // 
            this.lblCofmPass.AutoSize = true;
            this.lblCofmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCofmPass.Location = new System.Drawing.Point(921, 285);
            this.lblCofmPass.Name = "lblCofmPass";
            this.lblCofmPass.Size = new System.Drawing.Size(138, 19);
            this.lblCofmPass.TabIndex = 21;
            this.lblCofmPass.Text = "Re-Enter Password";
            // 
            // pnlLast
            // 
            this.pnlLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlLast.Location = new System.Drawing.Point(1, 463);
            this.pnlLast.Name = "pnlLast";
            this.pnlLast.Size = new System.Drawing.Size(1500, 10);
            this.pnlLast.TabIndex = 23;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbMale.Location = new System.Drawing.Point(747, 115);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(63, 23);
            this.rdbMale.TabIndex = 3;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbFemale.Location = new System.Drawing.Point(847, 115);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(76, 23);
            this.rdbFemale.TabIndex = 4;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Purple;
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Location = new System.Drawing.Point(11, 404);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(84, 31);
            this.btnADD.TabIndex = 14;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtQuestnAnsr
            // 
            this.txtQuestnAnsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestnAnsr.Location = new System.Drawing.Point(1065, 332);
            this.txtQuestnAnsr.Name = "txtQuestnAnsr";
            this.txtQuestnAnsr.Size = new System.Drawing.Size(176, 22);
            this.txtQuestnAnsr.TabIndex = 13;
            this.txtQuestnAnsr.Enter += new System.EventHandler(this.Set);
            this.txtQuestnAnsr.Leave += new System.EventHandler(this.Reset);
            // 
            // lblQuestnAnsr
            // 
            this.lblQuestnAnsr.AutoSize = true;
            this.lblQuestnAnsr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblQuestnAnsr.Location = new System.Drawing.Point(960, 334);
            this.lblQuestnAnsr.Name = "lblQuestnAnsr";
            this.lblQuestnAnsr.Size = new System.Drawing.Size(99, 19);
            this.lblQuestnAnsr.TabIndex = 31;
            this.lblQuestnAnsr.Text = "Enter Answer";
            // 
            // txtOwnQuestn
            // 
            this.txtOwnQuestn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnQuestn.Location = new System.Drawing.Point(711, 334);
            this.txtOwnQuestn.Name = "txtOwnQuestn";
            this.txtOwnQuestn.ReadOnly = true;
            this.txtOwnQuestn.Size = new System.Drawing.Size(243, 22);
            this.txtOwnQuestn.TabIndex = 12;
            this.txtOwnQuestn.Enter += new System.EventHandler(this.Set);
            this.txtOwnQuestn.Leave += new System.EventHandler(this.Reset);
            // 
            // lblOwnQuestn
            // 
            this.lblOwnQuestn.AutoSize = true;
            this.lblOwnQuestn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOwnQuestn.Location = new System.Drawing.Point(528, 336);
            this.lblOwnQuestn.Name = "lblOwnQuestn";
            this.lblOwnQuestn.Size = new System.Drawing.Size(177, 19);
            this.lblOwnQuestn.TabIndex = 29;
            this.lblOwnQuestn.Text = "Enter Your Own Question";
            // 
            // lblSecQuestn
            // 
            this.lblSecQuestn.AutoSize = true;
            this.lblSecQuestn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSecQuestn.Location = new System.Drawing.Point(1, 336);
            this.lblSecQuestn.Name = "lblSecQuestn";
            this.lblSecQuestn.Size = new System.Drawing.Size(173, 19);
            this.lblSecQuestn.TabIndex = 27;
            this.lblSecQuestn.Text = "Select Security Question";
            // 
            // cmbSecQuestn
            // 
            this.cmbSecQuestn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecQuestn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSecQuestn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecQuestn.FormattingEnabled = true;
            this.cmbSecQuestn.Items.AddRange(new object[] {
            "--Select Security Question--",
            "What Is Your Favriout Cricketer?",
            "What Is Your Favriout Actor?",
            "What Is Your Neak Name?",
            "Who Is Your Best Friend?",
            "What Is Your Grand Father Name?",
            "Others"});
            this.cmbSecQuestn.Location = new System.Drawing.Point(180, 334);
            this.cmbSecQuestn.Name = "cmbSecQuestn";
            this.cmbSecQuestn.Size = new System.Drawing.Size(342, 24);
            this.cmbSecQuestn.TabIndex = 11;
            this.cmbSecQuestn.SelectedIndexChanged += new System.EventHandler(this.cmbSecQuestn_SelectedIndexChanged);
            this.cmbSecQuestn.Enter += new System.EventHandler(this.cmbSecQuestn_Enter);
            this.cmbSecQuestn.Leave += new System.EventHandler(this.cmbSecQuestn_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(1, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 10);
            this.panel2.TabIndex = 24;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblError.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(502, 435);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 34;
            // 
            // btnDlte
            // 
            this.btnDlte.BackColor = System.Drawing.Color.Purple;
            this.btnDlte.ForeColor = System.Drawing.Color.White;
            this.btnDlte.Location = new System.Drawing.Point(191, 404);
            this.btnDlte.Name = "btnDlte";
            this.btnDlte.Size = new System.Drawing.Size(88, 31);
            this.btnDlte.TabIndex = 16;
            this.btnDlte.Text = "REMOVE";
            this.btnDlte.UseVisualStyleBackColor = false;
            this.btnDlte.Click += new System.EventHandler(this.btnDlte_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Purple;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(101, 404);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 31);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Tag = "";
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbxUsers
            // 
            this.cmbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxUsers.FormattingEnabled = true;
            this.cmbxUsers.Location = new System.Drawing.Point(899, 408);
            this.cmbxUsers.Name = "cmbxUsers";
            this.cmbxUsers.Size = new System.Drawing.Size(342, 24);
            this.cmbxUsers.TabIndex = 18;
            this.cmbxUsers.Enter += new System.EventHandler(this.cmbSecQuestn_Enter);
            this.cmbxUsers.Leave += new System.EventHandler(this.cmbSecQuestn_Leave);
            // 
            // chbxAdmin
            // 
            this.chbxAdmin.AutoSize = true;
            this.chbxAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chbxAdmin.Location = new System.Drawing.Point(532, 409);
            this.chbxAdmin.Name = "chbxAdmin";
            this.chbxAdmin.Size = new System.Drawing.Size(229, 23);
            this.chbxAdmin.TabIndex = 17;
            this.chbxAdmin.Text = "Select Role Of User As Admin";
            this.chbxAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCncl
            // 
            this.btnCncl.BackColor = System.Drawing.Color.Purple;
            this.btnCncl.ForeColor = System.Drawing.Color.White;
            this.btnCncl.Location = new System.Drawing.Point(285, 404);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(88, 31);
            this.btnCncl.TabIndex = 17;
            this.btnCncl.Text = "CANCEL";
            this.btnCncl.UseVisualStyleBackColor = false;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 485);
            this.Controls.Add(this.btnCncl);
            this.Controls.Add(this.chbxAdmin);
            this.Controls.Add(this.cmbxUsers);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDlte);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbSecQuestn);
            this.Controls.Add(this.txtQuestnAnsr);
            this.Controls.Add(this.lblQuestnAnsr);
            this.Controls.Add(this.txtOwnQuestn);
            this.Controls.Add(this.lblOwnQuestn);
            this.Controls.Add(this.lblSecQuestn);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.pnlLast);
            this.Controls.Add(this.txtCnfrmPass);
            this.Controls.Add(this.lblCofmPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnUpld);
            this.Controls.Add(this.lblPctrProfile);
            this.Controls.Add(this.pctrProfile);
            this.Controls.Add(this.pnlMiddl);
            this.Controls.Add(this.txtMono);
            this.Controls.Add(this.txtLstName);
            this.Controls.Add(this.lblGndr);
            this.Controls.Add(this.lblMono);
            this.Controls.Add(this.labLstName);
            this.Controls.Add(this.txtBrthDate);
            this.Controls.Add(this.txtAddrs);
            this.Controls.Add(this.txtFrstName);
            this.Controls.Add(this.lblBrthDate);
            this.Controls.Add(this.lblAddrs);
            this.Controls.Add(this.lblFrstName);
            this.Controls.Add(this.lblHdr);
            this.Controls.Add(this.pnlHdr);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(1500, 1500);
            this.Name = "frmAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User Registration";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHdr;
        private System.Windows.Forms.Label lblHdr;
        private System.Windows.Forms.Label lblFrstName;
        private System.Windows.Forms.Label lblAddrs;
        private System.Windows.Forms.Label lblBrthDate;
        private System.Windows.Forms.TextBox txtFrstName;
        private System.Windows.Forms.TextBox txtAddrs;
        private System.Windows.Forms.TextBox txtBrthDate;
        private System.Windows.Forms.TextBox txtMono;
        private System.Windows.Forms.TextBox txtLstName;
        private System.Windows.Forms.Label lblGndr;
        private System.Windows.Forms.Label lblMono;
        private System.Windows.Forms.Label labLstName;
        private System.Windows.Forms.Panel pnlMiddl;
        private System.Windows.Forms.PictureBox pctrProfile;
        private System.Windows.Forms.Label lblPctrProfile;
        private System.Windows.Forms.Button btnUpld;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtCnfrmPass;
        private System.Windows.Forms.Label lblCofmPass;
        private System.Windows.Forms.Panel pnlLast;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtQuestnAnsr;
        private System.Windows.Forms.Label lblQuestnAnsr;
        private System.Windows.Forms.TextBox txtOwnQuestn;
        private System.Windows.Forms.Label lblOwnQuestn;
        private System.Windows.Forms.Label lblSecQuestn;
        private System.Windows.Forms.ComboBox cmbSecQuestn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnDlte;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbxUsers;
        private System.Windows.Forms.CheckBox chbxAdmin;
        private System.Windows.Forms.Button btnCncl;

    }
}


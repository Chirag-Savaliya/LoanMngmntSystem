namespace LoanMngmntSystem
{
    partial class frmAddNewCstmr
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
            this.pctrProfile = new System.Windows.Forms.PictureBox();
            this.lblPctrProfile = new System.Windows.Forms.Label();
            this.btnUpld = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlLast = new System.Windows.Forms.Panel();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.btnADD = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnDlte = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCncl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPinno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxCstmr = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHdr
            // 
            this.pnlHdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlHdr.Location = new System.Drawing.Point(1, 37);
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
            this.lblHdr.Location = new System.Drawing.Point(502, 9);
            this.lblHdr.Name = "lblHdr";
            this.lblHdr.Size = new System.Drawing.Size(217, 25);
            this.lblHdr.TabIndex = 0;
            this.lblHdr.Text = "Customers Management";
            this.lblHdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrstName
            // 
            this.lblFrstName.AutoSize = true;
            this.lblFrstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFrstName.Location = new System.Drawing.Point(12, 218);
            this.lblFrstName.Name = "lblFrstName";
            this.lblFrstName.Size = new System.Drawing.Size(125, 19);
            this.lblFrstName.TabIndex = 1;
            this.lblFrstName.Text = "Enter First Name";
            // 
            // lblAddrs
            // 
            this.lblAddrs.AutoSize = true;
            this.lblAddrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAddrs.Location = new System.Drawing.Point(12, 253);
            this.lblAddrs.Name = "lblAddrs";
            this.lblAddrs.Size = new System.Drawing.Size(133, 19);
            this.lblAddrs.TabIndex = 2;
            this.lblAddrs.Text = "Enter Full Address";
            // 
            // lblBrthDate
            // 
            this.lblBrthDate.AutoSize = true;
            this.lblBrthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBrthDate.Location = new System.Drawing.Point(855, 216);
            this.lblBrthDate.Name = "lblBrthDate";
            this.lblBrthDate.Size = new System.Drawing.Size(215, 19);
            this.lblBrthDate.TabIndex = 3;
            this.lblBrthDate.Text = "Enter Birth Date (dd/mm/yyyy)";
            // 
            // txtFrstName
            // 
            this.txtFrstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrstName.Location = new System.Drawing.Point(143, 218);
            this.txtFrstName.Name = "txtFrstName";
            this.txtFrstName.Size = new System.Drawing.Size(176, 22);
            this.txtFrstName.TabIndex = 3;
            this.txtFrstName.Enter += new System.EventHandler(this.Set);
            this.txtFrstName.Leave += new System.EventHandler(this.Reset);
            // 
            // txtAddrs
            // 
            this.txtAddrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddrs.Location = new System.Drawing.Point(143, 253);
            this.txtAddrs.Name = "txtAddrs";
            this.txtAddrs.Size = new System.Drawing.Size(176, 22);
            this.txtAddrs.TabIndex = 6;
            this.txtAddrs.Enter += new System.EventHandler(this.Set);
            this.txtAddrs.Leave += new System.EventHandler(this.Reset);
            // 
            // txtBrthDate
            // 
            this.txtBrthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrthDate.Location = new System.Drawing.Point(1070, 216);
            this.txtBrthDate.MaxLength = 10;
            this.txtBrthDate.Name = "txtBrthDate";
            this.txtBrthDate.Size = new System.Drawing.Size(176, 22);
            this.txtBrthDate.TabIndex = 5;
            this.txtBrthDate.Enter += new System.EventHandler(this.Set);
            this.txtBrthDate.Leave += new System.EventHandler(this.Reset);
            // 
            // txtMono
            // 
            this.txtMono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMono.Location = new System.Drawing.Point(142, 283);
            this.txtMono.MaxLength = 10;
            this.txtMono.Name = "txtMono";
            this.txtMono.Size = new System.Drawing.Size(176, 22);
            this.txtMono.TabIndex = 10;
            this.txtMono.Enter += new System.EventHandler(this.Set);
            this.txtMono.Leave += new System.EventHandler(this.Reset);
            // 
            // txtLstName
            // 
            this.txtLstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLstName.Location = new System.Drawing.Point(507, 217);
            this.txtLstName.Name = "txtLstName";
            this.txtLstName.Size = new System.Drawing.Size(176, 22);
            this.txtLstName.TabIndex = 4;
            this.txtLstName.Enter += new System.EventHandler(this.Set);
            this.txtLstName.Leave += new System.EventHandler(this.Reset);
            // 
            // lblGndr
            // 
            this.lblGndr.AutoSize = true;
            this.lblGndr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGndr.Location = new System.Drawing.Point(855, 252);
            this.lblGndr.Name = "lblGndr";
            this.lblGndr.Size = new System.Drawing.Size(104, 19);
            this.lblGndr.TabIndex = 9;
            this.lblGndr.Text = "Select Gendar";
            // 
            // lblMono
            // 
            this.lblMono.AutoSize = true;
            this.lblMono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMono.Location = new System.Drawing.Point(12, 283);
            this.lblMono.Name = "lblMono";
            this.lblMono.Size = new System.Drawing.Size(122, 19);
            this.lblMono.TabIndex = 8;
            this.lblMono.Text = "Enter Mobile No";
            // 
            // labLstName
            // 
            this.labLstName.AutoSize = true;
            this.labLstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labLstName.Location = new System.Drawing.Point(377, 217);
            this.labLstName.Name = "labLstName";
            this.labLstName.Size = new System.Drawing.Size(124, 19);
            this.labLstName.TabIndex = 7;
            this.labLstName.Text = "Enter Last Name";
            // 
            // pctrProfile
            // 
            this.pctrProfile.BackColor = System.Drawing.Color.White;
            this.pctrProfile.Location = new System.Drawing.Point(561, 72);
            this.pctrProfile.Name = "pctrProfile";
            this.pctrProfile.Size = new System.Drawing.Size(82, 87);
            this.pctrProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrProfile.TabIndex = 14;
            this.pctrProfile.TabStop = false;
            // 
            // lblPctrProfile
            // 
            this.lblPctrProfile.AutoSize = true;
            this.lblPctrProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPctrProfile.Location = new System.Drawing.Point(539, 50);
            this.lblPctrProfile.Name = "lblPctrProfile";
            this.lblPctrProfile.Size = new System.Drawing.Size(149, 19);
            this.lblPctrProfile.TabIndex = 15;
            this.lblPctrProfile.Text = "Select Profile Picture";
            // 
            // btnUpld
            // 
            this.btnUpld.BackColor = System.Drawing.Color.Purple;
            this.btnUpld.ForeColor = System.Drawing.Color.White;
            this.btnUpld.Location = new System.Drawing.Point(561, 165);
            this.btnUpld.Name = "btnUpld";
            this.btnUpld.Size = new System.Drawing.Size(82, 25);
            this.btnUpld.TabIndex = 2;
            this.btnUpld.Text = "UPLOAD";
            this.btnUpld.UseVisualStyleBackColor = false;
            this.btnUpld.Click += new System.EventHandler(this.btnUpld_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(380, 255);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 19);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Enter Email ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(507, 252);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 22);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Enter += new System.EventHandler(this.Set);
            this.txtEmail.Leave += new System.EventHandler(this.Reset);
            // 
            // pnlLast
            // 
            this.pnlLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlLast.Location = new System.Drawing.Point(1, 388);
            this.pnlLast.Name = "pnlLast";
            this.pnlLast.Size = new System.Drawing.Size(1500, 10);
            this.pnlLast.TabIndex = 23;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbMale.Location = new System.Drawing.Point(965, 250);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(63, 23);
            this.rdbMale.TabIndex = 8;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbFemale.Location = new System.Drawing.Point(1065, 250);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(76, 23);
            this.rdbFemale.TabIndex = 9;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Purple;
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Location = new System.Drawing.Point(411, 351);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(84, 31);
            this.btnADD.TabIndex = 12;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblError.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(407, 401);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 22);
            this.lblError.TabIndex = 34;
            this.lblError.Tag = "";
            // 
            // btnDlte
            // 
            this.btnDlte.BackColor = System.Drawing.Color.Purple;
            this.btnDlte.ForeColor = System.Drawing.Color.White;
            this.btnDlte.Location = new System.Drawing.Point(591, 351);
            this.btnDlte.Name = "btnDlte";
            this.btnDlte.Size = new System.Drawing.Size(88, 31);
            this.btnDlte.TabIndex = 14;
            this.btnDlte.Text = "REMOVE";
            this.btnDlte.UseVisualStyleBackColor = false;
            this.btnDlte.Click += new System.EventHandler(this.btnDlte_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Purple;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(501, 351);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 31);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Tag = "";
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCncl
            // 
            this.btnCncl.BackColor = System.Drawing.Color.Purple;
            this.btnCncl.ForeColor = System.Drawing.Color.White;
            this.btnCncl.Location = new System.Drawing.Point(685, 351);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(88, 31);
            this.btnCncl.TabIndex = 15;
            this.btnCncl.Text = "CANCEL";
            this.btnCncl.UseVisualStyleBackColor = false;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(1, 196);
            this.panel1.MaximumSize = new System.Drawing.Size(1500, 1500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(1, 327);
            this.panel2.MaximumSize = new System.Drawing.Size(1500, 1500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 10);
            this.panel2.TabIndex = 0;
            // 
            // txtPinno
            // 
            this.txtPinno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinno.Location = new System.Drawing.Point(510, 286);
            this.txtPinno.MaxLength = 6;
            this.txtPinno.Name = "txtPinno";
            this.txtPinno.Size = new System.Drawing.Size(176, 22);
            this.txtPinno.TabIndex = 11;
            this.txtPinno.Enter += new System.EventHandler(this.Set);
            this.txtPinno.Leave += new System.EventHandler(this.Reset);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(380, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Enter Pincode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Select Customer Id";
            // 
            // cmbxCstmr
            // 
            this.cmbxCstmr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCstmr.Enabled = false;
            this.cmbxCstmr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxCstmr.FormattingEnabled = true;
            this.cmbxCstmr.Items.AddRange(new object[] {
            "--Select Customer Id--"});
            this.cmbxCstmr.Location = new System.Drawing.Point(155, 57);
            this.cmbxCstmr.Name = "cmbxCstmr";
            this.cmbxCstmr.Size = new System.Drawing.Size(177, 27);
            this.cmbxCstmr.TabIndex = 1;
            this.cmbxCstmr.SelectedIndexChanged += new System.EventHandler(this.cmbxCstmr_SelectedIndexChanged);
            this.cmbxCstmr.Enter += new System.EventHandler(this.cmbx_Enter);
            this.cmbxCstmr.Leave += new System.EventHandler(this.cmbx_Leave);
            // 
            // frmAddNewCstmr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 422);
            this.Controls.Add(this.cmbxCstmr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPinno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCncl);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDlte);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.pnlLast);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnUpld);
            this.Controls.Add(this.lblPctrProfile);
            this.Controls.Add(this.pctrProfile);
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHdr);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddNewCstmr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.frmAddNewCstmr_Load);
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
        private System.Windows.Forms.PictureBox pctrProfile;
        private System.Windows.Forms.Label lblPctrProfile;
        private System.Windows.Forms.Button btnUpld;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlLast;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnDlte;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCncl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPinno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxCstmr;

    }
}


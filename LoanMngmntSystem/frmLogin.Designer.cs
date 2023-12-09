namespace LoanMngmntSystem
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnCncl = new System.Windows.Forms.Button();
            this.btnNxt = new System.Windows.Forms.Button();
            this.txtAnsr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQstn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lnklblFrgtPswrd = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPasswrd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsrnm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lblErrMsg);
            this.groupBox1.Controls.Add(this.pnlLogin);
            this.groupBox1.Controls.Add(this.lnklblFrgtPswrd);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtPasswrd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsrnm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.AutoSize = true;
            this.lblErrMsg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsg.Location = new System.Drawing.Point(34, 417);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(0, 19);
            this.lblErrMsg.TabIndex = 9;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnCncl);
            this.pnlLogin.Controls.Add(this.btnNxt);
            this.pnlLogin.Controls.Add(this.txtAnsr);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.txtQstn);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Enabled = false;
            this.pnlLogin.Location = new System.Drawing.Point(1, 256);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(357, 156);
            this.pnlLogin.TabIndex = 8;
            // 
            // btnCncl
            // 
            this.btnCncl.BackColor = System.Drawing.Color.Purple;
            this.btnCncl.ForeColor = System.Drawing.Color.White;
            this.btnCncl.Location = new System.Drawing.Point(243, 125);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(83, 26);
            this.btnCncl.TabIndex = 8;
            this.btnCncl.Text = "CANCEL";
            this.btnCncl.UseVisualStyleBackColor = false;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // btnNxt
            // 
            this.btnNxt.BackColor = System.Drawing.Color.Purple;
            this.btnNxt.ForeColor = System.Drawing.Color.White;
            this.btnNxt.Location = new System.Drawing.Point(53, 125);
            this.btnNxt.Name = "btnNxt";
            this.btnNxt.Size = new System.Drawing.Size(75, 26);
            this.btnNxt.TabIndex = 7;
            this.btnNxt.Text = "NEXT";
            this.btnNxt.UseVisualStyleBackColor = false;
            this.btnNxt.Click += new System.EventHandler(this.btnNxt_Click);
            // 
            // txtAnsr
            // 
            this.txtAnsr.Location = new System.Drawing.Point(6, 93);
            this.txtAnsr.Name = "txtAnsr";
            this.txtAnsr.Size = new System.Drawing.Size(350, 26);
            this.txtAnsr.TabIndex = 6;
            this.txtAnsr.Enter += new System.EventHandler(this.Focus_Controls);
            this.txtAnsr.Leave += new System.EventHandler(this.Leave_Focus_Controls);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(130, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Answer";
            // 
            // txtQstn
            // 
            this.txtQstn.Location = new System.Drawing.Point(6, 27);
            this.txtQstn.Name = "txtQstn";
            this.txtQstn.ReadOnly = true;
            this.txtQstn.Size = new System.Drawing.Size(350, 26);
            this.txtQstn.TabIndex = 5;
            this.txtQstn.Enter += new System.EventHandler(this.Focus_Controls);
            this.txtQstn.Leave += new System.EventHandler(this.Leave_Focus_Controls);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(110, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Your Security Question";
            // 
            // lnklblFrgtPswrd
            // 
            this.lnklblFrgtPswrd.AutoSize = true;
            this.lnklblFrgtPswrd.Location = new System.Drawing.Point(240, 223);
            this.lnklblFrgtPswrd.Name = "lnklblFrgtPswrd";
            this.lnklblFrgtPswrd.Size = new System.Drawing.Size(120, 19);
            this.lnklblFrgtPswrd.TabIndex = 4;
            this.lnklblFrgtPswrd.TabStop = true;
            this.lnklblFrgtPswrd.Text = "Forget Password";
            this.lnklblFrgtPswrd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblFrgtPswrd_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Purple;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(135, 217);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPasswrd
            // 
            this.txtPasswrd.Location = new System.Drawing.Point(135, 179);
            this.txtPasswrd.Name = "txtPasswrd";
            this.txtPasswrd.Size = new System.Drawing.Size(220, 26);
            this.txtPasswrd.TabIndex = 2;
            this.txtPasswrd.Text = "admin";
            this.txtPasswrd.UseSystemPasswordChar = true;
            this.txtPasswrd.Enter += new System.EventHandler(this.Focus_Controls);
            this.txtPasswrd.Leave += new System.EventHandler(this.Leave_Focus_Controls);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Password";
            // 
            // txtUsrnm
            // 
            this.txtUsrnm.Location = new System.Drawing.Point(135, 129);
            this.txtUsrnm.Name = "txtUsrnm";
            this.txtUsrnm.Size = new System.Drawing.Size(220, 26);
            this.txtUsrnm.TabIndex = 1;
            this.txtUsrnm.Text = "admin@gmail.com";
            this.txtUsrnm.Enter += new System.EventHandler(this.Focus_Controls);
            this.txtUsrnm.Leave += new System.EventHandler(this.Leave_Focus_Controls);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPasswrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsrnm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtQstn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnklblFrgtPswrd;
        private System.Windows.Forms.TextBox txtAnsr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNxt;
        private System.Windows.Forms.Label lblErrMsg;
        private System.Windows.Forms.Button btnCncl;
    }
}
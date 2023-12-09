namespace LoanMngmntSystem
{
    partial class frmLoanMngmnt
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxLnNme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLnIntsrRt = new System.Windows.Forms.TextBox();
            this.txtLnMxAmntRt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLnInsrRt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCncl = new System.Windows.Forms.Button();
            this.btnDlt = new System.Windows.Forms.Button();
            this.btnEdt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(498, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Management Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(1, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 10);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Loan";
            // 
            // cmbxLnNme
            // 
            this.cmbxLnNme.BackColor = System.Drawing.Color.White;
            this.cmbxLnNme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLnNme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxLnNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbxLnNme.FormattingEnabled = true;
            this.cmbxLnNme.Location = new System.Drawing.Point(266, 82);
            this.cmbxLnNme.Name = "cmbxLnNme";
            this.cmbxLnNme.Size = new System.Drawing.Size(204, 24);
            this.cmbxLnNme.TabIndex = 1;
            this.cmbxLnNme.SelectedIndexChanged += new System.EventHandler(this.cmbxLnNme_SelectedIndexChanged);
            this.cmbxLnNme.Enter += new System.EventHandler(this.cmbxLnNme_Enter);
            this.cmbxLnNme.Leave += new System.EventHandler(this.cmbxLnNme_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(955, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Loan Interest Rate";
            // 
            // txtLnIntsrRt
            // 
            this.txtLnIntsrRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLnIntsrRt.Location = new System.Drawing.Point(1139, 80);
            this.txtLnIntsrRt.Name = "txtLnIntsrRt";
            this.txtLnIntsrRt.Size = new System.Drawing.Size(100, 22);
            this.txtLnIntsrRt.TabIndex = 2;
            this.txtLnIntsrRt.Enter += new System.EventHandler(this.txtLnMxAmntRt_Enter);
            this.txtLnIntsrRt.Leave += new System.EventHandler(this.txtLnMxAmntRt_Leave);
            // 
            // txtLnMxAmntRt
            // 
            this.txtLnMxAmntRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLnMxAmntRt.Location = new System.Drawing.Point(266, 152);
            this.txtLnMxAmntRt.Name = "txtLnMxAmntRt";
            this.txtLnMxAmntRt.Size = new System.Drawing.Size(100, 22);
            this.txtLnMxAmntRt.TabIndex = 3;
            this.txtLnMxAmntRt.Enter += new System.EventHandler(this.txtLnMxAmntRt_Enter);
            this.txtLnMxAmntRt.Leave += new System.EventHandler(this.txtLnMxAmntRt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Loan Maximum Amount Rate";
            // 
            // txtLnInsrRt
            // 
            this.txtLnInsrRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLnInsrRt.Location = new System.Drawing.Point(1139, 145);
            this.txtLnInsrRt.Name = "txtLnInsrRt";
            this.txtLnInsrRt.Size = new System.Drawing.Size(100, 22);
            this.txtLnInsrRt.TabIndex = 4;
            this.txtLnInsrRt.Enter += new System.EventHandler(this.txtLnMxAmntRt_Enter);
            this.txtLnInsrRt.Leave += new System.EventHandler(this.txtLnMxAmntRt_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(942, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter Loan Insurance Rate";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(1, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1249, 10);
            this.panel2.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Purple;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCncl
            // 
            this.btnCncl.BackColor = System.Drawing.Color.Purple;
            this.btnCncl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCncl.ForeColor = System.Drawing.Color.White;
            this.btnCncl.Location = new System.Drawing.Point(1147, 249);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(92, 32);
            this.btnCncl.TabIndex = 8;
            this.btnCncl.Text = "CANCEL";
            this.btnCncl.UseVisualStyleBackColor = false;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // btnDlt
            // 
            this.btnDlt.BackColor = System.Drawing.Color.Purple;
            this.btnDlt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDlt.ForeColor = System.Drawing.Color.White;
            this.btnDlt.Location = new System.Drawing.Point(752, 249);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(117, 32);
            this.btnDlt.TabIndex = 7;
            this.btnDlt.Text = "REMOVE";
            this.btnDlt.UseVisualStyleBackColor = false;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // btnEdt
            // 
            this.btnEdt.BackColor = System.Drawing.Color.Purple;
            this.btnEdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdt.ForeColor = System.Drawing.Color.White;
            this.btnEdt.Location = new System.Drawing.Point(395, 249);
            this.btnEdt.Name = "btnEdt";
            this.btnEdt.Size = new System.Drawing.Size(118, 32);
            this.btnEdt.TabIndex = 6;
            this.btnEdt.Text = "EDIT";
            this.btnEdt.UseVisualStyleBackColor = false;
            this.btnEdt.Click += new System.EventHandler(this.btnEdt_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(1, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1249, 10);
            this.panel3.TabIndex = 14;
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.AutoSize = true;
            this.lblErrMsg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblErrMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsg.Location = new System.Drawing.Point(391, 329);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(0, 22);
            this.lblErrMsg.TabIndex = 0;
            // 
            // frmLoanMngmnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1250, 354);
            this.Controls.Add(this.lblErrMsg);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnEdt);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.btnCncl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtLnInsrRt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLnMxAmntRt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLnIntsrRt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxLnNme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmLoanMngmnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Management";
            this.Load += new System.EventHandler(this.frmLoanMngmnt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxLnNme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLnIntsrRt;
        private System.Windows.Forms.TextBox txtLnMxAmntRt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLnInsrRt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCncl;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.Button btnEdt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblErrMsg;
    }
}
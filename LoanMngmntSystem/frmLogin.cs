using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoanMngmntSystem
{
    public partial class frmLogin : Form
    {
        string QRY = "";
        SqlConnection CNN;
        SqlCommand CMD;
        SqlDataAdapter DA;
        SqlDataReader DR;
        DataSet DS;
        


        public frmLogin()
        {
            InitializeComponent();
        }

        private void Focus_Controls(object s, EventArgs e)
        {

            ((TextBox)s).BackColor = Color.LightGoldenrodYellow;
            ((TextBox)s).ForeColor = Color.Teal;
        }

        private void Leave_Focus_Controls(object s, EventArgs e)
        {
            ((TextBox)s).BackColor = Color.White;
            ((TextBox)s).ForeColor = Color.Black;
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            ClearControls();
            pnlLogin.Enabled = false;
            txtPasswrd.Enabled = true;
            btnLogin.Enabled = true;
            txtUsrnm.ReadOnly = false;
            lblErrMsg.Text = "";
        }
        void ClearControls()
        {
            txtUsrnm.Clear();
            txtPasswrd.Clear();
            txtQstn.Clear();
            txtAnsr.Clear();
        }

        private void lnklblFrgtPswrd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtUsrnm.Text.Length >= 1)
            {
                btnLogin.Enabled = false;
                txtPasswrd.Clear();
                txtPasswrd.Enabled = false;
                pnlLogin.Enabled = true;
                txtQstn.Enabled = true;
                txtAnsr.Enabled = true;
                QRY = "SELECT usrScurtyQstn FROM tblLoginMaster WHERE usrNme = '" + txtUsrnm.Text.ToString() + "' AND usrLognIsAct = 'TRUE'";

                CNN = new SqlConnection(Connection.cnstr);
                CNN.Open();
                CMD = new SqlCommand(QRY, CNN);
                DR = CMD.ExecuteReader();

                if (DR.Read())
                {
                    txtQstn.Text = DR[0].ToString();
                    txtQstn.Enabled = true;
                    txtAnsr.Enabled = true;
                    btnNxt.Enabled = true;
                    txtUsrnm.ReadOnly = true;
                    lblErrMsg.Text = "";
                }
                else
                {
                    txtUsrnm.ReadOnly = false;
                    txtQstn.Clear();
                    txtAnsr.Clear();
                    txtQstn.Enabled = false;
                    txtAnsr.Enabled = false;
                    btnNxt.Enabled = false;
                    lblErrMsg.Text = "* Please Enter Valid Username";
                }

                CNN.Close();
                CNN.Dispose();
                CMD.Dispose();

            }
            else
            {
                txtQstn.Clear();
                txtAnsr.Clear();
                txtQstn.Enabled = false;
                txtAnsr.Enabled = false;
                lblErrMsg.Text = "* Please Enter Valid Username";
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CntrlsValidation())
            {

                QRY = "SELECT usrNme,usrPasswrd,usrRlId FROM tblLoginMaster WHERE usrNme = '" + txtUsrnm.Text.ToString() + "' AND usrPasswrd = '" + txtPasswrd.Text.ToString() + "' AND usrLognIsAct = 'TRUE'";
                CNN = new SqlConnection(Connection.cnstr);
                CNN.Open();
                CMD = new SqlCommand(QRY, CNN);
                DR = CMD.ExecuteReader();
                if(DR.Read())
                {
                    if(DR["usrNme"].ToString()==txtUsrnm.Text.ToString() && DR["usrPasswrd"].ToString()==txtPasswrd.Text.ToString())
                    {
                       Label l= ((Label)this.MdiParent.Controls["lblUser"]);
                       l.Text = DR["usrNme"].ToString();
                        this.Close();
                    }
                }
                else
                {
                    lblErrMsg.Text = " * Please Enter Valid Username Or Password";
                }             
                CNN.Close();
                CNN.Dispose();
                CMD.Dispose();
               
            }
            
        }

        Boolean CntrlsValidation()
        {
            if (txtUsrnm.TextLength < 1)
            {
                lblErrMsg.Text = " * User Name Must Not Be Empty";
            }
            else if (txtPasswrd.TextLength < 1)
            {
                lblErrMsg.Text = " * Password  Must Not Be Empty";
            }
            else if (!UserValidation(txtUsrnm))
            {
                lblErrMsg.Text = " * Please Enter Valid User Name";
            }
            else if (!UserValidation(txtPasswrd))
            {
                lblErrMsg.Text = " * Please Enter Valid Password";
            }
            
            else
            {
                lblErrMsg.Text = "";
            }
            if (lblErrMsg.Text.Length < 1)
                return true;
            else
                return false;
        }

        Boolean UserValidation(TextBox t1)
        {
            if (t1.Name == "txtUsrnm")
            {
                try
                {
                    string[] str = t1.Text.ToString().Split('@');
                    char[] emlPart1 = str[0].ToCharArray();
                    int contEmlFrstPart = 0;
                    for (int x = 0; x < emlPart1.Length; x++)
                    {
                        if (((int)emlPart1[x] >= 65 && (int)emlPart1[x] <= 90) || ((int)emlPart1[x] >= 97 && (int)emlPart1[x] <= 122) || ((int)emlPart1[x] >= 48 && (int)emlPart1[x] <= 57))
                        {
                            contEmlFrstPart++;
                        }
                    }
                    if ((contEmlFrstPart == emlPart1.Length && str[1] == "gmail.com") || (contEmlFrstPart == emlPart1.Length && str[1] == "yahoo.com"))
                    {
                        lblErrMsg.Text = "";
                    }
                    else
                    {
                        lblErrMsg.Text = "Email Invalid";
                    }
                }
                catch (Exception e)
                {
                    lblErrMsg.Text = "Email Invalid";
                }
            }
            if (lblErrMsg.Text.Length < 1)
                return true;
            else
                return false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnNxt_Click(object sender, EventArgs e)
        {
            if (txtUsrnm.Text.Length >= 1)
            {

                QRY = "SELECT usrQstnAnsr,usrPasswrd FROM tblLoginMaster WHERE usrNme ='" + txtUsrnm.Text.ToString() + "' AND usrScurtyQstn='" + txtQstn.Text + "' AND usrLognIsAct = 'TRUE'";
                CNN = new SqlConnection(Connection.cnstr);
                CNN.Open();
                CMD = new SqlCommand(QRY, CNN);
                DR = CMD.ExecuteReader();
                if (DR.Read())
                {
                    if (DR[0].ToString() == txtAnsr.Text.ToString())
                    {
                        ClearControls();
                        lblErrMsg.Text = "";
                        MessageBox.Show("Dear " + txtUsrnm.Text.ToString() + " Your Password Is " + DR[1].ToString());
                        pnlLogin.Enabled = false;
                        txtUsrnm.ReadOnly = false;
                        txtPasswrd.Enabled = true;
                        btnLogin.Enabled = true;
                    }
                    else lblErrMsg.Text = " * Please Enter Valid Answer";
                }
                else
                {
                    lblErrMsg.Text = " * Please Enter Valid Username";
                }
                CNN.Close();
                CNN.Dispose();
                CMD.Dispose();
            }
            else
                lblErrMsg.Text = " * Please Enter Valid Username";
        }     
    }
}

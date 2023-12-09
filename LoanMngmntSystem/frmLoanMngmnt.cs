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
    public partial class frmLoanMngmnt : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        string QRY="";
        public frmLoanMngmnt()
        {
            InitializeComponent();
        }

        private void frmLoanMngmnt_Load(object sender, EventArgs e)
        {
            DisableControls();
        }

        private void txtLnMxAmntRt_Enter(object s, EventArgs e)
        {
            ((TextBox)s).BackColor = Color.LightGoldenrodYellow;
            ((TextBox)s).ForeColor = Color.Teal;
        }

        private void txtLnMxAmntRt_Leave(object s, EventArgs e)
        {
            ((TextBox)s).BackColor = Color.White;
            ((TextBox)s).ForeColor = Color.Black;
        }

        private void cmbxLnNme_Enter(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            c.BackColor = Color.LightGoldenrodYellow;
            c.ForeColor = Color.Teal;
        }

        private void cmbxLnNme_Leave(object sender, EventArgs e)
        {
              ComboBox c = (ComboBox)sender;
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
        }
       
        private void btnCncl_Click(object sender, EventArgs e)
        {
            ClearControls();
            DisableControls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD")
            {
                    btnAdd.Text = "SAVE";
                    btnEdt.Enabled = false;
                    btnDlt.Enabled = false;
                    Clear();
                    EnableControls();
                    LoadLoan();
            }
            else
            {
               if(cmbxLnNme.SelectedIndex>=1)
               {
                   if (ValidateControls())
                   {
                           QRY = "UPDATE tblLoanMaster SET lnIntrstRt=" + txtLnIntsrRt.Text + ",lnMaxAmntRt=" + txtLnMxAmntRt.Text + ",lnInsrRt=" + txtLnInsrRt.Text + ",lnIsAct='TRUE' ";
                           QRY += "WHERE lnName='" + cmbxLnNme.SelectedItem.ToString() + "'";
                           Connection.AddUpdtDltOprtns(QRY);
                           MessageBox.Show("Loan Added Successfully", "Fantastic Financial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           btnAdd.Text = "ADD";
                           Clear();
                           DisableControls();
                           btnEdt.Enabled = true;
                           btnDlt.Enabled = true;
                   }
                }
               else
                   lblErrMsg.Text = " * Please Select Valid Loan Name";
            }
        }

        private void btnEdt_Click(object sender, EventArgs e)
        {
            if (btnEdt.Text == "EDIT")
            {
                btnEdt.Text = "UPDATE";
                btnAdd.Enabled = false;
                btnDlt.Enabled = false;
                Clear();
                EnableControls();
                LoadLoan();
            }
            else
            {
                if (cmbxLnNme.SelectedIndex >= 1)
                {
                    if (ValidateControls())
                    {
                            QRY = "UPDATE tblLoanMaster SET lnIntrstRt=" + txtLnIntsrRt.Text + ",lnMaxAmntRt=" + txtLnMxAmntRt.Text + ",lnInsrRt=" + txtLnInsrRt.Text + " ";
                            QRY += "WHERE lnName='" + cmbxLnNme.SelectedItem.ToString() + "'";
                            Connection.AddUpdtDltOprtns(QRY);
                            MessageBox.Show("Loan's Details Updated Successfully", "Fantastic Financial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            DisableControls();
                            btnEdt.Text = "EDIT";
                            btnAdd.Enabled = true;
                            btnDlt.Enabled = true;
                    }
                }
                else
                    lblErrMsg.Text = " * Please Select Valid Loan Name";
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (btnDlt.Text == "REMOVE")
            {
                btnDlt.Text = "DELETE";
                btnAdd.Enabled = false;
                btnEdt.Enabled = false;
                Clear();
                DisableControls();
                cmbxLnNme.Enabled = true;
                LoadLoan();
            }
            else
            {
                if (cmbxLnNme.SelectedIndex >= 1)
                {
                        QRY = "UPDATE tblLoanMaster SET lnIntrstRt=0,lnMaxAmntRt=0,lnInsrRt=0,lnIsAct='FALSE' ";
                        QRY += "WHERE lnName='" + cmbxLnNme.SelectedItem.ToString() + "'";
                        Connection.AddUpdtDltOprtns(QRY);
                        MessageBox.Show("Loan Removed Successfully", "Fantastic Financial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        DisableControls();
                        btnDlt.Text = "REMOVE";
                        btnAdd.Enabled = true;
                        btnEdt.Enabled = true;
                }
                else
                    lblErrMsg.Text = " * Please Select Valid Loan Name";
            }
        }

        private void cmbxLnNme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxLnNme.SelectedIndex >= 1)
            {
                if (btnEdt.Enabled == true || btnAdd.Enabled == true)
                {
                    txtLnInsrRt.Enabled = true;
                    txtLnIntsrRt.Enabled = true;
                    txtLnMxAmntRt.Enabled = true;
                    if (btnEdt.Enabled == true)
                        BindControls();
                }
            }
            else
            {
                Clear();
                txtLnInsrRt.Enabled = false;
                txtLnIntsrRt.Enabled = false;
                txtLnMxAmntRt.Enabled = false;
            }
        }
        void ClearControls()
        {
            txtLnInsrRt.Clear();
            txtLnIntsrRt.Clear();
            txtLnMxAmntRt.Clear();
            if (cmbxLnNme.Items.Count >= 1)
            {
                cmbxLnNme.SelectedIndex = 0;
            }
            lblErrMsg.Text = "";
            btnAdd.Enabled = true; 
            btnEdt.Enabled = true;
            btnDlt.Enabled = true;
            btnAdd.Text = "ADD";
            btnEdt.Text = "EDIT";
            btnDlt.Text = "REMOVE";
        }
        void Clear()
        {
            txtLnInsrRt.Clear();
            txtLnIntsrRt.Clear();
            txtLnMxAmntRt.Clear();
            lblErrMsg.Text = "";
            if (cmbxLnNme.Items.Count >= 1)
            {
                cmbxLnNme.SelectedIndex = 0;
            }
        }
        void EnableControls()
        {
            cmbxLnNme.Enabled = true;
            txtLnInsrRt.Enabled = true;
            txtLnIntsrRt.Enabled = true;
            txtLnMxAmntRt.Enabled = true;
        }
        void DisableControls()
        {
            cmbxLnNme.Enabled = false;
            txtLnInsrRt.Enabled = false;
            txtLnIntsrRt.Enabled = false;
            txtLnMxAmntRt.Enabled = false;
        }
        void LoadLoan()
        {
            if (btnAdd.Text == "SAVE")

                QRY = "SELECT lnName FROM tblLoanMaster WHERE lnId>0 AND lnIsAct='FALSE'";
            else
            {
                QRY = "SELECT lnName,lnIntrstRt,lnMaxAmntRt,lnInsrRt FROM tblLoanMaster WHERE lnId>0 AND lnIsAct='TRUE'";
            }
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(QRY, cn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            cn.Close();
            cmbxLnNme.Items.Clear();
            cmbxLnNme.Items.Add("-- Select Loan --");
            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                cmbxLnNme.Items.Add(ds.Tables[0].Rows[x][0].ToString());
            }
            cmbxLnNme.SelectedIndex = 0;
            cn.Dispose();
            cmd.Dispose();
            da.Dispose();
            ds.Dispose();
        }
        void BindControls()
        {
            QRY = "SELECT lnIntrstRt,lnMaxAmntRt,lnInsrRt FROM tblLoanMaster WHERE lnId>0 AND lnName='"+cmbxLnNme.SelectedItem.ToString()+"' AND lnIsAct='TRUE'";
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(QRY, cn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            cn.Close();
            cn.Dispose();
            cmd.Dispose();
            da.Dispose();
            txtLnIntsrRt.Text = ds.Tables[0].Rows[0][0].ToString();
            txtLnMxAmntRt.Text = ds.Tables[0].Rows[0][1].ToString();
            txtLnInsrRt.Text = ds.Tables[0].Rows[0][2].ToString();
            ds.Dispose();
        }
        Boolean ValidateControls()
        {
            if (btnAdd.Enabled == true || btnEdt.Enabled==true)
            {
                if (txtLnIntsrRt.Text.Length < 1)
                    lblErrMsg.Text = " * Please Enter Valid Loan Interest Rate Or Select Valid Loan";
                else if (ValidateTextBox(txtLnIntsrRt))
                    lblErrMsg.Text = " * Please Enter Valid Loan Interest Rate Or Select Valid Loan";
                else if (txtLnMxAmntRt.Text.Length < 1)
                    lblErrMsg.Text = " * Please Enter Valid Loan Maximum Amount Rate Or Select Valid Loan";
                else if (ValidateTextBox(txtLnMxAmntRt))
                    lblErrMsg.Text = " * Please Enter Valid Loan Maximum Amount Rate Or Select Valid Loan";
                else if (txtLnInsrRt.Text.Length < 1)
                    lblErrMsg.Text = " * Please Enter Valid Loan Insurance Rate Or Select Valid Loan";
                else if (ValidateTextBox(txtLnInsrRt))
                    lblErrMsg.Text = " * Please Enter Valid Loan Insurance Rate Or Select Valid Loan";
                else
                    lblErrMsg.Text = "";
            }
            if (lblErrMsg.Text.Length < 1)
                return true;
            else
                return false;
        }
        Boolean ValidateTextBox(TextBox t)
        {
            try
            {
                if (int.Parse(t.Text.ToString()) >= 1 && int.Parse(t.Text.ToString()) < 100)
                    lblErrMsg.Text = "";
                else
                    lblErrMsg.Text = "Error";
            }  
            catch (Exception e)
            {
                lblErrMsg.Text = "Error";
            }
            if (lblErrMsg.Text.Length >= 1)
                return true;
            else
                return false;
        }
    }
}
 
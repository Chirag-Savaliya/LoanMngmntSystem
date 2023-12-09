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
    public partial class frmLoanApprvl : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        string QRY = "";
        void LoadCustomersAndLoans()
        {
            QRY = "SELECT c.cstmrId,l.lnName FROM tblCstmrPrsnlDtls c,tblLoanMaster l WHERE c.cstmrId>0 AND c.cstmrIsAct='TRUE' AND l.lnIsAct='TRUE'";
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(QRY, cn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            cn.Close();
            cmbxCstmrId.Items.Clear();
            cmbxLnnm.Items.Clear();
            cmbxCstmrId.Items.Add("-- Select Customer Id --");
            cmbxLnnm.Items.Add("-- Select Loan --");
            for (int y = 0; y <= 1; y++)
            {
                for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                {
                    try
                    {
                        if (int.Parse(ds.Tables[0].Rows[x][y].ToString()) >= 1)
                        {
                            if (!cmbxCstmrId.Items.Contains(ds.Tables[0].Rows[x][y].ToString()))
                                cmbxCstmrId.Items.Add(ds.Tables[0].Rows[x][y].ToString());
                        }
                    }
                    catch (Exception e)
                    {
                        if (!cmbxLnnm.Items.Contains(ds.Tables[0].Rows[x][y].ToString()))
                            cmbxLnnm.Items.Add(ds.Tables[0].Rows[x][y].ToString());
                    }
                }
            }
            cn.Dispose();
            cmd.Dispose();
            da.Dispose();
            ds.Dispose();
            cmbxLnnm.SelectedIndex = 0;
            cmbxCstmrId.SelectedIndex = 0;
        }
        void LoadLoansAndTypes()
        {
            QRY = "SELECT * FROM tblLoanApprvlMaster WHERE cstmrId=" + cmbxCstmrId.SelectedItem.ToString() + " AND lnApprvlIsAct='TRUE'";
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(QRY, cn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            cn.Close();
            cmbxLnnm.Items.Clear();
            cmbxLnnm.Items.Add("-- Select Loan--");
            cmbxLnTyp.Items.Clear();
            cmbxLnTyp.Items.Add("-- Select Type Of Loan--");
            if (ds.Tables[0].Rows.Count >= 1)
            {
                cmbxLnnm.Items.Add("Home Loan");
                cmbxLnnm.Items.Add("Gold Loan");
                cmbxLnTyp.Items.Add("Mortgage Loan");
                cmbxLnTyp.SelectedIndex = 0;
                cmbxLnnm.SelectedIndex = 0;
            }
            else
            {
                QRY = "SELECT lnName FROM tblLoanMaster WHERE lnIsAct='TRUE'";
                cn = new SqlConnection(Connection.cnstr);
                cn.Open();
                cmd = new SqlCommand(QRY, cn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                cn.Close();
                for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                {
                    cmbxLnnm.Items.Add(ds.Tables[0].Rows[x][0].ToString());
                }
                cmbxLnnm.SelectedIndex = 0;
                cmbxLnTyp.Items.Add("Mortgage Loan");
                cmbxLnTyp.Items.Add("Non Mortgage Loan");
                cmbxLnnm.SelectedIndex = 0;
                cmbxLnTyp.SelectedIndex = 0;
            }
        }
        void ResetControls()
        {
            cmbxCstmrId.SelectedIndex = 0;
            cmbxLnnm.SelectedIndex = 0;
            cmbxLnTyp.SelectedIndex = 0;
            txtAdhrNo.Clear();
            txtIncmVltnAmnt.Clear();
            txtLnActlAmnt.Clear();
            txtLnAmnt.Clear();
            txtLnInsrAmnt.Clear();
            txtLnInsrRt.Clear();
            txtLnMaxAmnt.Clear();
            txtLnMaxAmntRt.Clear();
            txtPanNo.Clear();
            txtLnIntrstRt.Clear();
            txtAdhrNo.ReadOnly = false;
            txtPanNo.ReadOnly = false;
            txtIncmVltnAmnt.ReadOnly = false;
            txtLnAmnt.ReadOnly = true;
            lblError.Text = "";
        }
        Boolean ValidateControls()
        {
            if (cmbxCstmrId.SelectedIndex == 0)
                lblError.Text = " * Please Select Valid Customer Id";
            else if (cmbxLnnm.SelectedIndex == 0)
                lblError.Text = " * Please Select Valid Loan Name";
            else if (cmbxLnTyp.SelectedIndex == 0)
                lblError.Text = " * Please Select Valid Loan Type";
            else if (txtAdhrNo.Text.Length < 16)
                lblError.Text = " * Please Enter Valid Aadhar No (Aadhar No Must Be 16 Digits And You Can Only Insert 0-9)";
            else if (txtPanNo.Text.Length < 10)
                lblError.Text = " * Please Enter Valid Pan No (Pan No Must Be 10 Digits And You Can Only Insert 0-9 And A-Z)";
            else if (txtIncmVltnAmnt.Text.Length < 1)
                lblError.Text = " * Please Enter Valid Income Or Valuation Amount";
            else if (ValidateTextBoxes(txtIncmVltnAmnt))
                lblError.Text = " * Please Enter Valid Income Or Valuation Amount ( Income Or Valuation Amount Must Greater Or Equal To 50,000 You Can Only Insert 0-9 )";
            else if (txtLnAmnt.Text.Length < 1)
                lblError.Text = " * Please Enter Valid Loan Amount";
            else if (ValidateTextBoxes(txtLnAmnt))
                lblError.Text = " * Please Enter Valid Loan Amount.Loan Amount Must Greater Than 5000 And Less Than Maximum Loan Amount Can Be Approved";
            else if (txtLnInsrAmnt.Text.Length < 1)
                lblError.Text = " * Please Enter Valid Loan Insurance Amount";
            else if (txtLnMaxAmnt.Text.Length < 1)
                lblError.Text = " * Please Enter Valid Loan Maximum Amount";

            else if (txtLnActlAmnt.Text.Length < 1)
                lblError.Text = " * Please Enter Valid Loan Actual Amount";
            else if (ValidateTextBoxes(txtAdhrNo))
                lblError.Text = " * Please Enter Valid Aadhar No (Aadhar No Must Be 16 Digits And You Can Only Insert 0-9)";
            else if (ValidateTextBoxes(txtPanNo))
                lblError.Text = " Please Enter Valid Pan No (Pan No Must Be 10 Digits And You Can Only Insert 0-9 And A-Z)";
            else if (ValidateTextBoxes(txtLnAmnt))
                lblError.Text = " * Please Enter Valid Loan Amount";
            else
                lblError.Text = "";

            if (lblError.Text.Length < 1)
                return true;
            else
                return false;
        }
        Boolean ValidateTextBoxes(TextBox t)
        {
            char[] var = t.Text.ToString().ToCharArray();
            int count = 0;
            if (t.Name == "txtIncmVltnAmnt")
            {
                try
                {
                    for (int x = 0; x < var.Length; x++)
                    {
                        if ((int)var[x] >= 48 && (int)var[x] <= 57)
                            count++;
                    }
                    if (count == var.Length && int.Parse(txtIncmVltnAmnt.Text.ToString()) >= 50000)
                        lblError.Text = "";
                    else
                        lblError.Text = "Error";
                }
                catch (Exception E)
                {
                    lblError.Text = "";
                }
            }
            else if (t.Name == "txtLnAmnt")
            {
                try
                {
                    for (int x = 0; x < var.Length; x++)
                    {
                        if ((int)var[x] >= 48 && (int)var[x] <= 57)
                            count++;
                    }
                    if (count == var.Length && int.Parse(txtLnAmnt.Text.ToString()) <= int.Parse(txtLnMaxAmnt.Text.ToString()) && int.Parse(txtLnAmnt.Text.ToString())>5000)
                        lblError.Text = "";
                    else
                        lblError.Text = "Error";
                }
                catch (Exception E)
                {
                    lblError.Text = "";
                }
            }
            else if (t.Name == "txtAdhrNo")
            {
                for (int x = 0; x < var.Length; x++)
                {
                    if ((int)var[x] >= 48 && (int)var[x] <= 57)
                        count++;
                }
                if (count == var.Length)
                    lblError.Text = "";
                else
                    lblError.Text = "Error";
            }
            else if (t.Name == "txtPanNo")
            {
                for (int x = 0; x < var.Length; x++)
                {
                    if (((int)var[x] >= 48 && (int)var[x] <= 57) || ((int)var[x] >= 65 && (int)var[x] <= 90))
                        count++;
                    if (count == var.Length)
                        lblError.Text = "";
                    else
                        lblError.Text = "Error";
                }
            }
            else
                lblError.Text = "";

            if (lblError.Text.Length >= 1)
                return true;
            else
                return false;
        }
        public frmLoanApprvl()
        {
            InitializeComponent();
        }

        private void txt_Enter(object s, EventArgs e)
        {
            ((TextBox)s).BackColor = Color.LightGoldenrodYellow;
            ((TextBox)s).ForeColor = Color.Teal;
        }

        private void txt_Leave(object s, EventArgs e)
        {
            ((TextBox)s).BackColor = Color.White;
            ((TextBox)s).ForeColor = Color.Black;
        }

        private void Cmbx_Enter(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            c.BackColor = Color.LightGoldenrodYellow;
            c.ForeColor = Color.Teal;
        }

        private void Cmbx_Leave(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
        }

        private void frmLoanApprvl_Load(object sender, EventArgs e)
        {
            txtLnAprvlDt.Text = System.DateTime.Today.Date.ToShortDateString();
            cmbxLnTyp.SelectedIndex = 0;
            LoadCustomersAndLoans();
        }

        private void cmbxLnnm_SelectedIndexChanged(object sender, EventArgs e)
        {
            QRY = "SELECT lnIntrstRt,lnMaxAmntRt,lnInsrRt FROM tblLoanMaster WHERE lnId>0 AND lnName='" + cmbxLnnm.SelectedItem.ToString() + "' AND lnIsAct='TRUE'";
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(QRY, cn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            cn.Close();
            if (cmbxLnnm.SelectedIndex >= 1)
            {
                txtLnIntrstRt.Text = ds.Tables[0].Rows[0][0].ToString();
                txtLnMaxAmntRt.Text = ds.Tables[0].Rows[0][1].ToString();
                txtLnInsrRt.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            cn.Dispose();
            cmd.Dispose();
            da.Dispose();
            ds.Dispose();
        }

        private void btnLnApprv_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                QRY = "INSERT INTO tblLoanApprvlMaster VALUES((SELECT MAX(tblLnApprvlId) FROM tblLoanApprvlMaster)+1,";
                QRY += "" + cmbxCstmrId.SelectedItem.ToString() + ",";
                QRY += "" + txtLnIntrstRt.Text.ToString() + ",";
                QRY += "" + txtLnInsrRt.Text + ",";
                QRY += "" + txtLnMaxAmntRt.Text + ",";
                QRY += "'" + cmbxLnnm.SelectedItem.ToString() + "',";
                QRY += "'" + cmbxLnTyp.SelectedItem.ToString() + "',";
                QRY += "" + txtIncmVltnAmnt.Text + ",";
                QRY += "" + txtLnMaxAmnt.Text + ",";
                QRY += "" + txtLnAmnt.Text.ToString() + ",";
                QRY += "" + txtLnInsrAmnt.Text.ToString() + ",";
                QRY += "" + txtLnActlAmnt.Text.ToString() + ",";
                QRY += "'" + txtLnAprvlDt.Text.ToString() + "',";
                QRY += "'" + txtAdhrNo.Text.ToString() + "',";
                QRY += "'" + txtPanNo.Text.ToString() + "',";
                QRY += "'TRUE')";
                Connection.AddUpdtDltOprtns(QRY);
                cn = new SqlConnection(Connection.cnstr);
                QRY = "SELECT MAX(tblLnApprvlId) FROM tblLoanApprvlMaster WHERE cstmrId=" + cmbxCstmrId.SelectedItem.ToString() + " AND ";
                QRY += "lnName='" + cmbxLnnm.SelectedItem.ToString() + "' AND lnApprvlDt='" + txtLnAprvlDt.Text + "' AND ";
                QRY += "lnApprvlIsAct='TRUE'";
                cn.Open();
                cmd = new SqlCommand(QRY, cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                cn.Close();

                QRY = "INSERT INTO tblLoanInstlmntDtMaster VALUES((SELECT MAX(tblInstlmntDtId) FROM tblLoanInstlmntDtMaster)+1,";
                QRY += ""+ds.Tables[0].Rows[0][0].ToString()+",";
                QRY += "" + cmbxCstmrId.SelectedItem.ToString() + ",";
                QRY += "'" + DateTime.Now.AddDays(30).ToShortDateString() + "',";
                QRY += "'TRUE')";
                Connection.AddUpdtDltOprtns(QRY);
                MessageBox.Show("Loan Approved Successfully", "Fantastic Financial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControls();
            }
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void txtIncmVltnAmnt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtLnMaxAmnt.Text = (int.Parse(txtIncmVltnAmnt.Text.ToString()) * int.Parse(txtLnMaxAmntRt.Text.ToString()) / 100).ToString();
                txtLnAmnt.ReadOnly = false;
            }
            catch (Exception e1)
            {
            }
        }

        private void txtLnAmnt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtLnInsrAmnt.Text = (int.Parse(txtLnAmnt.Text.ToString()) * int.Parse(txtLnInsrRt.Text.ToString()) / 100).ToString();
                txtLnActlAmnt.Text = (int.Parse(txtLnAmnt.Text.ToString()) + int.Parse(txtLnInsrAmnt.Text.ToString())).ToString();
            }
            catch (Exception e2)
            {
            }
        }

        private void cmbxCstmrId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxCstmrId.SelectedIndex >= 1)
            {
                LoadLoansAndTypes();
                QRY = "SELECT cstmrAdhrNo,cstmrPanNo FROM tblLoanApprvlMaster WHERE cstmrId=" + cmbxCstmrId.SelectedIndex.ToString() + "";
                cn = new SqlConnection(Connection.cnstr);
                cn.Open();
                cmd = new SqlCommand(QRY, cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                cn.Close();
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    txtAdhrNo.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtPanNo.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtAdhrNo.ReadOnly = true;
                    txtPanNo.ReadOnly = true;
                }
                else
                {
                    txtAdhrNo.Clear();
                    txtPanNo.Clear();
                    txtAdhrNo.ReadOnly = false;
                    txtPanNo.ReadOnly = false;
                }
            }
        }
    }
}
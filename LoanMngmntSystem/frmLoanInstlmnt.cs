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
    public partial class frmLoanInstlmnt : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        string QRY = "";
        public frmLoanInstlmnt()
        {
            InitializeComponent();
        }

        private void frmLoanInstlmnt_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        void LoadCustomers()
        {
            cmbxCstmrId.Items.Clear();
            cmbxCstmrId.Items.Add("-- Select Customer Id --");
            QRY = "SELECT DISTINCT(cstmrId) FROM tblLoanApprvlMaster WHERE lnApprvlIsAct='TRUE'";
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(QRY, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            if (ds.Tables[0].Rows.Count >= 1)
            {
                for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                    cmbxCstmrId.Items.Add(ds.Tables[0].Rows[x][0].ToString());
            }
            cmbxCstmrId.SelectedIndex = 0;
        }
        void LoadLoanDetails()
        {
            QRY = "SELECT lnType,lnApprvlDt,lnAmnt,lnInsrAmnt,lnActlAmnt,lnIntrstRt FROM tblLoanApprvlMaster WHERE tblLnApprvlId=" + cmbxLoanId.SelectedItem.ToString() + " AND lnApprvlIsAct='TRUE'";
                cn = new SqlConnection(Connection.cnstr);
                cn.Open();
                cmd = new SqlCommand(QRY, cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                cn.Close();
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    txtLoanTyp.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtLnAprvlDt.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtLoanAmnt.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtLnInsrAmnt.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtLnActlAmnt.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtRmngLnActulAmnt.Text = txtLnActlAmnt.Text.ToString();
                    txtIntrstRt.Text = ds.Tables[0].Rows[0][5].ToString(); 
                }
        }
        void SetLoanInstallmentDate()
        {
            if (cmbxCstmrId.SelectedIndex >= 1 && cmbxLoanId.SelectedIndex >= 1)
            {
                QRY = "SELECT lnRmngActlAmnt,lnInstlmntDt FROM tblLoanInstlmntMaster WHERE tblLnInstlmntId=(SELECT MAX(tblLnInstlmntId) FROM tblLoanInstlmntMaster ";
                QRY += "WHERE lnApprvlId=" + cmbxLoanId.SelectedItem.ToString() + " AND cstmrId=" + cmbxCstmrId.SelectedItem.ToString() + " AND lnInstlmntIsAct='TRUE')";
                cn = new SqlConnection(Connection.cnstr);
                cn.Open();
                cmd = new SqlCommand(QRY, cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                cn.Close();
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    try
                    {
                        if (int.Parse(ds.Tables[0].Rows[0][0].ToString()) >= 1)
                        {
                            txtRmngLnActulAmnt.Text = ds.Tables[0].Rows[0][0].ToString();
                            string[] date = ds.Tables[0].Rows[0][1].ToString().Split('/');
                            DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[0]), int.Parse(date[1]));
                            txtInstlmntDt.Text = dt.AddDays(30).ToShortDateString();
                        }
                        else
                        {
                            MessageBox.Show("Your All Loan Installments Are Finished", "Fantastic Financial",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QRY = "UPDATE tblLoanApprvlMaster SET lnApprvlIsAct='FALSE' WHERE cstmrId="+cmbxCstmrId.SelectedItem.ToString()+" ";
                            QRY += "AND tblLnApprvlId="+cmbxLoanId.SelectedItem.ToString()+"";
                            Connection.AddUpdtDltOprtns(QRY);
                            QRY = "UPDATE tblLoanInstlmntDtMaster SET lnInstlmntDtIsAct='FALSE' WHERE cstmrId=" + cmbxCstmrId.SelectedItem.ToString() + " ";
                            QRY += "AND lnApprvlId=" + cmbxLoanId.SelectedItem.ToString() + "";
                            Connection.AddUpdtDltOprtns(QRY);

                            QRY = "UPDATE tblLoanInstlmntMaster SET lnInstlmntIsAct='FALSE' WHERE cstmrId=" + cmbxCstmrId.SelectedItem.ToString() + " ";
                            QRY += "AND lnApprvlId=" + cmbxLoanId.SelectedItem.ToString() + "";
                            Connection.AddUpdtDltOprtns(QRY);
                            ResetControls();
                            LoadCustomers();
                        }
                    }
                    catch (Exception inst)
                    {
                    }
                }
                else
                {
                    QRY = "SELECT lnInstlmntDt FROM tblLoanInstlmntDtMaster WHERE lnApprvlId=" + cmbxLoanId.SelectedItem.ToString() + " ";
                    QRY += "AND cstmrId=" + cmbxCstmrId.SelectedItem.ToString() + " ";
                    QRY += "AND lnInstlmntDtIsAct='TRUE'";
                    cn.Open();
                    cmd = new SqlCommand(QRY, cn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    cn.Close();
                    if (ds.Tables[0].Rows.Count >= 1)
                      txtInstlmntDt.Text = ds.Tables[0].Rows[0][0].ToString();
                }
            }
        }
        void ResetControls()
        {
            txtLoanTyp.Clear();
            txtLnAprvlDt.Clear();
            txtLoanAmnt.Clear();
            txtLnInsrAmnt.Clear();
            txtLnActlAmnt.Clear();
            txtInstlmntDt.Clear();
            txtRmngLnActulAmnt.Clear();
            txtIntrstRt.Clear();
            txtActlInrstDys.Clear();
            txtLatIntrstDys.Clear();
            txtTtlDys.Clear();
            txtCurrntDt.Clear();
            lblError.Text = "";
            txtLnIntrstAmnt.Clear();
            txtChrgAmnt.Clear();
            txtMnmInstlmntAmnt.Clear();
            txtLoanInstlmntAmnt.Clear();
            txtLoanPrncplAmnt.Clear();
            txtTtlInstlmntAmnt.Clear();
        }
        void ReSetInstlmntControls()
        {
            txtLnIntrstAmnt.Clear();
            txtChrgAmnt.Clear();
            txtMnmInstlmntAmnt.Clear();
            txtLoanInstlmntAmnt.Clear();
            txtLoanPrncplAmnt.Clear();
            txtTtlInstlmntAmnt.Clear();
            txtActlInrstDys.Clear();
            txtLatIntrstDys.Clear();
            txtTtlDys.Clear();
        }
        Boolean ChkCurrntDate()
        {
            if (txtCurrntDt.Text.Length < 1)
                lblError.Text = " * Please Enter Valid Current Date";
            else if(ChkDate(txtCurrntDt))
                lblError.Text=" * Please Enter Valid Value For Current Date";
            else
                lblError.Text="";

            if(lblError.Text.Length>=1)
                return false;
            else
                return true;
        }
        Boolean ChkDate(TextBox t)
        {
            try
            {
                string[] dt = t.Text.ToString().Split('/');
                if ((int.Parse(dt[0]) > 0 && int.Parse(dt[0]) < 13) && (int.Parse(dt[1]) > 0 && int.Parse(dt[1]) < 32) && (int.Parse(dt[2]) >= int.Parse(System.DateTime.Today.Year.ToString())))
                {
                    lblError.Text = "";
                }
                else
                    lblError.Text = "Error";
            }
            catch (Exception e)
            {
                lblError.Text="Error";
                btnAcptInstlmnt.Enabled = false;
            }
            if(lblError.Text.Length<1)
                return false;
            else
                return true;
        }
        void CmprCurrntDtInstlmntDt(DateTime CrntDt,DateTime InstlmntDt)
        {
            if (System.DateTime.Compare(CrntDt, InstlmntDt) == 0)
            {
                txtLoanInstlmntAmnt.ReadOnly = false;
                txtActlInrstDys.Text = "30";
                txtLatIntrstDys.Text = "0";
                txtChrgAmnt.Clear();
                txtTtlDys.Text = (int.Parse(txtActlInrstDys.Text.ToString()) + int.Parse(txtLatIntrstDys.Text.ToString())).ToString();
                txtChrgAmnt.Text = "0";
                txtLnIntrstAmnt.Text = ((int.Parse(txtRmngLnActulAmnt.Text.ToString()) * int.Parse(txtIntrstRt.Text.ToString()) * int.Parse(txtTtlDys.Text.ToString()))/(100*365)).ToString();
                txtMnmInstlmntAmnt.Text=(int.Parse(txtLnIntrstAmnt.Text.ToString())+int.Parse(txtChrgAmnt.Text.ToString())).ToString();
            }
            else if (System.DateTime.Compare(CrntDt, InstlmntDt) == 1)
            {
                txtLoanInstlmntAmnt.ReadOnly = false;
                txtActlInrstDys.Text = "30";
                int x = 1;
                do
                {
                    if (CrntDt.CompareTo(InstlmntDt.AddDays(x)) == 0)
                    {
                        txtLatIntrstDys.Text = (x).ToString();
                        break;
                    }
                    else
                        x++;
                }
                while (true);
                txtTtlDys.Text = (int.Parse(txtActlInrstDys.Text.ToString()) + int.Parse(txtLatIntrstDys.Text.ToString())).ToString();
                SetChargeAmount();
                txtLnIntrstAmnt.Text = ((int.Parse(txtRmngLnActulAmnt.Text.ToString()) * int.Parse(txtIntrstRt.Text.ToString()) * int.Parse(txtTtlDys.Text.ToString())) / (100 * 365)).ToString();
                txtMnmInstlmntAmnt.Text = (int.Parse(txtLnIntrstAmnt.Text.ToString()) + int.Parse(txtChrgAmnt.Text.ToString())).ToString();
            }
            else
            {
                ReSetInstlmntControls();
                txtLoanInstlmntAmnt.ReadOnly = true;
                lblError.Text="You Can Not Pay Installment Brfore Installment Date";
            }
        }
        void SetChargeAmount()
        {
            txtChrgAmnt.Text = (int.Parse(txtLatIntrstDys.Text.ToString()) * 10).ToString();
        }
        private void cmbxCstmrId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxLnnm.Items.Clear();
            cmbxLnnm.Items.Add("-- Select Loan --");
            if (cmbxCstmrId.SelectedIndex >= 1)
            {
                QRY = "SELECT DISTINCT(lnName) FROM tblLoanApprvlMaster WHERE cstmrId=" + cmbxCstmrId.SelectedItem.ToString() + " AND lnApprvlIsAct='TRUE'";
                cn = new SqlConnection(Connection.cnstr);
                cn.Open();
                cmd = new SqlCommand(QRY, cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                cn.Close();
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                        cmbxLnnm.Items.Add(ds.Tables[0].Rows[x][0].ToString());
                }
                cmbxLnnm.SelectedIndex = 0;
            }
            else
            {
                ResetControls();
                cmbxLnnm.SelectedIndex = 0;
                cmbxLoanId.SelectedIndex = 0;
            }
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

        private void Txt_Enter(object s, EventArgs e)
        {
            ((TextBox)s).BackColor = Color.LightGoldenrodYellow;
            ((TextBox)s).ForeColor = Color.Teal;
        }

        private void Txt_Leve(object s, EventArgs e)
        {
            ((TextBox)s).BackColor = Color.White;
            ((TextBox)s).ForeColor = Color.Black;
        }

        private void cmbxLnnm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxLoanId.Items.Clear();
            cmbxLoanId.Items.Add("-- Select Loan Id --");
            if (cmbxLnnm.SelectedIndex >= 1)
            {
                QRY = "SELECT tblLnApprvlId FROM tblLoanApprvlMaster WHERE cstmrId=" + cmbxCstmrId.SelectedItem.ToString() + " AND lnName='" + cmbxLnnm.SelectedItem.ToString() + "' AND lnApprvlIsAct='TRUE'";
                cn = new SqlConnection(Connection.cnstr);
                cn.Open();
                cmd = new SqlCommand(QRY, cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                cn.Close();
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                        cmbxLoanId.Items.Add(ds.Tables[0].Rows[x][0].ToString());
                }
            }
            else
            {
                ResetControls();
                cmbxLoanId.SelectedIndex = 0;
            }
            cmbxLoanId.SelectedIndex = 0;
        }

        private void cmbxLoanId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCurrntDt.Clear();
            ReSetInstlmntControls();
            lblError.Text = "";
            if (cmbxLoanId.SelectedIndex >= 1 && cmbxLnnm.SelectedIndex>=1 && cmbxCstmrId.SelectedIndex>=1)
            {
                LoadLoanDetails();
                SetLoanInstallmentDate();
            }
            else
                ResetControls();
        }

        private void txtCurrntDt_TextChanged(object sender, EventArgs e)
        {
            if (txtCurrntDt.Text.Length >= 1)
            {
                if (ChkCurrntDate())
                {
                    ReSetInstlmntControls();
                    lblError.Text = "";
                    string[] cd = txtCurrntDt.Text.ToString().Split('/');
                    string[] id = txtInstlmntDt.Text.ToString().Split('/');
                    DateTime CrntDt = new DateTime(int.Parse(cd[2]), int.Parse(cd[0]), int.Parse(cd[1]));
                    DateTime InstlmntDt = new DateTime(int.Parse(id[2]), int.Parse(id[0]), int.Parse(id[1]));
                    CmprCurrntDtInstlmntDt(CrntDt, InstlmntDt);
                }
                else
                {
                    ReSetInstlmntControls();
                    txtLoanInstlmntAmnt.ReadOnly = true;
                    btnAcptInstlmnt.Enabled = false;
                }
            }
            else
                lblError.Text = "";
        }

        private void txtLoanInstlmntAmnt_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (txtLoanInstlmntAmnt.Text.Length >= 1)
            {
                try
                {
                    if (int.Parse(txtLoanInstlmntAmnt.Text.ToString()) == int.Parse(txtMnmInstlmntAmnt.Text.ToString()))
                    {
                        lblError.Text = "";
                        txtLoanPrncplAmnt.Text = "0";
                        txtTtlInstlmntAmnt.Text = txtLoanInstlmntAmnt.Text.ToString();
                        btnAcptInstlmnt.Enabled = true;
                    }
                    else if (int.Parse(txtLoanInstlmntAmnt.Text.ToString()) > int.Parse(txtMnmInstlmntAmnt.Text.ToString()) && lblError.Text.Length<1)
                    {
                        lblError.Text = "";
                        txtLoanPrncplAmnt.Text = (int.Parse(txtLoanInstlmntAmnt.Text.ToString()) - int.Parse(txtMnmInstlmntAmnt.Text.ToString())).ToString();
                        txtTtlInstlmntAmnt.Text = txtLoanInstlmntAmnt.Text.ToString();
                        btnAcptInstlmnt.Enabled = true;
                    }
                    else
                    {
                        btnAcptInstlmnt.Enabled = false;
                        lblError.Text = " * Please Enter Valid Value For Loan Installment Amount.It Must Greater Or Equal To Minimum Installment Amount";
                    }
                }
                catch (Exception ins)
                {
                    lblError.Text = " * Please Enter Valid Loan Installment Amount";
                    btnAcptInstlmnt.Enabled = false;
                }
            }
        }

        private void btnAcptInstlmnt_Click(object sender, EventArgs e)
        {
            if (btnAcptInstlmnt.Text == "ACCEPT INSTALLMENT" && lblError.Text.Length<1)
            {
                txtCurrntDt.ReadOnly = true;
                txtLoanInstlmntAmnt.ReadOnly = true;
                cmbxCstmrId.Enabled = false;
                cmbxLnnm.Enabled = false;
                cmbxLoanId.Enabled = false;
                btnAcptInstlmnt.Text = "SAVE";
            }
            else if(btnAcptInstlmnt.Text=="SAVE" && lblError.Text.Length<1)
            {
                QRY = "INSERT INTO tblLoanInstlmntMaster VALUES(";
                QRY += "(SELECT MAX(tblLnInstlmntId) FROM tblLoanInstlmntMaster)+1,";
                QRY += "" + cmbxLoanId.SelectedItem.ToString() + ",";
                QRY += "" + cmbxCstmrId.SelectedItem.ToString() + ",";
                QRY += "" + txtLnIntrstAmnt.Text+ ",";
                QRY += "" + txtLoanPrncplAmnt.Text + ",";
                QRY += "" + txtChrgAmnt.Text + ",";
                QRY += "" + txtTtlInstlmntAmnt.Text + ",";
                QRY +=(int.Parse(txtRmngLnActulAmnt.Text.ToString())-int.Parse(txtLoanPrncplAmnt.Text.ToString())).ToString()+",";
                QRY += "'"+txtCurrntDt.Text+"',";
                QRY += "'TRUE')";
                Connection.AddUpdtDltOprtns(QRY);
                if (DialogResult.Yes == MessageBox.Show("Your Installment Transaction Has Completed Successfully.Do You Want To Print Receipt ?", "Print Installment Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    btnAcptInstlmnt.Text = "ACCEPT INSTALLMENT";
                    btnAcptInstlmnt.Enabled = false;
                    QRY = "SELECT cstmrFrstNme,cstmrLstNme,cstmrAddrs,cstmrMono,cstmrPinCod FROM tblCstmrPrsnlDtls WHERE cstmrId=" + cmbxCstmrId.SelectedItem.ToString() + " AND cstmrIsAct='TRUE'";
                    cn = new SqlConnection(Connection.cnstr);
                    cn.Open();
                    cmd = new SqlCommand(QRY, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds);
                    cn.Close();
                    DataTable tblLoanDtls = new DataTable();
                    tblLoanDtls.Columns.Add("cstmrId");
                    tblLoanDtls.Columns.Add("lnApprvlId");
                    tblLoanDtls.Columns.Add("lnName");
                    tblLoanDtls.Columns.Add("lnTyp");
                    tblLoanDtls.Columns.Add("lnIntrstRt");
                    tblLoanDtls.Columns.Add("lnActlInstlmntDt");
                    tblLoanDtls.Columns.Add("lnInstlmntDt");
                    tblLoanDtls.Columns.Add("lnActlDys");
                    tblLoanDtls.Columns.Add("lnLateDys");
                    tblLoanDtls.Columns.Add("lnTtlDys");
                    tblLoanDtls.Columns.Add("lnIntrstAmnt");
                    tblLoanDtls.Columns.Add("lnChrgAmnt");
                    tblLoanDtls.Columns.Add("lnPrncpltAmnt");
                    tblLoanDtls.Columns.Add("lnTtlInstlmntAmnt");
                    DataRow drLnDtls = tblLoanDtls.NewRow();
                    drLnDtls[0] = cmbxCstmrId.SelectedItem.ToString();
                    drLnDtls[1] = cmbxLoanId.SelectedItem.ToString();
                    drLnDtls[2] = cmbxLnnm.SelectedItem.ToString();
                    drLnDtls[3] = txtLoanTyp.Text.ToString();
                    drLnDtls[4] = txtIntrstRt.Text.ToString();
                    drLnDtls[5] = txtInstlmntDt.Text.ToString();
                    drLnDtls[6] = txtCurrntDt.Text.ToString();
                    drLnDtls[7] = txtActlInrstDys.Text.ToString();
                    drLnDtls[8] = txtLatIntrstDys.Text.ToString();
                    drLnDtls[9] = txtTtlDys.Text.ToString();
                    drLnDtls[10] = txtLnIntrstAmnt.Text.ToString();
                    drLnDtls[11] = txtChrgAmnt.Text.ToString();
                    drLnDtls[12] = txtLoanPrncplAmnt.Text.ToString();
                    drLnDtls[13] = txtTtlInstlmntAmnt.Text.ToString();
                    tblLoanDtls.Rows.Add(drLnDtls);
                    ds.Tables.Add(tblLoanDtls);
                    ds.WriteXml(System.IO.Directory.GetCurrentDirectory().ToString()+@"\Reports\InstlmntRecpt.xml");
                    ResetControls();
                    cmbxCstmrId.SelectedIndex = 0;
                    cmbxCstmrId.Enabled = true;
                    cmbxLnnm.Enabled = true;
                    cmbxLoanId.Enabled = true;
                    txtCurrntDt.ReadOnly = false;
                    frmInstlmntReceipt rcpt = new frmInstlmntReceipt();
                    rcpt.ShowDialog();
                }
                else
                {
                    ResetControls();
                    cmbxCstmrId.Enabled = true;
                    cmbxCstmrId.SelectedIndex = 0;
                    cmbxLnnm.Enabled = true;
                    cmbxLoanId.Enabled = true;
                    txtCurrntDt.ReadOnly = false;
                    btnAcptInstlmnt.Text = "ACCEPT INSTALLMENT";
                    btnAcptInstlmnt.Enabled = false;
                }
            }
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            ResetControls();
            cmbxCstmrId.Enabled = true;
            cmbxLnnm.Enabled = true;
            cmbxLoanId.Enabled = true;
            cmbxCstmrId.SelectedIndex = 0;
            btnAcptInstlmnt.Text = "ACCEPT INSTALLMENT";
            txtCurrntDt.ReadOnly = false;
        }

        private void txtLoanPrncplAmnt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtLoanPrncplAmnt.Text.ToString()) > int.Parse(txtRmngLnActulAmnt.Text.ToString()))
                {
                    lblError.Text = " * Please Enter Valid Loan Installment Amount.Principal Amount Must Less Than Or Equal To Remaning Actual Amount";
                }
                else
                {
                    lblError.Text = "";
                }
            }
            catch (Exception prncpl)
            {
            }
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}

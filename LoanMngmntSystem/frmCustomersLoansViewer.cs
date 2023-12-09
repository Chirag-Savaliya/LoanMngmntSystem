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
    public partial class frmCustomersLoansViewer : Form
    {
        string Qry = "";
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public frmCustomersLoansViewer()
        {
            InitializeComponent();
        }

        private void frmCustomersLoansViewer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            cmbxLnId.SelectedIndex = 0;
        }
        void BindCustomersLoansData()
        {
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(Qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            dtgrdCstmrsLoans.DataSource = ds.Tables[0];
            cn.Dispose();
            cmd.Dispose();
            ds.Dispose();
            da.Dispose();
        }
        void LoadCustomers()
        {
            Qry = "select distinct(cstmrId) from tblLoanApprvlMaster where lnApprvlIsAct='true'";
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(Qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            if (ds.Tables[0].Rows.Count >= 1)
            {
                cmbxId.Items.Clear();
                cmbxId.Items.Add("-- Select Customer Id --");
                for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                {
                    cmbxId.Items.Add(ds.Tables[0].Rows[x][0]);
                }
            }
            cn.Dispose();
            cmd.Dispose();
            ds.Dispose();
            da.Dispose();
            ds.Dispose();
            cmbxId.SelectedIndex = 0;
        }

        private void rdbtnWhole_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnWhole.Checked)
            {
                cmbxLnId.SelectedIndex = 0;
                cmbxLnId.Enabled = false;
                if (cmbxId.SelectedIndex >= 1)
                {
                    Qry = "SELECT tblLnApprvlId,lnName,lnType,lnIntrstRt,lnInsrnstRt,lnMaxAmntRt,lnMaxAmnt,lnAmnt,lnInsrAmnt,lnActlAmnt,lnApprvlDt FROM tblLoanApprvlMaster ";
                    Qry += "WHERE cstmrId=" + cmbxId.SelectedItem.ToString() + " AND lnApprvlIsAct='TRUE'";
                    cmbxLnId.SelectedIndex = 0;
                    cmbxLnId.Enabled = false;
                    BindCustomersLoansData();
                    dtgrdCstmrsLoans.Visible = true;
                }
            } 
        }

        private void rdbtnPrtclr_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPrtclr.Checked)
            {
                if (cmbxId.SelectedIndex >= 1)
                {
                    cmbxLnId.Enabled = true;
                    LoadCustumersLoansId();
                }
                else
                {
                    cmbxLnId.Enabled = false;
                }
                cmbxLnId.SelectedIndex = 0;
            }
            dtgrdCstmrsLoans.Visible = false;
        }

        private void cmbxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxId.SelectedIndex >= 1)
            {
                cmbxLnId.Enabled = true;
                if (rdbtnPrtclr.Checked)
                {
                    LoadCustumersLoansId();
                }
                else if (rdbtnWhole.Checked)
                {
                    cmbxLnId.SelectedIndex = 0;
                    cmbxLnId.Enabled = false;
                    Qry = "SELECT tblLnApprvlId,lnName,lnType,lnIntrstRt,lnInsrnstRt,lnMaxAmntRt,lnMaxAmnt,lnAmnt,lnInsrAmnt,lnActlAmnt,lnApprvlDt FROM tblLoanApprvlMaster ";
                    Qry += "WHERE cstmrId=" + cmbxId.SelectedItem.ToString() + " AND lnApprvlIsAct='TRUE'";
                    BindCustomersLoansData();
                    dtgrdCstmrsLoans.Visible = true;
                }
            }
            else
            {
                cmbxLnId.SelectedIndex = 0;
                dtgrdCstmrsLoans.Visible = false;
                cmbxLnId.Enabled = false;
            }
        }
        void LoadCustumersLoansId()
        {
            Qry = "SELECT tblLnApprvlId FROM tblLoanApprvlMaster WHERE lnApprvlIsAct='TRUE' AND cstmrId=" + cmbxId.SelectedItem.ToString() + "";
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(Qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            if (ds.Tables[0].Rows.Count >= 1)
            {
                cmbxLnId.Items.Clear();
                cmbxLnId.Items.Add("-- Select Loan Id --");
                for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                {
                    cmbxLnId.Items.Add(ds.Tables[0].Rows[x][0]);
                }
            }
            cn.Dispose();
            cmd.Dispose();
            ds.Dispose();
            da.Dispose();
            ds.Dispose();
            cmbxLnId.SelectedIndex = 0;
        }

        private void cmbxLnId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxLnId.SelectedIndex >= 1 && cmbxId.SelectedIndex>=1)
            {
                if (rdbtnPrtclr.Checked)
                {
                    Qry = "SELECT tblLnApprvlId,lnName,lnType,lnIntrstRt,lnInsrnstRt,lnMaxAmntRt,lnMaxAmnt,lnAmnt,lnInsrAmnt,lnActlAmnt,lnApprvlDt FROM tblLoanApprvlMaster ";
                    Qry += "WHERE cstmrId=" + cmbxId.SelectedItem.ToString() + " AND tblLnApprvlId=" + cmbxLnId.SelectedItem.ToString() + " AND lnApprvlIsAct='TRUE'";
                    BindCustomersLoansData();
                    dtgrdCstmrsLoans.Visible = true;
                }
            }
            else dtgrdCstmrsLoans.Visible = false;
        }

        private void btnPrnt_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count >= 1 && dtgrdCstmrsLoans.Visible == true)
            {
                ds.WriteXml(@"C:\CstmrsLoansRpt.xml");
                frmCstmrsLoansReport rpt = new frmCstmrsLoansReport();
                rpt.ShowDialog();
            }
        }
    }
}

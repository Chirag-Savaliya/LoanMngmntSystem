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
    public partial class frmLoanViewer : Form
    {
        string Qry = "";
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public frmLoanViewer()
        {
            InitializeComponent();
        }

        private void frmLoanViewer_Load(object sender, EventArgs e)
        {
            LoadLoans();
        }
        void BindLoansData()
        {
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(Qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            dtgrdLoans.DataSource = ds.Tables[0];
            cn.Dispose();
            cmd.Dispose();
            ds.Dispose();
            da.Dispose();
        }
        void LoadLoans()
        {
            Qry = "SELECT lnName FROM tblLoanMaster WHERE lnIsAct='TRUE'";
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
                cmbxId.Items.Add("-- Select Loan --");
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
            cmbxId.Enabled = false;
            if (rdbtnWhole.Checked)
            {
                Qry = "SELECT lnId,lnName,lnIntrstRt,lnMaxAmntRt,lnInsrRt FROM tblLoanMaster WHERE lnIsAct='TRUE'";
                cmbxId.SelectedIndex = 0;
                cmbxId.Enabled = false;
                BindLoansData();
                dtgrdLoans.Visible = true;
            }
        }

        private void rdbtnPrtclr_CheckedChanged(object sender, EventArgs e)
        {
            cmbxId.Enabled = true;
            if (rdbtnPrtclr.Checked)
            {
                cmbxId.Enabled = true;
            }
            dtgrdLoans.Visible = false;
        }

        private void cmbxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxId.SelectedIndex >= 1)
            {
                Qry = "SELECT lnId,lnName,lnIntrstRt,lnMaxAmntRt,lnInsrRt FROM tblLoanMaster WHERE lnIsAct='TRUE' AND lnName='" + cmbxId.SelectedItem.ToString() + "'";
                BindLoansData();
                dtgrdLoans.Visible = true;
            }
            else dtgrdLoans.Visible = false;
        }

        private void btnPrnt_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count >= 1 && dtgrdLoans.Visible == true)
            {
                ds.WriteXml(@"C:\LoansRpt.xml");
                frmLoansReport rpt = new frmLoansReport();
                rpt.ShowDialog();
            }
        }
    }
}

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
    public partial class frmCustomersInstlmntViewer : Form
    {
        string Qry = "";
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public frmCustomersInstlmntViewer()
        {
            InitializeComponent();
        }

        private void frmCustomersInstlmntViewer_Load(object sender, EventArgs e)
        {
            cmbxLnId.SelectedIndex = 0;
            LoadCustomers();
        }
        void LoadCustomers()
        {
            Qry = "SELECT DISTINCT(cstmrId) FROM tblLoanInstlmntMaster where lnInstlmntIsAct='TRUE'";
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

        private void cmbxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxId.SelectedIndex >= 1)
            {
                LoadLoansId();
                cmbxLnId.Enabled = true;
            }
            else
            {
                cmbxLnId.SelectedIndex = 0;
                cmbxLnId.Enabled = false;
                dtgrdCstmrsInstlmts.Visible = false;
            }
        }
        void LoadLoansId()
        {
            Qry = "SELECT DISTINCT(lnApprvlId) FROM tblLoanInstlmntMaster WHERE cstmrId=" + cmbxId.SelectedItem.ToString() + " AND lnInstlmntIsAct='TRUE'";
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
            if (cmbxLnId.SelectedIndex >= 1)
            {
                BindLoanInstallmentsData();
                dtgrdCstmrsInstlmts.Visible = true;
            }
            else dtgrdCstmrsInstlmts.Visible = false;
        }
        void BindLoanInstallmentsData()
        {
            Qry = "SELECT im.tblLnInstlmntId,im.lnIntrstAmnt,im.lnPrncplAmnt,im.lnChrgAmnt,im.lnTtlInstlmntAmnt,im.lnRmngActlAmnt,im.lnInstlmntDt,lam.lnName ";
            Qry += "FROM tblLoanInstlmntMaster im,tblLoanApprvlMaster lam WHERE ";
            Qry += "im.lnApprvlId="+cmbxLnId.SelectedItem.ToString()+" AND ";
            Qry += "im.cstmrId="+cmbxId.SelectedItem.ToString()+" AND ";
            Qry += "im.lnInstlmntIsAct='TRUE' AND ";
            Qry += "lam.tblLnApprvlId="+cmbxLnId.SelectedItem.ToString()+" AND ";
            Qry += "lam.cstmrId="+cmbxId.SelectedItem.ToString()+" AND ";
            Qry += "lam.lnApprvlIsAct='TRUE'";
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(Qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            if (ds.Tables[0].Rows.Count >= 1)
            {
                dtgrdCstmrsInstlmts.DataSource = ds.Tables[0];
            }
            cn.Dispose();
            cmd.Dispose();
            ds.Dispose();
            da.Dispose();
        }

        private void btnPrnt_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count >= 1 && dtgrdCstmrsInstlmts.Visible==true)
            {
                ds.WriteXml(@"C:\CstmrsInstlmntsRpt.xml");
                frmCstmrsInstlmntsReport rpt = new frmCstmrsInstlmntsReport();
                rpt.ShowDialog();
            }
        }
    }
}

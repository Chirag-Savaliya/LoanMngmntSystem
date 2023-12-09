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
using System.IO;
using System.Drawing.Imaging;

namespace LoanMngmntSystem
{
    public partial class frmCustomersViewer : Form
    {
        string Qry="";
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        byte[] ImgArry;
        MemoryStream ms;
        Image img;
        public frmCustomersViewer()
        {
            InitializeComponent();
        }

        private void frmCustomersViewer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        void BindCustomersData()
        {
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(Qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            dtGrdCstmrs.DataSource = ds.Tables[0];
            if (dtGrdCstmrs.Columns.Count==10)
            {
                dtGrdCstmrs.Columns.RemoveAt(9);
            }
            DataGridViewImageColumn imgclm = new DataGridViewImageColumn();
            imgclm.HeaderText = "Profile";
            imgclm.Width = 140;
            imgclm.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtGrdCstmrs.Columns.Add(imgclm);
            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                ImgArry = (byte[])ds.Tables[0].Rows[x][9];
                ms = new MemoryStream(ImgArry);
                dtGrdCstmrs.Rows[x].Cells[9].Value = Image.FromStream(ms);
                dtGrdCstmrs.Rows[x].Height = 90;
            }
            cn.Dispose();
            cmd.Dispose();
            ds.Dispose();
            da.Dispose();
        }
        void LoadCustomers()
        {
           Qry="SELECT cstmrId FROM tblCstmrPrsnlDtls WHERE cstmrIsAct='TRUE'";
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
                   for(int x=0; x<ds.Tables[0].Rows.Count; x++)
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
                Qry = "SELECT cstmrId,cstmrFrstNme,cstmrLstNme,cstmrAddrs,cstmrBrthDt,cstmrEml,cstmrGndr,cstmrMono,cstmrPinCod,cstmrPrfl FROM tblCstmrPrsnlDtls WHERE cstmrIsAct='TRUE'";
                cmbxId.SelectedIndex = 0;
                cmbxId.Enabled = false;
                BindCustomersData();
                dtGrdCstmrs.Visible = true;
            }
        }

        private void rdbtnPrtclr_CheckedChanged(object sender, EventArgs e)
        {
            cmbxId.Enabled = true;
            if (dtGrdCstmrs.Columns.Count == 10)
            {
                dtGrdCstmrs.Columns.RemoveAt(9);
            }
            if (rdbtnPrtclr.Checked)
            {
                cmbxId.Enabled = true;
            }
            dtGrdCstmrs.Visible = false;
        }

        private void cmbxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtGrdCstmrs.Columns.Count >= 10)
            {
                dtGrdCstmrs.Columns.RemoveAt(9);
            }
            if (cmbxId.SelectedIndex >= 1)
            {
                Qry = "SELECT cstmrId,cstmrFrstNme,cstmrLstNme,cstmrAddrs,cstmrBrthDt,cstmrEml,cstmrGndr,cstmrMono,cstmrPinCod,cstmrPrfl FROM tblCstmrPrsnlDtls WHERE cstmrIsAct='TRUE' AND ";
                Qry += "cstmrId=" + cmbxId.SelectedItem.ToString() + "";
                BindCustomersData();
                dtGrdCstmrs.Visible = true;
            }
            else dtGrdCstmrs.Visible = false;
        }

        private void btnPrnt_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count >= 1 && dtGrdCstmrs.Visible == true)
            {
                ds.WriteXml(@"C:\CstmrsRpt.xml");
                frmCustomersReport rpt = new frmCustomersReport();
                rpt.ShowDialog();
            }
        }
    }
}

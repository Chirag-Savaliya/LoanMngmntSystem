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
    public partial class frmUsersViewer : Form
    {
        string Qry = "";
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        byte[] ImgArry;
        MemoryStream ms;
        Image img;
        public frmUsersViewer()
        {
            InitializeComponent();
        }

        private void frmUsersViewer_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        void BindUsersData()
        {
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(Qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            dtgrdUsrs.DataSource = ds.Tables[0];
            if (dtgrdUsrs.Columns.Count == 9)
            {
                dtgrdUsrs.Columns.RemoveAt(8);
            }
            DataGridViewImageColumn imgclm = new DataGridViewImageColumn();
            imgclm.HeaderText = "Profile";
            imgclm.Width = 100;
            imgclm.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtgrdUsrs.Columns.Add(imgclm);
            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                ImgArry = (byte[])ds.Tables[0].Rows[x][8];
                ms = new MemoryStream(ImgArry);
                dtgrdUsrs.Rows[x].Cells[8].Value = Image.FromStream(ms);
                dtgrdUsrs.Rows[x].Height = 90;
            }
            dtgrdUsrs.Columns[7].Visible = false;
            cn.Dispose();
            cmd.Dispose();
            ds.Dispose();
            da.Dispose();
            ds.Dispose();
        }
        void LoadUsers()
        {
            Qry = "SELECT usrId FROM tblUserMaster WHERE usrIsAct='TRUE'";
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
                cmbxId.Items.Add("-- Select User Id --");
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
                Qry = "SELECT um.usrId,um.usrFrstName,um.usrLstName,um.usrBrthDate,um.usrGndr,um.usrAddrs,um.usrMoNo,lm.usrNme,um.usrPrfl FROM tblUserMaster um,tblLoginMaster lm WHERE um.usrIsAct='TRUE' AND lm.usrLognIsAct='TRUE' AND um.usrId=lm.usrId";
                cmbxId.SelectedIndex = 0;
                cmbxId.Enabled = false;
                BindUsersData();
                dtgrdUsrs.Visible = true;
            }
        }

        private void rdbtnPrtclr_CheckedChanged(object sender, EventArgs e)
        {
            cmbxId.Enabled = true;
            if (dtgrdUsrs.Columns.Count == 9)
            {
                dtgrdUsrs.Columns.RemoveAt(8);
            }
            if (rdbtnPrtclr.Checked)
            {
                cmbxId.Enabled = true;
            }
            dtgrdUsrs.Visible = false;
        }

        private void cmbxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtgrdUsrs.Columns.Count == 9)
            {
                dtgrdUsrs.Columns.RemoveAt(8);
            }
            if (cmbxId.SelectedIndex >= 1)
            {
                Qry = "SELECT um.usrId,um.usrFrstName,um.usrLstName,um.usrBrthDate,um.usrGndr,um.usrAddrs,um.usrMoNo,lm.usrNme,um.usrPrfl FROM tblUserMaster um,tblLoginMaster lm ";
                Qry += "WHERE um.usrIsAct='TRUE' AND lm.usrLognIsAct='TRUE' AND um.usrId=" + cmbxId.SelectedItem.ToString() + " AND lm.usrId="+cmbxId.SelectedItem.ToString()+"";
                BindUsersData();
                dtgrdUsrs.Visible = true;
            }
            else dtgrdUsrs.Visible = false;
        }

        private void btnPrnt_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count >= 1 && dtgrdUsrs.Visible == true)
            {
                ds.WriteXml(@"C:\UsersRpt.xml");
                frmUsersReport rpt = new frmUsersReport();
                rpt.ShowDialog();
            }
        }
    }
}

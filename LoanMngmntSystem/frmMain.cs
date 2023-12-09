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
    public partial class frmMain : Form
    {
        SqlConnection CNN;
        SqlCommand CMD;
        SqlDataReader DR;
        public frmMain()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if(f!=null)
                   f.Close();
            }
            ToolStripMenuItem mnu = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem m in mnuStrpMain.Items)
            {
                m.BackColor = Color.Aqua;
                m.ForeColor = Color.Black;
            }
            mnu.BackColor = Color.Black;
            mnu.ForeColor = Color.Aqua;
            if (mnuStrpMain.Items[0].Selected == true)
            {
                frmLoanMngmnt lnMnhmnt = new frmLoanMngmnt();
                lnMnhmnt.MdiParent = this;
                lnMnhmnt.Show();
            }
            else if (mnuStrpMain.Items[2].Selected == true)
            {
                frmLoanApprvl lnApprv = new frmLoanApprvl();
                lnApprv.MdiParent = this;
                lnApprv.Show();
            }
            else if (mnuStrpMain.Items[4].Selected == true)
            {
                frmLoanInstlmnt lnInstlmnt = new frmLoanInstlmnt();
                lnInstlmnt.MdiParent = this;
                lnInstlmnt.Show();
            }
            else if (mnuStrpMain.Items[6].Selected == true)
            {
                frmAddNewCstmr cstmrs = new frmAddNewCstmr();
                cstmrs.MdiParent = this;
                cstmrs.Show();
            }
            else if (mnuStrpMain.Items[8].Selected == true)
            {
                frmAddNewUser usrs = new frmAddNewUser();
                usrs.MdiParent = this;
                usrs.Show();
            }
            else if (mnuStrpMain.Items[12].Selected == true)
            {
                frmLogin lgn = new frmLogin();
                lgn.MdiParent = this;
                lgn.Show();
            }
            else if (mnuStrpMain.Items[14].Selected == true)
            {
                foreach (ToolStripMenuItem itm in mnuStrpMain.Items)
                {
                    if (itm.Text == "Login")
                        itm.Enabled = true;
                    else
                    {
                        itm.Enabled = false;
                    }
                    lblUser.Text = "";
                    foreach (Form f in this.MdiChildren)
                    {
                        f.Close();
                    }
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            System.IO.File.Copy(System.IO.Directory.GetCurrentDirectory().ToString() + @"\Reports\CstmrsLoansRpt.xml", @"C:\CstmrsLoansRpt.xml", true);
            System.IO.File.Copy(System.IO.Directory.GetCurrentDirectory().ToString() + @"\Reports\CstmrsInstlmntsRpt.xml", @"C:\CstmrsInstlmntsRpt.xml", true);
            System.IO.File.Copy(System.IO.Directory.GetCurrentDirectory().ToString() + @"\Reports\CstmrsRpt.xml", @"C:\CstmrsRpt.xml", true);
            System.IO.File.Copy(System.IO.Directory.GetCurrentDirectory().ToString() + @"\Reports\InstlmntRecpt.xml", @"C:\InstlmntRecpt.xml", true);
            System.IO.File.Copy(System.IO.Directory.GetCurrentDirectory().ToString() + @"\Reports\LoansRpt.xml", @"C:\LoansRpt.xml", true);
            System.IO.File.Copy(System.IO.Directory.GetCurrentDirectory().ToString() + @"\Reports\UsersRpt.xml", @"C:\UsersRpt.xml", true);
            foreach (ToolStripMenuItem m in mnuStrpMain.Items)
            {
                if (m.Text != "Login")
                {
                    m.Enabled = false;
                }
            }
        }

        private void Reports_ChildsMenus_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mnu = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem m in reportsToolStripMenuItem.DropDownItems)
            {
                m.BackColor = Color.Aqua;
                m.ForeColor = Color.Black;
            }
            mnu.BackColor = Color.Black;
            mnu.ForeColor = Color.Aqua;
            if (reportsToolStripMenuItem.DropDownItems[0].Text == mnu.Text)
            {
                frmUsersViewer usrRpt = new frmUsersViewer();
                usrRpt.MdiParent = this;
                usrRpt.Show();
            }
            if (reportsToolStripMenuItem.DropDownItems[1].Text == mnu.Text)
            {
                frmCustomersViewer cstmrsRpt = new frmCustomersViewer();
                cstmrsRpt.MdiParent = this;
                cstmrsRpt.Show();
            }
            if (reportsToolStripMenuItem.DropDownItems[2].Text == mnu.Text)
            {
                frmLoanViewer lnsRpt = new frmLoanViewer();
                lnsRpt.MdiParent = this;
                lnsRpt.Show();
            }
            if (reportsToolStripMenuItem.DropDownItems[3].Text == mnu.Text)
            {
                frmCustomersLoansViewer cstmrsLnsRpt = new frmCustomersLoansViewer();
                cstmrsLnsRpt.MdiParent = this;
                cstmrsLnsRpt.Show();
            }
            if (reportsToolStripMenuItem.DropDownItems[4].Text == mnu.Text)
            {
                frmCustomersInstlmntViewer instlmntsRpt = new frmCustomersInstlmntViewer();
                instlmntsRpt.MdiParent = this;
                instlmntsRpt.Show();
            }
        }

        private void lblUser_TextChanged(object sender, EventArgs e)
        {
            CheckUserRole();
        }
        void CheckUserRole()
        {
            CNN = new SqlConnection(Connection.cnstr);
            CNN.Open();
            CMD = new SqlCommand("SELECT usrRlId FROM tblLoginMaster WHERE usrNme='" + lblUser.Text.ToString() + "' AND usrLognIsAct='TRUE'", CNN);
            DR = CMD.ExecuteReader();
            if (DR.Read())
            {
                lblUser.Tag = DR[0].ToString();
                if (int.Parse(lblUser.Tag.ToString()) == 1)
                {
                    foreach (ToolStripMenuItem itm in mnuStrpMain.Items)
                    {
                        if (itm.Text == "Login")
                            itm.Enabled = false;
                        else
                            itm.Enabled = true;
                    }
                }
                else if (int.Parse(lblUser.Tag.ToString()) == 2)
                {
                    for (int x = 0; x <= 14; x+=2)
                    {
                        if (x == 0 || x == 2 || x == 6)
                            mnuStrpMain.Items[x].Enabled = false;
                        else
                            mnuStrpMain.Items[x].Enabled = true;
                    }
                }
            }
            CNN.Close();
        }

        private void mnuStrpMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
      
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
    public partial class frmAddNewUser : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        int Uid = 3;
        int RlId = 1;
        int flag = 0;
        string qry;
        string prflPath = @"D:\CHIRAG\LoanMngmntSystem\Profiles\";
        public frmAddNewUser()
        {
            InitializeComponent();
        }
        private void Set(object s, EventArgs e)
        {
            ((TextBox)s).BackColor = Color.LightGoldenrodYellow;
            ((TextBox)s).ForeColor = Color.Teal;
        }

        private void Reset(object s, EventArgs e)
        {
            ((TextBox)s).BackColor = Color.White;
            ((TextBox)s).ForeColor = Color.Black;
        }

        private void cmbSecQuestn_Enter(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            c.BackColor = Color.LightGoldenrodYellow;
            c.ForeColor = Color.Teal;
        }

        private void cmbSecQuestn_Leave(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            DisableControls();
            cmbSecQuestn.SelectedIndex = 0;
            if (RlId == 1)
            {
                btnADD.Enabled = true;
                btnDlte.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnADD.Enabled = false;
                btnDlte.Enabled = false;
                btnEdit.Enabled = true;

            }
        }
        Boolean CntrlsValidation()
        {
            if (txtFrstName.TextLength < 1)
            {
                lblError.Text = " * First Name Must Not Be Empty";
            }
            else if (txtLstName.TextLength < 1)
            {
                lblError.Text = " * Last Name Must Not Be Empty";
            }
            else if (txtBrthDate.TextLength < 1)
            {
                lblError.Text = " * Birth Date Must Not Be Empty";
            }
            else if (txtAddrs.TextLength < 1)
            {
                lblError.Text = " * Address Must Not Be Empty";
            }
            else if (txtMono.TextLength < 1)
            {
                lblError.Text = " * Mo-No Must Not Be Empty";
            }
            else if (txtEmail.TextLength < 1)
            {
                lblError.Text = " * Email Must Not Be Empty";
            }
            else if (txtPass.TextLength < 1)
            {
                lblError.Text = " * Password Must Not Be Empty";
            }
            else if (txtCnfrmPass.TextLength < 1)
            {
                lblError.Text = " * Confirm Password Must Not Be Empty";
            }
            else if (txtQuestnAnsr.TextLength < 1)
            {
                lblError.Text = " * Question Answer Must Not Be Empty";
            }
            else if (txtOwnQuestn.TextLength < 1 && txtOwnQuestn.ReadOnly == false)
            {
                lblError.Text = " * Question Must Not Be Empty";
            }
            else if (!TextBoxesValidation(txtFrstName))
            {
                lblError.Text = " * Please Enter Valid First Name";
            }
            else if (!TextBoxesValidation(txtLstName))
            {
                lblError.Text = " * Please Enter Valid Last Name";
            }
            else if (!TextBoxesValidation(txtBrthDate))
            {
                lblError.Text = " * Please Enter Valid Birth Date";
            }
            else if (!TextBoxesValidation(txtAddrs))
            {
                lblError.Text = " * Please Enter Valid Address";
            }
            else if (!TextBoxesValidation(txtMono))
            {
                lblError.Text = " * Please Enter Valid Mobile Number";
            }
            else if (!TextBoxesValidation(txtEmail))
            {
                lblError.Text = " * Please Enter Valid Email";
            }
            else if (!TextBoxesValidation(txtOwnQuestn))
            {
                lblError.Text = " * Please Enter Valid Question";
            }
            else if (!TextBoxesValidation(txtQuestnAnsr))
            {
                lblError.Text = " * Please Enter Valid Question Answer";
            }
            else if (!ChkPassword())
            {
                lblError.Text = " * Password Does Not Match";
            }
            else if (pctrProfile.Image == null)
            {
                lblError.Text = " * Upload Your Profile Picture";
            }
            else
            {
                lblError.Text = "";
            }
            if (lblError.Text.Length < 1)
                return true;
            else
                return false;
        }
        Boolean TextBoxesValidation(TextBox t)
        {
            if (t.Name == "txtFrstName" || t.Name == "txtLstName")
            {
                char[] str = t.Text.ToString().ToCharArray();
                int count = 0;
                for (int x = 0; x < str.Length; x++)
                {
                    if (((int)str[x] >= 65 && (int)str[x] <= 90) || ((int)str[x] >= 97 && (int)str[x] <= 122))
                    {
                        count++;
                    }
                }
                if (count == t.TextLength)
                    return true;
                else
                    return false;
            }
            else if (t.Name == "txtBrthDate")
            {
                try
                {
                    string[] bd = t.Text.ToString().Split('/');
                    if ((int.Parse(bd[0]) < 1 || int.Parse(bd[0]) > 31) || (int.Parse(bd[1]) < 1 || int.Parse(bd[1]) > 12) || (int.Parse(bd[2]) < 1980 || int.Parse(bd[2]) > 2019))
                    {
                        lblError.Text = " * Please Enter Valid Birth Date";
                    }
                    else
                    {
                        lblError.Text = "";
                    }
                }
                catch (Exception e)
                {
                    lblError.Text = " * Please Enter Valid Format Of Birth Date";
                }
            }
            else if (t.Name == "txtAddrs")
            {
                char[] str = t.Text.ToString().ToCharArray();
                for (int x = 0; x < str.Length; x++)
                {
                    if (((int)str[x] == 45) || ((int)str[x] >= 48 && (int)str[x] <= 57) || ((int)str[x] >= 65 && (int)str[x] <= 90) || ((int)str[x] >= 97 && (int)str[x] <= 122))
                    {
                        lblError.Text = "";
                    }
                    else
                    {
                        lblError.Text = "Enter Valid Address";
                    }
                }
            }
            else if (t.Name == "txtMono")
            {
                char[] str = t.Text.ToString().ToCharArray();
                int count = 0;
                for (int x = 0; x < str.Length; x++)
                {
                    if ((int)str[x] < 48 || (int)str[x] > 57)
                    {
                        count++;
                    }
                }
                if (count < 1 && txtMono.Text.Length == 10)
                {
                    lblError.Text = "";
                }
                else
                    lblError.Text = "Invalid Mobile No";
            }
            else if (t.Name == "txtEmail")
            {
                try
                {
                    string[] str = t.Text.ToString().Split('@');
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
                        lblError.Text = "";
                    }
                    else
                    {
                        lblError.Text = "Email Invalid";
                    }
                }
                catch (Exception e)
                {
                    lblError.Text = "Email Invalid";
                }
            }
            else if (t.Name == "txtOwnQuestn")
            {
                if (txtOwnQuestn.ReadOnly == false)
                {
                    char[] str = t.Text.ToString().ToCharArray();
                    int count = 0;
                    for (int x = 0; x < str.Length - 1; x++)
                    {
                        if (((int)str[x] >= 65 && (int)str[x] <= 90) || ((int)str[x] >= 97 && (int)str[x] <= 122) || ((int)str[x] >= 48 && (int)str[x] <= 57) || ((int)str[x] == 32))
                        {
                            count++;
                        }
                    }
                    if (count == t.TextLength - 1 && (int)str[str.Length - 1] == 63)
                        lblError.Text = "";
                    else
                        lblError.Text = "Invalid Question";
                }
            }
            else if (t.Name == "txtQuestnAnsr")
            {
                char[] str = t.Text.ToString().ToCharArray();
                int count = 0;
                for (int x = 0; x < str.Length; x++)
                {
                    if (((int)str[x] >= 65 && (int)str[x] <= 90) || ((int)str[x] >= 97 && (int)str[x] <= 122) || ((int)str[x] >= 48 && (int)str[x] <= 57) || ((int)str[x] == 32))
                    {
                        count++;
                    }
                }
                if (count == t.TextLength)
                    lblError.Text = "";
                else
                    lblError.Text = "Invalid Question Answer";
            }
            if (lblError.Text.Length < 1)
                return true;
            else
                return false;
        }
        Boolean ChkPassword()
        {
            if (txtPass.Text == txtCnfrmPass.Text)
                return true;
            else
                return false;
        }

        private void cmbSecQuestn_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOwnQuestn.Clear();
            if (cmbSecQuestn.SelectedIndex == cmbSecQuestn.Items.Count - 1)
            {
                txtOwnQuestn.ReadOnly = false;
            }
            else
            {
                txtOwnQuestn.ReadOnly = true;
            }
        }

        private void btnADD_Click(object sender, EventArgs ex)
        {
            flag = 1;
            if (btnADD.Text == "ADD")
            {
                btnADD.Text = "SAVE";
                ClearControls();
                EnableControls();
                cmbxUsers.Enabled = false;
                btnEdit.Enabled = false;
                btnDlte.Enabled = false;
                txtFrstName.Focus();
            }
            else
            {
                if (CntrlsValidation() && lblError.Text.Length < 1)
                {
                    SaveProfile();
                    if (cmbSecQuestn.SelectedIndex == 0)
                        lblError.Text = "Please Select Valid Security Question";
                    else
                    {
                        SaveProfile();
                        qry = "INSERT INTO tblUserMaster ";
                        qry += "VALUES(";
                        qry += "(SELECT MAX(usrId) FROM tblUserMaster)+1,";
                        qry += "'" + txtFrstName.Text + "',";
                        qry += "'" + txtLstName.Text + "',";
                        qry += "'" + txtBrthDate.Text + "',";
                        if (rdbMale.Checked)
                            qry += "'Male',";
                        else
                        {
                            qry += "'Female',";
                        }
                        qry += "'" + txtAddrs.Text + "',";
                        qry += "'" + txtMono.Text + "',";
                        qry += "'TRUE')";
                        Connection.AddUpdtDltOprtns(qry);
                        qry = "INSERT INTO tblLoginMaster ";
                        qry += "VALUES(";
                        qry += "(SELECT MAX(usrId) FROM tblUserMaster),";
                        if (chbxAdmin.Checked)
                            qry += "1,";
                        else
                        {
                            qry += "2,";
                        }
                        qry += "'" + txtEmail.Text + "',";
                        qry += "'" + txtPass.Text + "',";
                        if (cmbSecQuestn.SelectedIndex == cmbSecQuestn.Items.Count - 1)
                            qry += "'" + txtOwnQuestn.Text + "',";
                        else
                        {
                            qry += "'" + cmbSecQuestn.SelectedItem.ToString() + "',";
                        }
                        qry += "'" + txtQuestnAnsr.Text + "',";
                        qry += "'TRUE')";
                        Connection.AddUpdtDltOprtns(qry);
                        ClearControls();
                        DisableControls();
                        btnADD.Text = "ADD";
                        if (RlId == 1)
                        {
                            btnADD.Enabled = true;
                            btnEdit.Enabled = true;
                            btnDlte.Enabled = true;
                        }
                        else
                            btnEdit.Enabled = true;
                    }
                }
            }
        }
        private void btnUpld_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (flag == 0)
                {
                    pctrProfile.Image.Dispose();
                }
                pctrProfile.Image = Image.FromFile(ofd.FileName);
                System.IO.File.Delete(prflPath + txtEmail.Text + ".jpg");
            }
        }
        void ClearControls()
        {
            txtFrstName.Clear();
            txtLstName.Clear();
            txtAddrs.Clear();
            txtBrthDate.Clear();
            txtMono.Clear();
            txtPass.Clear();
            txtCnfrmPass.Clear();
            txtEmail.Clear();
            txtQuestnAnsr.Clear();
            txtOwnQuestn.Clear();
            lblError.Text = "";
            pctrProfile.Image = null;
            chbxAdmin.Checked = false;
            cmbSecQuestn.SelectedIndex = 0;
            cmbxUsers.Items.Clear();
            rdbMale.Checked = true;
        }
        private void btnDlte_Click(object sender, EventArgs e)
        {
            if (btnDlte.Text == "REMOVE")
            {
                ClearControls();
                DisableControls();
                cmbxUsers.Enabled = true;
                LoadUsers();
                btnDlte.Enabled = true;
                btnDlte.Text = "DELETE";
            }
            else
            {
                DeleteUser();
                if (lblError.Text.Length < 1)
                {
                    btnDlte.Text = "REMOVE";
                    DisableControls();
                    if (RlId == 1)
                    {
                        btnADD.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDlte.Enabled = true;
                    }
                    else
                    {
                        DisableControls();
                        btnEdit.Enabled = true;
                        ClearControls();
                    }
                }
            }
        }
        void DisableControls()
        {
            txtFrstName.Enabled = false;
            txtLstName.Enabled = false;
            txtAddrs.Enabled = false;
            txtBrthDate.Enabled = false;
            txtMono.Enabled = false;
            txtPass.Enabled = false;
            txtCnfrmPass.Enabled = false;
            txtEmail.Enabled = false;
            txtQuestnAnsr.Enabled = false;
            txtOwnQuestn.Enabled = false;
            pctrProfile.Enabled = false;
            cmbSecQuestn.Enabled = false;
            rdbMale.Enabled = false;
            rdbFemale.Enabled = false;
            btnUpld.Enabled = false;
            btnADD.Enabled = false;
            btnEdit.Enabled = false;
            btnDlte.Enabled = false;
            chbxAdmin.Enabled = false;
            cmbxUsers.Enabled = false;
        }
        void EnableControls()
        {
            txtFrstName.Enabled = true;
            txtLstName.Enabled = true;
            txtAddrs.Enabled = true;
            txtBrthDate.Enabled = true;
            txtMono.Enabled = true;
            txtPass.Enabled = true;
            txtCnfrmPass.Enabled = true;
            txtEmail.Enabled = true;
            txtQuestnAnsr.Enabled = true;
            txtOwnQuestn.Enabled = true;
            pctrProfile.Enabled = true;
            cmbSecQuestn.Enabled = true;
            rdbMale.Enabled = true;
            rdbFemale.Enabled = true;
            btnUpld.Enabled = true;
            btnADD.Enabled = true;
            btnEdit.Enabled = true;
            btnDlte.Enabled = true;
            chbxAdmin.Enabled = true;
            cmbxUsers.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flag = 0;
            if (btnEdit.Text == "EDIT")
            {
                EnableControls();
                ClearControls();
                BindControls();
                btnEdit.Text = "UPDATE";
                btnADD.Enabled = false;
                btnDlte.Enabled = false;
                chbxAdmin.Enabled = false;
                cmbxUsers.Enabled = false;
                txtEmail.ReadOnly = true;
                txtFrstName.Focus();
                if (RlId == 1)
                    chbxAdmin.Enabled = true;
            }
            else
            {
                if (CntrlsValidation() && lblError.Text.Length < 1)
                {
                    ReplaceProfile();
                    qry = "UPDATE tblUserMaster SET ";
                    qry += "usrFrstName='" + txtFrstName.Text + "',";
                    qry += "usrLstName='" + txtLstName.Text + "',";
                    qry += "usrBrthDate='" + txtBrthDate.Text + "',";
                    if (rdbMale.Checked)
                        qry += "usrGndr='Male',";
                    else
                    {
                        qry += "usrGndr='Female',";
                    }
                    qry += "usrAddrs='" + txtAddrs.Text + "',";
                    qry += "usrMoNo='" + txtMono.Text + "' WHERE usrId=" + Uid + "";

                    Connection.AddUpdtDltOprtns(qry);

                    qry = "UPDATE tblLoginMaster SET ";
                    if (chbxAdmin.Enabled == true)
                    {
                        if (chbxAdmin.Checked)
                            qry += "usrRlId=1,";
                        else
                            qry += "usrRlId=2,";
                    }
                    qry += "usrPasswrd='" + txtPass.Text + "',";
                    if (cmbSecQuestn.SelectedIndex == 0)
                        lblError.Text = "* Please Select Valid Security Question";
                    else if (cmbSecQuestn.SelectedIndex == cmbSecQuestn.Items.Count - 1)
                        qry += "usrScurtyQstn='" + txtOwnQuestn.Text + "',";
                    else
                    {
                        qry += "usrScurtyQstn='" + cmbSecQuestn.SelectedItem.ToString() + "',";
                    }
                    lblError.Text = "";
                    qry += "usrQstnAnsr='" + txtQuestnAnsr.Text + "' WHERE usrId=" + Uid + "";
                    Connection.AddUpdtDltOprtns(qry);
                    ClearControls();
                    DisableControls();
                    if (RlId == 1)
                    {
                        btnADD.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDlte.Enabled = true;
                    }
                    else
                    {
                        btnEdit.Enabled = true;
                    }
                    btnEdit.Text = "EDIT";
                    txtEmail.ReadOnly = false;
                }
            }
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            ClearControls();
            DisableControls();
            if (RlId == 1)
            {
                btnADD.Enabled = true;
                btnEdit.Enabled = true;
                btnDlte.Enabled = true;
                btnADD.Text = "ADD";
                btnEdit.Text = "EDIT";
                btnDlte.Text = "REMOVE";
            }
            else
            {
                btnEdit.Enabled = true;
                btnEdit.Text = "EDIT";
            }
        }
        void BindControls()
        {
            int chk = 0;
            qry = "SELECT um.usrFrstName,um.usrLstName,um.usrBrthDate,um.usrGndr,um.usrAddrs,um.usrMoNo,";
            qry += "ul.usrNme,ul.usrPasswrd,ul.usrScurtyQstn,ul.usrQstnAnsr ";
            qry += "FROM tblUserMaster um,tblLoginMaster ul ";
            qry += "WHERE um.usrId=" + Uid + " AND ul.usrId=" + Uid + " AND um.usrIsAct='TRUE'";

            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            txtFrstName.Text = ds.Tables[0].Rows[0][0].ToString();
            txtLstName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtBrthDate.Text = ds.Tables[0].Rows[0][2].ToString();
            if (ds.Tables[0].Rows[0][3].ToString() == "Male")
                rdbMale.Checked = true;
            else
            {
                rdbFemale.Checked = true;
            }
            txtAddrs.Text = ds.Tables[0].Rows[0][4].ToString();
            txtMono.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
            txtPass.Text = ds.Tables[0].Rows[0][7].ToString();
            txtCnfrmPass.Text = ds.Tables[0].Rows[0][7].ToString();
            for (int x = 1; x <= 4; x++)
            {
                if (ds.Tables[0].Rows[0][8].ToString() == cmbSecQuestn.Items[x].ToString())
                {
                    chk = x;
                }
            }
            if (chk > 0)
                cmbSecQuestn.SelectedIndex = chk;
            else
            {
                txtOwnQuestn.Text = ds.Tables[0].Rows[0][8].ToString();
            }
            txtQuestnAnsr.Text = ds.Tables[0].Rows[0][9].ToString();
            pctrProfile.Image = Image.FromFile(prflPath + txtEmail.Text + ".jpg");
            cn.Close();
            cn.Dispose();
            cmd.Dispose();
            da.Dispose();
            ds.Dispose();
        }
        void SaveProfile()
        {
            System.IO.File.Copy(ofd.FileName, prflPath + txtEmail.Text + ".jpg", true);
        }
        void ReplaceProfile()
        {
            if (ofd.FileName != "")
            {
                System.IO.File.Copy(ofd.FileName, prflPath + txtEmail.Text + ".jpg", true);
            }
        }
        void LoadUsers()
        {
            cmbxUsers.Items.Clear();
            cmbxUsers.Items.Add("-- Select User --");
            cmbxUsers.SelectedIndex = 0;
            qry = "SELECT usrNme FROM tblLoginMaster WHERE usrLognIsAct='TRUE'";
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                cmbxUsers.Items.Add(ds.Tables[0].Rows[x][0].ToString());
            }
            cn.Close();
            cn.Dispose();
            cmd.Dispose();
            da.Dispose();
            ds.Dispose();
        }
        void DeleteUser()
        {
            if (cmbxUsers.SelectedIndex > 0)
            {
                qry = "UPDATE tblLoginMaster SET usrLognIsAct='FALSE' WHERE usrNme='" + cmbxUsers.SelectedItem.ToString() + "'";
                Connection.AddUpdtDltOprtns(qry);
                qry = "UPDATE tblUserMaster SET usrIsAct='FALSE' WHERE usrId=(SELECT usrId FROM tblLoginMaster WHERE usrNme='"+cmbxUsers.SelectedItem.ToString()+"')";
                Connection.AddUpdtDltOprtns(qry);
                ClearControls();
            }
            else
                lblError.Text = " * Please Select Valid User Name";
        }
    }
}
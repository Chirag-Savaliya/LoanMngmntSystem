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
    public partial class frmAddNewUser : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        Label l;
        byte[] ImgArry;
        MemoryStream ms;
        Image img;

        int Uid;
        string qry;
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
            cmbxUsers.SelectedIndex = 0;
            SetRole();
            SetUserId();
            DisableControls();
            cmbSecQuestn.SelectedIndex = 0;
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
            if (btnADD.Text == "ADD")
            {
                btnADD.Text = "SAVE";
                ClearControls();
                EnableControls();
                if (int.Parse(l.Tag.ToString()) == 1)
                {
                    cmbxUsers.Enabled = true;
                    chbxAdmin.Enabled = true;
                }
                else if (int.Parse(l.Tag.ToString()) == 2)
                {
                    cmbxUsers.Enabled = false;
                    chbxAdmin.Enabled = false;
                }
                cmbxUsers.Enabled = false;
                btnEdit.Enabled = false;
                btnDlte.Enabled = false;
                txtFrstName.Focus();
            }
            else
            {
                if (CntrlsValidation() && lblError.Text.Length < 1)
                {
                    if (cmbSecQuestn.SelectedIndex == 0)
                        lblError.Text = "Please Select Valid Security Question";
                    else
                    {
                        try
                        {
                            qry = "INSERT INTO tblLoginMaster ";
                            qry += "VALUES(";
                            qry += "(SELECT MAX(usrId) FROM tblUserMaster)+1,";
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
                            SetUserProfile();
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
                            qry += "@Photo,";
                            qry += "'TRUE')";
                            cn = new SqlConnection(Connection.cnstr);
                            cn.Open();
                            cmd = new SqlCommand(qry, cn);
                            cmd.Parameters.AddWithValue("@Photo", ImgArry);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("User Added Successfully", "Fantastic Financial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearControls();
                            DisableControls();
                            btnADD.Text = "ADD";
                            btnEdit.Enabled = true;
                            btnDlte.Enabled = true;
                            chbxAdmin.Enabled = false;
                            cmbxUsers.Enabled = false;
                            SetRole();
                        }
                        catch (Exception User)
                        {
                            MessageBox.Show(User.ToString(), "Fantastic Financial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void btnUpld_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
                pctrProfile.Image = Image.FromFile(ofd.FileName.ToString());
            else
                pctrProfile.Image = null;
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
            cmbxUsers.SelectedIndex=0;
            rdbMale.Checked = true;
        }
        private void btnDlte_Click(object sender, EventArgs e)
        {
            if (btnDlte.Text == "REMOVE")
            {
                ClearControls();
                DisableControls();
                btnADD.Enabled = false;
                btnEdit.Enabled = false;
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
                    MessageBox.Show("User Removed Successfully", "Fantastic Financial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    btnADD.Enabled = true;
                    btnEdit.Enabled = true;
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "EDIT")
            {
                ofd = null;
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
            }
            else
            {
                if (CntrlsValidation() && lblError.Text.Length < 1)
                {
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
                    qry += "usrMoNo='" + txtMono.Text + "',usrPrfl=@Photo WHERE usrId=" + Uid + "";


                    if (ofd != null)
                    {
                        pctrProfile.Image = Image.FromFile(ofd.FileName.ToString());
                        img = Image.FromFile(ofd.FileName.ToString());
                        ms = new MemoryStream();
                        img.Save(ms, ImageFormat.Jpeg);
                        ImgArry = new byte[ms.Length];
                        ImgArry = ms.ToArray();
                    }
                    else if(pctrProfile.Image!=null)
                    {
                        img = pctrProfile.Image;
                        ms = new MemoryStream();
                        img.Save(ms, ImageFormat.Jpeg);
                        ImgArry = new byte[ms.Length];
                        ImgArry = ms.ToArray();
                    }
                        cn = new SqlConnection(Connection.cnstr);
                        cn.Open();
                        cmd = new SqlCommand(qry, cn);
                        cmd.Parameters.AddWithValue("@Photo", ImgArry);
                       cmd.ExecuteNonQuery();
                       cn.Close();

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
                    MessageBox.Show("User's Details Updated Successfully", "Fantastic Financial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    DisableControls();
                    btnEdit.Text = "EDIT";
                    txtEmail.ReadOnly = false;
                    btnADD.Enabled = true;
                    btnDlte.Enabled = true;
                    SetRole();
                }
            }
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            ClearControls();
            DisableControls();
            btnADD.Text = "ADD";
            btnEdit.Text = "EDIT";
            btnDlte.Text = "REMOVE";
            SetRole();
            chbxAdmin.Checked = false;
            chbxAdmin.Enabled = false;
            cmbxUsers.Enabled = false;
            if (btnEdit.Text == "EDIT")
                txtEmail.ReadOnly = false;
        }
        void BindControls()
        {
            int chk = 0;
            qry = "SELECT um.usrFrstName,um.usrLstName,um.usrBrthDate,um.usrGndr,um.usrAddrs,um.usrMoNo,um.usrPrfl,";
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
            try
            {
                ImgArry = (byte[])ds.Tables[0].Rows[0][6];
                ms = new MemoryStream(ImgArry);
                pctrProfile.Image = Image.FromStream(ms);
            }
            catch { }
            txtEmail.Text = ds.Tables[0].Rows[0][7].ToString();
            txtPass.Text = ds.Tables[0].Rows[0][8].ToString();
            txtCnfrmPass.Text = ds.Tables[0].Rows[0][8].ToString();
            for (int x = 1; x <= 4; x++)
            {
                if (ds.Tables[0].Rows[0][9].ToString() == cmbSecQuestn.Items[x].ToString())
                {
                    chk = x;
                }
            }
            if (chk > 0)
                cmbSecQuestn.SelectedIndex = chk;
            else
            {
                txtOwnQuestn.Text = ds.Tables[0].Rows[0][9].ToString();
            }
            txtQuestnAnsr.Text = ds.Tables[0].Rows[0][10].ToString();
            cn.Close();
            cn.Dispose();
            cmd.Dispose();
            da.Dispose();
            ds.Dispose();
        }
        void SaveProfile()
        {
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
        void SetUserId()
        {
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand("SELECT usrId FROM tblLoginMaster WHERE usrNme='" + l.Text.ToString() + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Uid = int.Parse(dr[0].ToString());
            }
            cn.Close();
        }
        void SetRole()
        {
            l = (Label)this.MdiParent.Controls["lblUser"];
            if (int.Parse(l.Tag.ToString()) == 1)
            {
                btnADD.Enabled = true;
                btnEdit.Enabled = true;
                btnDlte.Enabled = true;
            }
            else if (int.Parse(l.Tag.ToString()) == 2)
            {
                btnADD.Enabled = false;
                btnEdit.Enabled = true;
                btnDlte.Enabled = false;
                chbxAdmin.Enabled = false;
                cmbxUsers.Enabled = false;
            }
        }
        void SetUserProfile()
        {
            if (ofd != null)
            {
                img = Image.FromFile(ofd.FileName.ToString());
                ms = new MemoryStream();
                img.Save(ms, ImageFormat.Jpeg);
                ImgArry = new byte[ms.Length];
                ImgArry = ms.ToArray();
            }
        }
    }
}
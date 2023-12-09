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
    public partial class frmAddNewCstmr : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        byte[] ImgArry;
        MemoryStream ms;
        Image img;
        string qry;
        public frmAddNewCstmr()
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

        private void cmbx_Enter(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            c.BackColor = Color.LightGoldenrodYellow;
            c.ForeColor = Color.Teal;
        }

        private void cmbx_Leave(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
        }

        private void frmAddNewCstmr_Load(object sender, EventArgs e)
        {
            cmbxCstmr.SelectedIndex = 0;
            DisableControls();
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
            else if (txtPinno.TextLength < 1)
            {
                lblError.Text = " * Pincode Must Not Be Empty";
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
            else if (!TextBoxesValidation(txtPinno))
            {
                lblError.Text = " * Please Enter Valid Pincode";
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
            else if (t.Name == "txtPinno")
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
                if (count < 1 && txtPinno.Text.Length == 6)
                {
                    lblError.Text = "";
                }
                else
                    lblError.Text = "Invalid Pin No";
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
            if (lblError.Text.Length < 1)
                return true;
            else
                return false;
        }

        private void btnADD_Click(object sender, EventArgs ex)
        {
            if (btnADD.Text == "ADD")
            {
                btnADD.Text = "SAVE";
                ClearControls();
                btnEdit.Enabled = false;
                btnDlte.Enabled = false;
                EnableControls();
                btnUpld.Focus();
            }
            else
            {
                if (CntrlsValidation() && lblError.Text.Length < 1)
                {
                    qry = "INSERT INTO tblCstmrPrsnlDtls ";
                    qry += "VALUES(";
                    qry += "(SELECT MAX(cstmrId) FROM tblCstmrPrsnlDtls)+1,";
                    qry += "'" + txtFrstName.Text + "',";
                    qry += "'" + txtLstName.Text + "',";
                    qry += "'" + txtAddrs.Text + "',";
                    qry += "'" + txtBrthDate.Text + "',";  
                    qry += "'" + txtEmail.Text + "',";
                    if (rdbMale.Checked)
                        qry += "'Male',";
                    else
                    {
                        qry += "'Female',";
                    }
                    qry += "'" + txtMono.Text + "',";
                    qry += "'" + txtPinno.Text + "',";
                    qry += "@Photo,";
                    qry += "'TRUE')";
                    img = Image.FromFile(ofd.FileName.ToString());
                    ms = new MemoryStream();
                    img.Save(ms, ImageFormat.Jpeg);
                    ImgArry = new byte[ms.Length];
                    ImgArry = ms.ToArray();
                    cn = new SqlConnection(Connection.cnstr);
                    cn.Open();
                    cmd = new SqlCommand(qry, cn);
                    cmd.Parameters.AddWithValue("@Photo", ImgArry);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Customer Added Successfully", "Fantastic Financial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    btnADD.Text = "ADD";
                    btnEdit.Enabled = true;
                    btnDlte.Enabled = true;
                    DisableControls();
                }
            }
        }
        private void btnUpld_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
                pctrProfile.Image = Image.FromFile(ofd.FileName.ToString());
            else pctrProfile.Image = null;
        }
        void ClearControls()
        {
            txtFrstName.Clear();
            txtLstName.Clear();
            txtAddrs.Clear();
            txtBrthDate.Clear();
            txtMono.Clear();
            txtEmail.Clear();
            txtPinno.Clear();
            lblError.Text = "";
            pctrProfile.Image = null;
            rdbMale.Checked = true;
        }
        private void btnDlte_Click(object sender, EventArgs e)
        {
            if (btnDlte.Text == "REMOVE")
            {
                ClearControls();
                LoadCustomers();
                DisableControls();
                cmbxCstmr.Enabled = true;
                btnADD.Enabled = false;
                btnEdit.Enabled = false;
                cmbxCstmr.Enabled = true;
                btnDlte.Text = "DELETE";
            }
            else
            {
                if (lblError.Text.Length < 1 && cmbxCstmr.SelectedIndex > 0)
                {
                    DeleteCustomer();
                    MessageBox.Show("Customer Removed Successfully", "Fantastic Financial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDlte.Text = "REMOVE";
                    ClearControls();
                    btnADD.Enabled = true;
                    btnEdit.Enabled = true;
                    cmbxCstmr.Enabled = false;
                    cmbxCstmr.SelectedIndex = 0;
                    DisableControls();
                }
                else
                    lblError.Text = "* Please Select Valid Customer Id";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
             
            if (btnEdit.Text == "EDIT")
            {
                ofd = null;
                ClearControls();
                LoadCustomers();
                DisableControls();
                cmbxCstmr.Enabled = true;
                btnEdit.Text = "UPDATE";
                btnADD.Enabled = false;
                btnDlte.Enabled = false;
                cmbxCstmr.Focus();
            }
            else
            {
                if (CntrlsValidation() && lblError.Text.Length < 1 && cmbxCstmr.SelectedIndex > 0)
                {
                    qry = "UPDATE tblCstmrPrsnlDtls SET ";
                    qry += "cstmrFrstNme='" + txtFrstName.Text + "',";
                    qry += "cstmrLstNme='" + txtLstName.Text + "',";
                    qry += "cstmrAddrs='" + txtAddrs.Text + "',";
                    qry += "cstmrBrthDt='" + txtBrthDate.Text + "',";
                    qry += "cstmrEml='" + txtEmail.Text + "',";
                    if (rdbMale.Checked)
                        qry += "cstmrGndr='Male',";
                    else
                    {
                        qry += "cstmrGndr='Female',";
                    }
                    qry += "cstmrMono='" + txtMono.Text + "',";
                    qry += "cstmrPinCod='" + txtPinno.Text + "',cstmrPrfl=@Photo WHERE cstmrId=" + cmbxCstmr.SelectedItem + "";
                    if (ofd != null)
                    {
                        pctrProfile.Image = Image.FromFile(ofd.FileName.ToString());
                    }
                    img = pctrProfile.Image;
                    ms = new MemoryStream();
                    img.Save(ms, ImageFormat.Jpeg);
                    ImgArry = new byte[ms.Length];
                    ImgArry = ms.ToArray();
                    cn = new SqlConnection(Connection.cnstr);
                    cn.Open();
                    cmd = new SqlCommand(qry, cn);
                    cmd.Parameters.AddWithValue("@Photo", ImgArry);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Customer's Details Updated Successfully", "Fantastic Financial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    cmbxCstmr.SelectedIndex = 0;
                    btnEdit.Text = "EDIT";
                    btnADD.Enabled = true;
                    btnDlte.Enabled = true;
                    cmbxCstmr.Enabled = false;
                    DisableControls();
                }
                else
                    lblError.Text = "* Please Select Valid Customer Id";
            }
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            ClearControls();
            ResetCntrols();
            cmbxCstmr.SelectedIndex = 0;
            cmbxCstmr.Enabled = false;
            DisableControls();
        }
        void BindControls()
        {
            int chk = 0;
            qry = "SELECT cstmrFrstNme,cstmrLstNme,cstmrAddrs,cstmrBrthDt,cstmrEml,cstmrGndr,cstmrMono,cstmrPinCod,cstmrPrfl ";
            qry += "FROM tblCstmrPrsnlDtls ";
            qry += "WHERE cstmrId=" + cmbxCstmr.SelectedItem + " AND cstmrIsAct='TRUE'";

            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            txtFrstName.Text = ds.Tables[0].Rows[0][0].ToString();
            txtLstName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAddrs.Text = ds.Tables[0].Rows[0][2].ToString();
            txtBrthDate.Text = ds.Tables[0].Rows[0][3].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][4].ToString();
            if (ds.Tables[0].Rows[0][5].ToString() == "Male")
                rdbMale.Checked = true;
            else
            {
                rdbFemale.Checked = true;
            }
            txtMono.Text = ds.Tables[0].Rows[0][6].ToString();
            txtPinno.Text = ds.Tables[0].Rows[0][7].ToString();

            ImgArry = (byte[])ds.Tables[0].Rows[0][8];
            ms = new MemoryStream(ImgArry);
            pctrProfile.Image = Image.FromStream(ms);
           
            cn.Close();
            cn.Dispose();
            cmd.Dispose();
            da.Dispose();
            ds.Dispose();
        }
        void LoadUsers()
        {
            qry = "SELECT usrNme FROM tblLoginMaster WHERE usrLognIsAct='TRUE'";
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            cn.Dispose();
            cmd.Dispose();
            da.Dispose();
            ds.Dispose();
        }
        void ResetCntrols()
        {
            btnADD.Enabled = true;
            btnADD.Text = "ADD";
            btnEdit.Enabled = true;
            btnEdit.Text = "EDIT";
            btnDlte.Enabled = true;
            btnDlte.Text = "REMOVE";
        }
        void DisableControls()
        {
            txtFrstName.Enabled = false;
            txtLstName.Enabled = false;
            txtAddrs.Enabled = false;
            txtBrthDate.Enabled = false;
            txtMono.Enabled = false;
            txtPinno.Enabled = false;
            txtEmail.Enabled = false;
            pctrProfile.Enabled = false;
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
            txtPinno.Enabled = true;
            txtEmail.Enabled = true;
            pctrProfile.Enabled = true;
            rdbMale.Enabled = true;
            rdbFemale.Enabled = true;
            btnUpld.Enabled = true;
        }
        void LoadCustomers()
        {
            cmbxCstmr.Items.Clear();
            cmbxCstmr.Items.Add("-- Select Customer Id --");
            cmbxCstmr.SelectedIndex = 0;
            qry = "SELECT cstmrId FROM tblCstmrPrsnlDtls WHERE cstmrIsAct='TRUE'";
            cn = new SqlConnection(Connection.cnstr);
            cn.Open();
            cmd = new SqlCommand(qry, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                cmbxCstmr.Items.Add(ds.Tables[0].Rows[x][0].ToString());
            }
            cn.Close();
            cn.Dispose();
            cmd.Dispose();
            da.Dispose();
            ds.Dispose();
        }
        void DeleteCustomer()
        {
            qry = "UPDATE tblCstmrPrsnlDtls SET ";
            qry += "cstmrIsAct='FALSE' ";
            qry += "WHERE cstmrId=" + cmbxCstmr.SelectedItem + "";
            Connection.AddUpdtDltOprtns(qry);
        }

        private void cmbxCstmr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxCstmr.Items.Count > 1)
            {
                if (cmbxCstmr.SelectedIndex > 0)
                {
                    ClearControls();
                    EnableControls();
                    BindControls();
                }
                else
                {
                    ClearControls();
                    DisableControls();
                }
            }
        }
    }
}
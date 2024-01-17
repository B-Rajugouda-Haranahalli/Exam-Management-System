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

namespace Examination
{
    
    public partial class ChangePassword : Form
    {
        SqlConnection con;
        string userName;
        int userId;
        public string UserName
        {
            set
            {
                userName = value;
            }
            get
            {
                return userName;
            }
        }
        public int UserId
        {
            set
            {
                userId = value;
            }
            get
            {
                return userId;
            }
        }
        public ChangePassword()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString ="Databse Connection";

        }

       

        private void lnklogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin log = new frmLogin();
            this.Dispose();
            log.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AdminHome admin = new AdminHome();
            admin.UserName = userName;
            this.Dispose();
            admin.Show();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            lblUser.Text = userName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtOldPwd, "Enter the Existing Password ");
                txtOldPwd.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtNewPwd.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNewPwd, "Enter the New Password ");
                txtNewPwd.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (!txtNewPwd.Text.Trim().Equals(txtCnfPwd.Text.Trim()))
            {
                errorProvider1.SetError(txtCnfPwd, " Password Do not Match");
                txtCnfPwd.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmdchkPwd = new SqlCommand("select password from users where userId=" + userId);
            cmdchkPwd.Connection = con;
            string pwd = cmdchkPwd.ExecuteScalar().ToString();
            cmdchkPwd.Dispose();
            if (pwd == txtOldPwd.Text.Trim())
            {
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = con;
                cmdUpdate.CommandText = "update users set password ='" + txtNewPwd.Text.Trim() + "' where userid =" + userId;
                if (cmdUpdate.ExecuteNonQuery ()> 0)
                {
                    MessageBox.Show("password change Succesfully");
                    frmLogin login = new frmLogin();
                    this.Close();
                    login.ShowDialog();
                    this.Dispose();


                }
                else
                {
                    lblMsg.Text = "Change Password Failed ";
                    lblMsg.ForeColor = Color.Red;

                }
            }
            else
            {
                lblMsg.Text = "Invaild Password : you seem to be unauthorised";
                lblMsg.ForeColor = Color.Red;


            }
            //con.Close();
        }
    }
}

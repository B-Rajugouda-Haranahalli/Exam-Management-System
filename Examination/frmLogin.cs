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
    public partial class frmLogin : Form
    {
        SqlConnection con;
        public frmLogin()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-68L5NME\SQLEXPRESS; Initial Catalog=Exam;Integrated Security=true";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length == 0)
            {
                lblMsg.Text = "enter email ";
                lblMsg.ForeColor = Color.Red;
                txtEmail.Focus();

                return;
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmdlogin = new SqlCommand("select userId,name,password, roleid from Users where email='" + txtEmail.Text.Trim() + "'", con);
            SqlDataReader dr = cmdlogin.ExecuteReader();
            if (dr.HasRows)
            {
                //MessageBox.Show("ok");

                dr.Read();
                if (dr[2].ToString().Equals(txtPwd.Text.Trim()))
                {
                    if (Convert.ToInt32(dr[3]) == 1)
                    {
                        AdminHome admin = new AdminHome();
                        admin.UserName = dr[1].ToString();
                        admin.UserId = Convert.ToInt32(dr[0]);
                        this.Hide();
                        admin.ShowDialog();

                    }
                    else if (Convert.ToInt32(dr[3]) == 2)
                    {
                        StaffHome staff = new StaffHome();
                        staff.UserName = dr[1].ToString();
                        staff.UserId = Convert.ToInt32(dr[0]);
                        this.Hide();
                        staff.ShowDialog();


                    }
                    else if (Convert.ToInt32(dr[3]) == 3)
                    {
                        StudentHome st = new StudentHome();
                        st.UserName = dr[1].ToString();
                        st.UserId = Convert.ToInt32(dr[0]);
                        
                        st.ShowDialog();
                        this.Hide();
                    }
                }
                else
                {
                    lblMsg.Text = "Authentication Failed : Incorrect Password";
                    lblMsg.ForeColor = Color.Red;
                }
            }
            else
            {
                lblMsg.Text = "Authentication Failed : Incorrect Email Id";
                lblMsg.ForeColor = Color.Red;
            }
            con.Close();

        }
    }
}

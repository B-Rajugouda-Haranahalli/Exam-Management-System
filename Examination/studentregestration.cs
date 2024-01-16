using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Examination
{
    public partial class studentregestration : Form
    {
        SqlConnection con;
        
        public studentregestration()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-68L5NME\SQLEXPRESS; Initial Catalog=Exam;Integrated Security=true";

        }
        private void studentregestration_Load(object sender, EventArgs e)
        {
            lblid.Text = userid().ToString();
        }
        public int userid()
        {
            SqlCommand uid = new SqlCommand("select max(userid)+1 from users", con);
            if (con.State == ConnectionState.Closed)
                con.Open();
            int use = Convert.ToInt32(uid.ExecuteScalar());
            con.Close();
            return use;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim().Length == 0)
            {
                lblmsg.Text = "Please Enter : Name";
                lblmsg.ForeColor = Color.Red;
                txtname.Focus();
                return;
            }
            if (txtemail.Text.Trim().Length == 0)
            {
                lblmsg.Text = "Please Enter : Email Id";
                lblmsg.ForeColor = Color.Red;
                txtemail.Focus();
                return;
            }
            if (txtmobile.Text.Trim().Length == 0)
            {
                lblmsg.Text = "Please Enter : Mobile Number";
                lblmsg.ForeColor = Color.Red;
                txtmobile.Focus();
                return;
            }
            if (txtpwd.Text.Trim().Length == 0)
            {
                lblmsg.Text = "Please Enter : Password";
                lblmsg.ForeColor = Color.Red;
                txtpwd.Focus();
                return;
            }
            if (txtcnfpwd.Text.Trim()!=txtpwd.Text.Trim())
            {
                lblmsg.Text = "Please Enter : Same Password ";
                lblmsg.ForeColor = Color.Red;
                txtcnfpwd.Focus();
                return;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into users values(" + Convert.ToInt32(lblid.Text) + ",'" + txtname.Text + "','" + txtemail.Text + "'," + txtmobile.Text + ",'" + txtpwd.Text + "',3,getdate()," + Convert.ToInt32(lblid.Text) + ")";
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                lblmsg.Text = "Student Created ";
                lblmsg.ForeColor = Color.Green;
            }
            else
            {
                lblmsg.Text = "Failed To Create Student Account";
                lblmsg.ForeColor = Color.Red;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

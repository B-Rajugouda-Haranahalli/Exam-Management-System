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
    public partial class StaffManagement : Form
    {
        SqlConnection con;
        string userName;
        int userId;
        int action = 1;
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
        public StaffManagement()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-68L5NME\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=true";
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            lblUser.Text = userName;
            lblid.Text = userid().ToString();
            cmbrole.DataSource = role();
            cmbrole.DisplayMember ="Role";
            cmbrole.ValueMember = "RoleId";
            cmbrole.SelectedIndex = 0;

        }
        int userid()
        {
            SqlCommand cid = new SqlCommand();
            cid.Connection = con;
            cid.CommandText = "Select max(UserId)+1 from users";
            if (con.State == ConnectionState.Closed)
                con.Open();
            int uid = Convert.ToInt32(cid.ExecuteScalar());
            con.Close();
            return uid;
        }
        DataTable role()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from UserRoles where roleid in (1,2)", con);
            DataTable dtrole = new DataTable();
            da.Fill(dtrole);
            DataRow r = dtrole.NewRow();
            r[0] = 0;
            r[1] = "Prefer a Role";
            dtrole.Rows.InsertAt(r, 0);
            return dtrole;

        }

        private void lnklogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin log = new frmLogin();
            this.Dispose();
            log.ShowDialog();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                lblMsg.Text = " Enter Name";
                lblMsg.ForeColor = Color.Red;
                txtName.Focus();
                return;
            }
            if (txtemai.Text.Trim().Length == 0)
            {
                lblMsg.Text = " Enter Email";
                lblMsg.ForeColor = Color.Red;
                txtemai.Focus();
                return;
            }
            if (txtmobile.Text.Trim().Length == 0)
            {
                lblMsg.Text = " Enter Mobile Number";
                lblMsg.ForeColor = Color.Red;
                txtmobile.Focus();
                return;
            }
            if (cmbrole.SelectedIndex == 0)
            {
                lblMsg.Text = " Select Preferred Role";
                lblMsg.ForeColor = Color.Red;
                cmbrole.Focus();
                return;
            }
            
            if (con.State == ConnectionState.Closed)
                con.Open();
            string name = txtName.Text;
            int id = userid();
            string email = txtemai.Text;
            long mobile = Convert.ToInt64(txtmobile.Text);
            int roleid = Convert.ToInt32(cmbrole.SelectedValue);
            string pass = Convert.ToString(mobile);
            SqlCommand sm = new SqlCommand();
            sm.Connection = con;
            if (action == 1)
            {
                sm.CommandText = "insert into users values("+id+",'"+name+"','" + email+"',"+mobile+",'"+pass+"',"+roleid+","+"getdate(),"+userId+")";
            }
            else if (action == 2)
            {
                sm.CommandText = "update users set name='" + name + "', email='" + email + "',mobile=" + mobile + ",roleid=" + roleid+"where userid="+Convert.ToInt32(lblid.Text);
            }
            con.Open();
            if (sm.ExecuteNonQuery() > 0)
            {
                if (action == 1)
                {
                    lblMsg.Text = "User has been Created" + txtName.Text;
                    lblMsg.ForeColor = Color.Blue;
                }
                else if (action == 2)
                {
                    lblMsg.Text = " User Has Updated for : " + txtName.Text;
                    lblMsg.ForeColor = Color.Blue;
                    action = 1;
                }
                btnSave.Enabled = false;
            }
            else
            {
                if (action == 1)
                {
                    lblMsg.Text = "Failed to Create User";
                    lblMsg.ForeColor = Color.Red;
                }
                else if (action == 2)
                {
                    lblMsg.Text = "Failed to Update User";
                    lblMsg.ForeColor = Color.Red;
                }
            }
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtsearchname.Text.Trim().Length == 0)
            {
                lblsearchresult.Text = "Enter User Name";
                lblsearchresult.ForeColor = Color.Red;
                lblsearchresult.Focus();
                txtsearchname.Focus();
            }
            else
            {
                datagv();
            }
        }
        private void datagv()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Users where name like '%" + txtsearchname.Text.Trim() + "%'", con);
            DataTable dtuser = new DataTable();
            da.Fill(dtuser);
            lblsearchresult.Text = dtuser.Rows.Count + "Record(s) Found";
            lblsearchresult.ForeColor = Color.Blue;
            if (dtuser.Rows.Count > 0)
            {
                dgvuser.DataSource = dtuser;
            }
        }

        private void dgvuser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            lblid.Text = dgvuser.Rows[index].Cells[0].Value.ToString();
            txtName.Text= dgvuser.Rows[index].Cells[1].Value.ToString();
            txtemai.Text= dgvuser.Rows[index].Cells[2].Value.ToString();
            txtmobile.Text= dgvuser.Rows[index].Cells[3].Value.ToString();
            cmbrole.SelectedValue= dgvuser.Rows[index].Cells[5].Value.ToString();
            btnSave.Enabled = true;
            action = 2;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsearchname.Text = "";
            lblsearchresult.Text = "";
            dgvuser.DataSource = null;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            AdminHome ad = new AdminHome();
            this.Dispose();
            ad.ShowDialog();
        }
    }
}

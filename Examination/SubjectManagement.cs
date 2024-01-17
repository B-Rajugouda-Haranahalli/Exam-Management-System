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
    public partial class SubjectManagement : Form
    {
        string userName;
        int userId;
        int action = 1;
        SqlConnection con;
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
        public SubjectManagement()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString ="Databse Connection";
        }

        private void lnklogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin ad = new frmLogin();
            this.Dispose();
            ad.ShowDialog();

        }

        private void SubjectManagement_Load(object sender, EventArgs e)
        {
            lblUser.Text = userName;
            lblsubid.Text = subid().ToString();
            cmbusername.DataSource = stafname();
            cmbusername.DisplayMember = "name";
            cmbusername.ValueMember = "userid";
            cmbusername.SelectedValue = 0;
           // cmbsubjects.DataSource = subcombo();
            //cmbsubjects.DisplayMember = "subjectname";
            //cmbsubjects.ValueMember = "subjectid";
           // cmbsubjects.SelectedValue = 0;
            
        }
        //cmbusername
        DataTable stafname()
        {
            SqlDataAdapter da = new SqlDataAdapter("select userid,name from users where roleid in (1,2)", con);
            DataTable dtstaffname = new DataTable();
            da.Fill(dtstaffname);
            DataRow r = dtstaffname.NewRow();
            r[0] = 0;
            r[1] = "Choose a Staff";
            dtstaffname.Rows.InsertAt(r, 0);
            return dtstaffname;
        }
        //cmbsubjects
        DataTable subcombo()
        {
           
            SqlDataAdapter da = new SqlDataAdapter("select * from Subjects where subjectId not in(select  subid from SubjectAllocation where staffid = " + Convert.ToInt32(cmbusername.SelectedValue) + ")",con);
            DataTable dt = new DataTable();
           da.Fill(dt);
            DataRow r = dt.NewRow();
            r[0] = 0;
            r[1] = "Choose a Subject";
            dt.Rows.InsertAt(r, 0);
            return dt;        
        }

        int subid()
        {
            SqlCommand sid = new SqlCommand();
            sid.Connection = con;
            sid.CommandText = "Select max(subjectid)+1 from Subjects";
            if (con.State == ConnectionState.Closed)
                con.Open();
            int uid = Convert.ToInt32(sid.ExecuteScalar());
            con.Close();
            return uid;
        }

        private void btnsubSave_Click(object sender, EventArgs e)
        {
            if (txtsubject.Text.Trim().Length == 0)
            {
                lblsubjectresult.Text = " Enter the Subject";
                lblsubjectresult.ForeColor = Color.Red;
                return;
            }
            int subid = Convert.ToInt32(lblsubid.Text);
            string subname = txtsubject.Text.Trim();
            SqlCommand cmdsave = new SqlCommand();
            cmdsave.Connection = con;
            con.Open();
            if (action == 1)
            {
                cmdsave.CommandText = "insert into  subjects values (" + subid + ",'" + subname + "')";
            }
            else if (action == 2)
            {
                cmdsave.CommandText = "update subjects set subjectname='" + subname + "' where subjectid=" + Convert.ToInt32(lblsubid.Text);
            }
            

            if (cmdsave.ExecuteNonQuery() > 0)
            {
                if (action == 1)
                {
                    lblsubjectresult.Text ="Subject has Added";
                    lblsubjectresult.ForeColor = Color.BlueViolet;
                }
                else if (action == 2)
                {
                    lblsubjectresult.Text ="Subject Name has Updated";
                    lblsubjectresult.ForeColor = Color.BlueViolet;
                    action = 1;
                }
                btnsubSave.Enabled = true;
                con.Close();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Subjects", con);
            DataTable subt = new DataTable();
            da.Fill(subt);
            if (subt.Rows.Count > 0)
            {
                dgvSubjects.DataSource = subt;
            }
        }

        private void dgvSubjects_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            lblsubid.Text = dgvSubjects.Rows[index].Cells[0].Value.ToString();
            txtsubject.Text = dgvSubjects.Rows[index].Cells[1].Value.ToString();
            action = 2;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsubject.Text = "";
            dgvSubjects.DataSource = null;
            lblsubid.Text = subid().ToString();
            cmbsubjects.SelectedIndex = 0;
            cmbusername.SelectedIndex = 0;
            dgvsubstaff.DataSource = 0;
            con.Close();

        }

        private void btnstaffsubsave_Click(object sender, EventArgs e)
        {
            if (cmbusername.SelectedIndex == 0)
            {
                cmbusername.Focus();
                lblsubjectresult.Text = "choose The Staff Name";
                lblsubjectresult.ForeColor = Color.Red;

                return;
            }
            if (cmbsubjects.SelectedIndex == 0)
            {
                cmbsubjects.Focus();
                lblsubjectresult.Text = "Choose The Subject Name";
                lblsubjectresult.ForeColor = Color.Red;
                return;
            }
           
            con.Open(); 
            SqlCommand staffsave = new SqlCommand("insert into subjectallocation values(" + cmbsubjects.SelectedValue + "," + cmbusername.SelectedValue +",getdate(),"+UserId+")", con);
            if (staffsave.ExecuteNonQuery() > 0)
            {
                lblsubjectresult.Text = " Added subject";
                lblsubjectresult.ForeColor = Color.GreenYellow;        
            }

            con.Close();
        }

        private void btnshowsubjectstaff_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from subjectallocation", con);
            DataTable ss = new DataTable();
            da.Fill(ss);
            if (ss.Rows.Count > 0)
            {
                dgvsubstaff.DataSource = ss;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            AdminHome ad = new AdminHome();
            this.Dispose();
            ad.ShowDialog();
        }

        private void cmbusername_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Subjects where subjectId not in(select  subid from SubjectAllocation where staffid = " + Convert.ToInt32(cmbusername.SelectedValue) + ")", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbsubjects.DataSource = dt;
                cmbsubjects.DisplayMember = "SubjectName";
                cmbsubjects.ValueMember = "subjectid";
            }
            catch
            {

            }
        }

      
    }
}

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
    public partial class QuestionBank : Form
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

        public QuestionBank()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString ="Databse Connection";
        }

        private void StaffHome_Load(object sender, EventArgs e)
        {
            lblUser.Text = userName;
            lblqid.Text = QuestionBankId().ToString();
            cmbchooseSubject.DataSource = chooseSubject();
            cmbchooseSubject.DisplayMember = "subjectname"; 
            cmbchooseSubject.ValueMember = "subjectid";
            cmbchooseSubject.SelectedIndex = 0;

        }

        DataTable chooseSubject()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from subjects  where subjectid in (select subid from subjectallocation where staffid =" + userId+")", con);

            DataTable cs = new DataTable();
            da.Fill(cs);
            DataRow r = cs.NewRow();
            r[0] = 0;
            r[1] = 1;
            cs.Rows.InsertAt(r, 0);
            return cs;
        }
        private void lnklogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin log = new frmLogin();
            this.Dispose();
            log.ShowDialog();
        }
        public int QuestionBankId()
        {
            SqlCommand qbid = new SqlCommand("select max(questionid)+1 from questionBank", con);
            if (con.State == ConnectionState.Closed)
            {       
                con.Open();
            }
            int qid = Convert.ToInt32(qbid.ExecuteScalar());
            con.Close();
            return qid;
        }
        private void cmbchooseSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text.Trim().Length == 0)
            {
                lblmsg.Text = "Please enter : Question";
                lblmsg.ForeColor = Color.Red;
                lblmsg.Focus();
                
            }
            if (txtQptionA.Text.Trim().Length == 0)
            {
                lblmsg.Text = "Please enter : Option A ";
                lblmsg.ForeColor = Color.Red;
                lblmsg.Focus();

            }
            if (txtQptionB.Text.Trim().Length == 0)
            {
                lblmsg.Text = "Please enter : Option B ";
                lblmsg.ForeColor = Color.Red;
                lblmsg.Focus();

            }
            if (txtQptionC.Text.Trim().Length == 0)
            {
                lblmsg.Text = "Please enter : Option C ";
                lblmsg.ForeColor = Color.Red;
                lblmsg.Focus();

            }
            if (txtQptionD.Text.Trim().Length == 0)
            {
                lblmsg.Text = "Please enter : Option D ";
                lblmsg.ForeColor = Color.Red;
                lblmsg.Focus();

            }
            if (cmbchooseSubject.SelectedIndex == 0)
            {
                lblmsg.Text = "Please Choose a Subject";
                lblmsg.ForeColor = Color.Red;
                lblmsg.Focus();
            }
            SqlCommand cmdSAve = new SqlCommand();
            cmdSAve.Connection = con;
            if (action == 1)
            {
                cmdSAve.CommandText = "insert into QuestionBank  values(@QuestionId, @SubjectId, @StaffId, getdate(), @Questions, @OptionA, @OptionB, @OptionC, @OptionD, @CorrectAnswer)";
            }
            else if (action == 2)
            {
                cmdSAve.CommandText = "update QuestionBank set SubjectId= @SubjectId, StaffId=@StaffId,Questions = @Questions, OptionA = @OptionA, OptionB = @OptionB, OptionC = @OptionC, OptionD = @OptionD, CorrectAnswer = @CorrectAnswer where QuestionId=@QuestionId";
            }
            char ans = ' ';
            if (rbtnA.Checked)
                ans = 'A';
            else if (rbtnB.Checked)
                ans = 'B';
            else if (rbtnC.Checked)
                ans = 'C';
            else if (rbtnD.Checked)
                ans = 'D';
            cmdSAve.Parameters.AddWithValue("@QuestionId", Convert.ToInt32(lblqid.Text));
            cmdSAve.Parameters.AddWithValue("@SubjectId", Convert.ToInt32(cmbchooseSubject.SelectedValue));
            cmdSAve.Parameters.AddWithValue("@StaffId", UserId);
            cmdSAve.Parameters.AddWithValue("@DOC", DateTime.Now);
            cmdSAve.Parameters.AddWithValue("@Questions", txtQuestion.Text);
            cmdSAve.Parameters.AddWithValue("@OptionA", txtQptionA.Text);
            cmdSAve.Parameters.AddWithValue("@OptionB", txtQptionB.Text);
            cmdSAve.Parameters.AddWithValue("@OptionC", txtQptionC.Text);
            cmdSAve.Parameters.AddWithValue("@OptionD", txtQptionD.Text);
            cmdSAve.Parameters.AddWithValue("@CorrectAnswer", ans);
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (cmdSAve.ExecuteNonQuery() > 0)
            {
                if (action == 1)
                {
                    lblmsg.Text = "Question added : " + txtQuestion.Text;
                }
                else if (action == 2)
                {
                    lblmsg.Text = "Question updated: " + txtQuestion.Text;
                    BindGrid();
                    action = 1;
                }
                lblmsg.ForeColor = Color.Green;
                lblmsg.Enabled = false;
            }
            else
            {
                if (action == 1)
                {
                    lblmsg.Text = "Failed to save questions";
                }
                else if (action == 2)
                {
                    lblmsg.Text = "Failed to save updated questions";
                }
                lblmsg.ForeColor = Color.Red;
            }
            con.Close();






        }
        private void BindGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from QuestionBank where Questions like '%" + textBox1.Text.Trim() + "%'", con);
            DataTable dtUsersRole = new DataTable();
            da.Fill(dtUsersRole);
            lblmsg.Text = dtUsersRole.Rows.Count + "Record(s) Found";
            lblmsg.ForeColor = Color.Blue;

            if (dtUsersRole.Rows.Count > 0)
            {
                dgvqb.DataSource = dtUsersRole;
            }
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                lblmsg.Text = "Search here";
                lblmsg.ForeColor = Color.Red;
                lblmsg.Focus();
                textBox1.Focus();
            }
            else
            {
                BindGrid();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            lblqid.Text = QuestionBankId().ToString();
            btnSave.Enabled = true;
            txtQuestion.Text = "";
            txtQptionA.Text = " ";
            txtQptionB.Text = " ";
            txtQptionC.Text = " ";
            txtQptionD.Text = " ";
            rbtnA.Checked = false;
            rbtnB.Checked = false;
            rbtnC.Checked = false;
            rbtnD.Checked = false;
            lblmsg.Text = "";
            dgvqb.DataSource = null;
        }
    }
}

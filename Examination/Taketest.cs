using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Examination
{
    public partial class Taketest : Form
    {
        string userName;
        int userId;
        ArrayList questionseries = new ArrayList();
        int index = 0;
        


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
        public Taketest()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString ="Databse Connection";
        }

        private void Taketest_Load(object sender, EventArgs e)
        {
            lbluser.Text = userName;
            cmbsubject.DataSource = sub();
            cmbsubject.DisplayMember = "Subjectname";
            cmbsubject.ValueMember = "subjectid";
            cmbsubject.SelectedIndex = 0;

        }

        private void lnklogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentHome st = new StudentHome();
            this.Dispose();
            st.ShowDialog();
        }
        DataTable sub()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select subjectid,subjectname from Subjects ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow r = dt.NewRow();
            r[0] = 0;
            r[1] = "Subjects";
            dt.Rows.InsertAt(r, 0);
            return dt;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
           
            if (cmbsubject.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose the Subject");
                return;
            }
            
            ArrayList listofqs = new ArrayList();
            SqlCommand cmd = new SqlCommand("select questionid from questionBank where subjectid=" + Convert.ToInt32(cmbsubject.SelectedValue), con);
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listofqs.Add(dr[0]);
            }
            dr.Close();

            Hashtable qp = new Hashtable();
            Random rnd = new Random();
            while(qp.Count<7)
            {
                int questionindex = rnd.Next(listofqs.Count - 1);
                qp[listofqs[questionindex]] = "NA";

            }
            ICollection keys = qp.Keys;
            foreach (int i in keys)
            {
                questionseries.Add(i);
            }
            Display(index);
        
        }

        public void Display(int index) 
        {
            SqlCommand cmdgetqns = new SqlCommand("Select questions,optionA,optionb,optionc,optiond from questionbank where questionid=@questionid", con);
            cmdgetqns.Parameters.AddWithValue("@questionid", questionseries[index]);

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataReader drquestion = cmdgetqns.ExecuteReader();

            if(drquestion.Read())
            {
                lblquestion.Text = drquestion[0].ToString();
                lbloptionA.Text = drquestion[1].ToString();
                lbloptionB.Text = drquestion[2].ToString();
                lbloptionC.Text = drquestion[3].ToString();
                lbloptionD.Text = drquestion[4].ToString();
            }
            drquestion.Close();
            con.Close();

        }

        public int stexamid()
        {
            SqlCommand uid = new SqlCommand("select isnull(max(examid)+1,1) from examQ", con);
            if (con.State == ConnectionState.Closed)
                con.Open();
            int use = Convert.ToInt32(uid.ExecuteScalar());
            con.Close();
            return use;
        }

        public void exam()
        {
            SqlCommand cmdex = new SqlCommand();
            cmdex.CommandText = "insert into examQ values("+stexamid()+"," + cmbsubject.SelectedValue + "," + UserId + ",Getdate())";
            cmdex.Connection = con;
            if (con.State == ConnectionState.Closed)
                con.Open();

            if (cmdex.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Saved");
            }
        
            con.Close();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
                char ans = 'N';
                SqlCommand cmdsave = new SqlCommand();
                if (rbA.Checked)
                {
                    ans = 'A';

                }
                else if (rbB.Checked)
                {
                    ans = 'B';

                }
                else if (rbC.Checked)
                {
                    ans = 'C';

                }
                else if (rbD.Checked)
                {
                    ans = 'D';

                }
            SqlCommand cmdexamid = new SqlCommand();
            cmdexamid.CommandText = "Select examid from examQ where studentid=" + userId;
            cmdexamid.Connection = con;
            if (con.State == ConnectionState.Closed)
                con.Open();
            
            int examid=Convert.ToInt32(cmdexamid.ExecuteScalar());
            if (index < questionseries.Count)
            {
                cmdsave.CommandText = "insert into answers values ( "+examid+"," + questionseries[index] + ",'" + ans + "')";
                cmdsave.Connection = con;
                if (con.State == ConnectionState.Closed)
                    con.Open();

                if (cmdsave.ExecuteNonQuery() > 0)
                {
                    Display(index);

                }
                index++;
            }
            con.Close();
             
        }

       
    }
}

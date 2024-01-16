using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination
{
    public partial class StaffHome : Form
    {
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
        public StaffHome()
        {
            InitializeComponent();
        }

        private void StaffHome_Load(object sender, EventArgs e)
        {
            lblUser.Text = userName;
        }

        private void lnklogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin log =new frmLogin();
            this.Dispose();
            log.ShowDialog();
        }

        private void changepassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword chp = new ChangePassword();
            chp.UserId = userId;
            chp.UserName = userName;
            this.Dispose();
            chp.ShowDialog();

        }

        private void lnkquestionBank_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuestionBank qb = new QuestionBank();
            qb.UserName = userName;
            qb.UserId = userId;
            this.Hide();
            qb.ShowDialog();
        }

        private void lnkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin log = new frmLogin();
            this.Dispose();
            log.ShowDialog();
        }
    }
}

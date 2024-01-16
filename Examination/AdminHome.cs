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
    public partial class AdminHome : Form
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

        public AdminHome()
        {
            InitializeComponent();
        }
               
        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin log = new frmLogin();
            this.Dispose();
            log.ShowDialog();

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lblUser.Text = userName;
        }

        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword passwordChange =  new ChangePassword();
            this.Close();
            passwordChange.UserName = userName;
            passwordChange.UserId = userId;
            passwordChange.ShowDialog();
            passwordChange.Focus();
        }

        private void lnkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin log = new frmLogin();
            this.Dispose();
            log.ShowDialog();
        }

        private void lnkStaffManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StaffManagement sm = new StaffManagement();
            this.Dispose();
            sm.UserName = userName;
            sm.UserId = userId;
            sm.ShowDialog();
            
        }

        private void lnkSubjectManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SubjectManagement subm = new SubjectManagement();
            this.Dispose();
            subm.UserId = userId;
            subm.UserName = userName;
            subm.ShowDialog();
        }
    }
}

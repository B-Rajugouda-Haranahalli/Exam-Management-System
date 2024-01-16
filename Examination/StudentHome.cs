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
    public partial class StudentHome : Form
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

        public StudentHome()
        {
            InitializeComponent();
        }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            lbluser.Text = userName;
        }

        private void lnlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin log = new frmLogin();
            log.ShowDialog();
            this.Close();

        }

        private void lnkchange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword chp = new ChangePassword();
            chp.UserName = userName;
            chp.UserId = userId;
            chp.ShowDialog();
            chp.Close();

        }

        private void lnktest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Taketest tt = new Taketest();
            tt.UserId = userId;
            tt.UserName = userName;
            tt.ShowDialog();
            this.Close();

        }
    }
}

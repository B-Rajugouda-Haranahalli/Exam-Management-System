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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin log = new frmLogin();            
            log.ShowDialog();
            this.Dispose();       
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void lnkstudentreg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            studentregestration sreg = new studentregestration();
            sreg.ShowDialog();
            this.Hide();
        }
    }
}

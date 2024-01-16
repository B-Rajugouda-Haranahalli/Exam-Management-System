
namespace Examination
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.lnkstudentreg = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkLogin
            // 
            this.lnkLogin.AutoSize = true;
            this.lnkLogin.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogin.Location = new System.Drawing.Point(376, 213);
            this.lnkLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLogin.Name = "lnkLogin";
            this.lnkLogin.Size = new System.Drawing.Size(92, 41);
            this.lnkLogin.TabIndex = 0;
            this.lnkLogin.TabStop = true;
            this.lnkLogin.Text = "Login";
            this.lnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogin_LinkClicked);
            // 
            // lnkstudentreg
            // 
            this.lnkstudentreg.AutoSize = true;
            this.lnkstudentreg.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkstudentreg.Location = new System.Drawing.Point(268, 311);
            this.lnkstudentreg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkstudentreg.Name = "lnkstudentreg";
            this.lnkstudentreg.Size = new System.Drawing.Size(308, 41);
            this.lnkstudentreg.TabIndex = 1;
            this.lnkstudentreg.TabStop = true;
            this.lnkstudentreg.Text = "Student Regestration";
            this.lnkstudentreg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkstudentreg_LinkClicked);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 639);
            this.Controls.Add(this.lnkstudentreg);
            this.Controls.Add(this.lnkLogin);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHome";
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkLogin;
        private System.Windows.Forms.LinkLabel lnkstudentreg;
    }
}


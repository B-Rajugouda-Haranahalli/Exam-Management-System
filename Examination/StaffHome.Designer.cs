
namespace Examination
{
    partial class StaffHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnklogout = new System.Windows.Forms.LinkLabel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkCancel = new System.Windows.Forms.LinkLabel();
            this.changepassword = new System.Windows.Forms.LinkLabel();
            this.lnkquestionBank = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnklogout);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(969, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lnklogout
            // 
            this.lnklogout.AutoSize = true;
            this.lnklogout.Location = new System.Drawing.Point(848, 62);
            this.lnklogout.Name = "lnklogout";
            this.lnklogout.Size = new System.Drawing.Size(74, 24);
            this.lnklogout.TabIndex = 2;
            this.lnklogout.TabStop = true;
            this.lnklogout.Text = "Log Out";
            this.lnklogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklogout_LinkClicked);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(139, 62);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 24);
            this.lblUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lnkCancel);
            this.groupBox2.Controls.Add(this.changepassword);
            this.groupBox2.Controls.Add(this.lnkquestionBank);
            this.groupBox2.Location = new System.Drawing.Point(16, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 472);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lnkCancel
            // 
            this.lnkCancel.AutoSize = true;
            this.lnkCancel.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.lnkCancel.Location = new System.Drawing.Point(380, 225);
            this.lnkCancel.Name = "lnkCancel";
            this.lnkCancel.Size = new System.Drawing.Size(90, 35);
            this.lnkCancel.TabIndex = 1;
            this.lnkCancel.TabStop = true;
            this.lnkCancel.Text = "Cancel";
            this.lnkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCancel_LinkClicked);
            // 
            // changepassword
            // 
            this.changepassword.AutoSize = true;
            this.changepassword.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepassword.Location = new System.Drawing.Point(331, 87);
            this.changepassword.Name = "changepassword";
            this.changepassword.Size = new System.Drawing.Size(214, 35);
            this.changepassword.TabIndex = 0;
            this.changepassword.TabStop = true;
            this.changepassword.Text = "Change Password";
            this.changepassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changepassword_LinkClicked);
            // 
            // lnkquestionBank
            // 
            this.lnkquestionBank.AutoSize = true;
            this.lnkquestionBank.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.lnkquestionBank.Location = new System.Drawing.Point(341, 156);
            this.lnkquestionBank.Name = "lnkquestionBank";
            this.lnkquestionBank.Size = new System.Drawing.Size(182, 35);
            this.lnkquestionBank.TabIndex = 0;
            this.lnkquestionBank.TabStop = true;
            this.lnkquestionBank.Text = "Question Bank";
            this.lnkquestionBank.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkquestionBank_LinkClicked);
            // 
            // StaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffHome";
            this.Text = "StaffHome";
            this.Load += new System.EventHandler(this.StaffHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnklogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lnkCancel;
        private System.Windows.Forms.LinkLabel changepassword;
        private System.Windows.Forms.LinkLabel lnkquestionBank;
    }
}
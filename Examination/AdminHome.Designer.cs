
namespace Examination
{
    partial class AdminHome
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkCancel = new System.Windows.Forms.LinkLabel();
            this.lnkSubjectManagement = new System.Windows.Forms.LinkLabel();
            this.lnkStaffManagement = new System.Windows.Forms.LinkLabel();
            this.lnkChangePassword = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.lnkLogout);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(736, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(154, 42);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 23);
            this.lblUser.TabIndex = 3;
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.lnkLogout.Location = new System.Drawing.Point(623, 42);
            this.lnkLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(98, 35);
            this.lnkLogout.TabIndex = 2;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "LogOut";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(167, 42);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 23);
            this.lblMsg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lnkCancel);
            this.groupBox2.Controls.Add(this.lnkSubjectManagement);
            this.groupBox2.Controls.Add(this.lnkStaffManagement);
            this.groupBox2.Controls.Add(this.lnkChangePassword);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.groupBox2.Location = new System.Drawing.Point(14, 166);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(736, 431);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lnkCancel
            // 
            this.lnkCancel.AutoSize = true;
            this.lnkCancel.Location = new System.Drawing.Point(279, 294);
            this.lnkCancel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkCancel.Name = "lnkCancel";
            this.lnkCancel.Size = new System.Drawing.Size(90, 35);
            this.lnkCancel.TabIndex = 3;
            this.lnkCancel.TabStop = true;
            this.lnkCancel.Text = "Cancel";
            this.lnkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCancel_LinkClicked);
            // 
            // lnkSubjectManagement
            // 
            this.lnkSubjectManagement.AutoSize = true;
            this.lnkSubjectManagement.Location = new System.Drawing.Point(234, 226);
            this.lnkSubjectManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkSubjectManagement.Name = "lnkSubjectManagement";
            this.lnkSubjectManagement.Size = new System.Drawing.Size(258, 35);
            this.lnkSubjectManagement.TabIndex = 2;
            this.lnkSubjectManagement.TabStop = true;
            this.lnkSubjectManagement.Text = "Subject Management";
            this.lnkSubjectManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubjectManagement_LinkClicked);
            // 
            // lnkStaffManagement
            // 
            this.lnkStaffManagement.AutoSize = true;
            this.lnkStaffManagement.Location = new System.Drawing.Point(234, 166);
            this.lnkStaffManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkStaffManagement.Name = "lnkStaffManagement";
            this.lnkStaffManagement.Size = new System.Drawing.Size(224, 35);
            this.lnkStaffManagement.TabIndex = 1;
            this.lnkStaffManagement.TabStop = true;
            this.lnkStaffManagement.Text = "Staff Management";
            this.lnkStaffManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStaffManagement_LinkClicked);
            // 
            // lnkChangePassword
            // 
            this.lnkChangePassword.AutoSize = true;
            this.lnkChangePassword.Location = new System.Drawing.Point(234, 107);
            this.lnkChangePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkChangePassword.Name = "lnkChangePassword";
            this.lnkChangePassword.Size = new System.Drawing.Size(220, 35);
            this.lnkChangePassword.TabIndex = 0;
            this.lnkChangePassword.TabStop = true;
            this.lnkChangePassword.Text = "Change Password ";
            this.lnkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangePassword_LinkClicked);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lnkCancel;
        private System.Windows.Forms.LinkLabel lnkSubjectManagement;
        private System.Windows.Forms.LinkLabel lnkStaffManagement;
        private System.Windows.Forms.LinkLabel lnkChangePassword;
        private System.Windows.Forms.Label lblUser;
    }
}
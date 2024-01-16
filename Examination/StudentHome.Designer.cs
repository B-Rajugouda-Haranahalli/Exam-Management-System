
namespace Examination
{
    partial class StudentHome
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lnlogout = new System.Windows.Forms.LinkLabel();
            this.lnktest = new System.Windows.Forms.LinkLabel();
            this.lnkresult = new System.Windows.Forms.LinkLabel();
            this.lnkchange = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnlogout);
            this.groupBox1.Controls.Add(this.lbluser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(779, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lnkchange);
            this.groupBox2.Controls.Add(this.lnkresult);
            this.groupBox2.Controls.Add(this.lnktest);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(779, 438);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome : ";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(194, 62);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(0, 29);
            this.lbluser.TabIndex = 1;
            // 
            // lnlogout
            // 
            this.lnlogout.AutoSize = true;
            this.lnlogout.Location = new System.Drawing.Point(633, 62);
            this.lnlogout.Name = "lnlogout";
            this.lnlogout.Size = new System.Drawing.Size(89, 29);
            this.lnlogout.TabIndex = 2;
            this.lnlogout.TabStop = true;
            this.lnlogout.Text = "Log Out";
            this.lnlogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlogout_LinkClicked);
            // 
            // lnktest
            // 
            this.lnktest.AutoSize = true;
            this.lnktest.Location = new System.Drawing.Point(310, 207);
            this.lnktest.Name = "lnktest";
            this.lnktest.Size = new System.Drawing.Size(101, 29);
            this.lnktest.TabIndex = 0;
            this.lnktest.TabStop = true;
            this.lnktest.Text = "Take Test";
            this.lnktest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnktest_LinkClicked);
            // 
            // lnkresult
            // 
            this.lnkresult.AutoSize = true;
            this.lnkresult.Location = new System.Drawing.Point(323, 298);
            this.lnkresult.Name = "lnkresult";
            this.lnkresult.Size = new System.Drawing.Size(74, 29);
            this.lnkresult.TabIndex = 1;
            this.lnkresult.TabStop = true;
            this.lnkresult.Text = "Result";
            // 
            // lnkchange
            // 
            this.lnkchange.AutoSize = true;
            this.lnkchange.Location = new System.Drawing.Point(268, 116);
            this.lnkchange.Name = "lnkchange";
            this.lnkchange.Size = new System.Drawing.Size(184, 29);
            this.lnkchange.TabIndex = 2;
            this.lnkchange.TabStop = true;
            this.lnkchange.Text = "Change Password";
            this.lnkchange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkchange_LinkClicked);
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 649);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnlogout;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lnkresult;
        private System.Windows.Forms.LinkLabel lnktest;
        private System.Windows.Forms.LinkLabel lnkchange;
    }
}
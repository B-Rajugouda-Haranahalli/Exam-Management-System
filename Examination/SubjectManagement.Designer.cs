
namespace Examination
{
    partial class SubjectManagement
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblsubjectresult = new System.Windows.Forms.Label();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.btnsubSave = new System.Windows.Forms.Button();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsubid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnshowsubjectstaff = new System.Windows.Forms.Button();
            this.dgvsubstaff = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnstaffsubsave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbsubjects = new System.Windows.Forms.ComboBox();
            this.cmbusername = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubstaff)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnklogout);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(837, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lnklogout
            // 
            this.lnklogout.AutoSize = true;
            this.lnklogout.Location = new System.Drawing.Point(758, 27);
            this.lnklogout.Name = "lnklogout";
            this.lnklogout.Size = new System.Drawing.Size(64, 21);
            this.lnklogout.TabIndex = 2;
            this.lnklogout.TabStop = true;
            this.lnklogout.Text = "Log Out";
            this.lnklogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklogout_LinkClicked);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(112, 27);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 21);
            this.lblUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnclear);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.lblsubjectresult);
            this.groupBox2.Controls.Add(this.dgvSubjects);
            this.groupBox2.Controls.Add(this.btnsubSave);
            this.groupBox2.Controls.Add(this.txtsubject);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblsubid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 491);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(310, 439);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 32);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(229, 105);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 55);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblsubjectresult
            // 
            this.lblsubjectresult.AutoSize = true;
            this.lblsubjectresult.Location = new System.Drawing.Point(41, 122);
            this.lblsubjectresult.Name = "lblsubjectresult";
            this.lblsubjectresult.Size = new System.Drawing.Size(0, 21);
            this.lblsubjectresult.TabIndex = 8;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(17, 166);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.RowHeadersWidth = 51;
            this.dgvSubjects.RowTemplate.Height = 24;
            this.dgvSubjects.Size = new System.Drawing.Size(368, 246);
            this.dgvSubjects.TabIndex = 5;
            this.dgvSubjects.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubjects_RowHeaderMouseDoubleClick);
            // 
            // btnsubSave
            // 
            this.btnsubSave.Location = new System.Drawing.Point(310, 105);
            this.btnsubSave.Name = "btnsubSave";
            this.btnsubSave.Size = new System.Drawing.Size(75, 55);
            this.btnsubSave.TabIndex = 4;
            this.btnsubSave.Text = "Save";
            this.btnsubSave.UseVisualStyleBackColor = true;
            this.btnsubSave.Click += new System.EventHandler(this.btnsubSave_Click);
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(138, 71);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(247, 28);
            this.txtsubject.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subject Name : ";
            // 
            // lblsubid
            // 
            this.lblsubid.AutoSize = true;
            this.lblsubid.Location = new System.Drawing.Point(134, 24);
            this.lblsubid.Name = "lblsubid";
            this.lblsubid.Size = new System.Drawing.Size(0, 21);
            this.lblsubid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject id : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnshowsubjectstaff);
            this.groupBox3.Controls.Add(this.dgvsubstaff);
            this.groupBox3.Controls.Add(this.btnclose);
            this.groupBox3.Controls.Add(this.btnstaffsubsave);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbsubjects);
            this.groupBox3.Controls.Add(this.cmbusername);
            this.groupBox3.Location = new System.Drawing.Point(444, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 491);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnshowsubjectstaff
            // 
            this.btnshowsubjectstaff.Location = new System.Drawing.Point(204, 105);
            this.btnshowsubjectstaff.Name = "btnshowsubjectstaff";
            this.btnshowsubjectstaff.Size = new System.Drawing.Size(75, 55);
            this.btnshowsubjectstaff.TabIndex = 8;
            this.btnshowsubjectstaff.Text = "Show ";
            this.btnshowsubjectstaff.UseVisualStyleBackColor = true;
            this.btnshowsubjectstaff.Click += new System.EventHandler(this.btnshowsubjectstaff_Click);
            // 
            // dgvsubstaff
            // 
            this.dgvsubstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsubstaff.Location = new System.Drawing.Point(17, 166);
            this.dgvsubstaff.Name = "dgvsubstaff";
            this.dgvsubstaff.RowHeadersWidth = 51;
            this.dgvsubstaff.RowTemplate.Height = 24;
            this.dgvsubstaff.Size = new System.Drawing.Size(369, 246);
            this.dgvsubstaff.TabIndex = 6;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(311, 429);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 42);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnstaffsubsave
            // 
            this.btnstaffsubsave.Location = new System.Drawing.Point(299, 105);
            this.btnstaffsubsave.Name = "btnstaffsubsave";
            this.btnstaffsubsave.Size = new System.Drawing.Size(75, 55);
            this.btnstaffsubsave.TabIndex = 5;
            this.btnstaffsubsave.Text = "Save";
            this.btnstaffsubsave.UseVisualStyleBackColor = true;
            this.btnstaffsubsave.Click += new System.EventHandler(this.btnstaffsubsave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Subjects";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Staff Name ";
            // 
            // cmbsubjects
            // 
            this.cmbsubjects.FormattingEnabled = true;
            this.cmbsubjects.Location = new System.Drawing.Point(113, 63);
            this.cmbsubjects.Name = "cmbsubjects";
            this.cmbsubjects.Size = new System.Drawing.Size(273, 29);
            this.cmbsubjects.TabIndex = 1;
            // 
            // cmbusername
            // 
            this.cmbusername.FormattingEnabled = true;
            this.cmbusername.Location = new System.Drawing.Point(113, 16);
            this.cmbusername.Name = "cmbusername";
            this.cmbusername.Size = new System.Drawing.Size(273, 29);
            this.cmbusername.TabIndex = 0;
            this.cmbusername.SelectedIndexChanged += new System.EventHandler(this.cmbusername_SelectedIndexChanged);
            // 
            // SubjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 621);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SubjectManagement";
            this.Text = "SubjectManagement";
            this.Load += new System.EventHandler(this.SubjectManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubstaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnklogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button btnsubSave;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsubid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblsubjectresult;
        private System.Windows.Forms.DataGridView dgvsubstaff;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnstaffsubsave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbsubjects;
        private System.Windows.Forms.ComboBox cmbusername;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnshowsubjectstaff;
    }
}
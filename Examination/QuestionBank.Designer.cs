
namespace Examination
{
    partial class QuestionBank
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvqb = new System.Windows.Forms.DataGridView();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbtnD = new System.Windows.Forms.RadioButton();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQptionD = new System.Windows.Forms.TextBox();
            this.txtQptionC = new System.Windows.Forms.TextBox();
            this.txtQptionB = new System.Windows.Forms.TextBox();
            this.txtQptionA = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblqid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbchooseSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnklogout);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lnklogout
            // 
            this.lnklogout.AutoSize = true;
            this.lnklogout.LinkColor = System.Drawing.Color.Red;
            this.lnklogout.Location = new System.Drawing.Point(961, 42);
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
            this.lblUser.Location = new System.Drawing.Point(134, 42);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 24);
            this.lblUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Clear);
            this.groupBox2.Controls.Add(this.txtsearch);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dgvqb);
            this.groupBox2.Controls.Add(this.lblmsg);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.rbtnD);
            this.groupBox2.Controls.Add(this.rbtnC);
            this.groupBox2.Controls.Add(this.rbtnB);
            this.groupBox2.Controls.Add(this.rbtnA);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtQptionD);
            this.groupBox2.Controls.Add(this.txtQptionC);
            this.groupBox2.Controls.Add(this.txtQptionB);
            this.groupBox2.Controls.Add(this.txtQptionA);
            this.groupBox2.Controls.Add(this.txtQuestion);
            this.groupBox2.Controls.Add(this.lblqid);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbchooseSubject);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1085, 548);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(569, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 32);
            this.textBox1.TabIndex = 22;
            // 
            // dgvqb
            // 
            this.dgvqb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqb.Location = new System.Drawing.Point(569, 105);
            this.dgvqb.Name = "dgvqb";
            this.dgvqb.RowHeadersWidth = 51;
            this.dgvqb.RowTemplate.Height = 24;
            this.dgvqb.Size = new System.Drawing.Size(496, 428);
            this.dgvqb.TabIndex = 21;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(84, 509);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 24);
            this.lblmsg.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 41);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbtnD
            // 
            this.rbtnD.AutoSize = true;
            this.rbtnD.Location = new System.Drawing.Point(463, 450);
            this.rbtnD.Name = "rbtnD";
            this.rbtnD.Size = new System.Drawing.Size(43, 28);
            this.rbtnD.TabIndex = 18;
            this.rbtnD.TabStop = true;
            this.rbtnD.Text = "D";
            this.rbtnD.UseVisualStyleBackColor = true;
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Location = new System.Drawing.Point(368, 450);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(42, 28);
            this.rbtnC.TabIndex = 17;
            this.rbtnC.TabStop = true;
            this.rbtnC.Text = "C";
            this.rbtnC.UseVisualStyleBackColor = true;
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Location = new System.Drawing.Point(268, 452);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(42, 28);
            this.rbtnB.TabIndex = 16;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "B";
            this.rbtnB.UseVisualStyleBackColor = true;
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(177, 450);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(43, 28);
            this.rbtnA.TabIndex = 15;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "A";
            this.rbtnA.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Correct Answer";
            // 
            // txtQptionD
            // 
            this.txtQptionD.Location = new System.Drawing.Point(155, 396);
            this.txtQptionD.Name = "txtQptionD";
            this.txtQptionD.Size = new System.Drawing.Size(375, 32);
            this.txtQptionD.TabIndex = 13;
            // 
            // txtQptionC
            // 
            this.txtQptionC.Location = new System.Drawing.Point(155, 337);
            this.txtQptionC.Name = "txtQptionC";
            this.txtQptionC.Size = new System.Drawing.Size(375, 32);
            this.txtQptionC.TabIndex = 12;
            // 
            // txtQptionB
            // 
            this.txtQptionB.Location = new System.Drawing.Point(155, 278);
            this.txtQptionB.Name = "txtQptionB";
            this.txtQptionB.Size = new System.Drawing.Size(375, 32);
            this.txtQptionB.TabIndex = 11;
            // 
            // txtQptionA
            // 
            this.txtQptionA.Location = new System.Drawing.Point(155, 219);
            this.txtQptionA.Name = "txtQptionA";
            this.txtQptionA.Size = new System.Drawing.Size(375, 32);
            this.txtQptionA.TabIndex = 10;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(155, 160);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(375, 32);
            this.txtQuestion.TabIndex = 9;
            // 
            // lblqid
            // 
            this.lblqid.AutoSize = true;
            this.lblqid.Location = new System.Drawing.Point(155, 103);
            this.lblqid.Name = "lblqid";
            this.lblqid.Size = new System.Drawing.Size(0, 24);
            this.lblqid.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Option D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Option C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Option B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Option A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Q.No : ";
            // 
            // cmbchooseSubject
            // 
            this.cmbchooseSubject.FormattingEnabled = true;
            this.cmbchooseSubject.Location = new System.Drawing.Point(159, 25);
            this.cmbchooseSubject.Name = "cmbchooseSubject";
            this.cmbchooseSubject.Size = new System.Drawing.Size(305, 32);
            this.cmbchooseSubject.TabIndex = 1;
            this.cmbchooseSubject.SelectedIndexChanged += new System.EventHandler(this.cmbchooseSubject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = " Choose Subject";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(960, 25);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(75, 32);
            this.txtsearch.TabIndex = 23;
            this.txtsearch.Text = "Search";
            this.txtsearch.UseVisualStyleBackColor = true;
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(960, 63);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 36);
            this.Clear.TabIndex = 24;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // QuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuestionBank";
            this.Text = "Question Bank";
            this.Load += new System.EventHandler(this.StaffHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnklogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQptionD;
        private System.Windows.Forms.TextBox txtQptionC;
        private System.Windows.Forms.TextBox txtQptionB;
        private System.Windows.Forms.TextBox txtQptionA;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblqid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbchooseSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtnD;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DataGridView dgvqb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button txtsearch;
        private System.Windows.Forms.Button Clear;
    }
}
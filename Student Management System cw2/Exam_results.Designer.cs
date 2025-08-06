
namespace Student_Management_System_cw2
{
    partial class Exam_results
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.cmd_crsename = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_addresult = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.cmb_grade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(154, 19);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(97, 36);
            this.btn_clear.TabIndex = 19;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // cmd_crsename
            // 
            this.cmd_crsename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmd_crsename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_crsename.FormattingEnabled = true;
            this.cmd_crsename.Items.AddRange(new object[] {
            "Diploma In Computer Science",
            "Diploma In Networking",
            "Diploma In Business Studies",
            "Diploma In Fashion Designing",
            "Diploma In English"});
            this.cmd_crsename.Location = new System.Drawing.Point(226, 144);
            this.cmd_crsename.Name = "cmd_crsename";
            this.cmd_crsename.Size = new System.Drawing.Size(291, 28);
            this.cmd_crsename.TabIndex = 18;
            this.cmd_crsename.Text = "-Select-";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(479, 19);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(97, 36);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // btn_addresult
            // 
            this.btn_addresult.BackColor = System.Drawing.Color.Transparent;
            this.btn_addresult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addresult.ForeColor = System.Drawing.Color.White;
            this.btn_addresult.Location = new System.Drawing.Point(309, 19);
            this.btn_addresult.Name = "btn_addresult";
            this.btn_addresult.Size = new System.Drawing.Size(113, 36);
            this.btn_addresult.TabIndex = 16;
            this.btn_addresult.Text = "ADD";
            this.btn_addresult.UseVisualStyleBackColor = false;
            this.btn_addresult.Click += new System.EventHandler(this.btn_addresult_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(226, 81);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(237, 27);
            this.txt_ID.TabIndex = 15;
            // 
            // cmb_grade
            // 
            this.cmb_grade.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmb_grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_grade.FormattingEnabled = true;
            this.cmb_grade.Items.AddRange(new object[] {
            "A+",
            "A",
            "B",
            "C",
            "F"});
            this.cmb_grade.Location = new System.Drawing.Point(226, 202);
            this.cmb_grade.Name = "cmb_grade";
            this.cmb_grade.Size = new System.Drawing.Size(169, 28);
            this.cmb_grade.TabIndex = 14;
            this.cmb_grade.Text = "-Select-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student ID";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Student_Management_System_cw2.Properties.Resources.R__1_;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_addresult);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 78);
            this.panel1.TabIndex = 42;
            // 
            // Exam_results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmd_crsename);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.cmb_grade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exam_results";
            this.Text = "Exam_results";
            this.Load += new System.EventHandler(this.Exam_results_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmd_crsename;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_addresult;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.ComboBox cmb_grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
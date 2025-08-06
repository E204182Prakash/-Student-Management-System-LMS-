
namespace Student_Management_System_cw2
{
    partial class Student_View
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
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.rbn_Sname = new System.Windows.Forms.RadioButton();
            this.rbn_ID = new System.Windows.Forms.RadioButton();
            this.btn_view_student = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.IndianRed;
            this.btn_back.Location = new System.Drawing.Point(645, 74);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 33);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(185, 80);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(234, 27);
            this.txt_search.TabIndex = 10;
            // 
            // rbn_Sname
            // 
            this.rbn_Sname.AutoSize = true;
            this.rbn_Sname.Location = new System.Drawing.Point(25, 98);
            this.rbn_Sname.Name = "rbn_Sname";
            this.rbn_Sname.Size = new System.Drawing.Size(119, 21);
            this.rbn_Sname.TabIndex = 9;
            this.rbn_Sname.TabStop = true;
            this.rbn_Sname.Text = "Student Name";
            this.rbn_Sname.UseVisualStyleBackColor = true;
            // 
            // rbn_ID
            // 
            this.rbn_ID.AutoSize = true;
            this.rbn_ID.Location = new System.Drawing.Point(25, 64);
            this.rbn_ID.Name = "rbn_ID";
            this.rbn_ID.Size = new System.Drawing.Size(95, 21);
            this.rbn_ID.TabIndex = 8;
            this.rbn_ID.TabStop = true;
            this.rbn_ID.Text = "Student ID";
            this.rbn_ID.UseVisualStyleBackColor = true;
            // 
            // btn_view_student
            // 
            this.btn_view_student.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_student.Location = new System.Drawing.Point(474, 74);
            this.btn_view_student.Name = "btn_view_student";
            this.btn_view_student.Size = new System.Drawing.Size(110, 33);
            this.btn_view_student.TabIndex = 7;
            this.btn_view_student.Text = "View";
            this.btn_view_student.UseVisualStyleBackColor = false;
            this.btn_view_student.Click += new System.EventHandler(this.btn_view_student_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1364, 461);
            this.dataGridView1.TabIndex = 6;
            // 
            // Student_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 603);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.rbn_Sname);
            this.Controls.Add(this.rbn_ID);
            this.Controls.Add(this.btn_view_student);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Student_View";
            this.Text = "Student_View";
            this.Load += new System.EventHandler(this.Student_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.RadioButton rbn_Sname;
        private System.Windows.Forms.RadioButton rbn_ID;
        private System.Windows.Forms.Button btn_view_student;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
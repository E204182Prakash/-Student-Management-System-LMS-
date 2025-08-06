
namespace Student_Management_System_cw2
{
    partial class Course_view
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
            this.txt_srch_course = new System.Windows.Forms.TextBox();
            this.rbn_crsname = new System.Windows.Forms.RadioButton();
            this.btn_view_course = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.IndianRed;
            this.btn_back.Location = new System.Drawing.Point(639, 52);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(97, 34);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // txt_srch_course
            // 
            this.txt_srch_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_srch_course.Location = new System.Drawing.Point(194, 59);
            this.txt_srch_course.Name = "txt_srch_course";
            this.txt_srch_course.Size = new System.Drawing.Size(287, 27);
            this.txt_srch_course.TabIndex = 8;
            // 
            // rbn_crsname
            // 
            this.rbn_crsname.AutoSize = true;
            this.rbn_crsname.Location = new System.Drawing.Point(34, 63);
            this.rbn_crsname.Name = "rbn_crsname";
            this.rbn_crsname.Size = new System.Drawing.Size(115, 21);
            this.rbn_crsname.TabIndex = 7;
            this.rbn_crsname.TabStop = true;
            this.rbn_crsname.Text = "Course Name";
            this.rbn_crsname.UseVisualStyleBackColor = true;
            // 
            // btn_view_course
            // 
            this.btn_view_course.BackColor = System.Drawing.Color.Khaki;
            this.btn_view_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_course.Location = new System.Drawing.Point(512, 52);
            this.btn_view_course.Name = "btn_view_course";
            this.btn_view_course.Size = new System.Drawing.Size(119, 34);
            this.btn_view_course.TabIndex = 6;
            this.btn_view_course.Text = "View";
            this.btn_view_course.UseVisualStyleBackColor = false;
            this.btn_view_course.Click += new System.EventHandler(this.btn_view_course_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 386);
            this.dataGridView1.TabIndex = 5;
            // 
            // Course_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_srch_course);
            this.Controls.Add(this.rbn_crsname);
            this.Controls.Add(this.btn_view_course);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Course_view";
            this.Text = "Course_view";
            this.Load += new System.EventHandler(this.Course_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_srch_course;
        private System.Windows.Forms.RadioButton rbn_crsname;
        private System.Windows.Forms.Button btn_view_course;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System_cw2
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Update_lecturer obj = new Update_lecturer();
            obj.Show();
            this.Hide();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

        }
        private void btn_register_Click_1(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update obj = new Update();
            obj.Show();
            this.Hide();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Delete obj = new Delete();
            obj.Show();
            this.Hide();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Student_View obj = new Student_View();
            obj.Show();
            this.Hide();
        }

        private void btn_newcourse_Click(object sender, EventArgs e)
        {
            New_Course obj = new New_Course();
            obj.Show();
            this.Hide();
        }

        private void btn_Cupdate_Click(object sender, EventArgs e)
        {
            Update_course obj = new Update_course();
            obj.Show();
            this.Hide();
        }

        private void btn_Cview_Click(object sender, EventArgs e)
        {
            Course_view obj = new Course_view();
            obj.Show();
            this.Hide();
        }

        private void btn_new_lec_Click(object sender, EventArgs e)
        {
            New_Lecturer obj = new New_Lecturer();
            obj.Show();
            this.Hide();
        }

        private void btn_view_lec_Click(object sender, EventArgs e)
        {
            View_Lecturer obj = new View_Lecturer();
            obj.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
            Login_menu obj = new Login_menu();
            obj.Show();
        }

        private void btn_entr_result_Click(object sender, EventArgs e)
        {
            Exam_results obj = new Exam_results();
            obj.Show();
            this.Hide();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            Result_View obj = new Result_View();
            obj.Show();
            this.Hide();
        }

        private void btn_st_report_Click(object sender, EventArgs e)
        {
            student_report obj = new student_report();
            obj.Show();
            this.Hide();
        }
    }
}

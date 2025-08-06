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
    public partial class Course_view : MetroFramework.Forms.MetroForm
    {
        public Course_view()
        {
            InitializeComponent();
        }
        CollegeCon_DB obj = new CollegeCon_DB();
        private void Course_view_Load(object sender, EventArgs e)
        {

       
     
        }

        private void btn_view_course_Click(object sender, EventArgs e)
        {
            if (rbn_crsname.Checked == true)
                dataGridView1.DataSource = obj.display("Select * from Course where first_name LIKE '" + txt_srch_course.Text + "%'");
            else
                dataGridView1.DataSource = obj.display("Select * from Course");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            Main_Page obj = new Main_Page();
            obj.Show();
        }

        private void btn_view_course_Click_1(object sender, EventArgs e)
        {

        }
    }
}

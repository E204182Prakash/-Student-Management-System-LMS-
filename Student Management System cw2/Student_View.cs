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
    public partial class Student_View : MetroFramework.Forms.MetroForm
    {
        public Student_View()
        {
            InitializeComponent();
        }
        CollegeCon_DB obj = new CollegeCon_DB();
        private void btn_view_student_Click(object sender, EventArgs e)
        {
            if (rbn_ID.Checked == true)
                dataGridView1.DataSource = obj.display("Select * from Student where studentID = '" + txt_search.Text + "'");
            else if (rbn_Sname.Checked == true)
                dataGridView1.DataSource = obj.display("Select * from Student where first_name LIKE '" + txt_search.Text + "%'");
            else if (txt_search.Text.Length == 0)
                dataGridView1.DataSource = obj.display("Select * from Student");
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Close();
            Main_Page obj = new Main_Page();
            obj.Show();
        }

        private void Student_View_Load(object sender, EventArgs e)
        {

        }
    }
}

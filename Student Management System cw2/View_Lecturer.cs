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
    public partial class View_Lecturer : MetroFramework.Forms.MetroForm
    {
        public View_Lecturer()
        {
            InitializeComponent();
        }
        CollegeCon_DB obj = new CollegeCon_DB();

        private void View_Lecturer_Load(object sender, EventArgs e)
        {

        }
        

        private void btn_view_lec_Click(object sender, EventArgs e)
        {
            if (rbn_lec_name.Checked == true)
                dataGridView1.DataSource = obj.display("Select * from Lecturer where Lecturer_name LIKE '" + txt_srch_lec.Text + "%'");
            else
                dataGridView1.DataSource = obj.display("Select * from Lecturer");
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Close();
            Main_Page obj = new Main_Page();
            obj.Show();
        }
    }
}

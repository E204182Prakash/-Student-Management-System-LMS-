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
    public partial class Result_View : MetroFramework.Forms.MetroForm
    {
        public Result_View()
        {
            InitializeComponent();
        }
        CollegeCon_DB obj = new CollegeCon_DB();

        private void btn_View_result_Click(object sender, EventArgs e)
        {
            if (rbn_stuID_result.Checked == true)
                dataGridView1.DataSource = obj.display("Select * from Result where Stu_ID = '" + txt_search_reslt.Text + "'");
            else
                dataGridView1.DataSource = obj.display("Select * from Result");
        }

        private void Result_View_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Close();
            Main_Page obj = new Main_Page();
            obj.Show();
        }
    }
}

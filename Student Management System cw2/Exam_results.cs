using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Student_Management_System_cw2
{
    public partial class Exam_results : MetroFramework.Forms.MetroForm
    {
        public Exam_results()
        {
            InitializeComponent();
        }
        CollegeCon_DB obj = new CollegeCon_DB();

        private void btn_addresult_Click(object sender, EventArgs e)
        {
            try
            {
                string l = "Insert into Result values ('" + txt_ID.Text + "','" + cmd_crsename.Text + "','" + cmb_grade.Text + "') ";
                int c = obj.insert_update_delete_view(l);
                if (c == 1)
                    MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            cmd_crsename.Text = "-Select-";
            cmb_grade.Text = "-Select-";
        }

        private void Exam_results_Load(object sender, EventArgs e)
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

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
    public partial class Update_course : MetroFramework.Forms.MetroForm
    {
        public Update_course()
        {
            InitializeComponent();
        }
        CollegeCon_DB obj = new CollegeCon_DB();
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "update Course set course_name = '" + txt_crsname.Text + "',fees = '" + txt_fees.Text + "',lecture_hours ='" + txt_lec_hrs.Text + "'  ";
                int c = obj.insert_update_delete_view(q);
                if (c == 1)
                    MessageBox.Show(this, "Data Updated Successfully", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Data cannot update", "Error", MessageBoxButtons.OK,
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
            txt_crsname.Clear();
            txt_fees.Clear();
            txt_lec_hrs.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            Main_Page obj = new Main_Page();
            obj.Show();
        }

        private void Update_course_Load(object sender, EventArgs e)
        {

        }
    }
}

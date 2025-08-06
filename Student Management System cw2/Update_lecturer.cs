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
    public partial class Update_lecturer : MetroFramework.Forms.MetroForm
    {
        public Update_lecturer()
        {
            InitializeComponent();
        }
        CollegeCon_DB obj = new CollegeCon_DB();
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "update Lecturer set Lecturer_name = '" + txt_lecname.Text + "',Conduct_course = '" + cmb_up_lec.Text + "',Contact_number ='" + txt_tel.Text + "'  ";
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            Main_Page obj = new Main_Page();
            obj.Show();
        }

        private void Update_lecturer_Load(object sender, EventArgs e)
        {

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_lecname.Clear();
            txt_tel.Clear();
            cmb_up_lec.Text = "-Select-";
        }

        private void Update_lecturer_Load_1(object sender, EventArgs e)
        {

        }
    }
}

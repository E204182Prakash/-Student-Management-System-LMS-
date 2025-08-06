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
    public partial class Update : MetroFramework.Forms.MetroForm
    {
        public Update()
        {
            InitializeComponent();
        }

        CollegeCon_DB obj = new CollegeCon_DB();
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "update Student set full_Name = '" + txt_Fname.Text + "',student_DOB = '" + dateTimePicker1.Value + "',student_age ='" + txt_age.Text + "',gender = '" + cmb_gender.Text + "',course_name = '" + cmb_cource.Text + "',student_tel ='" + txt_tel.Text + "',student_email = '" + txt_email.Text + "' where studentID = '" + txt_SID.Text + "'  ";
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

        private void txt_age_TextChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - dateTimePicker1.Value.Year).ToString();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.display("Select *from Student");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            Main_Page obj = new Main_Page();
            obj.Show();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_SID.Clear();
            txt_Fname.Clear();
            txt_age.Clear();
            txt_tel.Clear();
            txt_tel.Clear();
            cmb_cource.Text = "-Select-";
            cmb_gender.Text = "-Select-";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_SID.Text = dataGridView1.CurrentRow.Cells["studentID"].Value.ToString();
            txt_Fname.Text = dataGridView1.CurrentRow.Cells["full_name"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["student_DOB"].Value.ToString();
            txt_age.Text = dataGridView1.CurrentRow.Cells["student_age"].Value.ToString();
            cmb_gender.Text = dataGridView1.CurrentRow.Cells["gender"].Value.ToString();
            cmb_cource.Text = dataGridView1.CurrentRow.Cells["course_name"].Value.ToString();
            txt_tel.Text = dataGridView1.CurrentRow.Cells["student_tel"].Value.ToString();
            txt_email.Text = dataGridView1.CurrentRow.Cells["student_email"].Value.ToString();
        }
    }
}

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
    public partial class New_Course : MetroFramework.Forms.MetroForm
    {
        public New_Course()
        {
            InitializeComponent();
        }
        CollegeCon_DB obj = new CollegeCon_DB();
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int b = 0;
                if (string.IsNullOrEmpty(txt_crsname.Text))
                {
                    error_msg.Text = "First Name cannot be blank";
                    txt_crsname.Focus();
                }
                else if (txt_crsname.Text.Any(char.IsDigit))
                {
                    error_msg.Text = "First Name cannot have numbers";
                    txt_crsname.Focus();
                }
                else
                {
                    b = 1;

                }
                if (b == 1)
                {
                    string l = "Insert into Course values ('" + txt_crsname.Text + "','" + txt_fees.Text + "','" + txt_lec_hrs.Text + "') ";
                    int c = obj.insert_update_delete_view(l);
                    if (c == 1)
                        MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                
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

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_crsname.Clear();
            txt_fees.Clear();
            txt_lec_hrs.Clear();
        }

        private void New_Course_Load(object sender, EventArgs e)
        {

        }
    }
}

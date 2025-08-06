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
    public partial class New_Lecturer : MetroFramework.Forms.MetroForm
    {
        public New_Lecturer()
        {
            InitializeComponent();
        }
        CollegeCon_DB obj = new CollegeCon_DB();
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string l = "Insert into Lecturer values ('" + txt_lecname.Text + "','" + cmb_con_corse.Text + "','" + txt_tel.Text + "') ";
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            Main_Page obj = new Main_Page();
            obj.Show();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_lecname.Clear();
            txt_tel.Clear();
            cmb_con_corse.Text = "-Select-";
        }

        private void New_Lecturer_Load(object sender, EventArgs e)
        {

        }
    }
    
}

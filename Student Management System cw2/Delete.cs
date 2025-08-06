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
    public partial class Delete : MetroFramework.Forms.MetroForm
    {
        public Delete()
        {
            InitializeComponent();
        }
        CollegeCon_DB obj = new CollegeCon_DB();
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "Delete from Student where studentID ='" + txt_delSID.Text + "'";
                int c = obj.insert_update_delete_view(q);
                if (c == 1)
                    MessageBox.Show(this, "Data delete Successfully", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Data Cannot delete", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_delSID.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            Close();
            Main_Page obj = new Main_Page();
            obj.Show();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}

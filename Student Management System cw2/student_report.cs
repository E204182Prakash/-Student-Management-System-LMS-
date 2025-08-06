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
    public partial class student_report : MetroFramework.Forms.MetroForm
    {
        public student_report()
        {
            InitializeComponent();
        }

        private void student_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Client_data.Student' table. You can move, or remove it, as needed.
            this.StudentTableAdapter.Fill(this.Client_data.Student);

            this.reportViewer1.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            Main_Page obj = new Main_Page();
            obj.Show();
        }
    }
}

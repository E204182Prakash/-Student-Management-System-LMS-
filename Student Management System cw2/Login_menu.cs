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
    public partial class Login_menu : Form
    {
        public Login_menu()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_pwd.Text == "1234")
            {
                timer1.Start();
                new Main_Page().Show();               
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password you entered incorrect, try again");
                txt_username.Clear();
                txt_pwd.Clear();
                txt_username.Focus();
            }
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_pwd.Clear();
            txt_username.Focus();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
            QRcode obj = new QRcode();
            obj.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(100);
        }
    }
}

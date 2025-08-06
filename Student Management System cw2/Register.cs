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
using System.IO;
using System.Text.RegularExpressions;


namespace Student_Management_System_cw2
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {

        Boolean isnew;

        public Register()
        {
            InitializeComponent();
        }

        CollegeCon_DB obj = new CollegeCon_DB();

        private void btn_register_Click(object sender, EventArgs e)
        {
            int b=0;
            if (isnew == true)
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_Fname.Text))
                    {
                        error_msg.Text = "First Name cannot be blank";
                        txt_Fname.Focus();
                    }
                    else if (txt_Fname.Text.Any(char.IsDigit))
                    {
                        error_msg.Text = "First Name cannot have numbers";
                        txt_Fname.Focus();
                    }
                    else if (txt_email.Text.Length == 0)
                    {
                        error_email.Text = "Please Enter Email Address";
                        txt_email.Focus();
                    }
                    else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                    {
                        error_email.Text = "Enter a valid email. Ex:name@gmail.com";
                        txt_email.Focus();
                    }
                    else if (!Regex.IsMatch(txt_tel.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                    {
                        error_tp.Text = "TP must have 10 numbers";
                        txt_tel.Focus();
                    }
                    else
                    {
                        b = 1;

                    }
                    if(b==1)
                    {
                        string q = "Insert into Student values ('" + txt_SID.Text + "','" + txt_Fname.Text + "','" + dateTimePicker1.Value + "','" + txt_age.Text + "','" + cmb_gender.Text + "','" + cmb_cource.Text + "','" + txt_tel.Text + "','" + txt_email.Text + "') ";
                        obj.exe(q);
                        int c = obj.insert_update_delete_view(q);
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
                    MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                btn_register.Enabled = false;
                btn_new.Enabled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.Now.Month > dateTimePicker1.Value.Month)
            {
                txt_age.Text = (DateTime.Now.Year - dateTimePicker1.Value.Year).ToString();
            }
            else if (DateTime.Now.Month == dateTimePicker1.Value.Month)
            {
                if (dateTimePicker1.Value.Day >= DateTime.Now.Day)
                {
                    txt_age.Text = (DateTime.Now.Year - dateTimePicker1.Value.Year - 1).ToString();
                }
                else
                {
                    txt_age.Text = (DateTime.Now.Year - dateTimePicker1.Value.Year).ToString();
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            Main_Page obj = new Main_Page();
            obj.Show();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Please select any image only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Please select a FIle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            isnew = true;
            int a;
            obj.exe("SELECT max(studentID) from Student");
            if (obj.dr.Read())
            {
                if (obj.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(obj.dr[0].ToString());
                    txt_SID.Text = (a + 1).ToString();
                }
                else
                {
                    txt_SID.Text = "1";
                }
            }
            btn_new.Enabled = false;
            btn_register.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_SID.Clear();
            txt_Fname.Clear();
            txt_age.Clear();
            txt_tel.Clear();
            txt_email.Clear();
            cmb_cource.Text = "-Select-";
            cmb_gender.Text = "-Select-";
        }
    }
}

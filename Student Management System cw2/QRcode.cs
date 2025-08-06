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
    public partial class QRcode : Form
    {
        public QRcode()
        {
            InitializeComponent();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(txt_QR.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox2.Image = code.GetGraphic(50);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            Login_menu obj = new Login_menu();
            obj.Show();
        }
    }
}

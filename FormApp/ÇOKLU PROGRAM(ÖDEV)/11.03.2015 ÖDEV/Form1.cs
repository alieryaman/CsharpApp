using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._03._2015_ÖDEV
{
    public partial class form_giris : Form
    {
        public form_giris()
        {
            InitializeComponent();
        }

        private void chb_yardim_CheckedChanged(object sender, EventArgs e)
        {
            lb_bilgiler.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tx_kadi.Text=="admin" && tx_sifre.Text=="12345")
            {
                MessageBox.Show("TEBRİKLER DOĞRU GİRİŞ YAPTINIZ");
                seçenekler secenekler = new seçenekler();
                secenekler.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI");
                tx_kadi.Clear();
                tx_sifre.Clear();
                tx_kadi.Focus();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}

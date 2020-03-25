using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                string kadi = "admin";
                int sifre = 1234;
                if (tx_kadi.Text=="admin"&&tx_sifre.Text=="1234")
                {
                    MessageBox.Show("HOŞGELDİNİZ !");
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI!");
                    tx_kadi.Clear();
                    tx_sifre.Clear();
                    tx_kadi.Focus();
                }
            }
            catch (Exception)
            {
                
                
            }
        }
    }
}

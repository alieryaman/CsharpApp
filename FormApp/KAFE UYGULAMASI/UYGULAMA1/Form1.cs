using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA1
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
                if (tx_kadi.Text==""||tx_sifre.Text=="")
                {
                    MessageBox.Show("BOŞ BIRAKILAMAZ");
                    tx_kadi.Focus();
                }
                if (tx_kadi.Text=="admin"&&tx_sifre.Text=="12345")
            {               
                giris2 girisyeni = new giris2();                
                girisyeni.Show();
                this.Hide();               
            }
            }
            catch (Exception)
            {
                
                
            }
            
        }
    }
}

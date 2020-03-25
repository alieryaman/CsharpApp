using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBOBOXLA_HESAP_MAKİNESİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int topla(int s1, int s2)
        {
            return s1 + s2;
        }
        int cikar(int s1, int s2)
        {
            return s1 - s2;
        }
        int carp(int s1, int s2)
        {
            return s1 * s2;
        }
        int bol(int s1, int s2)
        {
            return s1 / s2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_snc_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(tx_sayı1.Text);
            int sayı2 = Convert.ToInt32(tx_sayı2.Text);
            if (cmb_islem.SelectedIndex==0)
            {
                lbl_snc.Text = "TOPLAMA SONUCU : " + topla(sayı1 , sayı2).ToString();
            }
            if (cmb_islem.SelectedIndex == 1)
            {
                lbl_snc.Text = "ÇIKARMA SONUCU : " + cikar(sayı1, sayı2).ToString();
            }
            if (cmb_islem.SelectedIndex == 2)
            {
                lbl_snc.Text = "ÇARPMA SONUCU : " + carp(sayı1, sayı2).ToString();
            }
            if (cmb_islem.SelectedIndex == 3)
            {
                lbl_snc.Text = "BÖLME SONUCU : " + bol(sayı1, sayı2).ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DİZİLERLE_TEK_ÇİFT_SAYI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam = 0;
        int tekt = 0;
        int ciftt = 0;
        private void btn_ekleme_Click(object sender, EventArgs e)
        {
            

            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                sayilar[i]=Convert.ToInt32(Interaction.InputBox("SAYI GİRİNİZ ", "SAYI GİRİNİZ", "", 300, 300));
                lst_sayilar.Items.Add(sayilar[i]);
                toplam += sayilar[i];
                
                if (sayilar[i]%2==0)
                {
                    lst_cift.Items.Add(sayilar[i]);
                    ciftt = ciftt + sayilar[i];

                }
                else
                {
                    lst_tek.Items.Add(sayilar[i]);
                    tekt = ciftt + sayilar[i];
                }

            }
            tx_tektoplam.Text = tekt.ToString();
            tx_ciftoplam.Text = ciftt.ToString();
            tx_toplam.Text = toplam.ToString();

        }
    }
}

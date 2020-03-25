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

namespace DİZİLERLE_AD_YAZMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            int toplam=0;
            int[] sayilar = new int[5];
            for(int i=0;i<5;i++)
            { 
             sayilar[i] = Convert.ToInt32(Interaction.InputBox("SAYI GİRİNİZ ", "SAYI GİRİNİZ", "", 300, 300));
         toplam=toplam+sayilar[i];
         lst_sayilar.Items.Add(sayilar[i]);
            }
            MessageBox.Show("SAYILARIN TOPLAMI"+toplam.ToString());
}
         
        }
    }


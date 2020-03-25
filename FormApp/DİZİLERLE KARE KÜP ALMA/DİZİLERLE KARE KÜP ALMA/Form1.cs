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

namespace DİZİLERLE_KARE_KÜP_ALMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] sayilar = new int[5,3];

        private void btn_giris_Click(object sender, EventArgs e)
        {
            byte i=0, j=0;
            for ( i = 0; i < 5; i++)
            {           
                sayilar[i, j] = Convert.ToInt32(Interaction.InputBox("SAYI GİR",""));
                lst_sayilar.Items.Add(sayilar[i, j]);
                sayilar[i, j + 1] = sayilar[i, j] * sayilar[i, j];
                lst_karesi.Items.Add(sayilar[i, 1]);
                sayilar[i, j + 2] = sayilar[i, j] * sayilar[i, j] * sayilar[i, j];
                lst_kökü.Items.Add(sayilar[i, j + 2]);
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.csharpkampusu.com");
        }
    }
}

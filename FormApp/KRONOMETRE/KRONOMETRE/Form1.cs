using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRONOMETRE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int saniye = 0, dakika = 0, saat = 0, salise = 0;
        private void kronometre_Tick(object sender, EventArgs e)
        {
            kronometre.Interval = 12;
            salise++;
            lb_salise.Text = salise.ToString();
            if (salise==59)
            {               
                saniye++;
                salise = 0;              
            }            
            lb_Saniye.Text = saniye.ToString();
            if (saniye==59)
            {
                dakika++;
                lb_dakika.Text = dakika.ToString();
                saniye = 0;
            }
            if (dakika == 59)
            {
                saat++;
                lb_saat.Text = saat.ToString();
                dakika = 0;
            }
            if (saat==24)
            {
                saat = 0;
                saniye = 0;
                dakika = 0;
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_zaman_al_Click(object sender, EventArgs e)
        {
            int saniye = Convert.ToInt32(lb_Saniye.Text);
            int dakika = Convert.ToInt32(lb_dakika.Text);
            int saat = Convert.ToInt32(lb_saat.Text);
            listBox1.Items.Add(saat + ":" + dakika + ":" + saniye+":"+salise);       
        }

        private void BAŞLAT_Click(object sender, EventArgs e)
        {
            kronometre.Start();
        }

        private void btn_dur_Click(object sender, EventArgs e)
        {
            kronometre.Stop();
        }

        private void btn_sifir_Click(object sender, EventArgs e)
        {
            saat = 0; salise = 0; saniye = 0; dakika = 0;
            lb_dakika.Text = dakika.ToString();
            lb_salise.Text = salise.ToString();
            lb_saat.Text = saat.ToString();
            lb_Saniye.Text = saniye.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.csharpkampusu.com");
        }
    }
}

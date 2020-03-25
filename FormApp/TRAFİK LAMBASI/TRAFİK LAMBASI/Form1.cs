using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAFİK_LAMBASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye;
        void kirmizi()
        {
            pc_kirmizi.Visible = true;
            pc_sari.Visible = false;
            pc_yesil.Visible = false;
            lb_durum.ForeColor = Color.Red;
            lb_durum.Text = "DUR!";
        }
        void sari()
        {
            pc_kirmizi.Visible = false;
            pc_sari.Visible = true;
            pc_yesil.Visible = false;
            lb_durum.ForeColor = Color.Yellow;
            lb_durum.Text = "HAZIRLAN!";
        }
        void yesil()
        {
            pc_kirmizi.Visible = false;
            pc_sari.Visible = false;
            pc_yesil.Visible = true;
            lb_durum.ForeColor = Color.Green;
            lb_durum.Text = "GEÇ!";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye++;
            lb_saniye.Text = saniye.ToString();
            if (saniye<=5)
            {
                if (saniye == 1) { kirmizi(); }
                if (saniye == 3) { sari(); }
                if (saniye == 5) { yesil(); }
            }
            if (saniye>5)
            {
                saniye = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

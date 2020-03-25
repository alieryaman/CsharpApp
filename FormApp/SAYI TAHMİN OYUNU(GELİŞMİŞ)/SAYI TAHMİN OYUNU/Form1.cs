using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAYI_TAHMİN_OYUNU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            btn_s1.Visible = false;
            btn_s2.Visible = false;
            btn_s3.Visible = false;
            btn_s4.Visible = false;
            btn_s5.Visible = false;
            btn_s6.Visible = false;
            btn_s7.Visible = false;
            btn_s8.Visible = false;
            btn_basla.Visible = false;
            tx_s1.Visible = true;
            tx_s2.Visible = true;
            tx_s3.Visible = true;
            tx_s4.Visible = true;
            tx_s5.Visible = true;
            tx_s6.Visible = true;
            tx_s7.Visible = true;
            tx_s8.Visible = true;
            btn_bitir.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btn_s1.Text = rnd.Next(1, 50).ToString();
            btn_s2.Text = rnd.Next(1, 50).ToString();
            btn_s3.Text = rnd.Next(1, 50).ToString();
            btn_s4.Text = rnd.Next(1, 50).ToString();
            btn_s5.Text = rnd.Next(1, 50).ToString();
            btn_s6.Text = rnd.Next(1, 50).ToString();
            btn_s7.Text = rnd.Next(1, 50).ToString();
            btn_s8.Text = rnd.Next(1, 50).ToString();
            btn_bitir.Visible = false;
            tx_s1.Visible = false;
            tx_s2.Visible = false;
            tx_s3.Visible = false;
            tx_s4.Visible = false;
            tx_s5.Visible = false;
            tx_s6.Visible = false;
            tx_s7.Visible = false;
            tx_s8.Visible = false;
        }

        private void btn_bitir_Click(object sender, EventArgs e)
        {
            int puan = 0;
            int dogru = 0;
            if (btn_s1.Text == tx_s1.Text)
            {
                puan = puan + 5;
                dogru = dogru + 1;
                tx_s1.BackColor = Color.Green;
            }
            else
                tx_s1.BackColor = Color.Red;
            if (btn_s2.Text==tx_s2.Text)
            {
                puan = puan + 5;
                dogru = dogru + 1;
                tx_s2.BackColor = Color.Green;
            }
            else
                tx_s2.BackColor = Color.Red;
            if (btn_s3.Text == tx_s3.Text)
            {
                puan = puan + 5;
                dogru = dogru + 1;
                tx_s3.BackColor = Color.Green;
            }
            else
                tx_s3.BackColor = Color.Red;
            if (btn_s4.Text == tx_s4.Text)
            {
                puan = puan + 5;
                dogru = dogru + 1;
                tx_s4.BackColor = Color.Green;
            }
            else
                tx_s4.BackColor = Color.Red;
            if (btn_s5.Text == tx_s5.Text)
            {
                puan = puan + 5;
                dogru = dogru + 1;
                tx_s5.BackColor = Color.Green;
            }
            else
                tx_s5.BackColor = Color.Red;
            if (btn_s6.Text == tx_s6.Text)
            {
                puan = puan + 5;
                dogru = dogru + 1;
                tx_s6.BackColor = Color.Green;
            }
            else
                tx_s6.BackColor = Color.Red;
            if (btn_s7.Text == tx_s7.Text)
            {
                puan = puan + 5;
                dogru = dogru + 1;
                tx_s7.BackColor = Color.Green;
            }
            else
                tx_s7.BackColor = Color.Red;
            if (btn_s8.Text == tx_s8.Text)
            {
                puan = puan + 5;
                dogru = dogru + 1;
                tx_s8.BackColor = Color.Green;
            }
            else
                tx_s8.BackColor = Color.Red;
            lb_dogru.Text = dogru.ToString();
            lb_puan.Text = puan.ToString();
        }
    }
}

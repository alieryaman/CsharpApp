using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DERS_ORTALAMASI_ALMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void hesapla()
        {
            int yz1 = Convert.ToInt32(tx_y1.Text);
            int yz2 = Convert.ToInt32(tx_y2.Text);
            int soz = Convert.ToInt32(tx_sozlu.Text);
            int ort = (yz1 + yz2 + soz) / 3;
            lb_ort.Text=ort.ToString();
            if (ort>=85)
            {
                lb_drsnotu.Text = "5";
            }
            else if (ort>=70)
            {
                lb_drsnotu.Text = "4";
            }
            else if (ort>=55)
            {
                lb_drsnotu.Text = "3";
            }
            else if (ort>=45)
            {
                lb_drsnotu.Text = "2";
            }
            else if (ort>=0)
            {
                lb_drsnotu.Text = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_y1.Clear();
            tx_y2.Clear();
            tx_sozlu.Clear();
            lb_drsnotu.Text = "";
            lb_ort.Text = "";

        }

        private void tx_y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void tx_y2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void tx_sozlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }
    }
}

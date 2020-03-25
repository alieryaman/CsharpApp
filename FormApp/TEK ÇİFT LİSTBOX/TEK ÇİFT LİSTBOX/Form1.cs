using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEK_ÇİFT_LİSTBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tamtoplam = 0;
            int tektoplam = 0;
            int toplam = 0;
            for (int i = 0; i < 101; i++)
            {
                lb_tumsayılar.Items.Add(i.ToString());
                tamtoplam = tamtoplam + i;
            }
            for (int i = 0; i < 101; i++)
            {
                
                int imod = i % 2;
                if (imod==0)
                {
                    lb_cift.Items.Add(i.ToString());
                    toplam = toplam + i;
                }
                else
                {
                    lb_tek.Items.Add(i.ToString());
                    tektoplam = tektoplam + i;
                }
                
            }
            tx_cift.Text = toplam.ToString();
            tx_tek.Text = tektoplam.ToString();
            tx_fulltoplam.Text = tamtoplam.ToString();
        }
    }
}

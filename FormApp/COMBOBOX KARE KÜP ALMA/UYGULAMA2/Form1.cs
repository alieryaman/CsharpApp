using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(tx_s1.Text);
            int a = 0;
            
            if (cmb_islem.Text=="KARESİ")
            {
                a= s1 * s1;
                tx_sonuc.Text = a.ToString();
            }
            if (cmb_islem.Text=="KÜPÜ")
            {
                int snc = s1 * s1 * s1;
                tx_sonuc.Text = snc.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.csharpkampusu.com");
        }
    }
}

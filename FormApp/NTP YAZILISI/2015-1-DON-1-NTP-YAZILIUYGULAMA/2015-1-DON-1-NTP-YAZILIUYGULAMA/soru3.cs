using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2015_1_DON_1_NTP_YAZILIUYGULAMA
{
    public partial class soru3 : Form
    {
        public soru3()
        {
            InitializeComponent();
        }
        private void toplama()
        {
            int s1 = Convert.ToInt32(tx_s1.Text);
            int s2 = Convert.ToInt32(tx_s2.Text);
            int snc = s1 + s2;
            lb_sonuc.Text = snc.ToString();
        }
        private void cikarma()
        {
            int s1 = Convert.ToInt32(tx_s1.Text);
            int s2 = Convert.ToInt32(tx_s2.Text);
            int snc = s1 - s2;
            lb_sonuc.Text = snc.ToString();
        }
        private void carpma()
        {
            int s1 = Convert.ToInt32(tx_s1.Text);
            int s2 = Convert.ToInt32(tx_s2.Text);
            int snc = s1 * s2;
            lb_sonuc.Text = snc.ToString();
        }
        private void bolme()
        {
            int s1 = Convert.ToInt32(tx_s1.Text);
            int s2 = Convert.ToInt32(tx_s2.Text);
            int snc = s1 / s2;
            lb_sonuc.Text = snc.ToString();
        }


        private void rdb_topla_CheckedChanged(object sender, EventArgs e)
        {
            toplama();
        }

        private void tx_s1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void rdb_cikar_CheckedChanged(object sender, EventArgs e)
        {
            cikarma();
        }

        private void rdb_carpma_CheckedChanged(object sender, EventArgs e)
        {
            carpma();
        }

        private void rdb_bolme_CheckedChanged(object sender, EventArgs e)
        {
            bolme();
        }
    }
}

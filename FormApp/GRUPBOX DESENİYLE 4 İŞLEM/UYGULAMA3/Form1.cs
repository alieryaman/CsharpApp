using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void topla()
        {
            int s1 = Convert.ToInt32(tx_sayı1.Text);
            int s2 = Convert.ToInt32(tx_sayı2.Text);
            int snc = s1 + s2;
            tx_sonuc.Text = snc.ToString();
        }

        private void cikar()
        {
            int s1 = Convert.ToInt32(tx_sayı1.Text);
            int s2 = Convert.ToInt32(tx_sayı2.Text);
            int snc = s1 - s2;
            tx_sonuc.Text = snc.ToString();
        }

        private void carp()
        {
            int s1 = Convert.ToInt32(tx_sayı1.Text);
            int s2 = Convert.ToInt32(tx_sayı2.Text);
            int snc = s1 * s2;
            tx_sonuc.Text = snc.ToString();
        }

        private void bol()
        {
            int s1 = Convert.ToInt32(tx_sayı1.Text);
            int s2 = Convert.ToInt32(tx_sayı2.Text);
            int snc = s1 / s2;
            tx_sonuc.Text = snc.ToString();
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            topla();
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            cikar();
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            carp();
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            bol();
        }
    }
}

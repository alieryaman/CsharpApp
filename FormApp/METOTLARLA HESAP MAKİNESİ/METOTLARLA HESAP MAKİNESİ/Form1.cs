using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace METOTLARLA_HESAP_MAKİNESİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void toplama(int s1, int s2)
        {
            int snc = s1 + s2;
            label_snc.Text = snc.ToString();
        }
        void cikarma(int s1, int s2)
        {
            int snc = s1 - s2;
            label_snc.Text = snc.ToString();
        }
        void carpma(int s1, int s2)
        {
            int snc = s1 * s2;
            label_snc.Text = snc.ToString();
        }
        void bolme(int s1, int s2)
        {
            int snc = s1 / s2;
            label_snc.Text = snc.ToString();
        }
        int sayı1, sayı2;
        private void but_top_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToInt32(tex_sayı1.Text);
            sayı2 = Convert.ToInt32(tex_sayı2.Text);
            toplama(sayı1, sayı2);

        }

        private void but_cık_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToInt32(tex_sayı1.Text);
            sayı2 = Convert.ToInt32(tex_sayı2.Text);
            cikarma(sayı1, sayı2);
        }

        private void but_carp_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToInt32(tex_sayı1.Text);
            sayı2 = Convert.ToInt32(tex_sayı2.Text);
            carpma(sayı1, sayı2);
        }

        private void but_bol_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToInt32(tex_sayı1.Text);
            sayı2 = Convert.ToInt32(tex_sayı2.Text);
            bolme(sayı1, sayı2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_snc_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}

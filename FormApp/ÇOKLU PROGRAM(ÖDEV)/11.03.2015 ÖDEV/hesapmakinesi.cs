using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._03._2015_ÖDEV
{
    public partial class hesapmakinesi : Form
    {
        public hesapmakinesi()
        {
            InitializeComponent();
        }
        int s1, s2, snc;

        private void btn_topla_Click(object sender, EventArgs e)
        {
            
       
            s1 = Convert.ToInt32(txt_s1.Text);
            s2 = Convert.ToInt32(txt_s2.Text);
            
            snc = s1 + s2;
            txt_snc.Text = snc.ToString();
        }
        private void btn_cikar_Click(object sender, EventArgs e)
        {

            s1 = Convert.ToInt32(txt_s1.Text);
            s2 = Convert.ToInt32(txt_s2.Text);

            snc = s1 - s2;
            txt_snc.Text = snc.ToString();
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {

            s1 = Convert.ToInt32(txt_s1.Text);
            s2 = Convert.ToInt32(txt_s2.Text);

            snc = s1 * s2;
            txt_snc.Text = snc.ToString();
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {

            s1 = Convert.ToInt32(txt_s1.Text);
            s2 = Convert.ToInt32(txt_s2.Text);

            snc = s1 / s2;
            txt_snc.Text = snc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_s1.Clear();
            txt_s2.Clear();
            txt_snc.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seçenekler scnk2 = new seçenekler();
            scnk2.Show();
            this.Hide();
        }
        }
    }


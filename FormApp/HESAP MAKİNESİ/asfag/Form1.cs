using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asfag
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void txt_snc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

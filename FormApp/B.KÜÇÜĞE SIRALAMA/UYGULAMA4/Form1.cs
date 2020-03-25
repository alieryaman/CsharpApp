using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(tx_s1.Text);
            int s2 = Convert.ToInt32(tx_s2.Text);
            int s3 = Convert.ToInt32(tx_s3.Text);

            if (s1>s2 && s1>s3)
            {
                if (s2>s3)
                {
                    lb_buyuk.Text = s1.ToString();
                    lb_orta.Text = s2.ToString();
                    lb_kucuk.Text = s3.ToString();

                }
                else if (s3>s2)
                {
                    lb_buyuk.Text = s1.ToString();
                    lb_orta.Text = s3.ToString();
                    lb_kucuk.Text = s2.ToString();
                }
            }

            if (s2>s1 && s2>s3)
            {
                if (s1>s3)
                {
                    lb_buyuk.Text = s2.ToString();
                    lb_orta.Text = s1.ToString();
                    lb_kucuk.Text = s3.ToString();
                }
                else if (s3>s1)
                {
                    lb_buyuk.Text = s2.ToString();
                    lb_orta.Text = s3.ToString();
                    lb_kucuk.Text = s1.ToString();
                }
            }

            if (s3>s1 && s3>s2)
            {
                if (s1>s2)
                {
                    lb_buyuk.Text = s3.ToString();
                    lb_orta.Text = s1.ToString();
                    lb_kucuk.Text = s2.ToString();
                }
                else if (s2>s1)
                {
                    lb_buyuk.Text = s3.ToString();
                    lb_orta.Text = s2.ToString();
                    lb_kucuk.Text = s1.ToString();
                }
            }

        }
    }
}

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
    public partial class soru4 : Form
    {
        public soru4()
        {
            InitializeComponent();
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            double y1 = Convert.ToInt32(tx_y1.Text);
            double y2 = Convert.ToInt32(tx_y2.Text);
            double sozlu = Convert.ToInt32(tx_sozlu.Text);
            double ort = (y1 + y2 + sozlu) / 3;
            lb_ort.Text = ort.ToString();
            if (y1 > 100 && y1 < 0)
            {
                MessageBox.Show("0-100 ARALIĞI GİRİNİZ!");
                tx_y1.Focus();
            }

            else if (y2 > 100 && y2 < 0)
            {
                MessageBox.Show("0-100 ARALIĞI GİRİNİZ!");
                tx_y2.Focus();
            }
            else if (sozlu > 100 && sozlu < 0)
            {
                MessageBox.Show("0-100 ARALIĞI GİRİNİZ!");
                tx_sozlu.Focus();
            }

            if (ort > 84)
            {
                lb_not.Text = "5";
                lb_durum.Text = "GEÇTİ";
            }
                      
            else if (ort > 69)
            {
                lb_not.Text = "4";
                lb_durum.Text = "GEÇTİ";
            }
            else if (ort > 59)
            {
                lb_not.Text = "3";
                lb_durum.Text = "GEÇTİ";
            }
            else if (ort>50)
            {
                lb_not.Text = "2";
                lb_durum.Text = "GEÇTİ";
            }
            else if (ort > 24)
            {
                lb_not.Text = "1";
                lb_durum.Text = "KALDI";
            }
            else if (ort > 0)
            {
                lb_not.Text = "0";
                lb_durum.Text = "KALDI";
            }

            
        }
    }
}

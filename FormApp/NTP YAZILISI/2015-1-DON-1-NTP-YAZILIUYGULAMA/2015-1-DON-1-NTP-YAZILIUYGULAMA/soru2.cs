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
    public partial class soru2 : Form
    {
        public soru2()
        {
            InitializeComponent();
        }
        

        private void soru2_Load(object sender, EventArgs e)
        {

        }

        

        private void chb_voley_CheckedChanged(object sender, EventArgs e)
        {
            tx_secim.Text = tx_secim.Text + "-VOLEYBOL-";
        }

        private void chb_basket_CheckedChanged(object sender, EventArgs e)
        {
            tx_secim.Text = tx_secim.Text + "-BASKETBOL-";
        }

        private void chb_futbol_CheckedChanged(object sender, EventArgs e)
        {
            tx_secim.Text = tx_secim.Text + "-FUTBOL-";
        }

        private void chb_hentbol_CheckedChanged(object sender, EventArgs e)
        {
            tx_secim.Text = tx_secim.Text + "-HENTBOL-";
        }

        private void chb_yuzme_CheckedChanged(object sender, EventArgs e)
        {
            tx_secim.Text = tx_secim.Text + "-YÜZME-";
        }

        private void chb_masat_CheckedChanged(object sender, EventArgs e)
        {
            tx_secim.Text = tx_secim.Text + "-MASA TENİSİ-";
        }




    }
}

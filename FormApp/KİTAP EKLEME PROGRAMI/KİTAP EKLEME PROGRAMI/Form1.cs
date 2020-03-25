using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KİTAP_EKLEME_PROGRAMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_kadi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_kadi.Items.Add(tx_kadi.Text);
            lb_ktpturu.Items.Add(tx_kturu.Text);
            lb_fiyati.Items.Add(tx_fiyati.Text);
            lb_bsmtarihi.Items.Add(tx_basımtrh.Text);
            lb_syfasysi.Items.Add(tx_sayfasayisi.Text);
            lb_yaynevi.Items.Add(tx_yayınevi.Text);
            lb_yzradi.Items.Add(tx_yadi.Text);

        }

        private void tx_yayınevi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tx_kturu_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_sayfasayisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        
    }
}

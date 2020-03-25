using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_spal_Click(object sender, EventArgs e)
        {
            lb_ad.Items.Add(tx_adsyd.Text);
            lb_tel.Items.Add(tx_telno.Text);
            lb_adres.Items.Add(tx_adres.Text);
            lb_pboy.Items.Add(cmb_pboy.Text);
            lb_icecek.Items.Add(cmb_icecek.Text);
        }

        private void btn_tmzle_Click(object sender, EventArgs e)
        {
            tx_adsyd.Clear();
            tx_telno.Clear();
            tx_adres.Clear();
            cmb_pboy.Text = "";
            cmb_icecek.Text = "";
        }
    }
}

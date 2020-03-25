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

        private void chb_kare_CheckedChanged(object sender, EventArgs e)
        {
            tx_uznknr.Visible = false;
            tx_cap.Visible = false;
            tx_yukseklik.Visible = false;
            chb_daire.Enabled = false;
            chb_silindir.Enabled = false;
            chb_dikdort.Enabled = false;
            chb_ucgen.Enabled = false;
            chb_yamuk.Enabled = false;
        }

        private void chb_daire_CheckedChanged(object sender, EventArgs e)
        {
            tx_kenar.Visible = false;
            tx_uznknr.Visible = false;
            chb_kare.Enabled = false;
            chb_silindir.Enabled = false;
            chb_dikdort.Enabled = false;
            chb_ucgen.Enabled = false;
            chb_yamuk.Enabled = false;

        }

        private void chb_silindir_CheckedChanged(object sender, EventArgs e)
        {
            tx_uznknr.Visible = false;
            tx_kenar.Visible = false;
            chb_daire.Enabled = false;
            chb_kare.Enabled = false;
            chb_dikdort.Enabled = false;
            chb_ucgen.Enabled = false;
            chb_yamuk.Enabled = false;
        }

        private void chb_dikdort_CheckedChanged(object sender, EventArgs e)
        {
            tx_yukseklik.Visible = false;
            tx_cap.Visible = false;
            chb_daire.Enabled = false;
            chb_silindir.Enabled = false;
            chb_kare.Enabled = false;
            chb_ucgen.Enabled = false;
            chb_yamuk.Enabled = false;
        }

        private void chb_ucgen_CheckedChanged(object sender, EventArgs e)
        {
            tx_cap.Visible = false;
            tx_uznknr.Visible = false;
            chb_daire.Enabled = false;
            chb_silindir.Enabled = false;
            chb_dikdort.Enabled = false;
            chb_kare.Enabled = false;
            chb_yamuk.Enabled = false;
        }

        private void chb_yamuk_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "ÜST TABAN";
            label2.Text = "ALT TABAN";
            tx_cap.Visible = false;
            chb_daire.Enabled = false;
            chb_silindir.Enabled = false;
            chb_dikdort.Enabled = false;
            chb_kare.Enabled = false;
            chb_ucgen.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar, capi, uznkenar, yukseklik, sonuc, altbn, ustbn;

            if (chb_kare.Checked)
            {
                kenar = Convert.ToInt32(tx_kenar.Text);
                sonuc = kenar * kenar;
                tx_alan.Text = sonuc.ToString();
                
            }

            if (chb_daire.Checked)
            {
                capi = Convert.ToInt32(tx_cap.Text);
                sonuc = (capi * capi) * 3;
                tx_alan.Text = sonuc.ToString();
            }

            if (chb_silindir.Checked)
            {
                yukseklik = Convert.ToInt32(tx_yukseklik.Text);
                capi = Convert.ToInt32(tx_cap.Text);
                sonuc = (capi * capi) * yukseklik * 3;
                tx_alan.Text = sonuc.ToString();
            }

            if (chb_dikdort.Checked)
            {
                uznkenar = Convert.ToInt32(tx_uznknr.Text);
                kenar = Convert.ToInt32(tx_kenar.Text);
                sonuc = uznkenar * kenar;
                tx_alan.Text = sonuc.ToString();
            }

            if (chb_ucgen.Checked)
            {
                kenar = Convert.ToInt32(tx_kenar.Text);
                yukseklik = Convert.ToInt32(tx_yukseklik.Text);
                sonuc = (kenar * yukseklik) / 2;
                tx_alan.Text = sonuc.ToString();
            }

            if (chb_yamuk.Checked)
            {
                altbn = Convert.ToInt32(tx_kenar.Text);
                ustbn = Convert.ToInt32(tx_uznknr.Text);
                yukseklik=Convert.ToInt32(tx_yukseklik.Text);
                sonuc = ((altbn + ustbn) * yukseklik) / 2;
                tx_alan.Text = sonuc.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_alan.Clear();
            tx_cap.Clear();
            tx_kenar.Clear();
            tx_uznknr.Clear();
            tx_yukseklik.Clear();                     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

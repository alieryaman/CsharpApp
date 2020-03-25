using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA1
{
    public partial class KAFE : Form
    {
        public KAFE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hesap2 = 0;
            int hesap = 0;
            double kdbgymhsp = 0;
            double kdvgdahsp = 0;
            int toplamhesap = 0;

            if (chb_meyvesyu.Checked)
            {
                int myvadet = Convert.ToInt32(cmb_meyveadet.Text);
                hesap = hesap + (myvadet * 2);
            }
            if (chb_tost.Checked)
            {
                int tostadet = Convert.ToInt32(cmb_tostadet.Text);
                hesap = hesap + (tostadet * 4);
            }
            if (chb_salata.Checked)
            {
                int sltadet = Convert.ToInt32(cmb_salatadet.Text);
                hesap = hesap + (sltadet * 5);
            }
            if (rdb_kdvgıda.Checked)
            {
                kdvgdahsp = hesap * 1.08;
                tx_gıdatoplam.Text = kdvgdahsp.ToString();
            }
            if (chb_kazak.Checked)
            {
                int kazakdet = Convert.ToInt32(cmb_kazakadet.Text);
                hesap2 = hesap2 + (kazakdet * 10);
            }
            if (chb_pantalon.Checked)
            {
                int pantoadet = Convert.ToInt32(cmb_pantoadet.Text);
                hesap2 = hesap2 + (pantoadet * 35);
            }
            if (chb_mont.Checked)
            {
                int montadet = Convert.ToInt32(cmb_montadet.Text);
                hesap2 = hesap2 + (montadet * 100);
            }
            if (rdb_kdvgiyim.Checked)
            {
                kdbgymhsp = hesap2 * 1.18;
                tx_gymtoplam.Text = kdbgymhsp.ToString();
            }

            toplamhesap = hesap + hesap2;
            tx_tutar.Text = toplamhesap.ToString();



            
            
            
                
            
            
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class KullanıcıKontrol : Form
    {
        public KullanıcıKontrol()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (tx_kadi.Text=="AND"&&tx_sifre.Text=="111")
            {
                Anaform anafrm = new Anaform();
                anafrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("GİRİŞ BAŞARISIZ !");
                this.Close();
            }
        }
    }
}

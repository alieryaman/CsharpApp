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
    public partial class yeniform : Form
    {
        public yeniform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(tx_sayi.Text);
            int sayimod = sayi%2;
            if (sayimod==0)
            {
                MessageBox.Show("SAYI ÇİFTTİR");
            }
            else
            {
                MessageBox.Show("SAYI TEKTİR");
            }
        }

        private void tx_sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }

        private void btn_yenifrom_Click(object sender, EventArgs e)
        {
            KAFE kafe = new KAFE();
            kafe.Show();
            this.Hide();
        }
    }
}

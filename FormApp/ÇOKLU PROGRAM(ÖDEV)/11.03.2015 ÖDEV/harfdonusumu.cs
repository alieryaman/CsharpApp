using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._03._2015_ÖDEV
{
    public partial class harfdonusumu : Form
    {
        public harfdonusumu()
        {
            InitializeComponent();
        }
        public void buyuk()
        {
            string harf = tx_mesaj.Text;
            tx_mesaj.Text = harf.ToUpper();
        }
        public void kucuk()
        {
            string harf = tx_mesaj.Text;
            tx_mesaj.Text = harf.ToLower();
        }

        private void rdb_buyuk_CheckedChanged(object sender, EventArgs e)
        {
            buyuk();
        }

        private void rdb_kucuk_CheckedChanged(object sender, EventArgs e)
        {
            kucuk();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seçenekler scnk = new seçenekler();
            scnk.Show();
            this.Hide();
        }

        
    }
}

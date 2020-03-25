using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BÜYÜK_KÜÇÜK_HARF
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fıyat, ındırım, sonc;

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            fıyat = Convert.ToInt32(tx_fıyat.Text);
            ındırım = Convert.ToInt32(tx_ındırım.Text);
            sonc = fıyat - (fıyat / ındırım);
            tx_tutar.Text = sonc.ToString();
        }
    }
}

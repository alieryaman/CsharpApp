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
    public partial class giris2 : Form
    {
        public giris2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(tx_sayi1.Text);
            int s2 = Convert.ToInt32(tx_sayi2.Text);
            if (s1>s2)
            {
                lb_buyuk.Text = s1.ToString();
            }
            else
            {
                lb_buyuk.Text = s2.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yeniform yenifrm = new yeniform();
            yenifrm.Show();
            this.Hide();
        }
    }
}

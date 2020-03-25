using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int alan(int cap,int alansnc)
        {
            cap = Convert.ToInt32(tx_cap.Text);
            alansnc = 3 * (cap * cap);
            tx_alan.Text = alansnc.ToString();
        }
        int cevre(int cap, int cevresnc)
         {
             cap = Convert.ToInt32(tx_cap.Text);
             cevresnc = 2*3*cap;
             tx_cevre.Text = cevresnc.ToString();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}

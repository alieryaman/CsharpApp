using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARİTMETİK_İSİM_YAZDIRMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_yaz_Click(object sender, EventArgs e)
        {
            string cumle = tx_isim.Text;
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int x = 0; x <= i; x++)
                {
                    lbx_isim.Items.Add(cumle[x]);
                }
                lbx_isim.Items.Add("");
            }


            
                
            

        }
    }
}

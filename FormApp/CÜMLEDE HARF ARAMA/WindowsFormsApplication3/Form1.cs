using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = txt_cumle.Text;
            char harf = Convert.ToChar(txt_harf.Text);
            int harfsayisi = 0;

            foreach (char i in cumle)
            {
                if (harf==i)
                {
                    harfsayisi++;
                }
                
            }
            lb_sonuc.Text = "BULUNAN HARF SAYISI = " + harfsayisi.ToString();
        }
    }
}

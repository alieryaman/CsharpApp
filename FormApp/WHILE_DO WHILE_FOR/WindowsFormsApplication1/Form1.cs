using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn_yazdır_Click(object sender, EventArgs e)
        {
            string cumle = txt_isim.Text;   
            
            for (int i = 0; i < cumle.Length; i++)
            {
                lst_for.Items.Add(cumle);
            }
            
        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            string cumle = txt_isim.Text;
            int sayac = 0;
            while (sayac<cumle.Length)
            {
                lst_while.Items.Add(cumle);
                sayac++;
            }

        }

        private void btn_dowhile_Click(object sender, EventArgs e)
        {
            string cumle = txt_isim.Text;
            int sayac=0;
            do
            {
                lst_dowhile.Items.Add(cumle);
                sayac++;
            } while (sayac<cumle.Length);
        }
    }
}

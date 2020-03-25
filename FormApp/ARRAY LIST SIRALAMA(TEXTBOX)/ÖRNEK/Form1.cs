using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖRNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sabit = new int[3];
        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            lst_sayilar.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                sabit[i] = rnd.Next(1, 10);
                lst_sayilar.Items.Add(sabit[i]);
            }
        }

        private void btn_kbuyuge_Click(object sender, EventArgs e)
        {
            lst_kbuyuk.Items.Clear();
            Array.Sort(sabit);
            foreach (int aranan in sabit)
            {
                lst_kbuyuk.Items.Add(aranan);
            }
        }

        private void btn_bkucuge_Click(object sender, EventArgs e)
        {
            lst_bkucuk.Items.Clear();
            Array.Reverse(sabit);
            foreach (int aranan in sabit)
            {                
                lst_bkucuk.Items.Add(aranan);
            }
        }
        
        private void btn_kopya_Click(object sender, EventArgs e)
        {
            int[] yenidizi = new int[2];
            Array.Copy(sabit, 0, yenidizi,0,2);
            foreach (int ara in yenidizi)
            {
                lst_kopya.Items.Add(ara);
            }
            Array.Sort(sabit);
            lb_byk.Text = sabit[2].ToString();
            lb__kucuk.Text = sabit[0].ToString();
        }
        
    }
}

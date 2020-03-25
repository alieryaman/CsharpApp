using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace İKİ_BOYUTLU_DİZİLER_ÖRNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int[,] dizi1 = new int[3, 3];
        int[] dizi2 = new int[9];
        private void btn_ata_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dizi1[i, j] = rnd.Next(1, 20);
                    for (int a = 0; a < 9; a++)
                    {
                        dizi2[a] = dizi1[i, j];                        
                    }
                    tx_sayilar.Text += dizi1[i, j].ToString() + "     ";
                }
                
                tx_sayilar.Text += "\r\n";
            }
        }
    }
}

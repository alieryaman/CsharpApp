using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ÖRNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int dsayisi = Convert.ToInt32(Interaction.InputBox("KAÇ ELEMANLI DİZİ OLSUN", "", "", 100, 100));
            int[] sayilar = new int[dsayisi]; 
            Random rnd = new Random();
            for (int i = 0; i < dsayisi; i++)
            {
                sayilar[i]=rnd.Next(0, 20);
                lst_sayilar.Items.Add(sayilar[i]);
                lst_kareler.Items.Add(sayilar[i] * sayilar[i]);
                

            }
        }
    }
}

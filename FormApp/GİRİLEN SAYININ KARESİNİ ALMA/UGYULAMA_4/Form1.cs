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

namespace UGYULAMA_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            int i, j;
            int[,] saykar = new int[2, 10];
            for ( i = 0; i < 10; i++)
            {
                saykar[0, i] = Convert.ToInt32(Interaction.InputBox("BİR SAYI GİR", "SAYI GİR", "", 100, 100));
                lst_sayilar.Items.Add(saykar[0, i]);
                for ( j = 0; j < 1; j++)
                {
                    saykar[1, i] = saykar[0, i] * saykar[0, i];
                    lst_karesi.Items.Add(saykar[1, i]);
                }
            }

        }
    }
}

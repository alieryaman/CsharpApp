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

namespace UYGULAMA_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] a = new int[2, 4];
        int[] b = new int[4];
        private void btn_giris_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                a[0, i] = Convert.ToInt32(Interaction.InputBox("BİR SAYI GİRİNİZ :", "SAYI", "", 100, 100));
                a[1, i] = Convert.ToInt32(Interaction.InputBox("BİR ÖNCEKİNDEN ÇIKACAK SAYIYI GİRİNİZ :", "SAYI", "", 100, 100));
                if (a[0, i] > a[1, i])
                {
                    b[i] = a[0, i] - a[1, i];
                }
                else
                {
                    b[i] = a[1, i] - a[0, i];
                }
                
            }
            btn_1_1.Text = a[0, 0].ToString(); btn_1_2.Text = a[0, 1].ToString(); btn_1_3.Text = a[0, 2].ToString(); btn_1_4.Text = a[0, 3].ToString();
            btn_2_1.Text = a[1, 0].ToString(); btn_2_2.Text = a[1, 1].ToString(); btn_2_3.Text = a[1, 2].ToString(); btn_2_4.Text = a[1, 3].ToString();
            btn_stn1.Text = b[0].ToString(); btn_stn2.Text = b[1].ToString(); btn_stn3.Text = b[2].ToString(); btn_stn4.Text = b[3].ToString();
        }
    }
}

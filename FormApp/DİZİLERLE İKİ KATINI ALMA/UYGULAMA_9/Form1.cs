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

namespace UYGULAMA_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[4];
        int[,] b = new int[2, 4];

        private void btn_giris_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                a[i] = Convert.ToInt32(Interaction.InputBox("SAYI GİRİNİZ :", "SAYI", "", 100, 100));
                b[0, i] = a[i];
                
            }
            btn_a1.Text = a[0].ToString(); btn_a2.Text = a[1].ToString(); btn_a3.Text = a[2].ToString(); btn_a4.Text = a[3].ToString();
            btn_1_1.Text = b[0, 0].ToString(); btn_1_2.Text = b[0, 1].ToString(); btn_1_3.Text = b[0, 2].ToString(); btn_1_4.Text = b[0, 3].ToString();
            btn_2_1.Text = (b[0, 0] * 2).ToString();
            btn_2_2.Text = (b[0, 1] * 2).ToString();
            btn_2_3.Text = (b[0, 2] * 2).ToString();
            btn_2_4.Text = (b[0, 3] * 2).ToString();
            
        }
        
    }
}

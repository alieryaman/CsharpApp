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

namespace UYGULAMA_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] A = new int[10];
        int[] B = new int[5];
        private void btn_giris_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                A[i] = Convert.ToInt32(Interaction.InputBox("SAYI GİR:", "SAYI GİR", "", 100, 100));
                lst_sayilar.Items.Add(i+".ELEMAN =       " + A[i]);
            }
            B[0] = A[0] + A[9]; lb_0_9.Text = B[0].ToString();
            B[1] = A[1] + A[8]; lb_1_8.Text = B[1].ToString();
            B[2] = A[2] + A[7]; lb_2_7.Text = B[2].ToString();
            B[3] = A[3] + A[6]; lb_3_6.Text = B[3].ToString();
            B[4] = A[4] + A[5]; lb_4_5.Text = B[4].ToString();
        }
    }
}

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

namespace UYGULAMA_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[10];
        int[] b = new int[10];

        private void btn_giris_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                a[i]=Convert.ToInt32(Interaction.InputBox("SAYI GİRİNİZ :","SAYI","",100,100));
                lst_sayilar.Items.Add(a[i]);                               
            }
            for (int i = 0; i < a.Length; i++)
            {
                b[i]=a[a.Length-1-i];
                lst_ters.Items.Add(b[i]);
            }
        }

      
    }
}

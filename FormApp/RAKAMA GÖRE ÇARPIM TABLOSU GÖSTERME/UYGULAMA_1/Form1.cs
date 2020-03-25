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

namespace UYGULAMA_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] carpımsonuc = new int[10];
        int sayi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(Interaction.InputBox("BİR SAYI GİR", "SAYI GİR", "", 70, 50));
            for (int i = 0; i < 10; i++)
            {   
                carpımsonuc[i] = (i+1) * sayi;
                lst_liste.Items.Add(sayi.ToString()+ " X "+(i+1)+" = "+carpımsonuc[i].ToString()); 
            }
        }
    }
}

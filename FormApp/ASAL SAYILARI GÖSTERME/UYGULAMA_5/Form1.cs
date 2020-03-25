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

namespace UYGULAMA_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = new int[20];
        int aralıkdegeri = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            aralıkdegeri = Convert.ToInt32(Interaction.InputBox("10-100 ARASI BİR RAKAM GİRİNİZ :", "RAKAM", "", 100, 100));
            if (aralıkdegeri >= 100 || aralıkdegeri<=10)
            {
               aralıkdegeri = Convert.ToInt32(Interaction.InputBox("10-100 ARASI BİR RAKAM GİRİNİZ :", "RAKAM", "", 100, 100));
                
            }
            Random rstg = new Random();
            for (int i = 0; i < 20; i++)
            {
                sayilar[i] = rstg.Next(10,aralıkdegeri);
            }
            for (int i = 0; i <20 ; i++)
            {               
                lst_sayilar.Items.Add(sayilar[i]);
                
                if (sayilar[i] % 2 != 0 && sayilar[i] % 3 != 0 && sayilar[i] % 5 != 0 && sayilar[i] % 7 != 0)
                {
                    lst_asalsayilar.Items.Add(sayilar[i]);
                    
                }               
            }
            lst_asalsayilar.Items.Add("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            lst_sayilar.Items.Add("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
        }
        
        
    }
}

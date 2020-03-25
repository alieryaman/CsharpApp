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
namespace DİZİLERLE_ÖĞRENCİ_İŞİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler = new string[5];
        int[] not1 = new int[5];
        int[] not2 = new int[5];
        int[] ortalama = new int[5];
        private void btn_isimgir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
			{
			 isimler[i]= Interaction.InputBox("İSİM GİR ", "İSİM GİR", "", 300, 300);
             lst_ad.Items.Add(isimler[i]);
             not1[i] = Convert.ToInt32(Interaction.InputBox("NOT GİR ", "NOT GİR", "", 300, 300));
             lst_y1.Items.Add(not1[i]);
             not2[i] = Convert.ToInt32(Interaction.InputBox("NOT GİR ", "NOT GİR", "", 300, 300));
             lst_y2.Items.Add(not2[i]);
             ortalama[i] = (not1[i] + not2[i]) / 2;
             lst_ort.Items.Add(ortalama[i]);
             if (ortalama[i]>=50)
             {
                 lst_durum.Items.Add("GEÇTİ");
             }
             else
             {
                 lst_durum.Items.Add("KALDI");
             }
            
			}
           
        }

        

    }
}

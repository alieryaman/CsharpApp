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

namespace DİZİLERLE_NOT_HESAPLAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_not_Click(object sender, EventArgs e)
        {
            int[,] notlar = new int[3, 3]; int[] ortalama = new int[3];
            for (int i = 0; i < 3; i++)
            {
                notlar[0, i] = Convert.ToInt32(Interaction.InputBox("1. NOTU GİR:", "NOT", "", 100, 100));
                lst_not1.Items.Add((i+1+". ÖĞRENCİ ")+notlar[0, i]);
                lst_not1.Items.Add("*-*-*-*-*-*-*-*");
                notlar[1, i] = Convert.ToInt32(Interaction.InputBox("2. NOTU GİR:", "NOT", "", 100, 100));
                lst_not2.Items.Add((i + 1 + ". ÖĞRENCİ ") + notlar[1, i]);
                lst_not2.Items.Add("*-*-*-*-*-*-*-*");
                notlar[2, i] = Convert.ToInt32(Interaction.InputBox("3. NOTU GİR:", "NOT", "", 100, 100));
                lst_not3.Items.Add((i + 1 + ". ÖĞRENCİ ") + notlar[2, i]);
                lst_not3.Items.Add("*-*-*-*-*-*-*-*");
                ortalama[i] = (notlar[0, i] + notlar[1, i] + notlar[2, i]) / 3;
                lst_ort.Items.Add((i + 1 + ". ÖĞRENCİ ") + ortalama[i]);
                lst_ort.Items.Add("*-*-*-*-*-*-*-*");
            }
            Array.Sort(ortalama);
            lb_dusuk.Text = ortalama[0].ToString();
            lb_yuksek.Text = ortalama[2].ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.csharpkampusu.com");
        }
    }
}

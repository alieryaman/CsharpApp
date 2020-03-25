using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            int[] birler = new int[10];
            int[] ikiler = new int[10];
            int[] ucler = new int[10];
            int[] dortler = new int[10];
            int[] besler = new int[10];
            int[] altilar = new int[10];
            int[] yediler = new int[10];
            int[] sekizler = new int[10];
            int[] dokuzlar = new int[10];
            int[] onlar = new int[10];

            for (int i = 0; i <10; i++)
            {
                birler[i]=1*(i+1);
                lst_birler.Items.Add("1"+" X "+(i+1)+" = "+birler[i].ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                ikiler[i] = 2 * (i + 1);
                lst_ikiler.Items.Add("2" + " X " + (i + 1) + " = " + ikiler[i].ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                ucler[i] = 3 * (i + 1);
                lst_ucler.Items.Add("3" + " X " + (i + 1) + " = " + ucler[i].ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                dortler[i] = 4 * (i + 1);
                lst_dortler.Items.Add("4" + " X " + (i + 1) + " = " + dortler[i].ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                besler[i] = 5 * (i + 1);
                lst_besler.Items.Add("5" + " X " + (i + 1) + " = " + besler[i].ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                altilar[i] = 6 * (i + 1);
                lst_altilar.Items.Add("6" + " X " + (i + 1) + " = " + altilar[i].ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                yediler[i] = 7 * (i + 1);
                lst_yediler.Items.Add("7" + " X " + (i + 1) + " = " + yediler[i].ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                sekizler[i] = 8 * (i + 1);
                lst_sekizler.Items.Add("8" + " X " + (i + 1) + " = " + sekizler[i].ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                dokuzlar[i] = 9 * (i + 1);
                lst_dokuzlar.Items.Add("9" + " X " + (i + 1) + " = " + dokuzlar[i].ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                onlar[i] = 10 * (i + 1);
                lst_onlar.Items.Add("10" + " X " + (i + 1) + " = " + onlar[i].ToString());
            }
            //HOCAM TEK FORLA YAPABİLİRDİM AMA DENEDİĞİMDE DEĞİŞİK BİR HATA ALDIM BU NEDENLE BU KADAR FOR KULLANDIM :)
        }
    }
}

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

namespace UYGULAMA_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_giris_Click(object sender, EventArgs e)
        {  
            int syc =0;
            int ksayisi=Convert.ToInt32(Interaction.InputBox("KAÇ PERSONEL GİRİLECEK?:","KAÇ","",100,100));
            string[,]  personel = new string[ksayisi,2];           
            do
            {
                personel[syc,0]=Interaction.InputBox("ADINI GİRİNİZ:","AD","",100,100);
                lst_ad.Items.Add((syc+1)+". "+personel[syc,0]);
                personel[syc,1] = Interaction.InputBox("TC NO GİRİNİZ:", "TC", "", 100, 100);
                lst_tc.Items.Add(personel[syc,1]);
                syc++;
            } while (syc<ksayisi);

        }
    }
}

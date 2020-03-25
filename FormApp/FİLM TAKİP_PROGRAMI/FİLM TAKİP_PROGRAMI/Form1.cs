using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace FİLM_TAKİP_PROGRAMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList filmler = new ArrayList();

        private void btn_fgiris_Click(object sender, EventArgs e)
        {       
            string film = Interaction.InputBox("BİR FİLM GİRİNİZ :", "FİLM");
            filmler.Add(film.ToUpper()); lst_filmler.Items.Add(film.ToUpper());           
            DialogResult soru = new DialogResult();
            soru = MessageBox.Show("DEVAM ETMEK İSTİYOR MUSUNUZ?", "DEVAM MI?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            while (soru==DialogResult.Yes)
            {
                film = Interaction.InputBox("BİR FİLM GİRİNİZ :", "FİLM");
                filmler.Add(film.ToUpper());
                lst_filmler.Items.Add(film.ToUpper());
                soru = MessageBox.Show("DEVAM ETMEK İSTİYOR MUSUNUZ?", "DEVAM MI?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (soru==DialogResult.No)
                {
                    break;
                }
            }
        }

        private void btn_fekle_Click(object sender, EventArgs e)
        {
            string film = Interaction.InputBox("BİR FİLM GİRİNİZ :", "FİLM");
            filmler.Add(film.ToUpper());
            lst_filmler.Items.Add(film.ToUpper());
        }

        private void btn_sbul_Click(object sender, EventArgs e)
        {
            string arananfilm = Interaction.InputBox("ARADIĞINIZ FİLMİ GİRİNİZ :", "FİLM");
            MessageBox.Show("ARADIĞINIZ FİLMİN DİZİDEKİ INDEX NOSU = " + filmler.IndexOf(arananfilm.ToUpper()));
        }

        private void btn_sırala_Click(object sender, EventArgs e)
        {
            lst_sfilmler.Items.Clear();
            DialogResult soru = new DialogResult();
            soru = MessageBox.Show("DİZİYİ A'DAN Z'YE SIRALAYACAK. DEVAM MI ?", "SORU", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (soru == DialogResult.OK)
            {
                filmler.Sort();
                foreach (string ara in filmler)
                {
                    lst_sfilmler.Items.Add(ara.ToUpper());
                }
            }
        }

        private void btn_tcevir_Click(object sender, EventArgs e)
        {
            lst_sfilmler.Items.Clear();
            DialogResult soru = new DialogResult();
            soru = MessageBox.Show("DİZİ TERS ÇEVRİLECEK. DEVAM MI ?", "SORU", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (soru == DialogResult.OK)
            {
                filmler.Reverse();
                foreach (string ara in filmler)
                {
                    lst_sfilmler.Items.Add(ara.ToUpper());
                }
            }
        }

        private void btn_lsil_Click(object sender, EventArgs e)
        {
            filmler.Clear();
            DialogResult soru = new DialogResult();
            soru = MessageBox.Show("FİLM LİSTESİ SİLİNECEK. DEVAM MI?", "SORU", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (soru == DialogResult.OK)
            {
                lst_filmler.Items.Clear();
            }
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            lst_sfilmler.Items.Clear();
            filmler.Clear();
            lst_filmler.Items.Clear();
        }
        private void btn_isil_Click(object sender, EventArgs e)
        {
            lst_filmler.Items.Remove(lst_filmler.SelectedItem);
            filmler.Remove(lst_filmler.SelectedItem);
        }

        private void btn_kapasite_Click(object sender, EventArgs e)
        {
            int kapasite = filmler.Capacity;
            MessageBox.Show("DİZİNİZİN KAPASİTESİ = " + kapasite.ToString());
        }

        private void btn_eleman_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DİZİNİZİN ELEMAN SAYISI = " + filmler.Count.ToString()); 
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            DialogResult soru = new DialogResult();
            soru = MessageBox.Show("ÇIKMAK İSTEDİĞİNİZE EMİN MİSİNİZ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (soru == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.csharpkampusu.com");
        }

      

}

        
}
    


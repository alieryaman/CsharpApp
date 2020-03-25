using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VERİTABANLI_KULLANICI_GİRİŞİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ÖRNEK3.accdb");
        
        private void btn_giriş_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM ÜYELER where KULLANICI_ADI = '" + tx_kullanıcı.Text + "' AND SİFRE = '" + tx_sifre.Text + "'");
            komut.Connection = baglanti;
            OleDbDataReader okuyucu = komut.ExecuteReader();
            string kullanici = tx_kullanıcı.Text;
            string sifre = tx_sifre.Text;
            if (okuyucu.Read())
            {
                MessageBox.Show("BAŞARILI");
            }
            else
            {
                if (tx_kullanıcı.Text == "" || tx_sifre.Text == "")
                {
                    MessageBox.Show("BOŞ GEÇİLEMEZ");
                }
                else
                    MessageBox.Show("HATA!");
            }
            
        }

        private void kAYDOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaydol kyd = new kaydol();
            kyd.Show();
            this.Hide();
        }
    }
}

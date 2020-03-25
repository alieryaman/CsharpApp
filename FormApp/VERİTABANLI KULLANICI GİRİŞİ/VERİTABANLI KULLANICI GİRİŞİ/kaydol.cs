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
    public partial class kaydol : Form
    {
        public kaydol()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ÖRNEK3.accdb");
        private void button1_Click(object sender, EventArgs e)
        {         
            if (tx_kullanıcı.Text == "" || tx_sifre.Text == "")
            {
                MessageBox.Show("BOŞ GEÇİLEMEZ!");
            }
            else
            {
                baglanti.Open();
                OleDbCommand ekle = new OleDbCommand("insert into ÜYELER(KULLANICI_ADI,SİFRE) values (@kadi,@sifre)");
                ekle.Parameters.AddWithValue("@kadi", tx_kullanıcı.Text);
                ekle.Parameters.AddWithValue("@sifre", tx_sifre.Text);
                ekle.Connection = baglanti;
                ekle.ExecuteNonQuery();
                MessageBox.Show("KAYIT TAMAMLANDI");
                baglanti.Close();
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
        }
    }
}

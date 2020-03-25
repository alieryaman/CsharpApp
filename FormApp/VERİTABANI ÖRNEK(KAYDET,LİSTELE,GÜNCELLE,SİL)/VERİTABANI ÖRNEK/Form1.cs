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

namespace VERİTABANI_ÖRNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ÖRNEK.accdb");

        private void verilerigoster()
        {
            baglanti.Open();
            OleDbCommand komutum = new OleDbCommand("Select * From ÖRNEK");
            komutum.Connection = baglanti;
            OleDbDataAdapter okuyucu = new OleDbDataAdapter(komutum);
            DataTable dt = new DataTable();
            okuyucu.Fill(dt);
            data_listem.DataSource = dt;
            baglanti.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("insert into ÖRNEK(ADI,SOYADI) values (@ad,@soyad)");
            try
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.Parameters.AddWithValue("@ad", tx_ad.Text);
                komut.Parameters.AddWithValue("@soyad", tx_soyad.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("KAYIT EKLENDİ");
                tx_ad.Clear(); tx_soyad.Clear(); tx_ad.Focus();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!");
                baglanti.Close();
            }
            verilerigoster();
            
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
                verilerigoster();
        }

        private void btn_durum_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                MessageBox.Show("BAĞLANTU DURUMU : BAĞLANILABLİR");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("BAĞLANTI AÇILAMADI!");
                baglanti.Close();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {            
            try
            {
                baglanti.Open();
                OleDbCommand guncelleme = new OleDbCommand();
                guncelleme.CommandText = "UPDATE ÖRNEK set ADI='" + tx_ad.Text + "',SOYADI='" + tx_soyad.Text + "' where SOYADI = '" + tx_guncelyazi.Text + "'";
                guncelleme.Connection = baglanti;
                guncelleme.ExecuteNonQuery();
                MessageBox.Show("GÜNCELLEME TAMAMLANDI");
                verilerigoster();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ SOYADI BULUNMAMAKTADIR!");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {           
           
            
                baglanti.Open();
                OleDbCommand sil = new OleDbCommand();
                sil.Connection = baglanti;
                sil.CommandText = " delete from ÖRNEK where SOYADI = '" + tx_guncelyazi.Text + "'";
                sil.ExecuteNonQuery();
                MessageBox.Show("KAYIT SİLİNDİ");
                verilerigoster();
                baglanti.Close();      
        }
    }
}

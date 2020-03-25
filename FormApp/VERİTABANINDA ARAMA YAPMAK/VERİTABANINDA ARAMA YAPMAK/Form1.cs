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

namespace VERİTABANINDA_ARAMA_YAPMAK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BİLGİLER.accdb");

        private void verilerigoster()
        {
            baglanti.Open();
            OleDbCommand komutum = new OleDbCommand("Select * From ORNEK");
            komutum.Connection = baglanti;
            OleDbDataAdapter okuyucu = new OleDbDataAdapter(komutum);
            DataTable dt = new DataTable();
            okuyucu.Fill(dt);
            data_listem.DataSource = dt;
            baglanti.Close();
        }
       
        private void btn_ekle_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand();
            ekle.CommandText = "insert into ORNEK(TC_NO,AD,SOYAD,YAS) values (@tc_no,@ad,@soyad,@yas)";
            ekle.Connection = baglanti;
            ekle.Parameters.AddWithValue("@tc_no", tx_tcno.Text);
            ekle.Parameters.AddWithValue("@ad", tx_ad.Text);
            ekle.Parameters.AddWithValue("@soyad", tx_soyad.Text);
            ekle.Parameters.AddWithValue("@yas", tx_yas.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT TAMAMLANDI");
            tx_ad.Clear(); tx_soyad.Clear(); tx_tcno.Clear(); tx_yas.Clear(); tx_tcno.Focus();
        }

        private void btn_goster_Click_1(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand guncelleme = new OleDbCommand();
            guncelleme.CommandText = "UPDATE ORNEK set AD='" + tx_ad.Text + "',SOYAD='" + tx_soyad.Text + "',TC_NO='" + tx_tcno.Text + "',YAS='" + tx_yas.Text + "' where SOYAD = '" + tx_guncel.Text + "'";
            guncelleme.Connection = baglanti;
            guncelleme.ExecuteNonQuery();
            verilerigoster();
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

        }

        private void ara_tc_Click_1(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from ORNEK where TC Like '" + tc_ara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "ORNEK");
            data_listem.DataSource = ds.Tables["ORNEK"];
            baglanti.Close();
        }

        private void ara_soyad_Click_1(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from ORNEK where SOYAD Like '" + soyad_ara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "ORNEK");
            data_listem.DataSource = ds.Tables["ORNEK"];
            baglanti.Close();
        }

        private void ara_ad_Click_1(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from ORNEK where AD Like '" + ad_ara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "ORNEK");
            data_listem.DataSource = ds.Tables["ORNEK"];
            baglanti.Close();
        }

        private void ara_yas_Click_1(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from ORNEK where YAS Like '" + yas_ara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "ORNEK");
            data_listem.DataSource = ds.Tables["ORNEK"];
            baglanti.Close();
        }
    }
}

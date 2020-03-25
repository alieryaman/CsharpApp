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
using System.Media;

namespace CSHARP_SORU_CEVAP_OYUNU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer ses = new SoundPlayer();        
        int sayac = 0;
        int dogrucevap = 0;
        int yanliscevap = 0;
        int sayacsüre;
        int kalanzamandilimi;
        private void ileri_Click(object sender, EventArgs e)
        {
            süre.Enabled = true;
            lb_sure.Text = "10";
            sayac++;
            lb_soruno.Text = sayac.ToString();
            a_sikki.BackColor = Color.Red;
            b_sikki.BackColor = Color.Red;
            c_sikki.BackColor = Color.Red;
            d_sikki.BackColor = Color.Red;
            a_sikki.Enabled = true;
            b_sikki.Enabled = true;
            c_sikki.Enabled = true;
            d_sikki.Enabled = true;

            if (sayac == 1)
            {
                ileri.Visible = false;
                ses.Play();
                soru.Text = "1.Program içerisinde farklı değerler alabilen ifadelere ne ad verilir?";
                a_sikki.Text = " A) SABİT";
                b_sikki.Text = " B) DEĞİŞKEN";
                c_sikki.Text = " C) PROGRAM";
                d_sikki.Text = " D) HİÇBİRİ";
                dogru_cevap.Text = b_sikki.Text;
                
            }
            if (sayac == 2)
            {
                ileri.Visible = false;
                ses.Play();
                soru.Text = "2.Karşılaştırma işlemlerinde kullanılan “eşittir” operatörü aşağıdakilerden hangisidir?";
                a_sikki.Text = " A) =";
                b_sikki.Text = " B) <>";
                c_sikki.Text = " C) ==";
                d_sikki.Text = " D) !=";
                dogru_cevap.Text = c_sikki.Text;
            }
            if (sayac == 3 )
            {
                ileri.Visible = false;
                ses.Play();
                soru.Text = "3.Ve(AND) mantık operatörü için aşağıdakilerden hangisi kullanılır?";
                a_sikki.Text = " A)  &!";
                b_sikki.Text = " B)  ||";
                c_sikki.Text = " C)  #";
                d_sikki.Text = " D)  &&";
                dogru_cevap.Text = d_sikki.Text;
            }
            if (sayac == 4)
            {
                ileri.Visible = false;
                ses.Play();
                soru.Text = "4.Aşağıdakilerden hangisi döngü komutudur?";
                a_sikki.Text = " A) for";
                b_sikki.Text = " B) switch";
                c_sikki.Text = " C) if";
                d_sikki.Text = " D) convert";
                dogru_cevap.Text = a_sikki.Text;
            }
            if (sayac == 5)
            {
                ileri.Visible = false;
                ses.Play();
                soru.Text = "5.Aşağıdakilerden hangisi karşılaştırma komutudur?";
                a_sikki.Text = " A) convert";
                b_sikki.Text = " B) for";
                c_sikki.Text = " C) while";
                d_sikki.Text = " D) switch";
                dogru_cevap.Text = d_sikki.Text;
            }
            if (sayac == 6)
            {
                ileri.Visible = false;
                ses.Play();
                soru.Text = "6.Mod alma işlemi için kullanılan operatör aşağıdakilerden hangisidir?";
                a_sikki.Text = " A) +";
                b_sikki.Text = " B) -";
                c_sikki.Text = " C) %";
                d_sikki.Text = " D) /";
                dogru_cevap.Text = c_sikki.Text;
            }
            if (sayac == 7)
            {
                ileri.Visible = false;
                ses.Play();
                soru.Text = "7.Değil(NOT) mantık operatörü için aşağıdakilerden hangisi kullanılır?";
                a_sikki.Text = " A) !";
                b_sikki.Text = " B) &&";
                c_sikki.Text = " C) ?";
                d_sikki.Text = " D) |";
                dogru_cevap.Text = a_sikki.Text;
            }
            if (sayac == 8)
            {
                ileri.Visible = false;
                ses.Play();
                soru.Text = "8.Aşağıdakilerden hangisi, 5 elemanlı, elemanlarının tipi string olan a adlı dizinin tanımlanmasıdır?";
                a_sikki.Text = " A) string() a = new string[5]";
                b_sikki.Text = " B) string a = new string(5)";
                c_sikki.Text = " C) string[] a = new string[] ";
                d_sikki.Text = " D) string[] a = new string[5]";
                dogru_cevap.Text = d_sikki.Text;
            }
            if (sayac == 9)
            {
                ileri.Visible = false;
                ses.Play();
                soru.Text = "9.Visual C# programında kod yazarken satır sonlarına hangi karakter kullanılması zorunludur?";
                a_sikki.Text = " A) ÇİFT TIRNAK";
                b_sikki.Text = " B) NOKTALI VİRGÜL";
                c_sikki.Text = " C) İKİ NOKTA";
                d_sikki.Text = " D) VİRGÜL";
                dogru_cevap.Text = b_sikki.Text;
            }
            if (sayac == 10)
            {
                ileri.Visible = false;
                ses.Play();
                soru.Text = "10. C# programında hazırlanan programı çalıştırmak için klavyeden hangi tuşa basılır?";
                a_sikki.Text = " A) F2";
                b_sikki.Text = " B) F7";
                c_sikki.Text = " C) F5";
                d_sikki.Text = " D) F10";
                dogru_cevap.Text = c_sikki.Text;
                
            }
            
            
        }

        private void a_sikki_Click(object sender, EventArgs e)
        {
            a_sikki.Enabled = false;
            b_sikki.Enabled = false;
            c_sikki.Enabled = false;
            d_sikki.Enabled = false;

            süre.Enabled = false;
            if (a_sikki.Text == dogru_cevap.Text)
            {
                dogrucevap++;
                ses.Stop();
                puan.Text = dogrucevap.ToString();
                a_sikki.BackColor = Color.Green;
                kalanzamandilimi += 10 - sayacsüre;
                lb_kalansure.Text = kalanzamandilimi.ToString();
                ileri.Visible = true;
            }
            else
            {
                yanliscevap++;
                ses.Stop();
                a_sikki.BackColor = Color.Yellow;
                kalanzamandilimi += 10 - sayacsüre;
                yanlispuan.Text = yanliscevap.ToString();
                ileri.Visible = true;
            }
        }

        private void b_sikki_Click(object sender, EventArgs e)
        {
            a_sikki.Enabled = false;
            b_sikki.Enabled = false;
            c_sikki.Enabled = false;
            d_sikki.Enabled = false;

            süre.Enabled = false;
            if (b_sikki.Text == dogru_cevap.Text)
            {
                dogrucevap++;
                ses.Stop();
                puan.Text = dogrucevap.ToString();
                b_sikki.BackColor = Color.Green;
                kalanzamandilimi += 10 - sayacsüre;
                lb_kalansure.Text = kalanzamandilimi.ToString();
                ileri.Visible = true;
            }
            else
            {
                yanliscevap++;
                ses.Stop();
                b_sikki.BackColor = Color.Yellow;
                kalanzamandilimi += 10 - sayacsüre;
                yanlispuan.Text = yanliscevap.ToString();
                ileri.Visible = true;
            }
        }

        private void c_sikki_Click(object sender, EventArgs e)
        {
            a_sikki.Enabled = false;
            b_sikki.Enabled = false;
            c_sikki.Enabled = false;
            d_sikki.Enabled = false;

            süre.Enabled = false;
            if (c_sikki.Text == dogru_cevap.Text)
            {
                dogrucevap++;
                ses.Stop();
                puan.Text = dogrucevap.ToString();
                c_sikki.BackColor = Color.Green;
                kalanzamandilimi += 10 - sayacsüre;
                lb_kalansure.Text = kalanzamandilimi.ToString();
                ileri.Visible = true;
            }
            else
            {
                yanliscevap++;
                ses.Stop();
                c_sikki.BackColor = Color.Yellow;
                kalanzamandilimi += 10 - sayacsüre;
                yanlispuan.Text = yanliscevap.ToString();
                ileri.Visible = true;
            }
        }

        private void d_sikki_Click(object sender, EventArgs e)
        {
            a_sikki.Enabled = false;
            b_sikki.Enabled = false;
            c_sikki.Enabled = false;
            d_sikki.Enabled = false;

            süre.Enabled = false;
            if (d_sikki.Text == dogru_cevap.Text)
            {
                dogrucevap++;
                ses.Stop();
                puan.Text = dogrucevap.ToString();
                d_sikki.BackColor = Color.Green;
                kalanzamandilimi += 10 - sayacsüre;
                lb_kalansure.Text = kalanzamandilimi.ToString();
                ileri.Visible = true;
            }
            else
            {
                yanliscevap++;
                ses.Stop();
                d_sikki.BackColor = Color.Yellow;
                kalanzamandilimi += 10 - sayacsüre;
                yanlispuan.Text = yanliscevap.ToString();
                ileri.Visible = true;
            }
        }

        private void süre_Tick(object sender, EventArgs e)
        {
            süre.Interval = 1000;
            sayacsüre = Convert.ToInt32(lb_sure.Text);
            sayacsüre--;
            lb_sure.Text = sayacsüre.ToString();

            if (sayacsüre == 0)
            {
                süre.Enabled = false;
                yanliscevap++;
                yanlispuan.Text = yanliscevap.ToString();
                ileri.Visible = true;
                a_sikki.Enabled = false;
                b_sikki.Enabled = false;
                c_sikki.Enabled = false;
                d_sikki.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soru.Text = "HOŞGELDİN! TESTE BAŞLAMAK İÇİN İLERİ'YE TIKLA !";
            ses.SoundLocation = @"C:\Users\Veysel\Desktop\CSHARP SORU CEVAP OYUNU\CSHARP SORU CEVAP OYUNU\song.wav.wav"; 
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARABA_HAREKET_ETTİRME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();



        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            int solturuncu = pictureBox1.Left;
            int solyesil = pictureBox2.Left;
            int solmavi = pictureBox3.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int trncux = pictureBox1.Location.X;
            int yesilx = pictureBox2.Location.X;
            int mavix = pictureBox3.Location.X;
            int trncugenis = pictureBox1.Width;
            int yesilgenis = pictureBox2.Width;
            int mavigenis = pictureBox3.Width;
            int bitis = textBox7.Left;
            pictureBox1.Left = pictureBox1.Left + rnd.Next(5, 10);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 10);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(5,10);
            if (trncugenis+pictureBox1.Left>=bitis)
            {
                timer1.Stop();
                MessageBox.Show("TURUNCU ARABA YARIŞI KAZANDI !");
                
                
            }
            if (yesilgenis + pictureBox2.Left >= bitis)
            {
                timer1.Stop();
                MessageBox.Show("YEŞİL ARABA YARIŞI KAZANDI !");
                
            }
            if (mavigenis+pictureBox3.Left>=bitis)
            {
                timer1.Stop();
                MessageBox.Show("MAVİ ARABA YARIŞI KAZANDI");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

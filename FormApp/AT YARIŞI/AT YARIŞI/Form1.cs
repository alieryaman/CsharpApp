using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_YARIŞI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;

        Random rastgle = new Random();


        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatıngenisligi = pictureBox1.Width;
            int ikinciatıngenisligi = pictureBox2.Width;
            int ucuncuatıngenisligi = pictureBox3.Width;

            int bitisuzaklıgı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgle.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgle.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgle.Next(5, 15);

            if (birinciatıngenisligi + pictureBox1.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("DAZLAK(1)   ADLI   AT   YARIŞI    KAZANDI !");
                timer1.Stop();
            }

            if (ikinciatıngenisligi + pictureBox2.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("SİNEK(2)    ADLI   AT   YARIŞI    KAZANDI !");
                timer1.Stop();
            }

            if (ucuncuatıngenisligi + pictureBox3.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("YAPAY   ZEKA(3)   ADLI  AT   YARIŞI   KAZANDI !");
                timer1.Stop();
            }

        }

        
    }
}

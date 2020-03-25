using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUTSUZ_MAYMUN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right && x > 0)
                x += 5;
            else if (e.KeyCode == Keys.Left && x < 900)
                x -= 5;
            else if (e.KeyCode == Keys.Up && y > 0)
                y -= 5;
            else if (e.KeyCode == Keys.Down && y < 900)
                y += 5;
            pictureBox1.Location = new Point(x, y);

            if (pictureBox1.Bounds.IntersectsWith(label1.Bounds))
            {
                MessageBox.Show("ÇARPTINIZ !");
                pictureBox1.Location = new Point(484, 25);
            }
            if (pictureBox1.Bounds.IntersectsWith(label2.Bounds))
            {
                MessageBox.Show("ÇARPTINIZ !");
                pictureBox1.Location = new Point(484, 25);
            }
            if (pictureBox1.Bounds.IntersectsWith(label3.Bounds))
            {
                MessageBox.Show("ÇARPTINIZ !");
                pictureBox1.Location = new Point(484, 25);
            }
            if (pictureBox1.Bounds.IntersectsWith(label4.Bounds))
            {
                MessageBox.Show("ÇARPTINIZ !");
                pictureBox1.Location = new Point(484, 25);
            }
            if (pictureBox1.Bounds.IntersectsWith(label5.Bounds))
            {
                MessageBox.Show("ÇARPTINIZ !");
                pictureBox1.Location = new Point(484, 25);
            }
            if (pictureBox1.Bounds.IntersectsWith(label6.Bounds))
            {
                MessageBox.Show("ÇARPTINIZ !");
                pictureBox1.Location = new Point(484, 25);
            }
            if (pictureBox1.Bounds.IntersectsWith(label7.Bounds))
            {
                MessageBox.Show("ÇARPTINIZ !");
                pictureBox1.Location = new Point(484, 25);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox2.Visible = false;
                MessageBox.Show("TEBRİKLER KAZANDINIZ!");
                pictureBox1.Location = new Point(484, 25);
                pictureBox2.Visible = true;
            }

        }
    }
}

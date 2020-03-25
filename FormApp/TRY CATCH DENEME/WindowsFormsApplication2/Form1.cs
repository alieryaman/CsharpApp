using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s1 = Convert.ToInt32(textBox1.Text);
                int s2 = Convert.ToInt32(textBox2.Text);
                int snc = s1 / s2;
                lb_snc.Text = snc.ToString();

            }
            catch (DivideByZeroException)
            {

                MessageBox.Show("SIFIRDAN BÜYÜK BİR DEĞER GİRİNİZ!");
                textBox2.Text = "";
                textBox2.Focus();
            }
        }
    }
}

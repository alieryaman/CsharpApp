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
            string s = "";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] != ' ')
                {
                    s += textBox1.Text[i];
                    if (i == textBox1.Text.Length - 1)
                        listBox1.Items.Add(s);
                }
                else
                {
                    if (s.Length > 1)
                    {
                        listBox1.Items.Add(s);
                        s = "";
                    }
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖRNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zeminRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_zemin.ShowDialog();
            this.BackColor = color_zemin.Color;
        }

        private void yazırengi_Click(object sender, EventArgs e)
        {
            color_text.ShowDialog();
            tx_text.ForeColor = color_text.Color;
        }

        private void yazıfontu_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rtxt_text.Font = fontDialog1.Font;
        }

        private void KAPAT_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Show();
        }

        private void yazirengi_Click(object sender, EventArgs e)
        {
            color_text.ShowDialog();
            tx_text.ForeColor = color_text.Color;
        }

        private void font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            tx_text.Font = fontDialog1.Font;
        }

        private void gerial_Click(object sender, EventArgs e)
        {
            tx_text.Undo();
        }

        private void tamekran_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
        }

        

      
    }
}

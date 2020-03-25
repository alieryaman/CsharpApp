using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            rtxt_text.ForeColor = color_text.Color;
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
            timer1.Enabled = true;
        }

        private void yazirengi_Click(object sender, EventArgs e)
        {
            color_text.ShowDialog();
            rtxt_text.ForeColor = color_text.Color;
        }

        private void font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rtxt_text.Font = fontDialog1.Font;
        }

        private void gerial_Click(object sender, EventArgs e)
        {
            rtxt_text.Undo();
        }

        private void tamekran_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
        }

        

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();  
            save.Filter = "Metin Dosyası|*.txt";  
            save.OverwritePrompt = true;  
            save.CreatePrompt = true;  
  
           if (save.ShowDialog() == DialogResult.OK)  
           {  
            StreamWriter Kayit = new StreamWriter(save.FileName);  
            Kayit.WriteLine(rtxt_text.Text);  
            Kayit.Close();  
       }  

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
              DialogResult cevap = new DialogResult();
              cevap= MessageBox.Show("ÇIKMAK İSTEDİĞİNİZE EMİN MİSİNİZ?","UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
              if (cevap==DialogResult.Yes)
              {
                  this.Close();
              }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dosya_ac = "";
            openFileDialog1.InitialDirectory = "C:";
            openFileDialog1.Title = "Bir dosya açınız";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files|*.txt|word Document|*.doc";
            if (openFileDialog1.ShowDialog()!=DialogResult.Cancel)
            {
                dosya_ac = openFileDialog1.FileName;
                rtxt_text.LoadFile(dosya_ac, RichTextBoxStreamType.PlainText);
            }
        }

        private void ortalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void solaHizalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void sağaHizalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rtxt_text.Cut();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rtxt_text.Copy();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            rtxt_text.Paste();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.Paste();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();

        }

        private void programHakkkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanıcıyardım yardım = new kullanıcıyardım();
            yardım.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.csharpkampusu.com");
        }

        

        

      
    }
}

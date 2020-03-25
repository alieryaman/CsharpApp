using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYLAMA_PROGESSBAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gss = 0; int fb = 0; int bjk = 0; int trbzn = 0; int bursa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdb_gs.Checked)
            {               
                gss++;
                progressBar1.Value += 1;
                label1.Text = "%" + gss.ToString()+"  OY";                
            }

            if (radiofener.Checked)
            {               
                fb++;
                progressBar2.Value += 1;
                lb_fener.Text = "%" + fb.ToString() + "  OY";
            }

            if (rdb_besiktas.Checked)
            {
                bjk++;
                proges_besiktas.Value += 1;
                lb_bjk.Text = "%" + bjk.ToString() + "  OY";               
            }
            if (rdb_trabzon.Checked)
            {               
                trbzn++;
                prg_trabzon.Value+= 1;
                lb_trabzn.Text = "%" + trbzn.ToString() +"  OY";                
            }
            if (rdb_bursa.Checked)
            {
                bursa++;
                prb_bursa.Value += 1;
                lb_bursa.Text= "%" + bursa.ToString() + "  OY";
            }

            
        }

        private void rdb_gs_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.csharpkampusu.com");
        }

       

        
    }
}

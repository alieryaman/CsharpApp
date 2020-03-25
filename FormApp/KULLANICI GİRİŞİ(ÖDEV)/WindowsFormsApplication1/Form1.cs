using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_ad.Text = tx_ad.Text;
            lb_sınıf.Text = tx_snf.Text;
            lb_kimlik.Text = tx_no.Text;
            lb_mem.Text = tx_mem.Text;
            if (rd_kdn.Checked)
            {
                lb_cn.Text = "KADIN";
            }
            if (rd_erk.Checked)
            {
                lb_cn.Text = "ERKEK";
            }
            lb_dtrh.Text = cbx_dtrh.Text;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_ad.Text = "";
            tx_mem.Text = "";
            tx_no.Text = "";
            tx_snf.Text = "";
            lb_ad.Text = "";
            lb_cn.Text = "";
            lb_dtrh.Text = "";
            lb_kimlik.Text = "";
            lb_mem.Text = "";
            lb_sınıf.Text = "";
        }

        private void lb_mem_Click(object sender, EventArgs e)
        {

        }
    }
}

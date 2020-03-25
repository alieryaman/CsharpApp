using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._03._2015_ÖDEV
{
    public partial class seçenekler : Form
    {
        public seçenekler()
        {
            InitializeComponent();
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            hesapmakinesi frm_hesap = new hesapmakinesi();
            frm_hesap.Show();
            this.Hide();
        }

        private void btn_not_Click(object sender, EventArgs e)
        {
            nothesaplama frm_not = new nothesaplama();
            frm_not.Show();
            this.Hide();
        }

        private void btn_csharp_Click(object sender, EventArgs e)
        {
            csharp frm_csharp = new csharp();
            frm_csharp.Show();
            this.Hide();
        }

        private void btn_harf_Click(object sender, EventArgs e)
        {
            harfdonusumu frm_harf = new harfdonusumu();
            frm_harf.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2015_1_DON_1_NTP_YAZILIUYGULAMA
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void btn_soru2_Click(object sender, EventArgs e)
        {
            soru2 sr2 = new soru2();
            sr2.Show();
        }

        private void btn_soru3_Click(object sender, EventArgs e)
        {
            soru3 sr3 = new soru3();
            sr3.Show();
        }

        private void btn_soru4_Click(object sender, EventArgs e)
        {
            soru4 sr4 = new soru4();
            sr4.Show();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

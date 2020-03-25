using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA1
{
    public partial class frm_mesaj : Form
    {
        public frm_mesaj()
        {
            InitializeComponent();
        }
        int tık=0;

        private void btn_tık_Click(object sender, EventArgs e)
        {
            tık++;
            MessageBox.Show(tık.ToString()+"  KEZ BASTINIZ" );

        }
    }
}

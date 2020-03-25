using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06._10._2015
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }
        int syc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            syc = syc + 1;
            string sayac = Convert.ToString(syc);
            btn_label.Text = ("BUTONA " + sayac + " KEZ BASTINIZ");
            
        }
    }
}

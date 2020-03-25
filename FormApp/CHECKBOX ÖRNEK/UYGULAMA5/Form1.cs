using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (ch_basket.Checked && ch_fut.Checked && ch_voley.Checked)
            //{
            //    MessageBox.Show("BASKETBOL FUTBOL VE VOLEYBOL");
            //}
            //else if (ch_basket.Checked && ch_fut.Checked)
            //{
            //    MessageBox.Show("BASKETBOL VE FUTBOL");
            //}
            //else if (ch_basket.Checked && ch_voley.Checked)
            //{
            //    MessageBox.Show("BASKETBOL VE VOLEYBOL");
            //}
            //else if (ch_fut.Checked && ch_basket.Checked)
            //{
            //    MessageBox.Show("FUTBOL VE BASKETBOL");
            //}
            //else if (ch_fut.Checked && ch_voley.Checked )
            //{
            //    MessageBox.Show(" FUTBOL VE VOLEYBOL");
            //}
            //else if (ch_basket.Checked)
            //{
            //    MessageBox.Show("BASKETBOL");
            //}
            //else if (ch_fut.Checked)
            //{
            //    MessageBox.Show("FUTBOL");
            //}
            //else  if (ch_voley.Checked)
            //{
            //    MessageBox.Show("VOLEYBOL");
            //}

            
            string secim = "";

            if (ch_basket.Checked)
            {
                secim = secim + " BASKET" ;
            }
            if (ch_fut.Checked)
            {
                secim = secim + " FUTBOL";
            }
            if (ch_voley.Checked)
            {
                secim = secim + " VOLEYBOL";
            }
            MessageBox.Show(secim);
            

        }
    }
}

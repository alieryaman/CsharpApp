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
    public partial class DEĞİŞKEN_TÜRLERİ : Form
    {
        public DEĞİŞKEN_TÜRLERİ()
        {
            InitializeComponent();
        }

        private void DEĞİŞKEN_TÜRLERİ_Load(object sender, EventArgs e)
        {

        }

        private void lbox_degisken_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_degisken.SelectedItem.ToString() == "int")
            {
                tx_ornek.Text = "153";
            }
            if (lbox_degisken.SelectedItem.ToString() == "Long")
            {
                tx_ornek.Text = "153516, ....., 64461469";
            }
            if (lbox_degisken.SelectedItem.ToString() == "Double")
            {
                tx_ornek.Text = "5.0*10-324, ..., ±1.7*10308 ";
            }
            if (lbox_degisken.SelectedItem.ToString() == "Float")
            {
                tx_ornek.Text = "±1.5*10-45, ..., ±3.4*1038 ";
            }
            if (lbox_degisken.SelectedItem.ToString() == "Decimal")
            {
                tx_ornek.Text = "1.5*10-28, ..., ±7.9*1028  ";
            }
            if (lbox_degisken.SelectedItem.ToString() == "Bool")
            {
                tx_ornek.Text = " bool b1=true; ";
            }
            if (lbox_degisken.SelectedItem.ToString() == "Char")
            {
                tx_ornek.Text = " a , z , y , b , c ";
            }
            if (lbox_degisken.SelectedItem.ToString() == "String")
            {
                tx_ornek.Text = "Ben bir zaman kaybıyım, beni boşver hocam";
            }




        }
    }
}

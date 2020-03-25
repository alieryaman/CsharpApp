using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ÖRNEKLER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        ArrayList bilgiler = new ArrayList();
        

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int knm = Convert.ToInt32(tx_konum.Text);
            bilgiler.Add(tx_ekle.Text);
            lst_elemanlar.Items.Add(bilgiler[knm].ToString());
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            
            foreach (var ara in bilgiler)
            {
                lst_elemanlar.Items.Add(ara);
            }
        }

        private void btn_azliste_Click(object sender, EventArgs e)
        {
            lst_elemanlar.Items.Clear();
            bilgiler.Sort();
            lst_elemanlar.Items.Add(bilgiler);
        }

        private void btn_kapasite_Click(object sender, EventArgs e)
        {

        }

       
    }
}

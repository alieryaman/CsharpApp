using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EKRAN_GÖRÜNTÜSÜ_ALMA_PROGRAMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap resim;
        Graphics gr;

        private void btn_cek_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(1000);
            resim = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            gr = Graphics.FromImage(resim);
            gr.CopyFromScreen(0,0,0,0,  new Size(resim.Width,resim.Height));
            pictureBox1.Image = resim;
            this.Show();



            
           
        }

        private void btn_kydet_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.ShowDialog();
            resim.Save(saveFileDialog1.FileName+".jpg",ImageFormat.Jpeg);
        }
    }
}

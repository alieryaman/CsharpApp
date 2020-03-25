using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAİRE_HAREKET_ETTİRME
{
    public partial class frm_ana : Form
    {
        public frm_ana()
        {
            InitializeComponent();
        }

        private void frm_ana_KeyDown(object sender, KeyEventArgs e)
        {
            int lbsolsag = lb_sol.Right;
            int lbsagsol = lb_sag.Left;
            int lbustalt = lb_ust.Bottom;
            int lbaltust = lb_alt.Top;
            int resimsag=pictureBox1.Right;
            int resimsol=pictureBox1.Left;
            int resimalt=pictureBox1.Bottom;
            int resimust=pictureBox1.Top;
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right && x > 0)
                x += 5;
            else if (e.KeyCode == Keys.Left && x < 480)
                x -= 5;
            else if (e.KeyCode == Keys.Up && y > 0)
                y -= 5;
            else if (e.KeyCode == Keys.Down && y < 480)
                y += 5;
            pictureBox1.Location = new Point(x, y);


            if (lbsagsol<resimsag)
            {
                MessageBox.Show("ÇARPTINIZ!");
                this.Close();
            }
            if (lbsolsag>resimsol)
            {
                MessageBox.Show("ÇARPTINIZ!");
                this.Close();
            }
            if (lbaltust<resimalt)
            {
                MessageBox.Show("ÇARPTINIZ!");
                this.Close();
            }
            if (lbustalt>resimust)
            {
                MessageBox.Show("ÇARPTINIZ!");
                this.Close();
            }
            
                
           
        }

        private void frm_ana_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}

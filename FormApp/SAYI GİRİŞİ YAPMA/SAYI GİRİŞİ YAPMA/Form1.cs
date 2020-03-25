using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAYI_GİRİŞİ_YAPMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int toplam = 0;

        private void txt_gsayi_KeyDown(object sender, KeyEventArgs e)
        {
            
            
            if (e.KeyCode==Keys.Enter)
            {
                lbx_sayilar.Items.Add(txt_gsayi.Text);
                toplam = toplam + Convert.ToInt32(txt_gsayi.Text);

                DialogResult soru = new DialogResult();
                soru = MessageBox.Show("TEKRAR GİRMEK İSTİYOR MUSUNUZ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (soru==DialogResult.Yes)
                {
                    txt_gsayi.Clear();
                    txt_gsayi.Focus();
                }
                else
                {
                    lb_sonuc.Text = toplam.ToString();
                }
            }
        }

       

        
        }
    }



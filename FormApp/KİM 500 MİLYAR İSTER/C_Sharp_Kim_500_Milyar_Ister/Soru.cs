using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_Sharp_Kim_500_Milyar_Ister
{
    public partial class Soru : UserControl
    {
        List<int> soruNolar = new List<int>();
        Sorular sorular;
        int soruNo = 0;

        int[] ödül = {500,1000,2000,3000,5000,7500,15000,30000,60000,120000,250000,500000 };

        public Soru()
        {
            InitializeComponent();
        }

        public string SoruNo
        {
            get
            {
                return this.grouper1.GroupTitle.Substring(5);
            }
            set
            {
                this.grouper1.GroupTitle = "SORU "+value;
            }
        }

        public string SoruAciklamasi 
        {
            get
            {
               return txtSoru.Text ;
            }
            set
            {
                txtSoru.Text = value;
            }
        }

        public string SecenekA 
        {
            get
            {
               return txtSecenekA.Text ;
            }
            set
            {
                txtSecenekA.Text = value;
            }
        }

        public string SecenekB
        {
            get
            {
                return txtSecenekB.Text;
            }
            set
            {
                txtSecenekB.Text = value;
            }
        }

        public string SecenekC
        {
            get
            {
                return txtSecenekC.Text;
            }
            set
            {
                txtSecenekC.Text = value;
            }
        }

        public string SecenekD
        {
            get
            {
                return txtSecenekD.Text;
            }
            set
            {
                txtSecenekD.Text = value;
            }
        }

        public char DogruSecenek { get; set; }

        public bool CevapDogruMu { get; set; }

        private void txtSecenekler_Click(object sender, EventArgs e)
        {
            if (!(sender is TextBox)) return;

            TextBox secilenSecenek = sender as TextBox;

            secilenSecenek.BackColor = Color.Orange;

            if (DogruSecenek == 'A')
            {
                txtSecenekA.BackColor = Color.Lime;
            }
            else if (DogruSecenek == 'B')
            {
                txtSecenekB.BackColor = Color.Lime;
            }
            else if (DogruSecenek == 'C')
            {
                txtSecenekC.BackColor = Color.Lime;
            }
            else if (DogruSecenek == 'D')
            {
                txtSecenekD.BackColor = Color.Lime;
            }

            if (secilenSecenek.BackColor == Color.Lime)
            {
                CevapDogruMu = true;

            }
            else
            {
                CevapDogruMu = false;
            }

            DurumuGoster(CevapDogruMu);
        }

        private void DurumuGoster(bool durum)
        {
            if (durum)
            {
                btnIslem.Text = "Sonraki Soru";
                lblOdulMiktari.Text = string.Format("{0:C}", ödül[soruNo-1]);
            }
            else
            {
                btnIslem.Text = "Oyun Bitti. Yeni Oyun İçin Tıklayın";
            }
            btnIslem.Enabled = true;
        }
 
        public void OyunuBaslat()
        {
            soruNo = 0;
            lblOdulMiktari.Text = string.Format("{0:C}", 0);
            sorular = new Sorular();
            Random rastgele = new Random();

            soruNolar.Clear();

            soruNolar.Add(rastgele.Next(sorular.TumSorular.Count));
            for (int i = 0; i < 11; i++)
            {
                int no = rastgele.Next(sorular.TumSorular.Count);

                if (soruNolar.Contains(no))
                {
                    i--;
                }
                else
                {
                    soruNolar.Add(no);
                }
            }

            CevapDogruMu = true;
            SoruyuGoster();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (CevapDogruMu)
                SoruyuGoster();
            else
                OyunuBaslat();
        }

        private void SoruyuGoster()
        {
            btnIslem.Focus();
            btnIslem.Enabled = false;
            btnIslem.Text = "Yanıt Bekleniyor";

            if (CevapDogruMu)
            {
                foreach (Control item in grouper1.Controls)
                {
                    if(item is TextBox)
                    item.BackColor = SystemColors.Control;
                }

                this.SoruAciklamasi = sorular.TumSorular[soruNolar[soruNo]].SoruAciklamasi;
                this.SecenekA = sorular.TumSorular[soruNolar[soruNo]].SecenekA;
                this.SecenekB = sorular.TumSorular[soruNolar[soruNo]].SecenekB;
                this.SecenekC = sorular.TumSorular[soruNolar[soruNo]].SecenekC;
                this.SecenekD = sorular.TumSorular[soruNolar[soruNo]].SecenekD;
                this.DogruSecenek = sorular.TumSorular[soruNolar[soruNo]].DogruSecenek;
                this.SoruNo = (soruNo + 1).ToString();

                soruNo++;
            }
        }



    }
}

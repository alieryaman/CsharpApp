namespace _2015_1_DON_1_NTP_YAZILIUYGULAMA
{
    partial class soru2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tx_secim = new System.Windows.Forms.TextBox();
            this.chb_voley = new System.Windows.Forms.CheckBox();
            this.chb_basket = new System.Windows.Forms.CheckBox();
            this.chb_futbol = new System.Windows.Forms.CheckBox();
            this.chb_masat = new System.Windows.Forms.CheckBox();
            this.chb_yuzme = new System.Windows.Forms.CheckBox();
            this.chb_hentbol = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEÇİMİNİZ : ";
            // 
            // tx_secim
            // 
            this.tx_secim.Location = new System.Drawing.Point(98, 40);
            this.tx_secim.Multiline = true;
            this.tx_secim.Name = "tx_secim";
            this.tx_secim.Size = new System.Drawing.Size(187, 74);
            this.tx_secim.TabIndex = 1;
            // 
            // chb_voley
            // 
            this.chb_voley.AutoSize = true;
            this.chb_voley.Location = new System.Drawing.Point(25, 153);
            this.chb_voley.Name = "chb_voley";
            this.chb_voley.Size = new System.Drawing.Size(82, 17);
            this.chb_voley.TabIndex = 2;
            this.chb_voley.Text = "VOLEYBOL";
            this.chb_voley.UseVisualStyleBackColor = true;
            this.chb_voley.CheckedChanged += new System.EventHandler(this.chb_voley_CheckedChanged);
            // 
            // chb_basket
            // 
            this.chb_basket.AutoSize = true;
            this.chb_basket.Location = new System.Drawing.Point(25, 176);
            this.chb_basket.Name = "chb_basket";
            this.chb_basket.Size = new System.Drawing.Size(89, 17);
            this.chb_basket.TabIndex = 2;
            this.chb_basket.Text = "BASKETBOL";
            this.chb_basket.UseVisualStyleBackColor = true;
            this.chb_basket.CheckedChanged += new System.EventHandler(this.chb_basket_CheckedChanged);
            // 
            // chb_futbol
            // 
            this.chb_futbol.AutoSize = true;
            this.chb_futbol.Location = new System.Drawing.Point(25, 199);
            this.chb_futbol.Name = "chb_futbol";
            this.chb_futbol.Size = new System.Drawing.Size(68, 17);
            this.chb_futbol.TabIndex = 2;
            this.chb_futbol.Text = "FUTBOL";
            this.chb_futbol.UseVisualStyleBackColor = true;
            this.chb_futbol.CheckedChanged += new System.EventHandler(this.chb_futbol_CheckedChanged);
            // 
            // chb_masat
            // 
            this.chb_masat.AutoSize = true;
            this.chb_masat.Location = new System.Drawing.Point(162, 199);
            this.chb_masat.Name = "chb_masat";
            this.chb_masat.Size = new System.Drawing.Size(94, 17);
            this.chb_masat.TabIndex = 3;
            this.chb_masat.Text = "MASA TENİSİ";
            this.chb_masat.UseVisualStyleBackColor = true;
            this.chb_masat.CheckedChanged += new System.EventHandler(this.chb_masat_CheckedChanged);
            // 
            // chb_yuzme
            // 
            this.chb_yuzme.AutoSize = true;
            this.chb_yuzme.Location = new System.Drawing.Point(162, 176);
            this.chb_yuzme.Name = "chb_yuzme";
            this.chb_yuzme.Size = new System.Drawing.Size(64, 17);
            this.chb_yuzme.TabIndex = 4;
            this.chb_yuzme.Text = "YÜZME";
            this.chb_yuzme.UseVisualStyleBackColor = true;
            this.chb_yuzme.CheckedChanged += new System.EventHandler(this.chb_yuzme_CheckedChanged);
            // 
            // chb_hentbol
            // 
            this.chb_hentbol.AutoSize = true;
            this.chb_hentbol.Location = new System.Drawing.Point(162, 153);
            this.chb_hentbol.Name = "chb_hentbol";
            this.chb_hentbol.Size = new System.Drawing.Size(77, 17);
            this.chb_hentbol.TabIndex = 5;
            this.chb_hentbol.Text = "HENTBOL";
            this.chb_hentbol.UseVisualStyleBackColor = true;
            this.chb_hentbol.CheckedChanged += new System.EventHandler(this.chb_hentbol_CheckedChanged);
            // 
            // soru2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 305);
            this.Controls.Add(this.chb_masat);
            this.Controls.Add(this.chb_yuzme);
            this.Controls.Add(this.chb_hentbol);
            this.Controls.Add(this.chb_futbol);
            this.Controls.Add(this.chb_basket);
            this.Controls.Add(this.chb_voley);
            this.Controls.Add(this.tx_secim);
            this.Controls.Add(this.label1);
            this.Name = "soru2";
            this.Text = "SORU2";
            this.Load += new System.EventHandler(this.soru2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_secim;
        private System.Windows.Forms.CheckBox chb_voley;
        private System.Windows.Forms.CheckBox chb_basket;
        private System.Windows.Forms.CheckBox chb_futbol;
        private System.Windows.Forms.CheckBox chb_masat;
        private System.Windows.Forms.CheckBox chb_yuzme;
        private System.Windows.Forms.CheckBox chb_hentbol;
    }
}
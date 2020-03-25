namespace _2015_1_DON_1_NTP_YAZILIUYGULAMA
{
    partial class KullanıcıKontrol
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
            this.label2 = new System.Windows.Forms.Label();
            this.tx_kadi = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE :";
            // 
            // tx_kadi
            // 
            this.tx_kadi.Location = new System.Drawing.Point(108, 49);
            this.tx_kadi.Multiline = true;
            this.tx_kadi.Name = "tx_kadi";
            this.tx_kadi.Size = new System.Drawing.Size(95, 23);
            this.tx_kadi.TabIndex = 2;
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(108, 101);
            this.tx_sifre.Multiline = true;
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.Size = new System.Drawing.Size(95, 23);
            this.tx_sifre.TabIndex = 3;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(89, 154);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(79, 30);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // KullanıcıKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_kadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullanıcıKontrol";
            this.Text = "KULLANICI KONTROL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_kadi;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Button btn_giris;
    }
}


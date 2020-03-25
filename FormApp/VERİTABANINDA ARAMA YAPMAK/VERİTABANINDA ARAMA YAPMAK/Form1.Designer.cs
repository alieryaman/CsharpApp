namespace VERİTABANINDA_ARAMA_YAPMAK
{
    partial class Form1
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
            this.tx_tabloekle = new System.Windows.Forms.TextBox();
            this.btn_tekle = new System.Windows.Forms.Button();
            this.yas_ara = new System.Windows.Forms.TextBox();
            this.ad_ara = new System.Windows.Forms.TextBox();
            this.soyad_ara = new System.Windows.Forms.TextBox();
            this.tc_ara = new System.Windows.Forms.TextBox();
            this.data_listem = new System.Windows.Forms.DataGridView();
            this.ara_yas = new System.Windows.Forms.Button();
            this.ara_ad = new System.Windows.Forms.Button();
            this.ara_soyad = new System.Windows.Forms.Button();
            this.ara_tc = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_goster = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_yas = new System.Windows.Forms.TextBox();
            this.tx_soyad = new System.Windows.Forms.TextBox();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.tx_tcno = new System.Windows.Forms.TextBox();
            this.tx_guncel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_listem)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_tabloekle
            // 
            this.tx_tabloekle.Location = new System.Drawing.Point(217, 543);
            this.tx_tabloekle.Name = "tx_tabloekle";
            this.tx_tabloekle.Size = new System.Drawing.Size(135, 20);
            this.tx_tabloekle.TabIndex = 26;
            // 
            // btn_tekle
            // 
            this.btn_tekle.Location = new System.Drawing.Point(109, 536);
            this.btn_tekle.Name = "btn_tekle";
            this.btn_tekle.Size = new System.Drawing.Size(102, 33);
            this.btn_tekle.TabIndex = 23;
            this.btn_tekle.Text = "TABLO EKLE";
            this.btn_tekle.UseVisualStyleBackColor = true;
            // 
            // yas_ara
            // 
            this.yas_ara.Location = new System.Drawing.Point(292, 179);
            this.yas_ara.Name = "yas_ara";
            this.yas_ara.Size = new System.Drawing.Size(120, 20);
            this.yas_ara.TabIndex = 36;
            this.yas_ara.Text = "yaşa  göre ara";
            // 
            // ad_ara
            // 
            this.ad_ara.Location = new System.Drawing.Point(292, 153);
            this.ad_ara.Name = "ad_ara";
            this.ad_ara.Size = new System.Drawing.Size(120, 20);
            this.ad_ara.TabIndex = 34;
            this.ad_ara.Text = "ada göre ara";
            // 
            // soyad_ara
            // 
            this.soyad_ara.Location = new System.Drawing.Point(91, 179);
            this.soyad_ara.Name = "soyad_ara";
            this.soyad_ara.Size = new System.Drawing.Size(120, 20);
            this.soyad_ara.TabIndex = 35;
            this.soyad_ara.Text = "soyada göre ara";
            // 
            // tc_ara
            // 
            this.tc_ara.Location = new System.Drawing.Point(91, 153);
            this.tc_ara.Name = "tc_ara";
            this.tc_ara.Size = new System.Drawing.Size(120, 20);
            this.tc_ara.TabIndex = 33;
            this.tc_ara.Text = "Tc göre ara";
            // 
            // data_listem
            // 
            this.data_listem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_listem.Location = new System.Drawing.Point(12, 220);
            this.data_listem.Name = "data_listem";
            this.data_listem.Size = new System.Drawing.Size(512, 303);
            this.data_listem.TabIndex = 21;
            // 
            // ara_yas
            // 
            this.ara_yas.Location = new System.Drawing.Point(418, 177);
            this.ara_yas.Name = "ara_yas";
            this.ara_yas.Size = new System.Drawing.Size(44, 23);
            this.ara_yas.TabIndex = 31;
            this.ara_yas.Text = "ARA";
            this.ara_yas.UseVisualStyleBackColor = true;
            this.ara_yas.Click += new System.EventHandler(this.ara_yas_Click_1);
            // 
            // ara_ad
            // 
            this.ara_ad.Location = new System.Drawing.Point(418, 153);
            this.ara_ad.Name = "ara_ad";
            this.ara_ad.Size = new System.Drawing.Size(44, 23);
            this.ara_ad.TabIndex = 30;
            this.ara_ad.Text = "ARA";
            this.ara_ad.UseVisualStyleBackColor = true;
            this.ara_ad.Click += new System.EventHandler(this.ara_ad_Click_1);
            // 
            // ara_soyad
            // 
            this.ara_soyad.Location = new System.Drawing.Point(217, 177);
            this.ara_soyad.Name = "ara_soyad";
            this.ara_soyad.Size = new System.Drawing.Size(44, 23);
            this.ara_soyad.TabIndex = 29;
            this.ara_soyad.Text = "ARA";
            this.ara_soyad.UseVisualStyleBackColor = true;
            this.ara_soyad.Click += new System.EventHandler(this.ara_soyad_Click_1);
            // 
            // ara_tc
            // 
            this.ara_tc.Location = new System.Drawing.Point(217, 153);
            this.ara_tc.Name = "ara_tc";
            this.ara_tc.Size = new System.Drawing.Size(44, 23);
            this.ara_tc.TabIndex = 28;
            this.ara_tc.Text = "ARA";
            this.ara_tc.UseVisualStyleBackColor = true;
            this.ara_tc.Click += new System.EventHandler(this.ara_tc_Click_1);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(279, 114);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(85, 27);
            this.btn_sil.TabIndex = 32;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(345, 78);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(85, 27);
            this.btn_guncelle.TabIndex = 27;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(279, 45);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(85, 27);
            this.btn_goster.TabIndex = 25;
            this.btn_goster.Text = "GÖSTER";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click_1);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(279, 10);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(85, 27);
            this.btn_ekle.TabIndex = 24;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(45, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "ARA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(45, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "YAŞ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "SOYAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "AD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "TC NO:";
            // 
            // tx_yas
            // 
            this.tx_yas.Location = new System.Drawing.Point(94, 118);
            this.tx_yas.Name = "tx_yas";
            this.tx_yas.Size = new System.Drawing.Size(179, 20);
            this.tx_yas.TabIndex = 22;
            // 
            // tx_soyad
            // 
            this.tx_soyad.Location = new System.Drawing.Point(94, 80);
            this.tx_soyad.Name = "tx_soyad";
            this.tx_soyad.Size = new System.Drawing.Size(179, 20);
            this.tx_soyad.TabIndex = 20;
            // 
            // tx_ad
            // 
            this.tx_ad.Location = new System.Drawing.Point(94, 44);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(179, 20);
            this.tx_ad.TabIndex = 19;
            // 
            // tx_tcno
            // 
            this.tx_tcno.Location = new System.Drawing.Point(94, 9);
            this.tx_tcno.Name = "tx_tcno";
            this.tx_tcno.Size = new System.Drawing.Size(179, 20);
            this.tx_tcno.TabIndex = 18;
            // 
            // tx_guncel
            // 
            this.tx_guncel.Location = new System.Drawing.Point(436, 82);
            this.tx_guncel.Name = "tx_guncel";
            this.tx_guncel.Size = new System.Drawing.Size(88, 20);
            this.tx_guncel.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 530);
            this.Controls.Add(this.tx_guncel);
            this.Controls.Add(this.tx_tabloekle);
            this.Controls.Add(this.btn_tekle);
            this.Controls.Add(this.yas_ara);
            this.Controls.Add(this.ad_ara);
            this.Controls.Add(this.soyad_ara);
            this.Controls.Add(this.tc_ara);
            this.Controls.Add(this.data_listem);
            this.Controls.Add(this.ara_yas);
            this.Controls.Add(this.ara_ad);
            this.Controls.Add(this.ara_soyad);
            this.Controls.Add(this.ara_tc);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_goster);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_yas);
            this.Controls.Add(this.tx_soyad);
            this.Controls.Add(this.tx_ad);
            this.Controls.Add(this.tx_tcno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data_listem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_tabloekle;
        private System.Windows.Forms.Button btn_tekle;
        private System.Windows.Forms.TextBox yas_ara;
        private System.Windows.Forms.TextBox ad_ara;
        private System.Windows.Forms.TextBox soyad_ara;
        private System.Windows.Forms.TextBox tc_ara;
        private System.Windows.Forms.DataGridView data_listem;
        private System.Windows.Forms.Button ara_yas;
        private System.Windows.Forms.Button ara_ad;
        private System.Windows.Forms.Button ara_soyad;
        private System.Windows.Forms.Button ara_tc;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_goster;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_yas;
        private System.Windows.Forms.TextBox tx_soyad;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.TextBox tx_tcno;
        private System.Windows.Forms.TextBox tx_guncel;
    }
}


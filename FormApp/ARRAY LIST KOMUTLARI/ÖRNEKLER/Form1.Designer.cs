namespace ÖRNEKLER
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_azliste = new System.Windows.Forms.Button();
            this.btn_kapasite = new System.Windows.Forms.Button();
            this.btn_elemans = new System.Windows.Forms.Button();
            this.tx_ekle = new System.Windows.Forms.TextBox();
            this.tx_ara = new System.Windows.Forms.TextBox();
            this.lst_elemanlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_konum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(211, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(90, 33);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(282, 139);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(90, 33);
            this.btn_sil.TabIndex = 0;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(137, 138);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(90, 33);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(282, 218);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(90, 33);
            this.btn_listele.TabIndex = 0;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_azliste
            // 
            this.btn_azliste.Location = new System.Drawing.Point(282, 267);
            this.btn_azliste.Name = "btn_azliste";
            this.btn_azliste.Size = new System.Drawing.Size(90, 33);
            this.btn_azliste.TabIndex = 0;
            this.btn_azliste.Text = "A-Z LİSTELE";
            this.btn_azliste.UseVisualStyleBackColor = true;
            this.btn_azliste.Click += new System.EventHandler(this.btn_azliste_Click);
            // 
            // btn_kapasite
            // 
            this.btn_kapasite.Location = new System.Drawing.Point(282, 316);
            this.btn_kapasite.Name = "btn_kapasite";
            this.btn_kapasite.Size = new System.Drawing.Size(90, 33);
            this.btn_kapasite.TabIndex = 0;
            this.btn_kapasite.Text = "KAPASİTE";
            this.btn_kapasite.UseVisualStyleBackColor = true;
            this.btn_kapasite.Click += new System.EventHandler(this.btn_kapasite_Click);
            // 
            // btn_elemans
            // 
            this.btn_elemans.Location = new System.Drawing.Point(282, 365);
            this.btn_elemans.Name = "btn_elemans";
            this.btn_elemans.Size = new System.Drawing.Size(90, 33);
            this.btn_elemans.TabIndex = 0;
            this.btn_elemans.Text = "ELEMAN SAYISI";
            this.btn_elemans.UseVisualStyleBackColor = true;
            // 
            // tx_ekle
            // 
            this.tx_ekle.Location = new System.Drawing.Point(95, 19);
            this.tx_ekle.Name = "tx_ekle";
            this.tx_ekle.Size = new System.Drawing.Size(100, 20);
            this.tx_ekle.TabIndex = 1;
            // 
            // tx_ara
            // 
            this.tx_ara.Location = new System.Drawing.Point(21, 151);
            this.tx_ara.Name = "tx_ara";
            this.tx_ara.Size = new System.Drawing.Size(100, 20);
            this.tx_ara.TabIndex = 1;
            // 
            // lst_elemanlar
            // 
            this.lst_elemanlar.FormattingEnabled = true;
            this.lst_elemanlar.Location = new System.Drawing.Point(21, 195);
            this.lst_elemanlar.Name = "lst_elemanlar";
            this.lst_elemanlar.Size = new System.Drawing.Size(217, 225);
            this.lst_elemanlar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "(LİSTBOXTAN SEÇİLENİ SİLER)";
            // 
            // tx_konum
            // 
            this.tx_konum.Location = new System.Drawing.Point(95, 45);
            this.tx_konum.Name = "tx_konum";
            this.tx_konum.Size = new System.Drawing.Size(100, 20);
            this.tx_konum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "KONUMU GİR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_elemanlar);
            this.Controls.Add(this.tx_ara);
            this.Controls.Add(this.tx_konum);
            this.Controls.Add(this.tx_ekle);
            this.Controls.Add(this.btn_elemans);
            this.Controls.Add(this.btn_kapasite);
            this.Controls.Add(this.btn_azliste);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Name = "Form1";
            this.Text = "ARRAY KOMUTLARI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_azliste;
        private System.Windows.Forms.Button btn_kapasite;
        private System.Windows.Forms.Button btn_elemans;
        private System.Windows.Forms.TextBox tx_ekle;
        private System.Windows.Forms.TextBox tx_ara;
        private System.Windows.Forms.ListBox lst_elemanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_konum;
        private System.Windows.Forms.Label label2;

    }
}


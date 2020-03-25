namespace DİZİLERLE_TEK_ÇİFT_SAYI
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
            this.lst_sayilar = new System.Windows.Forms.ListBox();
            this.lst_cift = new System.Windows.Forms.ListBox();
            this.lst_tek = new System.Windows.Forms.ListBox();
            this.btn_ekleme = new System.Windows.Forms.Button();
            this.tx_toplam = new System.Windows.Forms.TextBox();
            this.tx_ciftoplam = new System.Windows.Forms.TextBox();
            this.tx_tektoplam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_sayilar
            // 
            this.lst_sayilar.FormattingEnabled = true;
            this.lst_sayilar.Location = new System.Drawing.Point(12, 21);
            this.lst_sayilar.Name = "lst_sayilar";
            this.lst_sayilar.Size = new System.Drawing.Size(99, 121);
            this.lst_sayilar.TabIndex = 0;
            // 
            // lst_cift
            // 
            this.lst_cift.FormattingEnabled = true;
            this.lst_cift.Location = new System.Drawing.Point(128, 21);
            this.lst_cift.Name = "lst_cift";
            this.lst_cift.Size = new System.Drawing.Size(99, 121);
            this.lst_cift.TabIndex = 0;
            // 
            // lst_tek
            // 
            this.lst_tek.FormattingEnabled = true;
            this.lst_tek.Location = new System.Drawing.Point(250, 21);
            this.lst_tek.Name = "lst_tek";
            this.lst_tek.Size = new System.Drawing.Size(99, 121);
            this.lst_tek.TabIndex = 0;
            // 
            // btn_ekleme
            // 
            this.btn_ekleme.Location = new System.Drawing.Point(12, 186);
            this.btn_ekleme.Name = "btn_ekleme";
            this.btn_ekleme.Size = new System.Drawing.Size(99, 48);
            this.btn_ekleme.TabIndex = 1;
            this.btn_ekleme.Text = "SAYI EKLE";
            this.btn_ekleme.UseVisualStyleBackColor = true;
            this.btn_ekleme.Click += new System.EventHandler(this.btn_ekleme_Click);
            // 
            // tx_toplam
            // 
            this.tx_toplam.Location = new System.Drawing.Point(13, 148);
            this.tx_toplam.Name = "tx_toplam";
            this.tx_toplam.Size = new System.Drawing.Size(100, 20);
            this.tx_toplam.TabIndex = 2;
            // 
            // tx_ciftoplam
            // 
            this.tx_ciftoplam.Location = new System.Drawing.Point(128, 148);
            this.tx_ciftoplam.Name = "tx_ciftoplam";
            this.tx_ciftoplam.Size = new System.Drawing.Size(100, 20);
            this.tx_ciftoplam.TabIndex = 2;
            // 
            // tx_tektoplam
            // 
            this.tx_tektoplam.Location = new System.Drawing.Point(249, 148);
            this.tx_tektoplam.Name = "tx_tektoplam";
            this.tx_tektoplam.Size = new System.Drawing.Size(100, 20);
            this.tx_tektoplam.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 251);
            this.Controls.Add(this.tx_tektoplam);
            this.Controls.Add(this.tx_ciftoplam);
            this.Controls.Add(this.tx_toplam);
            this.Controls.Add(this.btn_ekleme);
            this.Controls.Add(this.lst_tek);
            this.Controls.Add(this.lst_cift);
            this.Controls.Add(this.lst_sayilar);
            this.Name = "Form1";
            this.Text = "SAYILAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_sayilar;
        private System.Windows.Forms.ListBox lst_cift;
        private System.Windows.Forms.ListBox lst_tek;
        private System.Windows.Forms.Button btn_ekleme;
        private System.Windows.Forms.TextBox tx_toplam;
        private System.Windows.Forms.TextBox tx_ciftoplam;
        private System.Windows.Forms.TextBox tx_tektoplam;
    }
}


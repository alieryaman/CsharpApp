namespace DİZİLERLE_KARE_KÜP_ALMA
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
            this.lst_karesi = new System.Windows.Forms.ListBox();
            this.lst_kökü = new System.Windows.Forms.ListBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lst_sayilar
            // 
            this.lst_sayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_sayilar.FormattingEnabled = true;
            this.lst_sayilar.ItemHeight = 16;
            this.lst_sayilar.Location = new System.Drawing.Point(14, 22);
            this.lst_sayilar.Name = "lst_sayilar";
            this.lst_sayilar.Size = new System.Drawing.Size(59, 260);
            this.lst_sayilar.TabIndex = 0;
            // 
            // lst_karesi
            // 
            this.lst_karesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_karesi.FormattingEnabled = true;
            this.lst_karesi.ItemHeight = 16;
            this.lst_karesi.Location = new System.Drawing.Point(79, 22);
            this.lst_karesi.Name = "lst_karesi";
            this.lst_karesi.Size = new System.Drawing.Size(59, 260);
            this.lst_karesi.TabIndex = 0;
            // 
            // lst_kökü
            // 
            this.lst_kökü.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_kökü.FormattingEnabled = true;
            this.lst_kökü.ItemHeight = 16;
            this.lst_kökü.Location = new System.Drawing.Point(144, 22);
            this.lst_kökü.Name = "lst_kökü";
            this.lst_kökü.Size = new System.Drawing.Size(59, 260);
            this.lst_kökü.TabIndex = 0;
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(14, 288);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(189, 51);
            this.btn_giris.TabIndex = 1;
            this.btn_giris.Text = "SAYI GİRİŞİ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(13, 354);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(193, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.csharpkampusu.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(218, 384);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.lst_kökü);
            this.Controls.Add(this.lst_karesi);
            this.Controls.Add(this.lst_sayilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "KARE KÜP ALMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_sayilar;
        private System.Windows.Forms.ListBox lst_karesi;
        private System.Windows.Forms.ListBox lst_kökü;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


namespace ÖRNEK
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
            this.lst_kbuyuk = new System.Windows.Forms.ListBox();
            this.lst_bkucuk = new System.Windows.Forms.ListBox();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.btn_kbuyuge = new System.Windows.Forms.Button();
            this.btn_bkucuge = new System.Windows.Forms.Button();
            this.btn_kopya = new System.Windows.Forms.Button();
            this.lst_kopya = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_byk = new System.Windows.Forms.Label();
            this.lb__kucuk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_sayilar
            // 
            this.lst_sayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_sayilar.FormattingEnabled = true;
            this.lst_sayilar.ItemHeight = 25;
            this.lst_sayilar.Location = new System.Drawing.Point(12, 12);
            this.lst_sayilar.Name = "lst_sayilar";
            this.lst_sayilar.Size = new System.Drawing.Size(78, 104);
            this.lst_sayilar.TabIndex = 0;
            // 
            // lst_kbuyuk
            // 
            this.lst_kbuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_kbuyuk.FormattingEnabled = true;
            this.lst_kbuyuk.ItemHeight = 25;
            this.lst_kbuyuk.Location = new System.Drawing.Point(96, 12);
            this.lst_kbuyuk.Name = "lst_kbuyuk";
            this.lst_kbuyuk.Size = new System.Drawing.Size(78, 104);
            this.lst_kbuyuk.TabIndex = 0;
            // 
            // lst_bkucuk
            // 
            this.lst_bkucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_bkucuk.FormattingEnabled = true;
            this.lst_bkucuk.ItemHeight = 25;
            this.lst_bkucuk.Location = new System.Drawing.Point(180, 12);
            this.lst_bkucuk.Name = "lst_bkucuk";
            this.lst_bkucuk.Size = new System.Drawing.Size(78, 104);
            this.lst_bkucuk.TabIndex = 0;
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(355, 6);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(78, 28);
            this.btn_yazdir.TabIndex = 1;
            this.btn_yazdir.Text = "YAZDIR";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // btn_kbuyuge
            // 
            this.btn_kbuyuge.Location = new System.Drawing.Point(355, 40);
            this.btn_kbuyuge.Name = "btn_kbuyuge";
            this.btn_kbuyuge.Size = new System.Drawing.Size(78, 38);
            this.btn_kbuyuge.TabIndex = 1;
            this.btn_kbuyuge.Text = "KÜÇÜKTEN BÜYÜĞE";
            this.btn_kbuyuge.UseVisualStyleBackColor = true;
            this.btn_kbuyuge.Click += new System.EventHandler(this.btn_kbuyuge_Click);
            // 
            // btn_bkucuge
            // 
            this.btn_bkucuge.Location = new System.Drawing.Point(355, 83);
            this.btn_bkucuge.Name = "btn_bkucuge";
            this.btn_bkucuge.Size = new System.Drawing.Size(78, 36);
            this.btn_bkucuge.TabIndex = 1;
            this.btn_bkucuge.Text = "BÜYÜKTEN KÜÇÜĞE";
            this.btn_bkucuge.UseVisualStyleBackColor = true;
            this.btn_bkucuge.Click += new System.EventHandler(this.btn_bkucuge_Click);
            // 
            // btn_kopya
            // 
            this.btn_kopya.Location = new System.Drawing.Point(439, 40);
            this.btn_kopya.Name = "btn_kopya";
            this.btn_kopya.Size = new System.Drawing.Size(81, 38);
            this.btn_kopya.TabIndex = 2;
            this.btn_kopya.Text = "KOPYALA";
            this.btn_kopya.UseVisualStyleBackColor = true;
            this.btn_kopya.Click += new System.EventHandler(this.btn_kopya_Click);
            // 
            // lst_kopya
            // 
            this.lst_kopya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_kopya.FormattingEnabled = true;
            this.lst_kopya.ItemHeight = 25;
            this.lst_kopya.Location = new System.Drawing.Point(264, 10);
            this.lst_kopya.Name = "lst_kopya";
            this.lst_kopya.Size = new System.Drawing.Size(78, 104);
            this.lst_kopya.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "EN BÜYÜK :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(237, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "EN KÜÇÜK:";
            // 
            // lb_byk
            // 
            this.lb_byk.AutoSize = true;
            this.lb_byk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_byk.Location = new System.Drawing.Point(176, 131);
            this.lb_byk.Name = "lb_byk";
            this.lb_byk.Size = new System.Drawing.Size(20, 22);
            this.lb_byk.TabIndex = 3;
            this.lb_byk.Text = "0";
            // 
            // lb__kucuk
            // 
            this.lb__kucuk.AutoSize = true;
            this.lb__kucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb__kucuk.Location = new System.Drawing.Point(351, 131);
            this.lb__kucuk.Name = "lb__kucuk";
            this.lb__kucuk.Size = new System.Drawing.Size(20, 22);
            this.lb__kucuk.TabIndex = 3;
            this.lb__kucuk.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 160);
            this.Controls.Add(this.lb__kucuk);
            this.Controls.Add(this.lb_byk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kopya);
            this.Controls.Add(this.btn_bkucuge);
            this.Controls.Add(this.btn_kbuyuge);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.lst_kopya);
            this.Controls.Add(this.lst_bkucuk);
            this.Controls.Add(this.lst_kbuyuk);
            this.Controls.Add(this.lst_sayilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ARRAY LISTSIRALAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_sayilar;
        private System.Windows.Forms.ListBox lst_kbuyuk;
        private System.Windows.Forms.ListBox lst_bkucuk;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.Button btn_kbuyuge;
        private System.Windows.Forms.Button btn_bkucuge;
        private System.Windows.Forms.Button btn_kopya;
        private System.Windows.Forms.ListBox lst_kopya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_byk;
        private System.Windows.Forms.Label lb__kucuk;
    }
}


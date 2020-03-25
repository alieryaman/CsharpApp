namespace _2015_1_DON_1_NTP_YAZILIUYGULAMA
{
    partial class soru3
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
            this.tx_s1 = new System.Windows.Forms.TextBox();
            this.tx_s2 = new System.Windows.Forms.TextBox();
            this.rdb_topla = new System.Windows.Forms.RadioButton();
            this.rdb_cikar = new System.Windows.Forms.RadioButton();
            this.rdb_carpma = new System.Windows.Forms.RadioButton();
            this.rdb_bolme = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAYI 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SAYI 2";
            // 
            // tx_s1
            // 
            this.tx_s1.Location = new System.Drawing.Point(82, 37);
            this.tx_s1.Name = "tx_s1";
            this.tx_s1.Size = new System.Drawing.Size(195, 20);
            this.tx_s1.TabIndex = 2;
            this.tx_s1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_s1_KeyPress);
            // 
            // tx_s2
            // 
            this.tx_s2.Location = new System.Drawing.Point(82, 66);
            this.tx_s2.Name = "tx_s2";
            this.tx_s2.Size = new System.Drawing.Size(195, 20);
            this.tx_s2.TabIndex = 2;
            // 
            // rdb_topla
            // 
            this.rdb_topla.AutoSize = true;
            this.rdb_topla.Location = new System.Drawing.Point(66, 118);
            this.rdb_topla.Name = "rdb_topla";
            this.rdb_topla.Size = new System.Drawing.Size(76, 17);
            this.rdb_topla.TabIndex = 3;
            this.rdb_topla.TabStop = true;
            this.rdb_topla.Text = "TOPLAMA";
            this.rdb_topla.UseVisualStyleBackColor = true;
            this.rdb_topla.CheckedChanged += new System.EventHandler(this.rdb_topla_CheckedChanged);
            // 
            // rdb_cikar
            // 
            this.rdb_cikar.AutoSize = true;
            this.rdb_cikar.Location = new System.Drawing.Point(66, 141);
            this.rdb_cikar.Name = "rdb_cikar";
            this.rdb_cikar.Size = new System.Drawing.Size(73, 17);
            this.rdb_cikar.TabIndex = 3;
            this.rdb_cikar.TabStop = true;
            this.rdb_cikar.Text = "ÇIKARMA";
            this.rdb_cikar.UseVisualStyleBackColor = true;
            this.rdb_cikar.CheckedChanged += new System.EventHandler(this.rdb_cikar_CheckedChanged);
            // 
            // rdb_carpma
            // 
            this.rdb_carpma.AutoSize = true;
            this.rdb_carpma.Location = new System.Drawing.Point(171, 118);
            this.rdb_carpma.Name = "rdb_carpma";
            this.rdb_carpma.Size = new System.Drawing.Size(70, 17);
            this.rdb_carpma.TabIndex = 3;
            this.rdb_carpma.TabStop = true;
            this.rdb_carpma.Text = "ÇARPMA";
            this.rdb_carpma.UseVisualStyleBackColor = true;
            this.rdb_carpma.CheckedChanged += new System.EventHandler(this.rdb_carpma_CheckedChanged);
            // 
            // rdb_bolme
            // 
            this.rdb_bolme.AutoSize = true;
            this.rdb_bolme.Location = new System.Drawing.Point(171, 141);
            this.rdb_bolme.Name = "rdb_bolme";
            this.rdb_bolme.Size = new System.Drawing.Size(62, 17);
            this.rdb_bolme.TabIndex = 3;
            this.rdb_bolme.TabStop = true;
            this.rdb_bolme.Text = "BÖLME";
            this.rdb_bolme.UseVisualStyleBackColor = true;
            this.rdb_bolme.CheckedChanged += new System.EventHandler(this.rdb_bolme_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SONUÇ :";
            // 
            // lb_sonuc
            // 
            this.lb_sonuc.AutoSize = true;
            this.lb_sonuc.Location = new System.Drawing.Point(117, 214);
            this.lb_sonuc.Name = "lb_sonuc";
            this.lb_sonuc.Size = new System.Drawing.Size(13, 13);
            this.lb_sonuc.TabIndex = 4;
            this.lb_sonuc.Text = "0";
            // 
            // soru3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 312);
            this.Controls.Add(this.lb_sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdb_bolme);
            this.Controls.Add(this.rdb_carpma);
            this.Controls.Add(this.rdb_cikar);
            this.Controls.Add(this.rdb_topla);
            this.Controls.Add(this.tx_s2);
            this.Controls.Add(this.tx_s1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "soru3";
            this.Text = "SORU3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_s1;
        private System.Windows.Forms.TextBox tx_s2;
        private System.Windows.Forms.RadioButton rdb_topla;
        private System.Windows.Forms.RadioButton rdb_cikar;
        private System.Windows.Forms.RadioButton rdb_carpma;
        private System.Windows.Forms.RadioButton rdb_bolme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_sonuc;
    }
}
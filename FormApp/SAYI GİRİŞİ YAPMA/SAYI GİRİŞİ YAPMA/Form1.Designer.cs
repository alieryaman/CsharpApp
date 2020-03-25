namespace SAYI_GİRİŞİ_YAPMA
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
            this.txt_gsayi = new System.Windows.Forms.TextBox();
            this.lbx_sayilar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_gsayi
            // 
            this.txt_gsayi.Location = new System.Drawing.Point(21, 24);
            this.txt_gsayi.Name = "txt_gsayi";
            this.txt_gsayi.Size = new System.Drawing.Size(124, 20);
            this.txt_gsayi.TabIndex = 0;
            this.txt_gsayi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_gsayi_KeyDown);
            // 
            // lbx_sayilar
            // 
            this.lbx_sayilar.FormattingEnabled = true;
            this.lbx_sayilar.Location = new System.Drawing.Point(21, 64);
            this.lbx_sayilar.Name = "lbx_sayilar";
            this.lbx_sayilar.Size = new System.Drawing.Size(124, 147);
            this.lbx_sayilar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SONUÇ";
            // 
            // lb_sonuc
            // 
            this.lb_sonuc.AutoSize = true;
            this.lb_sonuc.Location = new System.Drawing.Point(77, 243);
            this.lb_sonuc.Name = "lb_sonuc";
            this.lb_sonuc.Size = new System.Drawing.Size(13, 13);
            this.lb_sonuc.TabIndex = 3;
            this.lb_sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(193, 289);
            this.Controls.Add(this.lb_sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_sayilar);
            this.Controls.Add(this.txt_gsayi);
            this.Name = "Form1";
            this.Text = "SAYI GİRİŞİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_gsayi;
        private System.Windows.Forms.ListBox lbx_sayilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_sonuc;
    }
}


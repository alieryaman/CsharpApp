namespace UYGULAMA_6
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
            this.btn_giris = new System.Windows.Forms.Button();
            this.lst_ters = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst_sayilar
            // 
            this.lst_sayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_sayilar.FormattingEnabled = true;
            this.lst_sayilar.ItemHeight = 16;
            this.lst_sayilar.Location = new System.Drawing.Point(10, 12);
            this.lst_sayilar.Name = "lst_sayilar";
            this.lst_sayilar.Size = new System.Drawing.Size(100, 164);
            this.lst_sayilar.TabIndex = 0;
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(10, 197);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(124, 50);
            this.btn_giris.TabIndex = 1;
            this.btn_giris.Text = "SAYI GİRİŞİ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // lst_ters
            // 
            this.lst_ters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_ters.FormattingEnabled = true;
            this.lst_ters.ItemHeight = 16;
            this.lst_ters.Location = new System.Drawing.Point(140, 12);
            this.lst_ters.Name = "lst_ters";
            this.lst_ters.Size = new System.Drawing.Size(100, 164);
            this.lst_ters.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 257);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.lst_ters);
            this.Controls.Add(this.lst_sayilar);
            this.Name = "Form1";
            this.Text = "TERSTEN SAYILAR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_sayilar;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.ListBox lst_ters;
    }
}


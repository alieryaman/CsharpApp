namespace İKİ_BOYUTLU_DİZİLER_ÖRNEK
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
            this.tx_sayilar = new System.Windows.Forms.TextBox();
            this.btn_ata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_sayilar
            // 
            this.tx_sayilar.Enabled = false;
            this.tx_sayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_sayilar.Location = new System.Drawing.Point(25, 89);
            this.tx_sayilar.Multiline = true;
            this.tx_sayilar.Name = "tx_sayilar";
            this.tx_sayilar.Size = new System.Drawing.Size(111, 108);
            this.tx_sayilar.TabIndex = 0;
            // 
            // btn_ata
            // 
            this.btn_ata.Location = new System.Drawing.Point(25, 37);
            this.btn_ata.Name = "btn_ata";
            this.btn_ata.Size = new System.Drawing.Size(111, 46);
            this.btn_ata.TabIndex = 1;
            this.btn_ata.Text = "SAYI ATA";
            this.btn_ata.UseVisualStyleBackColor = true;
            this.btn_ata.Click += new System.EventHandler(this.btn_ata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 273);
            this.Controls.Add(this.btn_ata);
            this.Controls.Add(this.tx_sayilar);
            this.Name = "Form1";
            this.Text = "DİZİ İŞLEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_sayilar;
        private System.Windows.Forms.Button btn_ata;
    }
}


namespace UYGULAMA
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
            this.label1 = new System.Windows.Forms.Label();
            this.tx_fıyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_ındırım = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_tutar = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN FİYATI :";
            // 
            // tx_fıyat
            // 
            this.tx_fıyat.Location = new System.Drawing.Point(148, 23);
            this.tx_fıyat.Name = "tx_fıyat";
            this.tx_fıyat.Size = new System.Drawing.Size(116, 21);
            this.tx_fıyat.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "İNİDİRİM ORANI :";
            // 
            // tx_ındırım
            // 
            this.tx_ındırım.Location = new System.Drawing.Point(148, 72);
            this.tx_ındırım.Name = "tx_ındırım";
            this.tx_ındırım.Size = new System.Drawing.Size(116, 21);
            this.tx_ındırım.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(87, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "TUTAR :";
            // 
            // tx_tutar
            // 
            this.tx_tutar.Enabled = false;
            this.tx_tutar.Location = new System.Drawing.Point(148, 114);
            this.tx_tutar.Name = "tx_tutar";
            this.tx_tutar.Size = new System.Drawing.Size(116, 21);
            this.tx_tutar.TabIndex = 2;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.BackColor = System.Drawing.SystemColors.Window;
            this.btn_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Location = new System.Drawing.Point(73, 157);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(147, 66);
            this.btn_hesapla.TabIndex = 3;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = false;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.MintCream;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(73, 229);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(147, 63);
            this.btn_temizle.TabIndex = 4;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(306, 314);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.tx_tutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_ındırım);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_fıyat);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "İNDİRİM HESAPLAMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_fıyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_ındırım;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_tutar;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_temizle;
    }
}


namespace UYGULAMA1
{
    partial class yeniform
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
            this.tx_sayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_yenifrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_sayi
            // 
            this.tx_sayi.Location = new System.Drawing.Point(106, 27);
            this.tx_sayi.Name = "tx_sayi";
            this.tx_sayi.Size = new System.Drawing.Size(100, 20);
            this.tx_sayi.TabIndex = 0;
            this.tx_sayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_sayi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAYIYI GİRİNİZ;";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "TEK  Mİ ÇİFT Mİ ?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_yenifrom
            // 
            this.btn_yenifrom.Location = new System.Drawing.Point(168, 153);
            this.btn_yenifrom.Name = "btn_yenifrom";
            this.btn_yenifrom.Size = new System.Drawing.Size(95, 54);
            this.btn_yenifrom.TabIndex = 3;
            this.btn_yenifrom.Text = "YENİ FORM --->";
            this.btn_yenifrom.UseVisualStyleBackColor = true;
            this.btn_yenifrom.Click += new System.EventHandler(this.btn_yenifrom_Click);
            // 
            // yeniform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 219);
            this.Controls.Add(this.btn_yenifrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_sayi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "yeniform";
            this.Text = "ÇİFT TEK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_sayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_yenifrom;
    }
}
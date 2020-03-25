namespace UYGULAMA1
{
    partial class giris2
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
            this.tx_sayi1 = new System.Windows.Forms.TextBox();
            this.tx_sayi2 = new System.Windows.Forms.TextBox();
            this.lb_buyuk = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_sayi1
            // 
            this.tx_sayi1.Location = new System.Drawing.Point(21, 22);
            this.tx_sayi1.Name = "tx_sayi1";
            this.tx_sayi1.Size = new System.Drawing.Size(100, 20);
            this.tx_sayi1.TabIndex = 0;
            // 
            // tx_sayi2
            // 
            this.tx_sayi2.Location = new System.Drawing.Point(21, 48);
            this.tx_sayi2.Name = "tx_sayi2";
            this.tx_sayi2.Size = new System.Drawing.Size(100, 20);
            this.tx_sayi2.TabIndex = 1;
            // 
            // lb_buyuk
            // 
            this.lb_buyuk.AutoSize = true;
            this.lb_buyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_buyuk.Location = new System.Drawing.Point(55, 139);
            this.lb_buyuk.Name = "lb_buyuk";
            this.lb_buyuk.Size = new System.Drawing.Size(29, 31);
            this.lb_buyuk.TabIndex = 2;
            this.lb_buyuk.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "SIRALA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "YENİ FORM -->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // giris2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_buyuk);
            this.Controls.Add(this.tx_sayi2);
            this.Controls.Add(this.tx_sayi1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "giris2";
            this.Text = "giris2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_sayi1;
        private System.Windows.Forms.TextBox tx_sayi2;
        private System.Windows.Forms.Label lb_buyuk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
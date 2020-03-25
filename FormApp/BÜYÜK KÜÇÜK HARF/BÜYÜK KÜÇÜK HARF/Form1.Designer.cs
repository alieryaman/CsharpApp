namespace BÜYÜK_KÜÇÜK_HARF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tx_mesaj = new System.Windows.Forms.TextBox();
            this.rdb_buyuk = new System.Windows.Forms.RadioButton();
            this.rdb_kucuk = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "MESAJ :";
            // 
            // tx_mesaj
            // 
            this.tx_mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_mesaj.Location = new System.Drawing.Point(104, 21);
            this.tx_mesaj.Multiline = true;
            this.tx_mesaj.Name = "tx_mesaj";
            this.tx_mesaj.Size = new System.Drawing.Size(223, 97);
            this.tx_mesaj.TabIndex = 1;
            // 
            // rdb_buyuk
            // 
            this.rdb_buyuk.AutoSize = true;
            this.rdb_buyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_buyuk.Location = new System.Drawing.Point(16, 142);
            this.rdb_buyuk.Name = "rdb_buyuk";
            this.rdb_buyuk.Size = new System.Drawing.Size(114, 21);
            this.rdb_buyuk.TabIndex = 2;
            this.rdb_buyuk.TabStop = true;
            this.rdb_buyuk.Text = "BÜYÜK HARF";
            this.rdb_buyuk.UseVisualStyleBackColor = true;
            this.rdb_buyuk.CheckedChanged += new System.EventHandler(this.rdb_buyuk_CheckedChanged);
            // 
            // rdb_kucuk
            // 
            this.rdb_kucuk.AutoSize = true;
            this.rdb_kucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_kucuk.Location = new System.Drawing.Point(16, 179);
            this.rdb_kucuk.Name = "rdb_kucuk";
            this.rdb_kucuk.Size = new System.Drawing.Size(114, 21);
            this.rdb_kucuk.TabIndex = 3;
            this.rdb_kucuk.TabStop = true;
            this.rdb_kucuk.Text = "KÜÇÜK HARF";
            this.rdb_kucuk.UseVisualStyleBackColor = true;
            this.rdb_kucuk.CheckedChanged += new System.EventHandler(this.rdb_kucuk_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(338, 221);
            this.Controls.Add(this.rdb_kucuk);
            this.Controls.Add(this.rdb_buyuk);
            this.Controls.Add(this.tx_mesaj);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MESAJ ŞEKİLLENDİRME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_mesaj;
        private System.Windows.Forms.RadioButton rdb_buyuk;
        private System.Windows.Forms.RadioButton rdb_kucuk;
    }
}


namespace _11._03._2015_ÖDEV
{
    partial class harfdonusumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(harfdonusumu));
            this.tx_mesaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_buyuk = new System.Windows.Forms.RadioButton();
            this.rdb_kucuk = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_mesaj
            // 
            this.tx_mesaj.Location = new System.Drawing.Point(128, 12);
            this.tx_mesaj.Multiline = true;
            this.tx_mesaj.Name = "tx_mesaj";
            this.tx_mesaj.Size = new System.Drawing.Size(211, 155);
            this.tx_mesaj.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "MESAJ =";
            // 
            // rdb_buyuk
            // 
            this.rdb_buyuk.AutoSize = true;
            this.rdb_buyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_buyuk.Location = new System.Drawing.Point(17, 182);
            this.rdb_buyuk.Name = "rdb_buyuk";
            this.rdb_buyuk.Size = new System.Drawing.Size(208, 35);
            this.rdb_buyuk.TabIndex = 2;
            this.rdb_buyuk.TabStop = true;
            this.rdb_buyuk.Text = "BÜYÜK HARF";
            this.rdb_buyuk.UseVisualStyleBackColor = true;
            this.rdb_buyuk.CheckedChanged += new System.EventHandler(this.rdb_buyuk_CheckedChanged);
            // 
            // rdb_kucuk
            // 
            this.rdb_kucuk.AutoSize = true;
            this.rdb_kucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_kucuk.Location = new System.Drawing.Point(15, 223);
            this.rdb_kucuk.Name = "rdb_kucuk";
            this.rdb_kucuk.Size = new System.Drawing.Size(210, 35);
            this.rdb_kucuk.TabIndex = 2;
            this.rdb_kucuk.TabStop = true;
            this.rdb_kucuk.Text = "KÜÇÜK HARF";
            this.rdb_kucuk.UseVisualStyleBackColor = true;
            this.rdb_kucuk.CheckedChanged += new System.EventHandler(this.rdb_kucuk_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 81);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // harfdonusumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(382, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdb_kucuk);
            this.Controls.Add(this.rdb_buyuk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_mesaj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "harfdonusumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÜYÜK-KÜÇÜK HARF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_mesaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_buyuk;
        private System.Windows.Forms.RadioButton rdb_kucuk;
        private System.Windows.Forms.Button button1;
    }
}
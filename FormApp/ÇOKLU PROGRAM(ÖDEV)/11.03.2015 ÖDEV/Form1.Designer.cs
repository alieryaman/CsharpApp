namespace _11._03._2015_ÖDEV
{
    partial class form_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_giris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.tx_kadi = new System.Windows.Forms.TextBox();
            this.chb_yardim = new System.Windows.Forms.CheckBox();
            this.lb_bilgiler = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tx_sifre
            // 
            this.tx_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_sifre.Location = new System.Drawing.Point(94, 120);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(161, 38);
            this.tx_sifre.TabIndex = 1;
            // 
            // tx_kadi
            // 
            this.tx_kadi.BackColor = System.Drawing.Color.White;
            this.tx_kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_kadi.Location = new System.Drawing.Point(94, 64);
            this.tx_kadi.Name = "tx_kadi";
            this.tx_kadi.Size = new System.Drawing.Size(161, 38);
            this.tx_kadi.TabIndex = 1;
            // 
            // chb_yardim
            // 
            this.chb_yardim.AutoSize = true;
            this.chb_yardim.BackColor = System.Drawing.Color.Transparent;
            this.chb_yardim.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_yardim.ForeColor = System.Drawing.Color.Black;
            this.chb_yardim.Location = new System.Drawing.Point(36, 189);
            this.chb_yardim.Name = "chb_yardim";
            this.chb_yardim.Size = new System.Drawing.Size(278, 28);
            this.chb_yardim.TabIndex = 2;
            this.chb_yardim.Text = "YARDIM ALMAK İÇİN İŞARETLE";
            this.chb_yardim.UseVisualStyleBackColor = false;
            this.chb_yardim.CheckedChanged += new System.EventHandler(this.chb_yardim_CheckedChanged);
            // 
            // lb_bilgiler
            // 
            this.lb_bilgiler.AutoSize = true;
            this.lb_bilgiler.BackColor = System.Drawing.Color.Transparent;
            this.lb_bilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_bilgiler.ForeColor = System.Drawing.Color.SeaShell;
            this.lb_bilgiler.Location = new System.Drawing.Point(33, 223);
            this.lb_bilgiler.Name = "lb_bilgiler";
            this.lb_bilgiler.Size = new System.Drawing.Size(174, 51);
            this.lb_bilgiler.TabIndex = 3;
            this.lb_bilgiler.Text = "KULLANICI ADI : admin\r\n\r\nŞİFRE: 12345\r\n";
            this.lb_bilgiler.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(261, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 70);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // form_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_bilgiler);
            this.Controls.Add(this.chb_yardim);
            this.Controls.Add(this.tx_kadi);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI GİRİŞİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.TextBox tx_kadi;
        private System.Windows.Forms.CheckBox chb_yardim;
        private System.Windows.Forms.Label lb_bilgiler;
        private System.Windows.Forms.Button button1;
    }
}


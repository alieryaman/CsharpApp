namespace TRAFİK_LAMBASI
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pc_yesil = new System.Windows.Forms.PictureBox();
            this.pc_sari = new System.Windows.Forms.PictureBox();
            this.pc_kirmizi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_durum = new System.Windows.Forms.Label();
            this.lb_saniye = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pc_yesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_sari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_kirmizi)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(148, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 63);
            this.button4.TabIndex = 1;
            this.button4.Text = "BAŞLAT/DEVAM";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(148, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 63);
            this.button5.TabIndex = 1;
            this.button5.Text = "DURDUR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pc_yesil
            // 
            this.pc_yesil.Image = global::TRAFİK_LAMBASI.Properties.Resources.yesil_fw;
            this.pc_yesil.Location = new System.Drawing.Point(12, 12);
            this.pc_yesil.Name = "pc_yesil";
            this.pc_yesil.Size = new System.Drawing.Size(114, 422);
            this.pc_yesil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_yesil.TabIndex = 2;
            this.pc_yesil.TabStop = false;
            this.pc_yesil.Visible = false;
            // 
            // pc_sari
            // 
            this.pc_sari.Image = global::TRAFİK_LAMBASI.Properties.Resources.sarı_fw;
            this.pc_sari.Location = new System.Drawing.Point(12, 12);
            this.pc_sari.Name = "pc_sari";
            this.pc_sari.Size = new System.Drawing.Size(114, 422);
            this.pc_sari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_sari.TabIndex = 2;
            this.pc_sari.TabStop = false;
            this.pc_sari.Visible = false;
            // 
            // pc_kirmizi
            // 
            this.pc_kirmizi.Image = global::TRAFİK_LAMBASI.Properties.Resources.kırmızı_fw;
            this.pc_kirmizi.Location = new System.Drawing.Point(12, 12);
            this.pc_kirmizi.Name = "pc_kirmizi";
            this.pc_kirmizi.Size = new System.Drawing.Size(114, 422);
            this.pc_kirmizi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_kirmizi.TabIndex = 2;
            this.pc_kirmizi.TabStop = false;
            this.pc_kirmizi.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "DURUM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 43);
            this.label2.TabIndex = 3;
            // 
            // lb_durum
            // 
            this.lb_durum.AutoSize = true;
            this.lb_durum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(162)));
            this.lb_durum.Location = new System.Drawing.Point(141, 106);
            this.lb_durum.Name = "lb_durum";
            this.lb_durum.Size = new System.Drawing.Size(29, 40);
            this.lb_durum.TabIndex = 3;
            this.lb_durum.Text = "-";
            // 
            // lb_saniye
            // 
            this.lb_saniye.AutoSize = true;
            this.lb_saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_saniye.Location = new System.Drawing.Point(189, 337);
            this.lb_saniye.Name = "lb_saniye";
            this.lb_saniye.Size = new System.Drawing.Size(70, 76);
            this.lb_saniye.TabIndex = 4;
            this.lb_saniye.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(336, 439);
            this.Controls.Add(this.lb_saniye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_durum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pc_kirmizi);
            this.Controls.Add(this.pc_sari);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pc_yesil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TRAFİK LAMBASI";
            this.TransparencyKey = System.Drawing.Color.Chocolate;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_yesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_sari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_kirmizi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pc_kirmizi;
        private System.Windows.Forms.PictureBox pc_sari;
        private System.Windows.Forms.PictureBox pc_yesil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_durum;
        private System.Windows.Forms.Label lb_saniye;
    }
}


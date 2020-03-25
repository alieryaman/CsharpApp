namespace C_Sharp_Puzzle_Game
{
    partial class MAinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAinForm));
            this.tumresim = new System.Windows.Forms.PictureBox();
            this.btnCik = new System.Windows.Forms.Button();
            this.btnDuraklat = new System.Windows.Forms.Button();
            this.btnBaşlat = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tumresim)).BeginInit();
            this.SuspendLayout();
            // 
            // tumresim
            // 
            this.tumresim.Location = new System.Drawing.Point(550, 50);
            this.tumresim.Name = "tumresim";
            this.tumresim.Size = new System.Drawing.Size(375, 375);
            this.tumresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tumresim.TabIndex = 58;
            this.tumresim.TabStop = false;
            // 
            // btnCik
            // 
            this.btnCik.Location = new System.Drawing.Point(439, 122);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(105, 29);
            this.btnCik.TabIndex = 71;
            this.btnCik.Text = "Çık";
            this.btnCik.UseVisualStyleBackColor = true;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // btnDuraklat
            // 
            this.btnDuraklat.Location = new System.Drawing.Point(439, 88);
            this.btnDuraklat.Name = "btnDuraklat";
            this.btnDuraklat.Size = new System.Drawing.Size(105, 28);
            this.btnDuraklat.TabIndex = 70;
            this.btnDuraklat.Text = "Duraklat/Devam";
            this.btnDuraklat.UseVisualStyleBackColor = true;
            this.btnDuraklat.Click += new System.EventHandler(this.btnDuraklat_Click);
            // 
            // btnBaşlat
            // 
            this.btnBaşlat.Location = new System.Drawing.Point(439, 49);
            this.btnBaşlat.Name = "btnBaşlat";
            this.btnBaşlat.Size = new System.Drawing.Size(105, 33);
            this.btnBaşlat.TabIndex = 69;
            this.btnBaşlat.Text = "Yeniden Başlat";
            this.btnBaşlat.UseVisualStyleBackColor = true;
            this.btnBaşlat.Click += new System.EventHandler(this.btnBaşlat_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(504, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = ":";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.Location = new System.Drawing.Point(485, 21);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(24, 16);
            this.lblDakika.TabIndex = 74;
            this.lblDakika.Text = "00";
            this.lblDakika.Click += new System.EventHandler(this.lblDakika_Click);
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(512, 21);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(24, 16);
            this.lblSaniye.TabIndex = 73;
            this.lblSaniye.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(436, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "SÜRE";
            // 
            // MAinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnDuraklat);
            this.Controls.Add(this.btnBaşlat);
            this.Controls.Add(this.tumresim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MAinForm";
            this.Text = "Puzzle Oyunu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tumresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tumresim;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.Button btnDuraklat;
        private System.Windows.Forms.Button btnBaşlat;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label label1;
    }
}
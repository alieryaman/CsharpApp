namespace CSHARP_SORU_CEVAP_OYUNU
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
            this.soru = new System.Windows.Forms.RichTextBox();
            this.a_sikki = new System.Windows.Forms.Button();
            this.b_sikki = new System.Windows.Forms.Button();
            this.c_sikki = new System.Windows.Forms.Button();
            this.d_sikki = new System.Windows.Forms.Button();
            this.ileri = new System.Windows.Forms.Button();
            this.dogru_cevap = new System.Windows.Forms.Label();
            this.puan = new System.Windows.Forms.Label();
            this.yanlispuan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_soruno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_kalansure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_sure = new System.Windows.Forms.Label();
            this.süre = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // soru
            // 
            this.soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soru.Location = new System.Drawing.Point(155, 10);
            this.soru.Name = "soru";
            this.soru.Size = new System.Drawing.Size(429, 95);
            this.soru.TabIndex = 0;
            this.soru.Text = "";
            // 
            // a_sikki
            // 
            this.a_sikki.BackColor = System.Drawing.Color.Red;
            this.a_sikki.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.a_sikki.FlatAppearance.BorderSize = 3;
            this.a_sikki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_sikki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.a_sikki.ForeColor = System.Drawing.Color.White;
            this.a_sikki.Location = new System.Drawing.Point(155, 130);
            this.a_sikki.Name = "a_sikki";
            this.a_sikki.Size = new System.Drawing.Size(176, 66);
            this.a_sikki.TabIndex = 1;
            this.a_sikki.UseVisualStyleBackColor = false;
            this.a_sikki.Click += new System.EventHandler(this.a_sikki_Click);
            // 
            // b_sikki
            // 
            this.b_sikki.BackColor = System.Drawing.Color.Red;
            this.b_sikki.FlatAppearance.BorderSize = 3;
            this.b_sikki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sikki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_sikki.ForeColor = System.Drawing.Color.White;
            this.b_sikki.Location = new System.Drawing.Point(408, 130);
            this.b_sikki.Name = "b_sikki";
            this.b_sikki.Size = new System.Drawing.Size(176, 66);
            this.b_sikki.TabIndex = 1;
            this.b_sikki.UseVisualStyleBackColor = false;
            this.b_sikki.Click += new System.EventHandler(this.b_sikki_Click);
            // 
            // c_sikki
            // 
            this.c_sikki.BackColor = System.Drawing.Color.Red;
            this.c_sikki.FlatAppearance.BorderSize = 3;
            this.c_sikki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_sikki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.c_sikki.ForeColor = System.Drawing.Color.White;
            this.c_sikki.Location = new System.Drawing.Point(155, 217);
            this.c_sikki.Name = "c_sikki";
            this.c_sikki.Size = new System.Drawing.Size(176, 66);
            this.c_sikki.TabIndex = 1;
            this.c_sikki.UseVisualStyleBackColor = false;
            this.c_sikki.Click += new System.EventHandler(this.c_sikki_Click);
            // 
            // d_sikki
            // 
            this.d_sikki.BackColor = System.Drawing.Color.Red;
            this.d_sikki.FlatAppearance.BorderSize = 3;
            this.d_sikki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_sikki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.d_sikki.ForeColor = System.Drawing.Color.White;
            this.d_sikki.Location = new System.Drawing.Point(408, 217);
            this.d_sikki.Name = "d_sikki";
            this.d_sikki.Size = new System.Drawing.Size(176, 66);
            this.d_sikki.TabIndex = 1;
            this.d_sikki.UseVisualStyleBackColor = false;
            this.d_sikki.Click += new System.EventHandler(this.d_sikki_Click);
            // 
            // ileri
            // 
            this.ileri.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ileri.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ileri.FlatAppearance.BorderSize = 3;
            this.ileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ileri.ForeColor = System.Drawing.Color.White;
            this.ileri.Location = new System.Drawing.Point(4, 88);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(139, 52);
            this.ileri.TabIndex = 2;
            this.ileri.Text = "İLERİ";
            this.ileri.UseVisualStyleBackColor = false;
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            // 
            // dogru_cevap
            // 
            this.dogru_cevap.AutoSize = true;
            this.dogru_cevap.ForeColor = System.Drawing.Color.White;
            this.dogru_cevap.Location = new System.Drawing.Point(360, 198);
            this.dogru_cevap.Name = "dogru_cevap";
            this.dogru_cevap.Size = new System.Drawing.Size(13, 13);
            this.dogru_cevap.TabIndex = 3;
            this.dogru_cevap.Text = "0";
            this.dogru_cevap.Visible = false;
            // 
            // puan
            // 
            this.puan.AutoSize = true;
            this.puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan.Location = new System.Drawing.Point(116, 33);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(29, 31);
            this.puan.TabIndex = 4;
            this.puan.Text = "0";
            // 
            // yanlispuan
            // 
            this.yanlispuan.AutoSize = true;
            this.yanlispuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yanlispuan.Location = new System.Drawing.Point(116, 76);
            this.yanlispuan.Name = "yanlispuan";
            this.yanlispuan.Size = new System.Drawing.Size(29, 31);
            this.yanlispuan.TabIndex = 5;
            this.yanlispuan.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "DOĞRU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "YANLIŞ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.yanlispuan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.puan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(603, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SKOR TABLOSU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "SORU NO:";
            // 
            // lb_soruno
            // 
            this.lb_soruno.AutoSize = true;
            this.lb_soruno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_soruno.Location = new System.Drawing.Point(54, 45);
            this.lb_soruno.Name = "lb_soruno";
            this.lb_soruno.Size = new System.Drawing.Size(23, 25);
            this.lb_soruno.TabIndex = 9;
            this.lb_soruno.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(607, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "KULLANILAN SÜRE \r\n        TOPLAMI";
            // 
            // lb_kalansure
            // 
            this.lb_kalansure.AutoSize = true;
            this.lb_kalansure.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_kalansure.Location = new System.Drawing.Point(683, 237);
            this.lb_kalansure.Name = "lb_kalansure";
            this.lb_kalansure.Size = new System.Drawing.Size(42, 46);
            this.lb_kalansure.TabIndex = 11;
            this.lb_kalansure.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "KALAN SÜRE";
            // 
            // lb_sure
            // 
            this.lb_sure.AutoSize = true;
            this.lb_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sure.Location = new System.Drawing.Point(32, 198);
            this.lb_sure.Name = "lb_sure";
            this.lb_sure.Size = new System.Drawing.Size(64, 46);
            this.lb_sure.TabIndex = 13;
            this.lb_sure.Text = "10";
            // 
            // süre
            // 
            this.süre.Tick += new System.EventHandler(this.süre_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(799, 311);
            this.Controls.Add(this.lb_sure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_kalansure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_soruno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dogru_cevap);
            this.Controls.Add(this.ileri);
            this.Controls.Add(this.d_sikki);
            this.Controls.Add(this.b_sikki);
            this.Controls.Add(this.c_sikki);
            this.Controls.Add(this.a_sikki);
            this.Controls.Add(this.soru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# BİLGİ YARIŞMASI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox soru;
        private System.Windows.Forms.Button a_sikki;
        private System.Windows.Forms.Button b_sikki;
        private System.Windows.Forms.Button c_sikki;
        private System.Windows.Forms.Button d_sikki;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Label dogru_cevap;
        private System.Windows.Forms.Label puan;
        private System.Windows.Forms.Label yanlispuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_soruno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_kalansure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_sure;
        private System.Windows.Forms.Timer süre;
    }
}


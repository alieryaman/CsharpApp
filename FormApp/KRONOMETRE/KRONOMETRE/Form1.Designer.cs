namespace KRONOMETRE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_saat = new System.Windows.Forms.Label();
            this.lb_dakika = new System.Windows.Forms.Label();
            this.lb_Saniye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kronometre = new System.Windows.Forms.Timer(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_zaman_al = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_salise = new System.Windows.Forms.Label();
            this.BAŞLAT = new System.Windows.Forms.Button();
            this.btn_dur = new System.Windows.Forms.Button();
            this.btn_sifir = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lb_saat
            // 
            this.lb_saat.AutoSize = true;
            this.lb_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_saat.Location = new System.Drawing.Point(21, 35);
            this.lb_saat.Name = "lb_saat";
            this.lb_saat.Size = new System.Drawing.Size(34, 25);
            this.lb_saat.TabIndex = 0;
            this.lb_saat.Text = "00";
            // 
            // lb_dakika
            // 
            this.lb_dakika.AutoSize = true;
            this.lb_dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_dakika.Location = new System.Drawing.Point(76, 35);
            this.lb_dakika.Name = "lb_dakika";
            this.lb_dakika.Size = new System.Drawing.Size(34, 25);
            this.lb_dakika.TabIndex = 0;
            this.lb_dakika.Text = "00";
            // 
            // lb_Saniye
            // 
            this.lb_Saniye.AutoSize = true;
            this.lb_Saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_Saniye.Location = new System.Drawing.Point(134, 35);
            this.lb_Saniye.Name = "lb_Saniye";
            this.lb_Saniye.Size = new System.Drawing.Size(34, 25);
            this.lb_Saniye.TabIndex = 0;
            this.lb_Saniye.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(116, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // kronometre
            // 
            this.kronometre.Tick += new System.EventHandler(this.kronometre_Tick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(592, 280);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(10, 20);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(228, 55);
            // 
            // btn_zaman_al
            // 
            this.btn_zaman_al.BackColor = System.Drawing.Color.Green;
            this.btn_zaman_al.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_zaman_al.FlatAppearance.BorderSize = 3;
            this.btn_zaman_al.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_zaman_al.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_zaman_al.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zaman_al.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_zaman_al.ForeColor = System.Drawing.Color.White;
            this.btn_zaman_al.Location = new System.Drawing.Point(251, 20);
            this.btn_zaman_al.Name = "btn_zaman_al";
            this.btn_zaman_al.Size = new System.Drawing.Size(151, 61);
            this.btn_zaman_al.TabIndex = 3;
            this.btn_zaman_al.Text = "SÜREYİ AL ";
            this.btn_zaman_al.UseVisualStyleBackColor = false;
            this.btn_zaman_al.Click += new System.EventHandler(this.btn_zaman_al_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(408, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 204);
            this.listBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(170, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // lb_salise
            // 
            this.lb_salise.AutoSize = true;
            this.lb_salise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_salise.Location = new System.Drawing.Point(193, 35);
            this.lb_salise.Name = "lb_salise";
            this.lb_salise.Size = new System.Drawing.Size(34, 25);
            this.lb_salise.TabIndex = 0;
            this.lb_salise.Text = "00";
            // 
            // BAŞLAT
            // 
            this.BAŞLAT.BackColor = System.Drawing.Color.Crimson;
            this.BAŞLAT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BAŞLAT.FlatAppearance.BorderSize = 3;
            this.BAŞLAT.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BAŞLAT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BAŞLAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BAŞLAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAŞLAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BAŞLAT.ForeColor = System.Drawing.Color.White;
            this.BAŞLAT.Location = new System.Drawing.Point(10, 122);
            this.BAŞLAT.Name = "BAŞLAT";
            this.BAŞLAT.Size = new System.Drawing.Size(151, 61);
            this.BAŞLAT.TabIndex = 5;
            this.BAŞLAT.Text = "BAŞLAT";
            this.BAŞLAT.UseVisualStyleBackColor = false;
            this.BAŞLAT.Click += new System.EventHandler(this.BAŞLAT_Click);
            // 
            // btn_dur
            // 
            this.btn_dur.BackColor = System.Drawing.Color.Crimson;
            this.btn_dur.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dur.FlatAppearance.BorderSize = 3;
            this.btn_dur.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_dur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_dur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_dur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dur.ForeColor = System.Drawing.Color.White;
            this.btn_dur.Location = new System.Drawing.Point(198, 122);
            this.btn_dur.Name = "btn_dur";
            this.btn_dur.Size = new System.Drawing.Size(151, 61);
            this.btn_dur.TabIndex = 5;
            this.btn_dur.Text = "DURDUR";
            this.btn_dur.UseVisualStyleBackColor = false;
            this.btn_dur.Click += new System.EventHandler(this.btn_dur_Click);
            // 
            // btn_sifir
            // 
            this.btn_sifir.BackColor = System.Drawing.Color.Crimson;
            this.btn_sifir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sifir.FlatAppearance.BorderSize = 3;
            this.btn_sifir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_sifir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_sifir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_sifir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifir.ForeColor = System.Drawing.Color.White;
            this.btn_sifir.Location = new System.Drawing.Point(102, 207);
            this.btn_sifir.Name = "btn_sifir";
            this.btn_sifir.Size = new System.Drawing.Size(151, 61);
            this.btn_sifir.TabIndex = 5;
            this.btn_sifir.Text = "SIFIRLA";
            this.btn_sifir.UseVisualStyleBackColor = false;
            this.btn_sifir.Click += new System.EventHandler(this.btn_sifir_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(405, 251);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.csharpkampusu.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(592, 280);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_sifir);
            this.Controls.Add(this.btn_dur);
            this.Controls.Add(this.BAŞLAT);
            this.Controls.Add(this.lb_salise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_zaman_al);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Saniye);
            this.Controls.Add(this.lb_dakika);
            this.Controls.Add(this.lb_saat);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KRONOMETRE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_saat;
        private System.Windows.Forms.Label lb_dakika;
        private System.Windows.Forms.Label lb_Saniye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer kronometre;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btn_zaman_al;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_salise;
        private System.Windows.Forms.Button BAŞLAT;
        private System.Windows.Forms.Button btn_dur;
        private System.Windows.Forms.Button btn_sifir;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


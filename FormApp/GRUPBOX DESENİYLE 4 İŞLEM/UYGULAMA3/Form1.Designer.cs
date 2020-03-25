namespace UYGULAMA3
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_sayı1 = new System.Windows.Forms.TextBox();
            this.tx_sayı2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.tx_sonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAYI 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SAYI2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tx_sayı2);
            this.groupBox1.Controls.Add(this.tx_sayı1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SAYILAR";
            // 
            // tx_sayı1
            // 
            this.tx_sayı1.Location = new System.Drawing.Point(62, 33);
            this.tx_sayı1.Name = "tx_sayı1";
            this.tx_sayı1.Size = new System.Drawing.Size(100, 20);
            this.tx_sayı1.TabIndex = 1;
            // 
            // tx_sayı2
            // 
            this.tx_sayı2.Location = new System.Drawing.Point(62, 67);
            this.tx_sayı2.Name = "tx_sayı2";
            this.tx_sayı2.Size = new System.Drawing.Size(100, 20);
            this.tx_sayı2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_bol);
            this.groupBox2.Controls.Add(this.btn_carp);
            this.groupBox2.Controls.Add(this.btn_cikar);
            this.groupBox2.Controls.Add(this.btn_topla);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(211, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // btn_topla
            // 
            this.btn_topla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_topla.Location = new System.Drawing.Point(23, 28);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(54, 42);
            this.btn_topla.TabIndex = 0;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = false;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_cikar
            // 
            this.btn_cikar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikar.Location = new System.Drawing.Point(92, 28);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(54, 42);
            this.btn_cikar.TabIndex = 1;
            this.btn_cikar.Text = "-";
            this.btn_cikar.UseVisualStyleBackColor = false;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_carp.Location = new System.Drawing.Point(23, 91);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(54, 42);
            this.btn_carp.TabIndex = 2;
            this.btn_carp.Text = "X";
            this.btn_carp.UseVisualStyleBackColor = false;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_bol
            // 
            this.btn_bol.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bol.Location = new System.Drawing.Point(92, 91);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(54, 42);
            this.btn_bol.TabIndex = 3;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = false;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // tx_sonuc
            // 
            this.tx_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_sonuc.ForeColor = System.Drawing.Color.Red;
            this.tx_sonuc.Location = new System.Drawing.Point(190, 214);
            this.tx_sonuc.Multiline = true;
            this.tx_sonuc.Name = "tx_sonuc";
            this.tx_sonuc.Size = new System.Drawing.Size(167, 38);
            this.tx_sonuc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(41, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "SONUÇ = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(400, 303);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_sonuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "UYGULAMA3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tx_sayı2;
        private System.Windows.Forms.TextBox tx_sayı1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.TextBox tx_sonuc;
        private System.Windows.Forms.Label label3;
    }
}


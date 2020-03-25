namespace VERİTABANLI_KULLANICI_GİRİŞİ
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
            this.tx_kullanıcı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.btn_giriş = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kAYDOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI :";
            // 
            // tx_kullanıcı
            // 
            this.tx_kullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_kullanıcı.Location = new System.Drawing.Point(176, 42);
            this.tx_kullanıcı.Name = "tx_kullanıcı";
            this.tx_kullanıcı.Size = new System.Drawing.Size(161, 30);
            this.tx_kullanıcı.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(90, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ŞİFRE :";
            // 
            // tx_sifre
            // 
            this.tx_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_sifre.Location = new System.Drawing.Point(176, 78);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(161, 30);
            this.tx_sifre.TabIndex = 2;
            // 
            // btn_giriş
            // 
            this.btn_giriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giriş.Location = new System.Drawing.Point(172, 124);
            this.btn_giriş.Name = "btn_giriş";
            this.btn_giriş.Size = new System.Drawing.Size(164, 47);
            this.btn_giriş.TabIndex = 3;
            this.btn_giriş.Text = "GİRİŞ";
            this.btn_giriş.UseVisualStyleBackColor = true;
            this.btn_giriş.Click += new System.EventHandler(this.btn_giriş_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAYDOLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kAYDOLToolStripMenuItem
            // 
            this.kAYDOLToolStripMenuItem.Name = "kAYDOLToolStripMenuItem";
            this.kAYDOLToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kAYDOLToolStripMenuItem.Text = "KAYDOL";
            this.kAYDOLToolStripMenuItem.Click += new System.EventHandler(this.kAYDOLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 188);
            this.Controls.Add(this.btn_giriş);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_kullanıcı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KULLANICI GİRİŞİ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_kullanıcı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Button btn_giriş;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kAYDOLToolStripMenuItem;
    }
}


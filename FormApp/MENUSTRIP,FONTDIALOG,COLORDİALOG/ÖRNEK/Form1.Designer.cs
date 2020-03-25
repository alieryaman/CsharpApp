namespace ÖRNEK
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENÜToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programHakkkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.color_zemin = new System.Windows.Forms.ColorDialog();
            this.color_text = new System.Windows.Forms.ColorDialog();
            this.tx_text = new System.Windows.Forms.TextBox();
            this.CONTEXTTEXTBOX = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yazirengi = new System.Windows.Forms.ToolStripMenuItem();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxt_text = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KAPAT = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerial = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamekran = new System.Windows.Forms.ToolStripMenuItem();
            this.zeminRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazırengi = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıfontu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.CONTEXTTEXTBOX.SuspendLayout();
            this.context.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENÜToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENÜToolStripMenuItem
            // 
            this.mENÜToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.mENÜToolStripMenuItem.Name = "mENÜToolStripMenuItem";
            this.mENÜToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.mENÜToolStripMenuItem.Text = "Dosya";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.gerial,
            this.ileriToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamekran,
            this.zeminRengiToolStripMenuItem,
            this.yazırengi,
            this.yazıfontu});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programHakkkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // programHakkkındaToolStripMenuItem
            // 
            this.programHakkkındaToolStripMenuItem.Name = "programHakkkındaToolStripMenuItem";
            this.programHakkkındaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.programHakkkındaToolStripMenuItem.Text = "Program Hakkkında";
            // 
            // tx_text
            // 
            this.tx_text.ContextMenuStrip = this.CONTEXTTEXTBOX;
            this.tx_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_text.Location = new System.Drawing.Point(12, 79);
            this.tx_text.Multiline = true;
            this.tx_text.Name = "tx_text";
            this.tx_text.Size = new System.Drawing.Size(186, 241);
            this.tx_text.TabIndex = 1;
            // 
            // CONTEXTTEXTBOX
            // 
            this.CONTEXTTEXTBOX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazirengi,
            this.font});
            this.CONTEXTTEXTBOX.Name = "CONTEXTTEXTBOX";
            this.CONTEXTTEXTBOX.Size = new System.Drawing.Size(136, 48);
            // 
            // yazirengi
            // 
            this.yazirengi.Name = "yazirengi";
            this.yazirengi.Size = new System.Drawing.Size(135, 22);
            this.yazirengi.Text = "YAZI RENGİ";
            this.yazirengi.Click += new System.EventHandler(this.yazirengi_Click);
            // 
            // font
            // 
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(135, 22);
            this.font.Text = "FONTU";
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // rtxt_text
            // 
            this.rtxt_text.Location = new System.Drawing.Point(204, 79);
            this.rtxt_text.Name = "rtxt_text";
            this.rtxt_text.Size = new System.Drawing.Size(209, 239);
            this.rtxt_text.TabIndex = 2;
            this.rtxt_text.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "YAZI RENGİ DEĞİŞME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FONT DEĞİŞME";
            // 
            // context
            // 
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KAPAT});
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(112, 26);
            // 
            // KAPAT
            // 
            this.KAPAT.Name = "KAPAT";
            this.KAPAT.Size = new System.Drawing.Size(111, 22);
            this.KAPAT.Text = "KAPAT";
            this.KAPAT.Click += new System.EventHandler(this.KAPAT_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.kterm;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.açToolStripMenuItem.Text = "Aç";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources._3floppy_unmount;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.displayconfig;
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.editcut;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.format_increaseindent;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.view_sidetree;
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // gerial
            // 
            this.gerial.Image = global::ÖRNEK.Properties.Resources.agt_back;
            this.gerial.Name = "gerial";
            this.gerial.Size = new System.Drawing.Size(160, 22);
            this.gerial.Text = "Geri Al   (Ctrl+Z)";
            this.gerial.Click += new System.EventHandler(this.gerial_Click);
            // 
            // ileriToolStripMenuItem
            // 
            this.ileriToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.agt_forward;
            this.ileriToolStripMenuItem.Name = "ileriToolStripMenuItem";
            this.ileriToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ileriToolStripMenuItem.Text = "İleri";
            // 
            // tamekran
            // 
            this.tamekran.Image = global::ÖRNEK.Properties.Resources.resizerow;
            this.tamekran.Name = "tamekran";
            this.tamekran.Size = new System.Drawing.Size(152, 22);
            this.tamekran.Text = "Tam Ekran";
            this.tamekran.Click += new System.EventHandler(this.tamekran_Click);
            // 
            // zeminRengiToolStripMenuItem
            // 
            this.zeminRengiToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.color_fill;
            this.zeminRengiToolStripMenuItem.Name = "zeminRengiToolStripMenuItem";
            this.zeminRengiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zeminRengiToolStripMenuItem.Text = "Zemin Rengi";
            this.zeminRengiToolStripMenuItem.Click += new System.EventHandler(this.zeminRengiToolStripMenuItem_Click);
            // 
            // yazırengi
            // 
            this.yazırengi.Image = global::ÖRNEK.Properties.Resources.color_line;
            this.yazırengi.Name = "yazırengi";
            this.yazırengi.Size = new System.Drawing.Size(152, 22);
            this.yazırengi.Text = "Yazı Rengi";
            this.yazırengi.Click += new System.EventHandler(this.yazırengi_Click);
            // 
            // yazıfontu
            // 
            this.yazıfontu.Image = global::ÖRNEK.Properties.Resources.fonts;
            this.yazıfontu.Name = "yazıfontu";
            this.yazıfontu.Size = new System.Drawing.Size(152, 22);
            this.yazıfontu.Text = "Yazı Fontu";
            this.yazıfontu.Click += new System.EventHandler(this.yazıfontu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 389);
            this.ContextMenuStrip = this.context;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxt_text);
            this.Controls.Add(this.tx_text);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MenüStrip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CONTEXTTEXTBOX.ResumeLayout(false);
            this.context.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENÜToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamekran;
        private System.Windows.Forms.ToolStripMenuItem programHakkkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeminRengiToolStripMenuItem;
        private System.Windows.Forms.ColorDialog color_zemin;
        private System.Windows.Forms.ToolStripMenuItem yazırengi;
        private System.Windows.Forms.ColorDialog color_text;
        private System.Windows.Forms.TextBox tx_text;
        private System.Windows.Forms.ToolStripMenuItem yazıfontu;
        private System.Windows.Forms.RichTextBox rtxt_text;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ToolStripMenuItem KAPAT;
        private System.Windows.Forms.ContextMenuStrip CONTEXTTEXTBOX;
        private System.Windows.Forms.ToolStripMenuItem yazirengi;
        private System.Windows.Forms.ToolStripMenuItem font;
        private System.Windows.Forms.ToolStripMenuItem gerial;
        private System.Windows.Forms.ToolStripMenuItem ileriToolStripMenuItem;
    }
}


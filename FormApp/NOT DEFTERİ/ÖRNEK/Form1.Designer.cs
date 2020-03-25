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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENÜToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerial = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamekran = new System.Windows.Forms.ToolStripMenuItem();
            this.zeminRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazırengi = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıfontu = new System.Windows.Forms.ToolStripMenuItem();
            this.paragrafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solaHizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağaHizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programHakkkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.color_zemin = new System.Windows.Forms.ColorDialog();
            this.color_text = new System.Windows.Forms.ColorDialog();
            this.CONTEXTTEXTBOX = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yazirengi = new System.Windows.Forms.ToolStripMenuItem();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxt_text = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KAPAT = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.CONTEXTTEXTBOX.SuspendLayout();
            this.context.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENÜToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.paragrafToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENÜToolStripMenuItem
            // 
            this.mENÜToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.mENÜToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.mENÜToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mENÜToolStripMenuItem.Name = "mENÜToolStripMenuItem";
            this.mENÜToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.mENÜToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.kterm;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources._3floppy_unmount;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.displayconfig;
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.gerial,
            this.ileriToolStripMenuItem});
            this.düzenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.editcut;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.format_increaseindent;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.view_sidetree;
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // gerial
            // 
            this.gerial.Image = global::ÖRNEK.Properties.Resources.agt_back;
            this.gerial.Name = "gerial";
            this.gerial.Size = new System.Drawing.Size(179, 24);
            this.gerial.Text = "Geri Al   (Ctrl+Z)";
            this.gerial.Click += new System.EventHandler(this.gerial_Click);
            // 
            // ileriToolStripMenuItem
            // 
            this.ileriToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.agt_forward;
            this.ileriToolStripMenuItem.Name = "ileriToolStripMenuItem";
            this.ileriToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.ileriToolStripMenuItem.Text = "İleri";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamekran,
            this.zeminRengiToolStripMenuItem,
            this.yazırengi,
            this.yazıfontu});
            this.görünümToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // tamekran
            // 
            this.tamekran.Image = global::ÖRNEK.Properties.Resources.resizerow;
            this.tamekran.Name = "tamekran";
            this.tamekran.Size = new System.Drawing.Size(154, 24);
            this.tamekran.Text = "Tam Ekran";
            this.tamekran.Click += new System.EventHandler(this.tamekran_Click);
            // 
            // zeminRengiToolStripMenuItem
            // 
            this.zeminRengiToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.color_fill;
            this.zeminRengiToolStripMenuItem.Name = "zeminRengiToolStripMenuItem";
            this.zeminRengiToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.zeminRengiToolStripMenuItem.Text = "Zemin Rengi";
            this.zeminRengiToolStripMenuItem.Click += new System.EventHandler(this.zeminRengiToolStripMenuItem_Click);
            // 
            // yazırengi
            // 
            this.yazırengi.Image = global::ÖRNEK.Properties.Resources.color_line;
            this.yazırengi.Name = "yazırengi";
            this.yazırengi.Size = new System.Drawing.Size(154, 24);
            this.yazırengi.Text = "Yazı Rengi";
            this.yazırengi.Click += new System.EventHandler(this.yazırengi_Click);
            // 
            // yazıfontu
            // 
            this.yazıfontu.Image = global::ÖRNEK.Properties.Resources.fonts;
            this.yazıfontu.Name = "yazıfontu";
            this.yazıfontu.Size = new System.Drawing.Size(154, 24);
            this.yazıfontu.Text = "Yazı Fontu";
            this.yazıfontu.Click += new System.EventHandler(this.yazıfontu_Click);
            // 
            // paragrafToolStripMenuItem
            // 
            this.paragrafToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.paragrafToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solaHizalaToolStripMenuItem,
            this.ortalaToolStripMenuItem,
            this.sağaHizalaToolStripMenuItem});
            this.paragrafToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paragrafToolStripMenuItem.Name = "paragrafToolStripMenuItem";
            this.paragrafToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.paragrafToolStripMenuItem.Text = "Paragraf";
            // 
            // solaHizalaToolStripMenuItem
            // 
            this.solaHizalaToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.applix;
            this.solaHizalaToolStripMenuItem.Name = "solaHizalaToolStripMenuItem";
            this.solaHizalaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.solaHizalaToolStripMenuItem.Text = "Sola Hizala";
            this.solaHizalaToolStripMenuItem.Click += new System.EventHandler(this.solaHizalaToolStripMenuItem_Click);
            // 
            // ortalaToolStripMenuItem
            // 
            this.ortalaToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.gettext;
            this.ortalaToolStripMenuItem.Name = "ortalaToolStripMenuItem";
            this.ortalaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.ortalaToolStripMenuItem.Text = "Ortala";
            this.ortalaToolStripMenuItem.Click += new System.EventHandler(this.ortalaToolStripMenuItem_Click);
            // 
            // sağaHizalaToolStripMenuItem
            // 
            this.sağaHizalaToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.font;
            this.sağaHizalaToolStripMenuItem.Name = "sağaHizalaToolStripMenuItem";
            this.sağaHizalaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.sağaHizalaToolStripMenuItem.Text = "Sağa Hizala";
            this.sağaHizalaToolStripMenuItem.Click += new System.EventHandler(this.sağaHizalaToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programHakkkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // programHakkkındaToolStripMenuItem
            // 
            this.programHakkkındaToolStripMenuItem.Image = global::ÖRNEK.Properties.Resources.help;
            this.programHakkkındaToolStripMenuItem.Name = "programHakkkındaToolStripMenuItem";
            this.programHakkkındaToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.programHakkkındaToolStripMenuItem.Text = "Program Hakkkında";
            this.programHakkkındaToolStripMenuItem.Click += new System.EventHandler(this.programHakkkındaToolStripMenuItem_Click);
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
            this.rtxt_text.ContextMenuStrip = this.CONTEXTTEXTBOX;
            this.rtxt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxt_text.Location = new System.Drawing.Point(-1, 58);
            this.rtxt_text.Name = "rtxt_text";
            this.rtxt_text.Size = new System.Drawing.Size(343, 331);
            this.rtxt_text.TabIndex = 2;
            this.rtxt_text.Text = "";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripLabel1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(-1, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(343, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ÖRNEK.Properties.Resources.Editing_Cut_Filled_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "KES";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::ÖRNEK.Properties.Resources.copy_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "KOPYALA";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::ÖRNEK.Properties.Resources.paste_icon;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "KAYDET";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::ÖRNEK.Properties.Resources.printer1;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "YAZDIR";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(104, 392);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.csharpkampusu.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 411);
            this.ContextMenuStrip = this.context;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtxt_text);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    NOT     DEFTERİ     ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CONTEXTTEXTBOX.ResumeLayout(false);
            this.context.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem yazıfontu;
        private System.Windows.Forms.RichTextBox rtxt_text;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ToolStripMenuItem KAPAT;
        private System.Windows.Forms.ContextMenuStrip CONTEXTTEXTBOX;
        private System.Windows.Forms.ToolStripMenuItem yazirengi;
        private System.Windows.Forms.ToolStripMenuItem font;
        private System.Windows.Forms.ToolStripMenuItem gerial;
        private System.Windows.Forms.ToolStripMenuItem ileriToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem paragrafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solaHizalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağaHizalaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


namespace _06._10._2015
{
    partial class DEĞİŞKEN_TÜRLERİ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DEĞİŞKEN_TÜRLERİ));
            this.lbox_degisken = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_ornek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbox_degisken
            // 
            this.lbox_degisken.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbox_degisken.FormattingEnabled = true;
            this.lbox_degisken.ItemHeight = 20;
            this.lbox_degisken.Items.AddRange(new object[] {
            "int ",
            "Long",
            "Double",
            "Float\t",
            "Decimal",
            "Bool",
            "Char",
            "String"});
            this.lbox_degisken.Location = new System.Drawing.Point(21, 51);
            this.lbox_degisken.Name = "lbox_degisken";
            this.lbox_degisken.Size = new System.Drawing.Size(228, 164);
            this.lbox_degisken.TabIndex = 0;
            this.lbox_degisken.SelectedIndexChanged += new System.EventHandler(this.lbox_degisken_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEĞİŞKENLER;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "DEĞİŞKEN ÖRNEĞİ";
            // 
            // tx_ornek
            // 
            this.tx_ornek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tx_ornek.ForeColor = System.Drawing.Color.Red;
            this.tx_ornek.Location = new System.Drawing.Point(21, 284);
            this.tx_ornek.Multiline = true;
            this.tx_ornek.Name = "tx_ornek";
            this.tx_ornek.Size = new System.Drawing.Size(333, 45);
            this.tx_ornek.TabIndex = 3;
            // 
            // DEĞİŞKEN_TÜRLERİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 387);
            this.Controls.Add(this.tx_ornek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbox_degisken);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DEĞİŞKEN_TÜRLERİ";
            this.Text = "DEĞİŞKENLER";
            this.Load += new System.EventHandler(this.DEĞİŞKEN_TÜRLERİ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_degisken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_ornek;

    }
}
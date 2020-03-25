namespace _11._03._2015_ÖDEV
{
    partial class csharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(csharp));
            this.lbox_degisken = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_ornek = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_degisken
            // 
            this.lbox_degisken.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbox_degisken.FormattingEnabled = true;
            this.lbox_degisken.ItemHeight = 29;
            this.lbox_degisken.Items.AddRange(new object[] {
            "int ",
            "Long",
            "Double",
            "Float\t",
            "Decimal",
            "Bool",
            "Char",
            "String"});
            this.lbox_degisken.Location = new System.Drawing.Point(12, 12);
            this.lbox_degisken.Name = "lbox_degisken";
            this.lbox_degisken.Size = new System.Drawing.Size(410, 236);
            this.lbox_degisken.TabIndex = 0;
            this.lbox_degisken.SelectedIndexChanged += new System.EventHandler(this.lbox_degisken_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEĞİŞKEN ÖRNEĞİ:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tx_ornek
            // 
            this.tx_ornek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_ornek.ForeColor = System.Drawing.Color.Red;
            this.tx_ornek.Location = new System.Drawing.Point(17, 323);
            this.tx_ornek.Multiline = true;
            this.tx_ornek.Name = "tx_ornek";
            this.tx_ornek.Size = new System.Drawing.Size(405, 64);
            this.tx_ornek.TabIndex = 2;
            this.tx_ornek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tx_ornek.TextChanged += new System.EventHandler(this.tx_ornek_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(323, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 81);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // csharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(447, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_ornek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbox_degisken);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "csharp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# ÖRNEKLER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_degisken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_ornek;
        private System.Windows.Forms.Button button1;
    }
}
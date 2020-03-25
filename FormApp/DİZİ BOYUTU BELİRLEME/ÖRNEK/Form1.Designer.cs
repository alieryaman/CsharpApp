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
            this.lst_sayilar = new System.Windows.Forms.ListBox();
            this.lst_kareler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst_sayilar
            // 
            this.lst_sayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_sayilar.FormattingEnabled = true;
            this.lst_sayilar.ItemHeight = 20;
            this.lst_sayilar.Location = new System.Drawing.Point(21, 12);
            this.lst_sayilar.Name = "lst_sayilar";
            this.lst_sayilar.Size = new System.Drawing.Size(105, 224);
            this.lst_sayilar.TabIndex = 0;
            // 
            // lst_kareler
            // 
            this.lst_kareler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_kareler.FormattingEnabled = true;
            this.lst_kareler.ItemHeight = 20;
            this.lst_kareler.Location = new System.Drawing.Point(132, 12);
            this.lst_kareler.Name = "lst_kareler";
            this.lst_kareler.Size = new System.Drawing.Size(105, 224);
            this.lst_kareler.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 247);
            this.Controls.Add(this.lst_kareler);
            this.Controls.Add(this.lst_sayilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DİZİ BOYUTU BELİRLEME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_sayilar;
        private System.Windows.Forms.ListBox lst_kareler;
    }
}


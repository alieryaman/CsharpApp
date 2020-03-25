namespace C_Sharp_Kim_500_Milyar_Ister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.soru = new C_Sharp_Kim_500_Milyar_Ister.Soru();
            this.SuspendLayout();
            // 
            // soru
            // 
            this.soru.BackColor = System.Drawing.Color.DarkRed;
            this.soru.CevapDogruMu = false;
            this.soru.DogruSecenek = '\0';
            this.soru.Location = new System.Drawing.Point(21, 24);
            this.soru.Name = "soru";
            this.soru.SecenekA = "";
            this.soru.SecenekB = "";
            this.soru.SecenekC = "";
            this.soru.SecenekD = "";
            this.soru.Size = new System.Drawing.Size(672, 265);
            this.soru.SoruAciklamasi = "";
            this.soru.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(705, 317);
            this.Controls.Add(this.soru);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "KİM 500 MİLYAR İSTER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Soru soru;

    }
}


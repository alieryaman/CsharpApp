namespace ARİTMETİK_İSİM_YAZDIRMA
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
            this.tx_isim = new System.Windows.Forms.TextBox();
            this.btn_yaz = new System.Windows.Forms.Button();
            this.lbx_isim = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İSMİ GİRİNİZ:";
            // 
            // tx_isim
            // 
            this.tx_isim.Location = new System.Drawing.Point(90, 14);
            this.tx_isim.Name = "tx_isim";
            this.tx_isim.Size = new System.Drawing.Size(100, 20);
            this.tx_isim.TabIndex = 1;
            // 
            // btn_yaz
            // 
            this.btn_yaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yaz.Location = new System.Drawing.Point(215, 12);
            this.btn_yaz.Name = "btn_yaz";
            this.btn_yaz.Size = new System.Drawing.Size(75, 47);
            this.btn_yaz.TabIndex = 2;
            this.btn_yaz.Text = "YAZDIR";
            this.btn_yaz.UseVisualStyleBackColor = true;
            this.btn_yaz.Click += new System.EventHandler(this.btn_yaz_Click);
            // 
            // lbx_isim
            // 
            this.lbx_isim.FormattingEnabled = true;
            this.lbx_isim.Location = new System.Drawing.Point(12, 55);
            this.lbx_isim.Name = "lbx_isim";
            this.lbx_isim.Size = new System.Drawing.Size(178, 251);
            this.lbx_isim.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 326);
            this.Controls.Add(this.lbx_isim);
            this.Controls.Add(this.btn_yaz);
            this.Controls.Add(this.tx_isim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARİTMETİK İSİM YAZMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_isim;
        private System.Windows.Forms.Button btn_yaz;
        private System.Windows.Forms.ListBox lbx_isim;
    }
}


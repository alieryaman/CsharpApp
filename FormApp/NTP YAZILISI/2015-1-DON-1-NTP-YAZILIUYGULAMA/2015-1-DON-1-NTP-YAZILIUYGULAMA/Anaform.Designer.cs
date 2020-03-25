namespace _2015_1_DON_1_NTP_YAZILIUYGULAMA
{
    partial class Anaform
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
            this.btn_soru1 = new System.Windows.Forms.Button();
            this.btn_soru2 = new System.Windows.Forms.Button();
            this.btn_soru3 = new System.Windows.Forms.Button();
            this.btn_soru4 = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_soru1
            // 
            this.btn_soru1.Location = new System.Drawing.Point(67, 41);
            this.btn_soru1.Name = "btn_soru1";
            this.btn_soru1.Size = new System.Drawing.Size(107, 35);
            this.btn_soru1.TabIndex = 0;
            this.btn_soru1.Text = "SORU1";
            this.btn_soru1.UseVisualStyleBackColor = true;
            // 
            // btn_soru2
            // 
            this.btn_soru2.Location = new System.Drawing.Point(67, 79);
            this.btn_soru2.Name = "btn_soru2";
            this.btn_soru2.Size = new System.Drawing.Size(107, 35);
            this.btn_soru2.TabIndex = 1;
            this.btn_soru2.Text = "SORU2";
            this.btn_soru2.UseVisualStyleBackColor = true;
            this.btn_soru2.Click += new System.EventHandler(this.btn_soru2_Click);
            // 
            // btn_soru3
            // 
            this.btn_soru3.Location = new System.Drawing.Point(67, 117);
            this.btn_soru3.Name = "btn_soru3";
            this.btn_soru3.Size = new System.Drawing.Size(107, 35);
            this.btn_soru3.TabIndex = 2;
            this.btn_soru3.Text = "SORU3";
            this.btn_soru3.UseVisualStyleBackColor = true;
            this.btn_soru3.Click += new System.EventHandler(this.btn_soru3_Click);
            // 
            // btn_soru4
            // 
            this.btn_soru4.Location = new System.Drawing.Point(67, 155);
            this.btn_soru4.Name = "btn_soru4";
            this.btn_soru4.Size = new System.Drawing.Size(107, 35);
            this.btn_soru4.TabIndex = 3;
            this.btn_soru4.Text = "SORU4";
            this.btn_soru4.UseVisualStyleBackColor = true;
            this.btn_soru4.Click += new System.EventHandler(this.btn_soru4_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(67, 193);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(107, 35);
            this.btn_kapat.TabIndex = 4;
            this.btn_kapat.Text = "KAPAT";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 298);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_soru4);
            this.Controls.Add(this.btn_soru3);
            this.Controls.Add(this.btn_soru2);
            this.Controls.Add(this.btn_soru1);
            this.Name = "Anaform";
            this.Text = "Anaform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_soru1;
        private System.Windows.Forms.Button btn_soru2;
        private System.Windows.Forms.Button btn_soru3;
        private System.Windows.Forms.Button btn_soru4;
        private System.Windows.Forms.Button btn_kapat;
    }
}
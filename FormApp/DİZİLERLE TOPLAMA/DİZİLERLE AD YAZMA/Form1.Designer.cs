﻿namespace DİZİLERLE_AD_YAZMA
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
            this.btn_giris = new System.Windows.Forms.Button();
            this.lst_sayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(23, 15);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(194, 64);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "SAYIYI GİR";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // lst_sayilar
            // 
            this.lst_sayilar.FormattingEnabled = true;
            this.lst_sayilar.Location = new System.Drawing.Point(23, 101);
            this.lst_sayilar.Name = "lst_sayilar";
            this.lst_sayilar.Size = new System.Drawing.Size(194, 212);
            this.lst_sayilar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 342);
            this.Controls.Add(this.lst_sayilar);
            this.Controls.Add(this.btn_giris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DİZİLERLE TOPLAMA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.ListBox lst_sayilar;
    }
}


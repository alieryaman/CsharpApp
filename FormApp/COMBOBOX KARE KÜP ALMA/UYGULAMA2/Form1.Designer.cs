namespace UYGULAMA2
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
            this.tx_s1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_islem = new System.Windows.Forms.ComboBox();
            this.btn_hesap = new System.Windows.Forms.Button();
            this.tx_sonuc = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tx_s1
            // 
            this.tx_s1.Location = new System.Drawing.Point(94, 23);
            this.tx_s1.Name = "tx_s1";
            this.tx_s1.Size = new System.Drawing.Size(100, 20);
            this.tx_s1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BİRİNCİ SAYI ";
            // 
            // cmb_islem
            // 
            this.cmb_islem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_islem.FormattingEnabled = true;
            this.cmb_islem.Items.AddRange(new object[] {
            "KARESİ",
            "KÜPÜ"});
            this.cmb_islem.Location = new System.Drawing.Point(94, 52);
            this.cmb_islem.Name = "cmb_islem";
            this.cmb_islem.Size = new System.Drawing.Size(100, 21);
            this.cmb_islem.TabIndex = 2;
            // 
            // btn_hesap
            // 
            this.btn_hesap.Location = new System.Drawing.Point(94, 87);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(103, 34);
            this.btn_hesap.TabIndex = 3;
            this.btn_hesap.Text = "SONUÇ ";
            this.btn_hesap.UseVisualStyleBackColor = true;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // tx_sonuc
            // 
            this.tx_sonuc.Location = new System.Drawing.Point(76, 127);
            this.tx_sonuc.Name = "tx_sonuc";
            this.tx_sonuc.Size = new System.Drawing.Size(121, 20);
            this.tx_sonuc.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(49, 162);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.csharpkampusu.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(253, 188);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tx_sonuc);
            this.Controls.Add(this.btn_hesap);
            this.Controls.Add(this.cmb_islem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_s1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "COMBOBOX KULLANIMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_s1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_islem;
        private System.Windows.Forms.Button btn_hesap;
        private System.Windows.Forms.TextBox tx_sonuc;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


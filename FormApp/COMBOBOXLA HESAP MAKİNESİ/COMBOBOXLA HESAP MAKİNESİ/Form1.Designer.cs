namespace COMBOBOXLA_HESAP_MAKİNESİ
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
            this.label1 = new System.Windows.Forms.Label();
            this.tx_sayı1 = new System.Windows.Forms.TextBox();
            this.cmb_islem = new System.Windows.Forms.ComboBox();
            this.btn_snc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_sayı2 = new System.Windows.Forms.TextBox();
            this.lbl_snc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAYI :";
            // 
            // tx_sayı1
            // 
            this.tx_sayı1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_sayı1.Location = new System.Drawing.Point(96, 12);
            this.tx_sayı1.Multiline = true;
            this.tx_sayı1.Name = "tx_sayı1";
            this.tx_sayı1.Size = new System.Drawing.Size(125, 31);
            this.tx_sayı1.TabIndex = 1;
            // 
            // cmb_islem
            // 
            this.cmb_islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_islem.FormattingEnabled = true;
            this.cmb_islem.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "÷"});
            this.cmb_islem.Location = new System.Drawing.Point(100, 125);
            this.cmb_islem.Name = "cmb_islem";
            this.cmb_islem.Size = new System.Drawing.Size(121, 28);
            this.cmb_islem.TabIndex = 3;
            // 
            // btn_snc
            // 
            this.btn_snc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_snc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_snc.ForeColor = System.Drawing.Color.White;
            this.btn_snc.Location = new System.Drawing.Point(100, 179);
            this.btn_snc.Name = "btn_snc";
            this.btn_snc.Size = new System.Drawing.Size(123, 35);
            this.btn_snc.TabIndex = 3;
            this.btn_snc.Text = "SONUÇ GÖR";
            this.btn_snc.UseVisualStyleBackColor = false;
            this.btn_snc.Click += new System.EventHandler(this.btn_snc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(44, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "SAYI :";
            // 
            // tx_sayı2
            // 
            this.tx_sayı2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_sayı2.Location = new System.Drawing.Point(96, 61);
            this.tx_sayı2.Multiline = true;
            this.tx_sayı2.Name = "tx_sayı2";
            this.tx_sayı2.Size = new System.Drawing.Size(125, 31);
            this.tx_sayı2.TabIndex = 2;
            // 
            // lbl_snc
            // 
            this.lbl_snc.AutoSize = true;
            this.lbl_snc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_snc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_snc.ForeColor = System.Drawing.Color.Red;
            this.lbl_snc.Location = new System.Drawing.Point(34, 253);
            this.lbl_snc.Name = "lbl_snc";
            this.lbl_snc.Size = new System.Drawing.Size(72, 17);
            this.lbl_snc.TabIndex = 0;
            this.lbl_snc.Text = "SONUÇ :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(285, 319);
            this.Controls.Add(this.btn_snc);
            this.Controls.Add(this.cmb_islem);
            this.Controls.Add(this.tx_sayı2);
            this.Controls.Add(this.tx_sayı1);
            this.Controls.Add(this.lbl_snc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HESAP MAKİNESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_sayı1;
        private System.Windows.Forms.ComboBox cmb_islem;
        private System.Windows.Forms.Button btn_snc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_sayı2;
        private System.Windows.Forms.Label lbl_snc;
    }
}


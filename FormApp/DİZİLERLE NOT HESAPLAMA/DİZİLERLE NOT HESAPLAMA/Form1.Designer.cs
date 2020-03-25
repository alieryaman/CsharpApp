namespace DİZİLERLE_NOT_HESAPLAMA
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
            this.lst_not1 = new System.Windows.Forms.ListBox();
            this.lst_not2 = new System.Windows.Forms.ListBox();
            this.lst_not3 = new System.Windows.Forms.ListBox();
            this.lst_ort = new System.Windows.Forms.ListBox();
            this.btn_not = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_yuksek = new System.Windows.Forms.Label();
            this.lb_dusuk = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lst_not1
            // 
            this.lst_not1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_not1.FormattingEnabled = true;
            this.lst_not1.Location = new System.Drawing.Point(23, 32);
            this.lst_not1.Name = "lst_not1";
            this.lst_not1.Size = new System.Drawing.Size(93, 121);
            this.lst_not1.TabIndex = 0;
            // 
            // lst_not2
            // 
            this.lst_not2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_not2.FormattingEnabled = true;
            this.lst_not2.Location = new System.Drawing.Point(122, 32);
            this.lst_not2.Name = "lst_not2";
            this.lst_not2.Size = new System.Drawing.Size(93, 121);
            this.lst_not2.TabIndex = 0;
            // 
            // lst_not3
            // 
            this.lst_not3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_not3.FormattingEnabled = true;
            this.lst_not3.Location = new System.Drawing.Point(221, 32);
            this.lst_not3.Name = "lst_not3";
            this.lst_not3.Size = new System.Drawing.Size(99, 121);
            this.lst_not3.TabIndex = 0;
            this.lst_not3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // lst_ort
            // 
            this.lst_ort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_ort.FormattingEnabled = true;
            this.lst_ort.Location = new System.Drawing.Point(326, 32);
            this.lst_ort.Name = "lst_ort";
            this.lst_ort.Size = new System.Drawing.Size(99, 121);
            this.lst_ort.TabIndex = 0;
            this.lst_ort.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // btn_not
            // 
            this.btn_not.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_not.Location = new System.Drawing.Point(23, 162);
            this.btn_not.Name = "btn_not";
            this.btn_not.Size = new System.Drawing.Size(93, 48);
            this.btn_not.TabIndex = 1;
            this.btn_not.Text = "NOT GİR";
            this.btn_not.UseVisualStyleBackColor = true;
            this.btn_not.Click += new System.EventHandler(this.btn_not_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ORTALAMA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOT1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOT2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "NOT3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(155, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "EN YÜKSEK ORTALAMA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(155, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "EN DÜŞÜK ORTALAMA:\r\n";
            // 
            // lb_yuksek
            // 
            this.lb_yuksek.AutoSize = true;
            this.lb_yuksek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_yuksek.Location = new System.Drawing.Point(357, 165);
            this.lb_yuksek.Name = "lb_yuksek";
            this.lb_yuksek.Size = new System.Drawing.Size(18, 20);
            this.lb_yuksek.TabIndex = 3;
            this.lb_yuksek.Text = "0";
            // 
            // lb_dusuk
            // 
            this.lb_dusuk.AutoSize = true;
            this.lb_dusuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_dusuk.Location = new System.Drawing.Point(357, 190);
            this.lb_dusuk.Name = "lb_dusuk";
            this.lb_dusuk.Size = new System.Drawing.Size(18, 20);
            this.lb_dusuk.TabIndex = 3;
            this.lb_dusuk.Text = "0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(62, 246);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(330, 32);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.csharpkampusu.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(443, 287);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lb_dusuk);
            this.Controls.Add(this.lb_yuksek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_not);
            this.Controls.Add(this.lst_ort);
            this.Controls.Add(this.lst_not3);
            this.Controls.Add(this.lst_not2);
            this.Controls.Add(this.lst_not1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "NOT HESAPLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_not1;
        private System.Windows.Forms.ListBox lst_not2;
        private System.Windows.Forms.ListBox lst_not3;
        private System.Windows.Forms.ListBox lst_ort;
        private System.Windows.Forms.Button btn_not;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_yuksek;
        private System.Windows.Forms.Label lb_dusuk;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


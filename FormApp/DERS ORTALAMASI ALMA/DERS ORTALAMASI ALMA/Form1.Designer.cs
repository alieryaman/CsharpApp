namespace DERS_ORTALAMASI_ALMA
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
            this.tx_y1 = new System.Windows.Forms.TextBox();
            this.tx_y2 = new System.Windows.Forms.TextBox();
            this.tx_sozlu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ort = new System.Windows.Forms.Label();
            this.lb_drsnotu = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_y1
            // 
            this.tx_y1.Location = new System.Drawing.Point(12, 69);
            this.tx_y1.MaxLength = 3;
            this.tx_y1.Name = "tx_y1";
            this.tx_y1.Size = new System.Drawing.Size(100, 20);
            this.tx_y1.TabIndex = 1;
            this.tx_y1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_y1_KeyPress);
            // 
            // tx_y2
            // 
            this.tx_y2.Location = new System.Drawing.Point(140, 69);
            this.tx_y2.MaxLength = 3;
            this.tx_y2.Name = "tx_y2";
            this.tx_y2.Size = new System.Drawing.Size(100, 20);
            this.tx_y2.TabIndex = 2;
            this.tx_y2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_y2_KeyPress);
            // 
            // tx_sozlu
            // 
            this.tx_sozlu.Location = new System.Drawing.Point(261, 69);
            this.tx_sozlu.MaxLength = 3;
            this.tx_sozlu.Name = "tx_sozlu";
            this.tx_sozlu.Size = new System.Drawing.Size(100, 20);
            this.tx_sozlu.TabIndex = 3;
            this.tx_sozlu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_sozlu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. YAZILI NOTU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. YAZILI NOTU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SÖZLÜ NOTU";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(387, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ORTALAMANIZ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "DERS NOTU";
            // 
            // lb_ort
            // 
            this.lb_ort.AutoSize = true;
            this.lb_ort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_ort.Location = new System.Drawing.Point(132, 123);
            this.lb_ort.Name = "lb_ort";
            this.lb_ort.Size = new System.Drawing.Size(16, 17);
            this.lb_ort.TabIndex = 3;
            this.lb_ort.Text = "0";
            // 
            // lb_drsnotu
            // 
            this.lb_drsnotu.AutoSize = true;
            this.lb_drsnotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_drsnotu.Location = new System.Drawing.Point(132, 148);
            this.lb_drsnotu.Name = "lb_drsnotu";
            this.lb_drsnotu.Size = new System.Drawing.Size(16, 17);
            this.lb_drsnotu.TabIndex = 3;
            this.lb_drsnotu.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(387, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(483, 189);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_drsnotu);
            this.Controls.Add(this.lb_ort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_sozlu);
            this.Controls.Add(this.tx_y2);
            this.Controls.Add(this.tx_y1);
            this.Name = "Form1";
            this.Text = "ORTALAMA HESAPLAMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_y1;
        private System.Windows.Forms.TextBox tx_y2;
        private System.Windows.Forms.TextBox tx_sozlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ort;
        private System.Windows.Forms.Label lb_drsnotu;
        private System.Windows.Forms.Button button2;
    }
}


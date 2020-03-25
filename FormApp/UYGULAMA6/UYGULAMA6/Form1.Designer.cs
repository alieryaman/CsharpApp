namespace UYGULAMA6
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
            this.tx_cap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_cevre = new System.Windows.Forms.TextBox();
            this.tx_alan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAİRENİN YARIÇAPINI GİRİNİZ :";
            // 
            // tx_cap
            // 
            this.tx_cap.Location = new System.Drawing.Point(212, 35);
            this.tx_cap.Name = "tx_cap";
            this.tx_cap.Size = new System.Drawing.Size(100, 20);
            this.tx_cap.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_cevre
            // 
            this.tx_cevre.Location = new System.Drawing.Point(144, 154);
            this.tx_cevre.Name = "tx_cevre";
            this.tx_cevre.Size = new System.Drawing.Size(100, 20);
            this.tx_cevre.TabIndex = 1;
            // 
            // tx_alan
            // 
            this.tx_alan.Location = new System.Drawing.Point(144, 180);
            this.tx_alan.Name = "tx_alan";
            this.tx_alan.Size = new System.Drawing.Size(100, 20);
            this.tx_alan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ÇEVRESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ALANI ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_alan);
            this.Controls.Add(this.tx_cevre);
            this.Controls.Add(this.tx_cap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_cap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_cevre;
        private System.Windows.Forms.TextBox tx_alan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


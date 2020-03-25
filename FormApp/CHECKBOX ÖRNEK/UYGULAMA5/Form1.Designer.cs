namespace UYGULAMA5
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
            this.ch_basket = new System.Windows.Forms.CheckBox();
            this.ch_fut = new System.Windows.Forms.CheckBox();
            this.ch_voley = new System.Windows.Forms.CheckBox();
            this.btn_snc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "YAPTIĞINIZ BRANŞI İŞARETLEYİNİZ";
            // 
            // ch_basket
            // 
            this.ch_basket.AutoSize = true;
            this.ch_basket.Location = new System.Drawing.Point(12, 51);
            this.ch_basket.Name = "ch_basket";
            this.ch_basket.Size = new System.Drawing.Size(92, 17);
            this.ch_basket.TabIndex = 1;
            this.ch_basket.Text = " BASKETBOL";
            this.ch_basket.UseVisualStyleBackColor = true;
            // 
            // ch_fut
            // 
            this.ch_fut.AutoSize = true;
            this.ch_fut.Location = new System.Drawing.Point(107, 51);
            this.ch_fut.Name = "ch_fut";
            this.ch_fut.Size = new System.Drawing.Size(71, 17);
            this.ch_fut.TabIndex = 1;
            this.ch_fut.Text = " FUTBOL";
            this.ch_fut.UseVisualStyleBackColor = true;
            // 
            // ch_voley
            // 
            this.ch_voley.AutoSize = true;
            this.ch_voley.Location = new System.Drawing.Point(184, 51);
            this.ch_voley.Name = "ch_voley";
            this.ch_voley.Size = new System.Drawing.Size(85, 17);
            this.ch_voley.TabIndex = 1;
            this.ch_voley.Text = " VOLEYBOL";
            this.ch_voley.UseVisualStyleBackColor = true;
            // 
            // btn_snc
            // 
            this.btn_snc.Location = new System.Drawing.Point(78, 84);
            this.btn_snc.Name = "btn_snc";
            this.btn_snc.Size = new System.Drawing.Size(97, 33);
            this.btn_snc.TabIndex = 2;
            this.btn_snc.Text = "SONUÇ";
            this.btn_snc.UseVisualStyleBackColor = true;
            this.btn_snc.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 156);
            this.Controls.Add(this.btn_snc);
            this.Controls.Add(this.ch_voley);
            this.Controls.Add(this.ch_fut);
            this.Controls.Add(this.ch_basket);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ch_basket;
        private System.Windows.Forms.CheckBox ch_fut;
        private System.Windows.Forms.CheckBox ch_voley;
        private System.Windows.Forms.Button btn_snc;
    }
}


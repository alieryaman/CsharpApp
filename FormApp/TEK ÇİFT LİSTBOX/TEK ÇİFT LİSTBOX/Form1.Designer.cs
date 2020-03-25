namespace TEK_ÇİFT_LİSTBOX
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
            this.lb_tek = new System.Windows.Forms.ListBox();
            this.lb_cift = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_tek = new System.Windows.Forms.TextBox();
            this.tx_cift = new System.Windows.Forms.TextBox();
            this.lb_tumsayılar = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_fulltoplam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_tek
            // 
            this.lb_tek.FormattingEnabled = true;
            this.lb_tek.Location = new System.Drawing.Point(40, 31);
            this.lb_tek.Name = "lb_tek";
            this.lb_tek.Size = new System.Drawing.Size(119, 381);
            this.lb_tek.TabIndex = 0;
            // 
            // lb_cift
            // 
            this.lb_cift.FormattingEnabled = true;
            this.lb_cift.Location = new System.Drawing.Point(165, 31);
            this.lb_cift.Name = "lb_cift";
            this.lb_cift.Size = new System.Drawing.Size(122, 381);
            this.lb_cift.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(148, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "SIRALA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TEKLER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÇİFTLER";
            // 
            // tx_tek
            // 
            this.tx_tek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_tek.Location = new System.Drawing.Point(49, 427);
            this.tx_tek.Name = "tx_tek";
            this.tx_tek.Size = new System.Drawing.Size(100, 23);
            this.tx_tek.TabIndex = 4;
            // 
            // tx_cift
            // 
            this.tx_cift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_cift.Location = new System.Drawing.Point(175, 427);
            this.tx_cift.Name = "tx_cift";
            this.tx_cift.Size = new System.Drawing.Size(100, 23);
            this.tx_cift.TabIndex = 5;
            // 
            // lb_tumsayılar
            // 
            this.lb_tumsayılar.FormattingEnabled = true;
            this.lb_tumsayılar.Location = new System.Drawing.Point(293, 31);
            this.lb_tumsayılar.Name = "lb_tumsayılar";
            this.lb_tumsayılar.Size = new System.Drawing.Size(122, 381);
            this.lb_tumsayılar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TÜM SAYILAR";
            // 
            // tx_fulltoplam
            // 
            this.tx_fulltoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_fulltoplam.Location = new System.Drawing.Point(303, 427);
            this.tx_fulltoplam.Name = "tx_fulltoplam";
            this.tx_fulltoplam.Size = new System.Drawing.Size(100, 23);
            this.tx_fulltoplam.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(435, 562);
            this.Controls.Add(this.tx_fulltoplam);
            this.Controls.Add(this.lb_tumsayılar);
            this.Controls.Add(this.tx_cift);
            this.Controls.Add(this.tx_tek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_cift);
            this.Controls.Add(this.lb_tek);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEK ÇİFT YAZDIRMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_tek;
        private System.Windows.Forms.ListBox lb_cift;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_tek;
        private System.Windows.Forms.TextBox tx_cift;
        private System.Windows.Forms.ListBox lb_tumsayılar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_fulltoplam;
    }
}


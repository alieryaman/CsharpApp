namespace _11._03._2015_ÖDEV
{
    partial class seçenekler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seçenekler));
            this.btn_hesap = new System.Windows.Forms.Button();
            this.btn_csharp = new System.Windows.Forms.Button();
            this.btn_not = new System.Windows.Forms.Button();
            this.btn_harf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hesap
            // 
            this.btn_hesap.BackColor = System.Drawing.Color.Transparent;
            this.btn_hesap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hesap.BackgroundImage")));
            this.btn_hesap.FlatAppearance.BorderSize = 0;
            this.btn_hesap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_hesap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_hesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hesap.Location = new System.Drawing.Point(26, 33);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(119, 101);
            this.btn_hesap.TabIndex = 0;
            this.btn_hesap.UseVisualStyleBackColor = false;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // btn_csharp
            // 
            this.btn_csharp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_csharp.BackgroundImage")));
            this.btn_csharp.FlatAppearance.BorderSize = 0;
            this.btn_csharp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_csharp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_csharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_csharp.Location = new System.Drawing.Point(26, 164);
            this.btn_csharp.Name = "btn_csharp";
            this.btn_csharp.Size = new System.Drawing.Size(119, 101);
            this.btn_csharp.TabIndex = 1;
            this.btn_csharp.UseVisualStyleBackColor = true;
            this.btn_csharp.Click += new System.EventHandler(this.btn_csharp_Click);
            // 
            // btn_not
            // 
            this.btn_not.BackColor = System.Drawing.Color.Transparent;
            this.btn_not.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_not.BackgroundImage")));
            this.btn_not.FlatAppearance.BorderSize = 0;
            this.btn_not.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_not.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_not.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_not.Location = new System.Drawing.Point(188, 33);
            this.btn_not.Name = "btn_not";
            this.btn_not.Size = new System.Drawing.Size(119, 101);
            this.btn_not.TabIndex = 2;
            this.btn_not.UseVisualStyleBackColor = false;
            this.btn_not.Click += new System.EventHandler(this.btn_not_Click);
            // 
            // btn_harf
            // 
            this.btn_harf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_harf.BackgroundImage")));
            this.btn_harf.FlatAppearance.BorderSize = 0;
            this.btn_harf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_harf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_harf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_harf.Location = new System.Drawing.Point(188, 164);
            this.btn_harf.Name = "btn_harf";
            this.btn_harf.Size = new System.Drawing.Size(119, 101);
            this.btn_harf.TabIndex = 3;
            this.btn_harf.UseVisualStyleBackColor = true;
            this.btn_harf.Click += new System.EventHandler(this.btn_harf_Click);
            // 
            // seçenekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(336, 310);
            this.Controls.Add(this.btn_harf);
            this.Controls.Add(this.btn_not);
            this.Controls.Add(this.btn_csharp);
            this.Controls.Add(this.btn_hesap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "seçenekler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEÇİMİNİZ ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hesap;
        private System.Windows.Forms.Button btn_csharp;
        private System.Windows.Forms.Button btn_not;
        private System.Windows.Forms.Button btn_harf;
    }
}
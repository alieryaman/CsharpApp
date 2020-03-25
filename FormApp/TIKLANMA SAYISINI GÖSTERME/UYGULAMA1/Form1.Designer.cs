namespace UYGULAMA1
{
    partial class frm_mesaj
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
            this.btn_tık = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tık
            // 
            this.btn_tık.FlatAppearance.BorderSize = 0;
            this.btn_tık.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tık.Location = new System.Drawing.Point(61, 73);
            this.btn_tık.Name = "btn_tık";
            this.btn_tık.Size = new System.Drawing.Size(143, 97);
            this.btn_tık.TabIndex = 0;
            this.btn_tık.Text = "MESAJ";
            this.btn_tık.UseVisualStyleBackColor = true;
            this.btn_tık.Click += new System.EventHandler(this.btn_tık_Click);
            // 
            // frm_mesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 258);
            this.Controls.Add(this.btn_tık);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_mesaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UYGULAMA1 ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tık;
    }
}


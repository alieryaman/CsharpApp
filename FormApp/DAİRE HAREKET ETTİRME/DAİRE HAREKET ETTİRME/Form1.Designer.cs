namespace DAİRE_HAREKET_ETTİRME
{
    partial class frm_ana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ana));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_sol = new System.Windows.Forms.Label();
            this.lb_sag = new System.Windows.Forms.Label();
            this.lb_alt = new System.Windows.Forms.Label();
            this.lb_ust = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAİRE_HAREKET_ETTİRME.Properties.Resources.circle_38648_640;
            this.pictureBox1.Location = new System.Drawing.Point(77, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_sol
            // 
            this.lb_sol.BackColor = System.Drawing.Color.Red;
            this.lb_sol.Location = new System.Drawing.Point(20, 13);
            this.lb_sol.Name = "lb_sol";
            this.lb_sol.Size = new System.Drawing.Size(38, 398);
            this.lb_sol.TabIndex = 1;
            // 
            // lb_sag
            // 
            this.lb_sag.BackColor = System.Drawing.Color.Red;
            this.lb_sag.Location = new System.Drawing.Point(551, 13);
            this.lb_sag.Name = "lb_sag";
            this.lb_sag.Size = new System.Drawing.Size(38, 436);
            this.lb_sag.TabIndex = 2;
            // 
            // lb_alt
            // 
            this.lb_alt.BackColor = System.Drawing.Color.Red;
            this.lb_alt.Location = new System.Drawing.Point(20, 411);
            this.lb_alt.Name = "lb_alt";
            this.lb_alt.Size = new System.Drawing.Size(534, 38);
            this.lb_alt.TabIndex = 3;
            // 
            // lb_ust
            // 
            this.lb_ust.BackColor = System.Drawing.Color.Red;
            this.lb_ust.Location = new System.Drawing.Point(55, 13);
            this.lb_ust.Name = "lb_ust";
            this.lb_ust.Size = new System.Drawing.Size(499, 38);
            this.lb_ust.TabIndex = 3;
            // 
            // frm_ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 471);
            this.Controls.Add(this.lb_ust);
            this.Controls.Add(this.lb_alt);
            this.Controls.Add(this.lb_sag);
            this.Controls.Add(this.lb_sol);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAİRE HAREKET ETTİRME";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ana_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_ana_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_sol;
        private System.Windows.Forms.Label lb_sag;
        private System.Windows.Forms.Label lb_alt;
        private System.Windows.Forms.Label lb_ust;
    }
}


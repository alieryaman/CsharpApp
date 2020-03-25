namespace C_Sharp_Kim_500_Milyar_Ister
{
    partial class Soru
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grouper1 = new CodeVendor.Controls.Grouper();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecenekD = new System.Windows.Forms.TextBox();
            this.txtSecenekC = new System.Windows.Forms.TextBox();
            this.txtSecenekB = new System.Windows.Forms.TextBox();
            this.txtSecenekA = new System.Windows.Forms.TextBox();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.btnIslem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdulMiktari = new System.Windows.Forms.Label();
            this.grouper1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grouper1
            // 
            this.grouper1.BackgroundColor = System.Drawing.Color.Firebrick;
            this.grouper1.BackgroundGradientColor = System.Drawing.Color.Salmon;
            this.grouper1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.BackwardDiagonal;
            this.grouper1.BorderColor = System.Drawing.Color.Black;
            this.grouper1.BorderThickness = 1F;
            this.grouper1.Controls.Add(this.lblOdulMiktari);
            this.grouper1.Controls.Add(this.label5);
            this.grouper1.Controls.Add(this.btnIslem);
            this.grouper1.Controls.Add(this.label4);
            this.grouper1.Controls.Add(this.label3);
            this.grouper1.Controls.Add(this.label2);
            this.grouper1.Controls.Add(this.label1);
            this.grouper1.Controls.Add(this.txtSecenekD);
            this.grouper1.Controls.Add(this.txtSecenekC);
            this.grouper1.Controls.Add(this.txtSecenekB);
            this.grouper1.Controls.Add(this.txtSecenekA);
            this.grouper1.Controls.Add(this.txtSoru);
            this.grouper1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grouper1.GroupImage = null;
            this.grouper1.GroupTitle = "SORU";
            this.grouper1.Location = new System.Drawing.Point(0, 0);
            this.grouper1.Name = "grouper1";
            this.grouper1.Padding = new System.Windows.Forms.Padding(20);
            this.grouper1.PaintGroupBox = false;
            this.grouper1.RoundCorners = 10;
            this.grouper1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper1.ShadowControl = false;
            this.grouper1.ShadowThickness = 3;
            this.grouper1.Size = new System.Drawing.Size(672, 265);
            this.grouper1.TabIndex = 0;
            this.grouper1.Click += new System.EventHandler(this.txtSecenekler_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "D-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "C-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "B-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "A-";
            // 
            // txtSecenekD
            // 
            this.txtSecenekD.Location = new System.Drawing.Point(56, 213);
            this.txtSecenekD.Multiline = true;
            this.txtSecenekD.Name = "txtSecenekD";
            this.txtSecenekD.ReadOnly = true;
            this.txtSecenekD.Size = new System.Drawing.Size(485, 20);
            this.txtSecenekD.TabIndex = 4;
            this.txtSecenekD.Click += new System.EventHandler(this.txtSecenekler_Click);
            // 
            // txtSecenekC
            // 
            this.txtSecenekC.Location = new System.Drawing.Point(56, 187);
            this.txtSecenekC.Multiline = true;
            this.txtSecenekC.Name = "txtSecenekC";
            this.txtSecenekC.ReadOnly = true;
            this.txtSecenekC.Size = new System.Drawing.Size(485, 20);
            this.txtSecenekC.TabIndex = 3;
            this.txtSecenekC.Click += new System.EventHandler(this.txtSecenekler_Click);
            // 
            // txtSecenekB
            // 
            this.txtSecenekB.Location = new System.Drawing.Point(56, 161);
            this.txtSecenekB.Multiline = true;
            this.txtSecenekB.Name = "txtSecenekB";
            this.txtSecenekB.ReadOnly = true;
            this.txtSecenekB.Size = new System.Drawing.Size(485, 20);
            this.txtSecenekB.TabIndex = 2;
            this.txtSecenekB.Click += new System.EventHandler(this.txtSecenekler_Click);
            // 
            // txtSecenekA
            // 
            this.txtSecenekA.Location = new System.Drawing.Point(56, 135);
            this.txtSecenekA.Multiline = true;
            this.txtSecenekA.Name = "txtSecenekA";
            this.txtSecenekA.ReadOnly = true;
            this.txtSecenekA.Size = new System.Drawing.Size(485, 20);
            this.txtSecenekA.TabIndex = 1;
            this.txtSecenekA.Click += new System.EventHandler(this.txtSecenekler_Click);
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(24, 36);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.ReadOnly = true;
            this.txtSoru.Size = new System.Drawing.Size(517, 80);
            this.txtSoru.TabIndex = 0;
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(574, 36);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(75, 80);
            this.btnIslem.TabIndex = 9;
            this.btnIslem.Text = "button1";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(578, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ÖDÜLÜNÜZ:";
            // 
            // lblOdulMiktari
            // 
            this.lblOdulMiktari.AutoSize = true;
            this.lblOdulMiktari.Location = new System.Drawing.Point(578, 187);
            this.lblOdulMiktari.Name = "lblOdulMiktari";
            this.lblOdulMiktari.Size = new System.Drawing.Size(13, 13);
            this.lblOdulMiktari.TabIndex = 11;
            this.lblOdulMiktari.Text = "0";
            // 
            // Soru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.grouper1);
            this.Name = "Soru";
            this.Size = new System.Drawing.Size(672, 265);
            this.grouper1.ResumeLayout(false);
            this.grouper1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CodeVendor.Controls.Grouper grouper1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecenekD;
        private System.Windows.Forms.TextBox txtSecenekC;
        private System.Windows.Forms.TextBox txtSecenekB;
        private System.Windows.Forms.TextBox txtSecenekA;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Label lblOdulMiktari;
        private System.Windows.Forms.Label label5;
    }
}

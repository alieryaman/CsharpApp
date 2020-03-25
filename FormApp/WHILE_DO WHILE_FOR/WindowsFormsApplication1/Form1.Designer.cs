namespace WindowsFormsApplication1
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
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lst_for = new System.Windows.Forms.ListBox();
            this.lst_while = new System.Windows.Forms.ListBox();
            this.lst_dowhile = new System.Windows.Forms.ListBox();
            this.btn_yazdır = new System.Windows.Forms.Button();
            this.btn_while = new System.Windows.Forms.Button();
            this.btn_dowhile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_isim
            // 
            this.txt_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isim.Location = new System.Drawing.Point(15, 12);
            this.txt_isim.Multiline = true;
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(488, 61);
            this.txt_isim.TabIndex = 0;
            // 
            // lst_for
            // 
            this.lst_for.FormattingEnabled = true;
            this.lst_for.Location = new System.Drawing.Point(13, 110);
            this.lst_for.Name = "lst_for";
            this.lst_for.Size = new System.Drawing.Size(153, 147);
            this.lst_for.TabIndex = 1;
            // 
            // lst_while
            // 
            this.lst_while.FormattingEnabled = true;
            this.lst_while.Location = new System.Drawing.Point(186, 110);
            this.lst_while.Name = "lst_while";
            this.lst_while.Size = new System.Drawing.Size(148, 147);
            this.lst_while.TabIndex = 2;
            // 
            // lst_dowhile
            // 
            this.lst_dowhile.FormattingEnabled = true;
            this.lst_dowhile.Location = new System.Drawing.Point(355, 110);
            this.lst_dowhile.Name = "lst_dowhile";
            this.lst_dowhile.Size = new System.Drawing.Size(148, 147);
            this.lst_dowhile.TabIndex = 3;
            // 
            // btn_yazdır
            // 
            this.btn_yazdır.BackColor = System.Drawing.Color.Red;
            this.btn_yazdır.FlatAppearance.BorderSize = 2;
            this.btn_yazdır.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_yazdır.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_yazdır.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_yazdır.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_yazdır.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yazdır.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_yazdır.Location = new System.Drawing.Point(41, 263);
            this.btn_yazdır.Name = "btn_yazdır";
            this.btn_yazdır.Size = new System.Drawing.Size(95, 49);
            this.btn_yazdır.TabIndex = 4;
            this.btn_yazdır.Text = "YAZDIR";
            this.btn_yazdır.UseVisualStyleBackColor = false;
            this.btn_yazdır.Click += new System.EventHandler(this.btn_yazdır_Click);
            // 
            // btn_while
            // 
            this.btn_while.BackColor = System.Drawing.Color.Red;
            this.btn_while.FlatAppearance.BorderSize = 2;
            this.btn_while.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_while.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_while.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_while.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_while.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_while.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_while.Location = new System.Drawing.Point(214, 263);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(95, 49);
            this.btn_while.TabIndex = 5;
            this.btn_while.Text = "YAZDIR";
            this.btn_while.UseVisualStyleBackColor = false;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // btn_dowhile
            // 
            this.btn_dowhile.BackColor = System.Drawing.Color.Red;
            this.btn_dowhile.FlatAppearance.BorderSize = 2;
            this.btn_dowhile.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_dowhile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_dowhile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_dowhile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dowhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dowhile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_dowhile.Location = new System.Drawing.Point(386, 263);
            this.btn_dowhile.Name = "btn_dowhile";
            this.btn_dowhile.Size = new System.Drawing.Size(95, 49);
            this.btn_dowhile.TabIndex = 6;
            this.btn_dowhile.Text = "YAZDIR";
            this.btn_dowhile.UseVisualStyleBackColor = false;
            this.btn_dowhile.Click += new System.EventHandler(this.btn_dowhile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FOR DÖNGÜSÜ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "WHILE DÖNGÜSÜ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DO WHILE DÖNGÜSÜ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(526, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dowhile);
            this.Controls.Add(this.btn_while);
            this.Controls.Add(this.btn_yazdır);
            this.Controls.Add(this.lst_dowhile);
            this.Controls.Add(this.lst_while);
            this.Controls.Add(this.lst_for);
            this.Controls.Add(this.txt_isim);
            this.Name = "Form1";
            this.Text = "DÖNGÜLER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.ListBox lst_for;
        private System.Windows.Forms.ListBox lst_while;
        private System.Windows.Forms.ListBox lst_dowhile;
        private System.Windows.Forms.Button btn_yazdır;
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Button btn_dowhile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


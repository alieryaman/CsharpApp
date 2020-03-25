namespace Hospital_Program
{
    partial class Add_Date
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
            this.components = new System.ComponentModel.Container();
            this.lstview_dates = new System.Windows.Forms.ListView();
            this.clmn_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_diagnonis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_borndate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_datetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_datestatue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpbx_patientinfos = new System.Windows.Forms.GroupBox();
            this.datetimepic_borndate = new System.Windows.Forms.DateTimePicker();
            this.lbl_borndate = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txtbx_surname = new System.Windows.Forms.TextBox();
            this.txtbx_name = new System.Windows.Forms.TextBox();
            this.txtbx_id = new System.Windows.Forms.TextBox();
            this.grpbx_dateinfos = new System.Windows.Forms.GroupBox();
            this.txtbx_diagnonis = new System.Windows.Forms.TextBox();
            this.datetimepic_datetime = new System.Windows.Forms.DateTimePicker();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.lbl_diagnonis = new System.Windows.Forms.Label();
            this.btn_date_add = new System.Windows.Forms.Button();
            this.btn_date_delete = new System.Windows.Forms.Button();
            this.btn_date_edit = new System.Windows.Forms.Button();
            this.menustrp_1 = new System.Windows.Forms.MenuStrip();
            this.strpitem_langue = new System.Windows.Forms.ToolStripMenuItem();
            this.strp_langueitem_tr = new System.Windows.Forms.ToolStripMenuItem();
            this.strp_langueitem_en = new System.Windows.Forms.ToolStripMenuItem();
            this.strpitem_date_prcss = new System.Windows.Forms.ToolStripMenuItem();
            this.item_dateprcss_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.item_dateprcss_delete_disables = new System.Windows.Forms.ToolStripMenuItem();
            this.item_dateprcss_delete_enables = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_remaining_time = new System.Windows.Forms.Label();
            this.tm_remaining_time = new System.Windows.Forms.Timer(this.components);
            this.btn_enabled = new System.Windows.Forms.Button();
            this.btn_disabled = new System.Windows.Forms.Button();
            this.grpbx_patientinfos.SuspendLayout();
            this.grpbx_dateinfos.SuspendLayout();
            this.menustrp_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstview_dates
            // 
            this.lstview_dates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmn_id,
            this.clmn_name,
            this.clmn_surname,
            this.clmn_diagnonis,
            this.clmn_borndate,
            this.clmn_datetime,
            this.clmn_datestatue});
            this.lstview_dates.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstview_dates.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstview_dates.FullRowSelect = true;
            this.lstview_dates.GridLines = true;
            this.lstview_dates.Location = new System.Drawing.Point(0, 270);
            this.lstview_dates.MultiSelect = false;
            this.lstview_dates.Name = "lstview_dates";
            this.lstview_dates.Size = new System.Drawing.Size(692, 214);
            this.lstview_dates.TabIndex = 0;
            this.lstview_dates.UseCompatibleStateImageBehavior = false;
            this.lstview_dates.View = System.Windows.Forms.View.Details;
            this.lstview_dates.Click += new System.EventHandler(this.lstview_dates_Click);
            this.lstview_dates.DoubleClick += new System.EventHandler(this.lstview_dates_DoubleClick);
            // 
            // clmn_id
            // 
            this.clmn_id.Text = "TC";
            this.clmn_id.Width = 56;
            // 
            // clmn_name
            // 
            this.clmn_name.Text = "Ad";
            this.clmn_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmn_name.Width = 89;
            // 
            // clmn_surname
            // 
            this.clmn_surname.Text = "Soyad";
            this.clmn_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmn_surname.Width = 89;
            // 
            // clmn_diagnonis
            // 
            this.clmn_diagnonis.Text = "Teşhis";
            this.clmn_diagnonis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmn_diagnonis.Width = 90;
            // 
            // clmn_borndate
            // 
            this.clmn_borndate.Text = "Doğum Tarihi";
            this.clmn_borndate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmn_borndate.Width = 106;
            // 
            // clmn_datetime
            // 
            this.clmn_datetime.Text = "Randevu Tarihi";
            this.clmn_datetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmn_datetime.Width = 150;
            // 
            // clmn_datestatue
            // 
            this.clmn_datestatue.Text = "Date Statue";
            this.clmn_datestatue.Width = 117;
            // 
            // grpbx_patientinfos
            // 
            this.grpbx_patientinfos.Controls.Add(this.datetimepic_borndate);
            this.grpbx_patientinfos.Controls.Add(this.lbl_borndate);
            this.grpbx_patientinfos.Controls.Add(this.lbl_surname);
            this.grpbx_patientinfos.Controls.Add(this.lbl_name);
            this.grpbx_patientinfos.Controls.Add(this.lbl_id);
            this.grpbx_patientinfos.Controls.Add(this.txtbx_surname);
            this.grpbx_patientinfos.Controls.Add(this.txtbx_name);
            this.grpbx_patientinfos.Controls.Add(this.txtbx_id);
            this.grpbx_patientinfos.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbx_patientinfos.Location = new System.Drawing.Point(12, 30);
            this.grpbx_patientinfos.Name = "grpbx_patientinfos";
            this.grpbx_patientinfos.Size = new System.Drawing.Size(334, 171);
            this.grpbx_patientinfos.TabIndex = 1;
            this.grpbx_patientinfos.TabStop = false;
            this.grpbx_patientinfos.Text = "Hasta Bilgileri";
            // 
            // datetimepic_borndate
            // 
            this.datetimepic_borndate.Location = new System.Drawing.Point(102, 124);
            this.datetimepic_borndate.Name = "datetimepic_borndate";
            this.datetimepic_borndate.Size = new System.Drawing.Size(133, 23);
            this.datetimepic_borndate.TabIndex = 9;
            // 
            // lbl_borndate
            // 
            this.lbl_borndate.AutoSize = true;
            this.lbl_borndate.Location = new System.Drawing.Point(6, 129);
            this.lbl_borndate.Name = "lbl_borndate";
            this.lbl_borndate.Size = new System.Drawing.Size(66, 18);
            this.lbl_borndate.TabIndex = 6;
            this.lbl_borndate.Text = "D.Tarihi :";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(6, 100);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(53, 18);
            this.lbl_surname.TabIndex = 5;
            this.lbl_surname.Text = "Soyad :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(6, 74);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(33, 18);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Ad :";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(6, 46);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(75, 18);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "TC Kimlik :";
            // 
            // txtbx_surname
            // 
            this.txtbx_surname.Location = new System.Drawing.Point(102, 95);
            this.txtbx_surname.Name = "txtbx_surname";
            this.txtbx_surname.Size = new System.Drawing.Size(133, 23);
            this.txtbx_surname.TabIndex = 2;
            // 
            // txtbx_name
            // 
            this.txtbx_name.Location = new System.Drawing.Point(102, 69);
            this.txtbx_name.Name = "txtbx_name";
            this.txtbx_name.Size = new System.Drawing.Size(133, 23);
            this.txtbx_name.TabIndex = 1;
            // 
            // txtbx_id
            // 
            this.txtbx_id.Location = new System.Drawing.Point(102, 43);
            this.txtbx_id.Name = "txtbx_id";
            this.txtbx_id.Size = new System.Drawing.Size(133, 23);
            this.txtbx_id.TabIndex = 0;
            // 
            // grpbx_dateinfos
            // 
            this.grpbx_dateinfos.Controls.Add(this.txtbx_diagnonis);
            this.grpbx_dateinfos.Controls.Add(this.datetimepic_datetime);
            this.grpbx_dateinfos.Controls.Add(this.lbl_datetime);
            this.grpbx_dateinfos.Controls.Add(this.lbl_diagnonis);
            this.grpbx_dateinfos.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbx_dateinfos.Location = new System.Drawing.Point(361, 30);
            this.grpbx_dateinfos.Name = "grpbx_dateinfos";
            this.grpbx_dateinfos.Size = new System.Drawing.Size(282, 171);
            this.grpbx_dateinfos.TabIndex = 2;
            this.grpbx_dateinfos.TabStop = false;
            this.grpbx_dateinfos.Text = "Randevu Bilgileri";
            // 
            // txtbx_diagnonis
            // 
            this.txtbx_diagnonis.Location = new System.Drawing.Point(122, 43);
            this.txtbx_diagnonis.Name = "txtbx_diagnonis";
            this.txtbx_diagnonis.Size = new System.Drawing.Size(136, 23);
            this.txtbx_diagnonis.TabIndex = 8;
            // 
            // datetimepic_datetime
            // 
            this.datetimepic_datetime.Location = new System.Drawing.Point(122, 72);
            this.datetimepic_datetime.Name = "datetimepic_datetime";
            this.datetimepic_datetime.Size = new System.Drawing.Size(136, 23);
            this.datetimepic_datetime.TabIndex = 8;
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.AutoSize = true;
            this.lbl_datetime.Location = new System.Drawing.Point(6, 74);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(110, 18);
            this.lbl_datetime.TabIndex = 7;
            this.lbl_datetime.Text = "Randevu Tarihi :";
            // 
            // lbl_diagnonis
            // 
            this.lbl_diagnonis.AutoSize = true;
            this.lbl_diagnonis.Location = new System.Drawing.Point(6, 46);
            this.lbl_diagnonis.Name = "lbl_diagnonis";
            this.lbl_diagnonis.Size = new System.Drawing.Size(55, 18);
            this.lbl_diagnonis.TabIndex = 6;
            this.lbl_diagnonis.Text = "Teşhis :";
            // 
            // btn_date_add
            // 
            this.btn_date_add.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_date_add.FlatAppearance.BorderSize = 15;
            this.btn_date_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_date_add.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_date_add.Location = new System.Drawing.Point(4, 225);
            this.btn_date_add.Name = "btn_date_add";
            this.btn_date_add.Size = new System.Drawing.Size(101, 31);
            this.btn_date_add.TabIndex = 3;
            this.btn_date_add.Text = "Randevu Ekle";
            this.btn_date_add.UseVisualStyleBackColor = false;
            this.btn_date_add.Click += new System.EventHandler(this.btn_add_date_Click);
            // 
            // btn_date_delete
            // 
            this.btn_date_delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_date_delete.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_date_delete.FlatAppearance.BorderSize = 15;
            this.btn_date_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_date_delete.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_date_delete.Location = new System.Drawing.Point(111, 225);
            this.btn_date_delete.Name = "btn_date_delete";
            this.btn_date_delete.Size = new System.Drawing.Size(107, 31);
            this.btn_date_delete.TabIndex = 4;
            this.btn_date_delete.Text = "Randevu Silme";
            this.btn_date_delete.UseVisualStyleBackColor = false;
            this.btn_date_delete.Click += new System.EventHandler(this.btn_date_delete_Click);
            // 
            // btn_date_edit
            // 
            this.btn_date_edit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_date_edit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_date_edit.FlatAppearance.BorderSize = 15;
            this.btn_date_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_date_edit.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_date_edit.Location = new System.Drawing.Point(224, 225);
            this.btn_date_edit.Name = "btn_date_edit";
            this.btn_date_edit.Size = new System.Drawing.Size(122, 31);
            this.btn_date_edit.TabIndex = 5;
            this.btn_date_edit.Text = "Randevu Düzenle";
            this.btn_date_edit.UseVisualStyleBackColor = false;
            this.btn_date_edit.Click += new System.EventHandler(this.btn_date_edit_Click);
            // 
            // menustrp_1
            // 
            this.menustrp_1.BackColor = System.Drawing.SystemColors.Control;
            this.menustrp_1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menustrp_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpitem_langue,
            this.strpitem_date_prcss});
            this.menustrp_1.Location = new System.Drawing.Point(0, 0);
            this.menustrp_1.Name = "menustrp_1";
            this.menustrp_1.Size = new System.Drawing.Size(692, 26);
            this.menustrp_1.TabIndex = 6;
            this.menustrp_1.Text = "menuStrip1";
            // 
            // strpitem_langue
            // 
            this.strpitem_langue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strp_langueitem_tr,
            this.strp_langueitem_en});
            this.strpitem_langue.Name = "strpitem_langue";
            this.strpitem_langue.Size = new System.Drawing.Size(59, 22);
            this.strpitem_langue.Text = "Langue";
            // 
            // strp_langueitem_tr
            // 
            this.strp_langueitem_tr.Name = "strp_langueitem_tr";
            this.strp_langueitem_tr.Size = new System.Drawing.Size(152, 22);
            this.strp_langueitem_tr.Text = "TR";
            this.strp_langueitem_tr.Click += new System.EventHandler(this.strp_langueitem_tr_Click);
            // 
            // strp_langueitem_en
            // 
            this.strp_langueitem_en.Name = "strp_langueitem_en";
            this.strp_langueitem_en.Size = new System.Drawing.Size(152, 22);
            this.strp_langueitem_en.Text = "EN";
            this.strp_langueitem_en.Click += new System.EventHandler(this.strp_langueitem_en_Click);
            // 
            // strpitem_date_prcss
            // 
            this.strpitem_date_prcss.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_dateprcss_delete});
            this.strpitem_date_prcss.Name = "strpitem_date_prcss";
            this.strpitem_date_prcss.Size = new System.Drawing.Size(91, 22);
            this.strpitem_date_prcss.Text = "Date Process";
            // 
            // item_dateprcss_delete
            // 
            this.item_dateprcss_delete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_dateprcss_delete_disables,
            this.item_dateprcss_delete_enables});
            this.item_dateprcss_delete.Name = "item_dateprcss_delete";
            this.item_dateprcss_delete.Size = new System.Drawing.Size(112, 22);
            this.item_dateprcss_delete.Text = "Delete";
            // 
            // item_dateprcss_delete_disables
            // 
            this.item_dateprcss_delete_disables.Name = "item_dateprcss_delete_disables";
            this.item_dateprcss_delete_disables.Size = new System.Drawing.Size(119, 22);
            this.item_dateprcss_delete_disables.Text = "Disables";
            this.item_dateprcss_delete_disables.Click += new System.EventHandler(this.item_dateprcss_delete_disables_Click);
            // 
            // item_dateprcss_delete_enables
            // 
            this.item_dateprcss_delete_enables.Name = "item_dateprcss_delete_enables";
            this.item_dateprcss_delete_enables.Size = new System.Drawing.Size(119, 22);
            this.item_dateprcss_delete_enables.Text = "Enables";
            this.item_dateprcss_delete_enables.Click += new System.EventHandler(this.item_dateprcss_delete_enables_Click);
            // 
            // lbl_remaining_time
            // 
            this.lbl_remaining_time.AutoSize = true;
            this.lbl_remaining_time.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_remaining_time.Location = new System.Drawing.Point(405, 212);
            this.lbl_remaining_time.Name = "lbl_remaining_time";
            this.lbl_remaining_time.Size = new System.Drawing.Size(111, 18);
            this.lbl_remaining_time.TabIndex = 7;
            this.lbl_remaining_time.Text = "Remaining Time :";
            // 
            // tm_remaining_time
            // 
            this.tm_remaining_time.Interval = 1;
            this.tm_remaining_time.Tick += new System.EventHandler(this.tm_remaining_time_Tick);
            // 
            // btn_enabled
            // 
            this.btn_enabled.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_enabled.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_enabled.FlatAppearance.BorderSize = 15;
            this.btn_enabled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enabled.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_enabled.Location = new System.Drawing.Point(405, 233);
            this.btn_enabled.Name = "btn_enabled";
            this.btn_enabled.Size = new System.Drawing.Size(57, 25);
            this.btn_enabled.TabIndex = 8;
            this.btn_enabled.Text = "Aktif";
            this.btn_enabled.UseVisualStyleBackColor = false;
            this.btn_enabled.Click += new System.EventHandler(this.btn_enabled_Click);
            // 
            // btn_disabled
            // 
            this.btn_disabled.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_disabled.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_disabled.FlatAppearance.BorderSize = 15;
            this.btn_disabled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_disabled.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_disabled.Location = new System.Drawing.Point(468, 233);
            this.btn_disabled.Name = "btn_disabled";
            this.btn_disabled.Size = new System.Drawing.Size(57, 25);
            this.btn_disabled.TabIndex = 9;
            this.btn_disabled.Text = "Deaktif";
            this.btn_disabled.UseVisualStyleBackColor = false;
            this.btn_disabled.Click += new System.EventHandler(this.btn_disabled_Click);
            // 
            // Add_Date
            // 
            this.AcceptButton = this.btn_date_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_date_delete;
            this.ClientSize = new System.Drawing.Size(692, 484);
            this.Controls.Add(this.btn_disabled);
            this.Controls.Add(this.btn_enabled);
            this.Controls.Add(this.lbl_remaining_time);
            this.Controls.Add(this.btn_date_edit);
            this.Controls.Add(this.btn_date_delete);
            this.Controls.Add(this.btn_date_add);
            this.Controls.Add(this.grpbx_dateinfos);
            this.Controls.Add(this.grpbx_patientinfos);
            this.Controls.Add(this.lstview_dates);
            this.Controls.Add(this.menustrp_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menustrp_1;
            this.Name = "Add_Date";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Date";
            this.Load += new System.EventHandler(this.Add_Date_Load);
            this.grpbx_patientinfos.ResumeLayout(false);
            this.grpbx_patientinfos.PerformLayout();
            this.grpbx_dateinfos.ResumeLayout(false);
            this.grpbx_dateinfos.PerformLayout();
            this.menustrp_1.ResumeLayout(false);
            this.menustrp_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstview_dates;
        private System.Windows.Forms.ColumnHeader clmn_id;
        private System.Windows.Forms.ColumnHeader clmn_name;
        private System.Windows.Forms.ColumnHeader clmn_surname;
        private System.Windows.Forms.ColumnHeader clmn_diagnonis;
        private System.Windows.Forms.ColumnHeader clmn_borndate;
        private System.Windows.Forms.ColumnHeader clmn_datetime;
        private System.Windows.Forms.GroupBox grpbx_patientinfos;
        private System.Windows.Forms.Label lbl_borndate;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txtbx_surname;
        private System.Windows.Forms.TextBox txtbx_name;
        private System.Windows.Forms.TextBox txtbx_id;
        private System.Windows.Forms.GroupBox grpbx_dateinfos;
        private System.Windows.Forms.TextBox txtbx_diagnonis;
        private System.Windows.Forms.DateTimePicker datetimepic_datetime;
        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.Label lbl_diagnonis;
        private System.Windows.Forms.Button btn_date_add;
        private System.Windows.Forms.DateTimePicker datetimepic_borndate;
        private System.Windows.Forms.Button btn_date_delete;
        private System.Windows.Forms.Button btn_date_edit;
        private System.Windows.Forms.MenuStrip menustrp_1;
        private System.Windows.Forms.ToolStripMenuItem strpitem_langue;
        private System.Windows.Forms.ToolStripMenuItem strp_langueitem_tr;
        private System.Windows.Forms.ToolStripMenuItem strp_langueitem_en;
        private System.Windows.Forms.Label lbl_remaining_time;
        private System.Windows.Forms.Timer tm_remaining_time;
        private System.Windows.Forms.ColumnHeader clmn_datestatue;
        private System.Windows.Forms.Button btn_enabled;
        private System.Windows.Forms.Button btn_disabled;
        private System.Windows.Forms.ToolStripMenuItem strpitem_date_prcss;
        private System.Windows.Forms.ToolStripMenuItem item_dateprcss_delete;
        private System.Windows.Forms.ToolStripMenuItem item_dateprcss_delete_disables;
        private System.Windows.Forms.ToolStripMenuItem item_dateprcss_delete_enables;
    }
}
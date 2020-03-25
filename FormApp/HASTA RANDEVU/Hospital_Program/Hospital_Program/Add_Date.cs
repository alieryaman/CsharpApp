using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Program
{
    public partial class Add_Date : Form
    {
        public Add_Date()
        {
            InitializeComponent();
        }
        Langues_EN lang_en = new Langues_EN();
        Langues_TR lang_tr=new Langues_TR();
        public string current_langue = "";
        public void M_Langue(string lang)
        {
            if (lang=="tr")
            {
                current_langue = "tr";
                // Labels
                lbl_id.Text = lang_tr.id;
                lbl_name.Text = lang_tr.name;
                lbl_surname.Text = lang_tr.surname;
                lbl_borndate.Text = lang_tr.born_date;
                lbl_datetime.Text = lang_tr.date_time;
                lbl_diagnonis.Text = lang_tr.diagnonis;

                // Buttons
                btn_date_add.Text = lang_tr.date_add;
                btn_date_delete.Text = lang_tr.date_delete;
                btn_date_edit.Text = lang_tr.date_edit;
                btn_enabled.Text = lang_tr.stat_enabled;
                btn_disabled.Text = lang_tr.stat_disabled;

                // Listview Columns
                lstview_dates.Columns[0].Text = lang_tr.id;
                lstview_dates.Columns[1].Text = lang_tr.name;
                lstview_dates.Columns[2].Text = lang_tr.surname;
                lstview_dates.Columns[3].Text = lang_tr.diagnonis;
                lstview_dates.Columns[4].Text = lang_tr.born_date;
                lstview_dates.Columns[5].Text = lang_tr.date_time;
                lstview_dates.Columns[6].Text = lang_tr.date_statue;

                // GroupBoxs
                grpbx_dateinfos.Text = lang_tr.date_info;
                grpbx_patientinfos.Text = lang_tr.patient_info;

                // MenuStrip
                strpitem_langue.Text = lang_tr.langues;
                strpitem_date_prcss.Text = lang_tr.date_process;
                item_dateprcss_delete.Text = lang_tr.delete;
                item_dateprcss_delete_disables.Text = lang_tr.disables;
                item_dateprcss_delete_enables.Text = lang_tr.enables;

                for (int i = 0; i < lstview_dates.Items.Count; i++)
                {
                    if (lstview_dates.Items[i].SubItems[6].Text==lang_en.stat_enabled)
                    {
                        lstview_dates.Items[i].SubItems[6].Text = lang_tr.stat_enabled;
                    }
                    if (lstview_dates.Items[i].SubItems[6].Text == lang_en.stat_disabled)
                    {
                        lstview_dates.Items[i].SubItems[6].Text = lang_tr.stat_disabled;
                    }
                }
            }
            if (lang == "en")
            {
                current_langue = "en";
                // Labels
                lbl_id.Text = lang_en.id;
                lbl_name.Text = lang_en.name;
                lbl_surname.Text = lang_en.surname;
                lbl_borndate.Text = lang_en.born_date;
                lbl_datetime.Text = lang_en.date_time;
                lbl_diagnonis.Text = lang_en.diagnonis;
                

                // Buttons
                btn_date_add.Text = lang_en.date_add;
                btn_date_delete.Text = lang_en.date_delete;
                btn_date_edit.Text = lang_en.date_edit;
                btn_enabled.Text = lang_en.stat_enabled;
                btn_disabled.Text = lang_en.stat_disabled;

                // Listview Columns
                lstview_dates.Columns[0].Text = lang_en.id;
                lstview_dates.Columns[1].Text = lang_en.name;
                lstview_dates.Columns[2].Text = lang_en.surname;
                lstview_dates.Columns[3].Text = lang_en.diagnonis;
                lstview_dates.Columns[4].Text = lang_en.born_date;
                lstview_dates.Columns[5].Text = lang_en.date_time;
                lstview_dates.Columns[6].Text = lang_en.date_statue;

                // GroupBoxs
                grpbx_dateinfos.Text = lang_en.date_info;
                grpbx_patientinfos.Text = lang_en.patient_info;

                // MenuStrip
                strpitem_langue.Text = lang_en.langues;
                strpitem_date_prcss.Text = lang_en.date_process;
                item_dateprcss_delete.Text = lang_en.delete;
                item_dateprcss_delete_disables.Text = lang_en.disables;
                item_dateprcss_delete_enables.Text = lang_en.enables;

                // Date State in Listview
                for (int i = 0; i < lstview_dates.Items.Count; i++)
                {
                    if (lstview_dates.Items[i].SubItems[6].Text == lang_tr.stat_enabled)
                    {
                        lstview_dates.Items[i].SubItems[6].Text = lang_en.stat_enabled;
                    }
                    if (lstview_dates.Items[i].SubItems[6].Text == lang_tr.stat_disabled)
                    {
                        lstview_dates.Items[i].SubItems[6].Text = lang_en.stat_disabled;
                    }
                }
            }
        }

        public void M_DateAdding()
        {
            try
            {
                ListViewItem nw_lstview = lstview_dates.Items.Add(txtbx_id.Text);
                nw_lstview.SubItems.Add(txtbx_name.Text);
                nw_lstview.SubItems.Add(txtbx_surname.Text);
                nw_lstview.SubItems.Add(txtbx_diagnonis.Text);
                nw_lstview.SubItems.Add(datetimepic_borndate.Text);
                nw_lstview.SubItems.Add(datetimepic_datetime.Text);
                if (current_langue == "tr")
                {
                    nw_lstview.SubItems.Add(lang_tr.stat_enabled);
                }
                if (current_langue == "en")
                {
                    nw_lstview.SubItems.Add(lang_en.stat_enabled);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                txtbx_id.Text=null;
                txtbx_name.Text = null;
                txtbx_surname.Text= null;
                txtbx_diagnonis.Text = null;
                datetimepic_borndate.Text = null;
                datetimepic_datetime.Text = null;
            }
            
        }

        public void M_DateStateChanging(int indx,string prcss)
        {
            if (prcss == "Enable")
            {
                if (current_langue == "tr")
                {
                    lstview_dates.Items[indx].SubItems[6].Text = lang_tr.stat_enabled;
                    lstview_dates.Items[indx].BackColor = Color.White;
                }
                if (current_langue == "en")
                {
                    lstview_dates.Items[indx].SubItems[6].Text = lang_en.stat_enabled;
                    lstview_dates.Items[indx].BackColor = Color.White;
                }
            }
            if (prcss == "Disable")
            {
                if (current_langue == "tr")
                {
                    lstview_dates.Items[indx].SubItems[6].Text = lang_tr.stat_disabled;
                    lstview_dates.Items[indx].BackColor = Color.Red;
                }
                if (current_langue == "en")
                {
                    lstview_dates.Items[indx].SubItems[6].Text = lang_en.stat_disabled;
                    lstview_dates.Items[indx].BackColor = Color.Red;
                }
            }
        }

        public void M_DateDeleting(int indx)
        {
            lstview_dates.Items.RemoveAt(indx);
        }

        public void M_AllDateDeleting(string prcss)
        {
            if (prcss == "Enables")
            {
                for (int i = 0; i < lstview_dates.Items.Count; i++)
                {
                    if (lstview_dates.Items[i].SubItems[6].Text==lang_tr.stat_enabled || lstview_dates.Items[i].SubItems[6].Text==lang_en.stat_enabled)
                    {
                        lstview_dates.Items.RemoveAt(i);
                    }
                }
            }
            if (prcss == "Disables")
            {
                for (int i = 0; i < lstview_dates.Items.Count; i++)
                {
                    if (lstview_dates.Items[i].SubItems[6].Text == lang_tr.stat_disabled || lstview_dates.Items[i].SubItems[6].Text == lang_en.stat_disabled)
                    {
                        lstview_dates.Items.RemoveAt(i);
                    }
                }
            }
        }
        public string M_DateRemaining(int indx)
        {
            var date_user = DateTime.Parse(lstview_dates.Items[indx].SubItems[5].Text);
            var date_now = DateTime.Now;
            if (DateTime.Compare(date_user, date_now) < 0)
            {
                tm_remaining_time.Stop();
                return "Out of time";
            }
            else
            {
                var r_day= date_user.Subtract(date_now).Days;
                var r_hour=date_user.Subtract(date_now).Hours;
                var r_minute = date_user.Subtract(date_now).Minutes;
                var r_second = date_user.Subtract(date_now).Seconds;
                var r_millisecond = date_user.Subtract(date_now).Milliseconds;
                var result = r_day + " day " + r_hour + ":" + r_minute + ":" + r_second + ":"+r_millisecond;
                return result;
                //KEEP CALM AND WRİTE CODE :)
            }
        }

        public void M_DateEditing(int indx,string prcss)
        {
            ListViewItem nw_item = lstview_dates.Items[indx];
            if (prcss=="Fill")
            {
                txtbx_id.Text = nw_item.Text;
                txtbx_name.Text = nw_item.SubItems[1].Text;
                txtbx_surname.Text = nw_item.SubItems[2].Text;
                txtbx_diagnonis.Text = nw_item.SubItems[3].Text;
                datetimepic_borndate.Text = nw_item.SubItems[4].Text;
                datetimepic_datetime.Text = nw_item.SubItems[5].Text;
            }
            if (prcss == "Save")
            {
                if (txtbx_id.Text != null || txtbx_name.Text != null || txtbx_surname.Text != null || txtbx_diagnonis.Text != null || txtbx_id.Text != "" || txtbx_name.Text != "" || txtbx_surname.Text != "" || txtbx_diagnonis.Text != "")
                {
                    nw_item.Text = txtbx_id.Text;
                    nw_item.SubItems[1].Text = txtbx_name.Text;
                    nw_item.SubItems[2].Text = txtbx_surname.Text;
                    nw_item.SubItems[3].Text = txtbx_diagnonis.Text;
                    nw_item.SubItems[4].Text = datetimepic_borndate.Text;
                    nw_item.SubItems[5].Text = datetimepic_datetime.Text;
                }
                else
                {
                    MessageBox.Show("Please, first choose date", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_add_date_Click(object sender, EventArgs e)
        {
            M_DateAdding();
        }

        private void lstview_dates_Click(object sender, EventArgs e)
        {
            tm_remaining_time.Start();
        }

        private void btn_date_delete_Click(object sender, EventArgs e)
        {
            try
            {
                M_DateDeleting(lstview_dates.SelectedIndices[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose date", "Error",MessageBoxButtons.OK);
            }
        }

        private void btn_date_edit_Click(object sender, EventArgs e)
        {
            try
            {
                M_DateEditing(lstview_dates.SelectedIndices[0], "Save");
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose date", "Error", MessageBoxButtons.OK);
            }
           
        }

        private void strp_langueitem_tr_Click(object sender, EventArgs e)
        {
            M_Langue("tr");
        }

        private void strp_langueitem_en_Click(object sender, EventArgs e)
        {
            M_Langue("en");
        }

        private void Add_Date_Load(object sender, EventArgs e)
        {
            M_Langue("en");
        }

        private void lstview_dates_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                M_DateEditing(lstview_dates.SelectedIndices[0], "Fill");
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose date", "Error", MessageBoxButtons.OK);
            }
        }

        private void tm_remaining_time_Tick(object sender, EventArgs e)
        {
            try
            {
                lbl_remaining_time.Text = "Remaining Time : " + M_DateRemaining(lstview_dates.SelectedIndices[0]);
            }
            catch (Exception)
            {
                lbl_remaining_time.Text = "Remaining Time : N/A (Please choose date)";
                tm_remaining_time.Stop();
            }
            
        }

        private void btn_enabled_Click(object sender, EventArgs e)
        {
            try
            {
                M_DateStateChanging(lstview_dates.SelectedIndices[0], "Enable");
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose date", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_disabled_Click(object sender, EventArgs e)
        {
            try
            {
                M_DateStateChanging(lstview_dates.SelectedIndices[0], "Disable");
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose date", "Error", MessageBoxButtons.OK);
            }
        }

        private void item_dateprcss_delete_enables_Click(object sender, EventArgs e)
        {
            M_AllDateDeleting("Enables");
        }

        private void item_dateprcss_delete_disables_Click(object sender, EventArgs e)
        {
            M_AllDateDeleting("Disables");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace ÖRNEKDERS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ACCES BAĞLANTISI İÇİN;
            database verim = new database();
            OleDbConnection accesbaglanti = verim.AccesBaglanti();
            //accesbaglanti.Open();

            //SQL BAĞLANTISI İÇİN;
            database verim2 = new database();
            SqlConnection sqlbaglanti = verim2.SqlBaglanti();
            //sqlbaglanti.Open();

            //EXCEL BAĞLANTISI İÇİN;
            database verim3 = new database();
            OleDbConnection excelbaglanti = verim3.ExcelBaglanti();
            //excelbaglanti.Open();

            //CONFIG İÇİN;
            string saat = ConfigurationManager.AppSettings["saat"];
        }
    }
}

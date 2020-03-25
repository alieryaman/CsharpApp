using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ÖRNEKDERS
{
    //VERİTTABANI BAĞLANTISI KURAR;
    class database
    {
        //ACCES İÇİN;
        public OleDbConnection AccesBaglanti()
        {
          OleDbConnection acCon = new OleDbConnection();
          acCon.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ornek.accdb;Jet OLEDB:Database Password=12345;";
          return acCon;
        }

        //SQL İÇİN;
        public SqlConnection SqlBaglanti()
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Server = .; Database = ornek; Trusted_Connection = True;";
            return sqlCon;
        }

       //EXCEL İÇİN;
        public OleDbConnection ExcelBaglanti()
        {
            OleDbConnection exCon = new OleDbConnection();
            exCon.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\myFolder\myExcel2007file.xlsx;Extended Properties=Excel 12.0 Xml;HDR=YES;";
            return exCon;
        }
    }
}

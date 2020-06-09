using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplikasi01
{
   public class Table
    {
       private string namaTable, namaDataBase;
       private DataTable dt;
       private BindingSource bs;

       public Table(String namaTable, String namaDataBase)
       {
           this.namaTable = namaTable;
           this.namaDataBase = namaDataBase;
           this.dt = new DataTable();
           this.bs = new BindingSource();
           isiDataTable();
           this.bs.DataSource = this.dt;
       }
       public void cari(String field, String kataKunci)
       {
           int noBaris = this.bs.Find(field, kataKunci);
           if (noBaris >= 0)
               this.bs.Position = noBaris;
           else
               MessageBox.Show(kataKunci + "not found!!", "Sorry", 
                   MessageBoxButtons.OK, MessageBoxIcon.Hand);
       }
       public bool sudahAda(String kolom, String nilai) 
       {
           SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder(); //4
           strCon.DataSource = ".\\SQLEXPRESS";//UNTUK mengetahui nama data base yang ada di pc
           strCon.InitialCatalog = this.namaDataBase;//untuk mengetahui nama data best yang ada di program sqlexpres yang ada di pc
           strCon.IntegratedSecurity = true;//untuk jika meggunakan pasword dapat langsung masuk.
           SqlConnection kon = new SqlConnection(strCon.ToString()); //Klik kanan resolve (3)
           kon.Open();//11
           SqlCommand cmd = new SqlCommand("SELECT * From " + this.namaTable + 
               " WHERE " + kolom + "='" + nilai + "'", kon); //8
           SqlDataReader dr = cmd.ExecuteReader();
           return dr.HasRows;
       }

       private void isiDataTable()
       {
           SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder(); //4
           strCon.DataSource = ".\\SQLEXPRESS";//UNTUK mengetahui nama data base yang ada di pc
           strCon.InitialCatalog = this.namaDataBase;//untuk mengetahui nama data best yang ada di program sqlexpres yang ada di pc
           strCon.IntegratedSecurity = true;//untuk jika meggunakan pasword dapat langsung masuk.
           SqlConnection kon = new SqlConnection(strCon.ToString()); //Klik kanan resolve (3)
           kon.Open();//11
           SqlCommand cmd = new SqlCommand("SELECT * From " + this.namaTable, kon); //8
           SqlDataAdapter da = new SqlDataAdapter(cmd);//9
           this.dt.Clear();
           da.Fill(this.dt);//10
           kon.Close();//12
       }

       public BindingSource getBs()
       {
           return this.bs;
       }

       public void eksekusiSQL(String sqlstr)
       {
           SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder(); //4
           strCon.DataSource = ".\\SQLEXPRESS";//UNTUK mengetahui nama data base yang ada di pc
           strCon.InitialCatalog = this.namaDataBase;//untuk mengetahui nama data best yang ada di program sqlexpres yang ada di pc
           strCon.IntegratedSecurity = true;//untuk jika meggunakan pasword dapat langsung masuk.
           SqlConnection kon = new SqlConnection(strCon.ToString()); //Klik kanan resolve (3)
           kon.Open();
           SqlCommand cmd = new SqlCommand(sqlstr, kon);
           cmd.ExecuteNonQuery();
           kon.Close();
           isiDataTable();
       }
    }
}

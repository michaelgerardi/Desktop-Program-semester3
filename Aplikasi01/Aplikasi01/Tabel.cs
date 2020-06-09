using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi01
{
    public class Tabel
    {
        private String namaTabel;
        private String namaDatabase;
        private DataTable dt;
        private BindingSource bs;



        public Tabel(String namaTabel, String namaDatabase)
        {
            this.namaTabel = namaTabel;
            this.namaDatabase = namaDatabase;
            this.dt = new DataTable();
            this.bs = new BindingSource();
            isiDataTabel();
            this.bs.DataSource = this.dt;
        }

        public void cari(String field, String kataKunci)
        {
            int noBaris = this.bs.Find(field, kataKunci);
            if (noBaris >= 0)
                this.bs.Position = noBaris;
            else
                MessageBox.Show(kataKunci + " is not found!", "Sorry", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
        }

        public bool sudahAda(String kolom, String nilai)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = this.namaDatabase;
            strCon.IntegratedSecurity = true;
            SqlConnection kon = new SqlConnection(strCon.ToString());
            kon.Open();
            SqlCommand cmd = new SqlCommand("Select * from " + this.namaTabel +
                " WHERE " + kolom + "='" + nilai + "'", kon);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr.HasRows;
        }

        public bool bolehUpdate(String kolom, String nilai, String nilaiLama)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = this.namaDatabase;
            strCon.IntegratedSecurity = true;
            SqlConnection kon = new SqlConnection(strCon.ToString());
            kon.Open();
            SqlCommand cmd = new SqlCommand("Select * from " + this.namaTabel +
                " WHERE " + kolom + "='" + nilai + "' AND " +
                kolom + "<> '" + nilaiLama + "'", kon);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr.HasRows;
        }


        private void isiDataTabel(){
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = this.namaDatabase;
            strCon.IntegratedSecurity = true;
            SqlConnection kon = new SqlConnection(strCon.ToString());
            kon.Open();
            SqlCommand cmd = new SqlCommand("Select * from " + this.namaTabel, kon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            this.dt.Clear();// Dikosongi dulu 
            da.Fill(this.dt);
            kon.Close();
        }

        public BindingSource getBs()
        {
            return this.bs;
        }

        public void eksekusiSQL(String sqlStr)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = this.namaDatabase;
            strCon.IntegratedSecurity = true;
            SqlConnection kon = new SqlConnection(strCon.ToString());
            kon.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, kon);
            cmd.ExecuteNonQuery();
            isiDataTabel();
            kon.Close();
        }
        public String eksekusiSQL_GETID(String sqlStr)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = this.namaDatabase;
            strCon.IntegratedSecurity = true;
            SqlConnection kon = new SqlConnection(strCon.ToString());
            kon.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, kon);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(" select @@identity", kon);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            String nomornotabaru = dr.GetValue(0).ToString();
            kon.Close();
            isiDataTabel();
            return nomornotabaru;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi01
{
    public partial class FormMatakuliah : Form
    {
        public FormMatakuliah()
        {
            InitializeComponent();
           /* INI PERCOBAAN MEMBUAT DATA DIMASUKKAN DATATABLE :
            * this.dt.Columns.Add("kodeMK", typeof(String));
            this.dt.Columns.Add("namaMataKuliah", typeof(String));
            this.dt.Columns.Add("sks", typeof(int));
            this.dt.Rows.Add("SI1032", "Dasar-Dasar Pemrograman", 3);
            this.dt.Rows.Add("SI1033", "Aplikasi Berbasis Desktop", 3);
            this.dt.Rows.Add("SI1035", "Algoritma dan Struktur Data", 3);*/
            ambilData();
            dgvMataKuliah.DataSource = this.dt;
        }
        DataTable dt = new DataTable(); //<-- Struktur Data

        void ambilData() // koneksi ke database
        {
            String strConn = "Data Source=.\\SQLEXPRESS;Initial Catalog=akademik;Integrated Security=true";
            SqlConnection con;
            con = new SqlConnection(strConn);// 1. Buat objek koneksi
            con.Open();
            //2. Tulis querynya dan alamatnya
            SqlCommand cmd = new SqlCommand("SELECT * FROM matakuliah", con);
            //3. Siapkan DataAdapter untuk mengkonversi tipe data di Database ke DataTable
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //4. Mulai memindahkan data dari Database Server ke Client (DataTable)
            da.Fill(dt);
            con.Close();
        }
    }
}

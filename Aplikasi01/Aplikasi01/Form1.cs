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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //INI PERCOBAAN MANUALLL !! DATA DIMASUKKAN DATATABLE : 
            //------------------------------
            //this.dt.Columns.Add("kodeMK", typeof(string));
            //this.dt.Columns.Add("namaMataKuliah", typeof(string));
            //this.dt.Columns.Add("sks", typeof(int));
            //this.dt.Rows.Add("SI1032", "Dasar -Dasar Pemrograman", 3);
            //this.dt.Rows.Add("SI1033", "Aplikasi Berbasis Desktop", 3);
            //this.dt.Rows.Add("SI1035", "Algoritma Struktur Data", 3);
            //------------------------------
            ambilData();
            dgvMataKuliah.DataSource = this.dt;
        }
        DataTable dt = new DataTable(); //<-- Struktur Data

        void ambilData()
        {
            string strConn = "Data Source=.\\SQLEXPRESS;Initial Catalog=akademik;Integrated Security=true;";
            SqlConnection con;
            con = new SqlConnection(strConn);//<-- Buat Objek Koneksi
            con.Open();
            //<-- Tulis Permintaan dan Alamatnya 
            SqlCommand cmd = new SqlCommand("SELECT * FROM matakuliah", con);
            //<-- Siapkan DataAdapter untuk mengkonversi tipe tipe data di Database ke 
            // DataTable
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd; // <-- seperti di buku
            //<-- Mulai memindahkan data dari Database Server ke Client(DataTable)
            da.Fill(dt);
            con.Close();
        }
    }
}

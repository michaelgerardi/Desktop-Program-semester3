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
    public partial class FormBarang : Form
    {
        public FormBarang()
        {
            InitializeComponent();
            isiTabel();
            bs.DataSource = dtBarang;
            bind();
            dgvBarang.DataSource = bs;
        }
        DataTable dtBarang = new DataTable();
        BindingSource bs = new BindingSource();

        void bind() 
        {
            txtKodeBarang.DataBindings.Add("Text", bs, "kodeBarang");
            txtNamaBarang.DataBindings.Add("Text", bs, "namaBarang");
            txtHargaBeli.DataBindings.Add("Text", bs, "hargaBeli");
            txtHargaJual.DataBindings.Add("Text", bs, "hargaJual");
            txtStok.DataBindings.Add("Text", bs, "stok");
            txtSatuan.DataBindings.Add("Text", bs, "satuan");

        }
        void isiTabel()
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "inventory";
            strCon.IntegratedSecurity = true;
            SqlConnection kon = new SqlConnection(strCon.ToString());
            kon.Open();
            SqlCommand cmd = new SqlCommand("Select * from barang", kon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(this.dtBarang);
            kon.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

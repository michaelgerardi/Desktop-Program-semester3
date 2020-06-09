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
    public partial class Barang : Form
    {
        bool baru;
        string kodeLama;

        void buka()
        {
            unBind();
            txtKodeBarang.Enabled = true;
            txtNamaBarang.Enabled = true;
            txtHargaBeli.Enabled = true;
            txtHargaJual.Enabled = true;
            txtStok.Enabled = true;
            txtSatuan.Enabled = true;
            txtKodeBarang.Focus(); //<-- kursor pindah di sini
            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEnd.Enabled = false;
            btnPrint.Enabled = false;
            btnFind.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Visible = true; // tombol save tampak
            btnUndo.Visible = true; // tombol undo tampak
            btnClose.Enabled = false;
        }

        void tutup()
        {
            bind();
            txtKodeBarang.Enabled = false;
            txtNamaBarang.Enabled = false;
            txtHargaBeli.Enabled = false;
            txtHargaJual.Enabled = false;
            txtStok.Enabled = false;
            txtSatuan.Enabled = false;
            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnEnd.Enabled = true;
            btnPrint.Enabled = true;
            btnFind.Enabled = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Visible = false; // tombol save sembunyi
            btnUndo.Visible = false; // tombol undo sembunyi
            btnClose.Enabled = true;
        }

        public Barang()
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

        void unBind()
        {
            txtKodeBarang.DataBindings.Clear();
            txtNamaBarang.DataBindings.Clear();
            txtHargaBeli.DataBindings.Clear();
            txtHargaJual.DataBindings.Clear();
            txtStok.DataBindings.Clear();
            txtSatuan.DataBindings.Clear();
        }

        void isiTabel()
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "inventory";
            strCon.IntegratedSecurity = true;
            SqlConnection kon = new SqlConnection(strCon.ToString());
            kon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM barang", kon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            this.dtBarang.Clear(); // dikosongi dulu
            da.Fill(this.dtBarang);
            kon.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            buka();
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtHargaBeli.Text = "0";
            txtHargaJual.Text = "0";
            txtStok.Text = "0";
            txtSatuan.Text = "";
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }


        private void btnUndo_Click(object sender, EventArgs e)
        {
            tutup();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sqlStr, kode, nama, beli, jual, stok, satuan;
            kode = txtKodeBarang.Text;
            nama = txtNamaBarang.Text;
            beli = txtHargaBeli.Text;
            jual = txtHargaJual.Text;
            stok = txtStok.Text;
            satuan = txtSatuan.Text;
            if (baru)
            {
            sqlStr = "INSERT INTO barang VALUES('{0}','{1}','{2}','{3}','{4}','{5}')";
            sqlStr = String.Format(sqlStr, kode, nama, beli, jual, stok, satuan);
            }
            else
            {
                sqlStr ="UPDATE barang SET kodebarang='{0}', namabarang='{1}', hargabeli='{2}',";
                sqlStr += "hargajual ='{3}', stok='{4}', satuan='{5}' WHERE kodebarang='{6}'";
                sqlStr = String.Format(sqlStr, kode, nama, beli, jual, stok, satuan, kodeLama);
            }

            // MessageBox.Show(sqlStr); //untuk ngecek apakah perintah telah benar
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "inventory";
            strCon.IntegratedSecurity = true;
            SqlConnection kon = new SqlConnection(strCon.ToString());
            kon.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, kon);
            cmd.ExecuteNonQuery();
            kon.Close();
            isiTabel(); // DataTable diisi ulang diambilkan dari database server

            tutup();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buka();
            baru = false;
            kodeLama = txtKodeBarang.Text;
        
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult jwb;
            jwb = MessageBox.Show("Yakin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(jwb==DialogResult.Yes)
            {
                String kodeBarangnya, sqlStr;
                kodeBarangnya = txtKodeBarang.Text;
                sqlStr = "DELETE FROM barang WHERE kodebarang='{0}'";
                sqlStr = String.Format(sqlStr, kodeBarangnya);
                SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
                strCon.DataSource = ".\\SQLEXPRESS";
                strCon.InitialCatalog = "inventory";
                strCon.IntegratedSecurity = true;
                SqlConnection kon = new SqlConnection(strCon.ToString());
                kon.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, kon);
                cmd.ExecuteNonQuery();
                kon.Close();
                isiTabel();
                MessageBox.Show("Sudah dihapus");
            }
            else
            {
                MessageBox.Show("Batal hapus!");
            }
        }
        
    }
}

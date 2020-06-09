using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplikasi01
{
    public partial class FormTabelDosen : Form
    {
        public FormTabelDosen()
        {
            InitializeComponent();
            dgvDosen.DataSource = dosen.getBs();
            tutup();
        }
        Tabel dosen = new Tabel("dosen", "akademik");
        bool baru;
        String idLama;

        void bind()
        {
            txtNIK.DataBindings.Add("Text", dosen.getBs(), "nik");
            txtNamaDosen.DataBindings.Add("Text", dosen.getBs(), "nama_dosen");
            txtAlamat.DataBindings.Add("Text", dosen.getBs(), "alamat");
            txtKota.DataBindings.Add("Text", dosen.getBs(), "kota");
        }

        void unBind()
        {
            txtNIK.DataBindings.Clear();
            txtNamaDosen.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            txtKota.DataBindings.Clear();
        }
        void buka()
        {
            unBind();
            txtNIK.Enabled = true;
            txtNamaDosen.Enabled = true;
            txtAlamat.Enabled = true;
            txtKota.Enabled = true;
            txtNIK.Focus(); //<-- kursor pindah di sini
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
            txtNIK.Enabled = false;
            txtNamaDosen.Enabled = false;
            txtAlamat.Enabled = false;
            txtKota.Enabled = false;
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
        private void btnNew_Click(object sender, EventArgs e)
        {
            buka();
            txtNIK.Text = "";
            txtNamaDosen.Text = "";
            txtAlamat.Text = "";
            txtKota.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            String sqlStr, nik, nama_dosen, alamat, kota;
            nik = txtNIK.Text.Trim();
            nama_dosen = txtNamaDosen.Text.Trim();
            alamat = txtAlamat.Text.Trim();
            kota = txtKota.Text.Trim();
            if (baru)
            {
                sqlStr = "INSERT INTO dosen VALUES('{0}','{1}','{2}','{3}')";
                sqlStr = String.Format(sqlStr, nik, nama_dosen, alamat, kota);
            }
            else
            {
                sqlStr = "UPDATE dosen SET nik='{0}', nama_dosen='{1}', alamat='{2}',";
                sqlStr += "kota ='{3}' WHERE nik='{4}'";
                sqlStr = String.Format(sqlStr, nik, nama_dosen, alamat, kota, stok, satuan, idLama);
            }
            dosen.eksekusiSQL(sqlStr);
            tutup();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            buka();
            baru = false;
            idLama = txtKodeBarang.Text;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult jwb;
            jwb = MessageBox.Show("Yakin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jwb == DialogResult.Yes)
            {
                String kodeBarangnya, sqlStr;
                kodeBarangnya = txtKodeBarang.Text;
                sqlStr = "DELETE FROM barang WHERE kodebarang='{0}'";
                sqlStr = String.Format(sqlStr, kodeBarangnya);
                barang.eksekusiSQL(sqlStr);
                MessageBox.Show("Sudah dihapus");
            }
            else
            {
                MessageBox.Show("Batal hapus!");
            }
    }
}

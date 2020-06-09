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
    public partial class FormDosenSendiri : Form
    {
        Tabel DosenSendiri = new Tabel("dosen", "akademik");
        bool baru;
        public FormDosenSendiri()
        {
            InitializeComponent();
        }

        void bind()
        {
            txtNikDosen.DataBindings.Add("Text", DosenSendiri.getBs(), "nik");
            txtNamaDosen.DataBindings.Add("Text", DosenSendiri.getBs(), "nama_dosen");
            txtAlamat.DataBindings.Add("Text", DosenSendiri.getBs(), "alamat");
            txtKota.DataBindings.Add("Text", DosenSendiri.getBs(), "kota");
        }

        void unBind()
        {
            txtNikDosen.DataBindings.Clear();
            txtNamaDosen.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            txtKota.DataBindings.Clear();
        }

        void buka()
        {
            unBind();
            txtNikDosen.Enabled = true;
            txtNamaDosen.Enabled = true;
            txtAlamat.Enabled = true;
            txtKota.Enabled = true;
            txtNikDosen.Focus();//<-- kursor pindah ke sini ;
            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEnd.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;// Tombol Save Tampak
            btnUndo.Enabled = true;// Tombol Undo Tampak
            btnClose.Enabled = false;
        }

        void tutup()
        {
            bind();
            txtNikDosen.Enabled =false;
            txtNamaDosen.Enabled = false;
            txtAlamat.Enabled = false;
            txtKota.Enabled = false;
            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnEnd.Enabled = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Enabled = false;  // Tombol Save Sembunyi
            btnUndo.Enabled = false; // Tombol Undo Sembunyi
            btnClose.Enabled = true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            buka();
            txtNikDosen.Text = "";
            txtNamaDosen.Text = "";
            txtAlamat.Text = "0";
            txtKota.Text = "0";
            baru = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sqlStr, nik, nama, alamat, kota;
            nik = txtNikDosen.Text;
            nama = txtNamaDosen.Text;
            alamat = txtAlamat.Text;
            kota = txtKota.Text;
            if (baru)
            {
                sqlStr = "Insert into dosen values('{0}','{1}','{2}','{3}')";
                sqlStr = String.Format(sqlStr, nik, nama, alamat, kota);
            }
            else
            {
                sqlStr = "Update dosen set kodeBarang='{0}', namaBarang='{1}', hargaBeli='{2}',";
                sqlStr += "hargaJual='{3}', stok='{4}', satuan='{5}' where kodeBarang='{6}'";
                sqlStr = String.Format(sqlStr, nik, nama, alamat, kota);
            }
            tutup();
        }
    }
}

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
    public partial class FormSupplier : Form
    {
        Tabel supplier = new Tabel("supplier", "inventory_tigger");
        bool baru;
        string idLama;
        public FormSupplier()
        {
            InitializeComponent();
            dgvSupplier.DataSource = supplier.getBs();
            tutup();
        }

        void bind()
        {
            txtKodeSupplier.DataBindings.Add("Text", supplier.getBs(), "kodeSupplier");
            txtNamaSupplier.DataBindings.Add("Text", supplier.getBs(), "namaSupplier");
            txtAlamat.DataBindings.Add("Text", supplier.getBs(), "alamat");
            txtKota.DataBindings.Add("Text", supplier.getBs(), "kota");
            txtTelepon.DataBindings.Add("Text", supplier.getBs(), "telpon");
        }

        void unBind()
        {
            txtKodeSupplier.DataBindings.Clear();
            txtNamaSupplier.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            txtKota.DataBindings.Clear();
            txtTelepon.DataBindings.Clear();
        }
        void buka()
        {
            unBind();
            txtKodeSupplier.Enabled = true;
            txtNamaSupplier.Enabled = true;
            txtAlamat.Enabled = true;
            txtKota.Enabled = true;
            txtTelepon.Enabled = true;
            txtKodeSupplier.Focus();//<-- kursor pindah ke sini ;
            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEnd.Enabled = false;
            btnPrint.Enabled = false;
            btnFind.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Visible = true;// Tombol Save Tampak
            btnUndo.Visible = true;// Tombol Undo Tampak
            btnClose.Enabled = false;
        }

        void tutup()
        {
            bind();
            txtKodeSupplier.Enabled = false;
            txtNamaSupplier.Enabled = false;
            txtAlamat.Enabled = false;
            txtKota.Enabled = false;
            txtTelepon.Enabled = false;
            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnEnd.Enabled = true;
            btnPrint.Enabled = true;
            btnFind.Enabled = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Visible = false;  // Tombol Save Sembunyi
            btnUndo.Visible = false; // Tombol Undo Sembunyi
            btnClose.Enabled = true;
        }

        void eksekusiSQL(String sqlStr)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "inventory_tigger";
            strCon.IntegratedSecurity = true;
            SqlConnection kon = new SqlConnection(strCon.ToString());
            kon.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, kon);
            cmd.ExecuteNonQuery();
            kon.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sqlStr, kode, nama, alamat, kota, telpon;
            kode = txtKodeSupplier.Text;
            nama = txtNamaSupplier.Text;
            alamat = txtAlamat.Text;
            kota = txtKota.Text;
            telpon = txtTelepon.Text;

            if (baru)
            {
                sqlStr = "Insert into barang values('{0}','{1}','{2}','{3}','{4}')";
                sqlStr = String.Format(sqlStr, kode, nama, alamat, kota, telpon);
            }
            else
            {
                sqlStr = "Update barang set kodeSupplier='{0}', namaSupplier='{1}', alamat='{2}',";
                sqlStr += "kota='{3}', telpon='{4}' where kodeSupplier='{5}'";
                sqlStr = String.Format(sqlStr, kode, nama, alamat, kota, telpon, idLama);
            }
            supplier.eksekusiSQL(sqlStr);
            tutup();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MoveNext();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MoveLast();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            buka();
            txtKodeSupplier.Text = "";
            txtNamaSupplier.Text = "";
            txtAlamat.Text = "";
            txtKota.Text = "";
            txtTelepon.Text = "";
            baru = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buka();
            baru = false;
            idLama = txtKodeSupplier.Text;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormSaringSup fSaring = new FormSaringSup();
            fSaring.ShowDialog();
            fSaring.Dispose();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FormCari FrmCari = new FormCari(supplier.getBs());
            FrmCari.ShowDialog();
            if (FrmCari.find())
            {
                String kodeCari = FrmCari.getKodeCari();
                supplier.cari("kodeSupplier", kodeCari);
            }
            else
            {
                supplier.getBs().Filter = "";
                supplier.getBs().Position = supplier.getBs().Find("kodeSupplier", FrmCari.kodenya);

            }
        }
    }
}

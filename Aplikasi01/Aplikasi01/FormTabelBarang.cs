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
    public partial class FormTabelBarang : Form
    {
       
        public FormTabelBarang()
        {
            InitializeComponent();
            dgvBarang.DataSource = barang.getBs();
            tutup();
        }
        Tabel barang = new Tabel("barang", "inventory_tigger");
        bool baru;
        String idLama;

        void bind()
        {
            txtKodeBarang.DataBindings.Add("Text", barang.getBs(), "kodeBarang");
            txtNamaBarang.DataBindings.Add("Text", barang.getBs(), "namaBarang");
            txtHargaBeli.DataBindings.Add("Text", barang.getBs(), "hargaBeli");
            txtHargaJual.DataBindings.Add("Text", barang.getBs(), "hargaJual");
            txtStok.DataBindings.Add("Text", barang.getBs(), "stok");
            cmbSatuan.DataBindings.Add("Text", barang.getBs(), "satuan");

        }
        void unBind()
        {
            txtKodeBarang.DataBindings.Clear();
            txtNamaBarang.DataBindings.Clear();
            txtHargaBeli.DataBindings.Clear();
            txtHargaJual.DataBindings.Clear();
            txtStok.DataBindings.Clear();
            cmbSatuan.DataBindings.Clear();
        }
        void buka()
        {
            unBind();
            txtKodeBarang.Enabled = true;
            txtNamaBarang.Enabled = true;
            txtHargaBeli.Enabled = true;
            txtHargaJual.Enabled = true;
            txtStok.Enabled = true;
            cmbSatuan.Enabled = true;
            txtKodeBarang.Focus();//<-- kursor pindah ke sini ;
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
            txtKodeBarang.Enabled = false;
            txtNamaBarang.Enabled = false;
            txtHargaBeli.Enabled = false;
            txtHargaJual.Enabled = false;
            txtStok.Enabled = false;
            cmbSatuan.Enabled = false;
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

        private void btnNew_Click(object sender, EventArgs e)
        {

            buka();
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtHargaBeli.Text = "0";
            txtHargaJual.Text = "0";
            txtStok.Text = "0";
            cmbSatuan.Text = "";
            baru = true;

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
            String sqlStr, kode, nama, beli, jual, stok, satuan;
            kode = txtKodeBarang.Text;
            nama = txtNamaBarang.Text;
            beli = txtHargaBeli.Text;
            jual = txtHargaJual.Text;
            stok = txtStok.Text;
            satuan = cmbSatuan.Text;
            if (baru)
            {
                if (barang.sudahAda("kodeBarang", kode))
                {
                    MessageBox.Show("Kode : " + kode + " sudah ada..");
                    txtKodeBarang.Focus();
                    return;
                }
                sqlStr = "Insert into barang values('{0}','{1}','{2}','{3}','{4}','{5}')";
                sqlStr = String.Format(sqlStr, kode, nama, beli, jual, stok, satuan);
            }
            else
            {
                if (barang.bolehUpdate("kodeBarang", kode, idLama))
                {
                    MessageBox.Show("Kode : " + kode + " sudah ada..");
                    txtKodeBarang.Focus();
                    return;
                }

                else
                {
                    sqlStr = "Update barang set kodeBarang='{0}', namaBarang='{1}', hargaBeli='{2}',";
                    sqlStr += "hargaJual='{3}', stok='{4}', satuan='{5}' where kodeBarang='{6}'";
                    sqlStr = String.Format(sqlStr, kode, nama, beli, jual, stok, satuan, idLama);
                }
            }
            barang.eksekusiSQL(sqlStr);
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
            jwb = MessageBox.Show("Yakin Dihapus ?", "Konfirmasi ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jwb == DialogResult.Yes)
            {
                String kodeBarangnya, sqlStr;
                kodeBarangnya = txtKodeBarang.Text;
                sqlStr = "Delete From barang where kodeBarang='{0}'";
                sqlStr = String.Format(sqlStr, kodeBarangnya);
                barang.eksekusiSQL(sqlStr);
                MessageBox.Show("Sudah DiHapus");
            }
            else
            {
                MessageBox.Show("Batal Hapus");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FormCari FrmCari = new FormCari(barang.getBs());
            FrmCari.ShowDialog();
            if (FrmCari.find())
            {
                String kodeCari = FrmCari.getKodeCari();
                barang.cari("kodeBarang", kodeCari);
            }
            else
            {
                barang.getBs().Filter = "";
                barang.getBs().Position = barang.getBs().Find("kodeBarang", FrmCari.kodenya);

            }


            //MessageBox.Show(kodeCari);
            //int baris = barang.getBs().Find("kodeBarang", kodeCari);
            ////MessageBox.Show("Ada di Baris : " + baris);
            //barang.getBs().Position = baris;
            //if (baris >= 0)
            //    barang.getBs().Position = baris;
            //else
            //{
            //    MessageBox.Show("Kode : " + kodeCari + " tidak ditemukan...", "Perhatian",
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormSaringLapStok fSaring = new FormSaringLapStok();
            fSaring.ShowDialog();
            fSaring.Dispose();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            barang.getBs().MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            barang.getBs().MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            barang.getBs().MoveNext();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            barang.getBs().MoveLast();
        }
    }
}



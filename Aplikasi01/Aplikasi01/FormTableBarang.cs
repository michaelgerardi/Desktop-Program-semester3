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
    public partial class FormTableBarang : Form
    {
        Table barang = new Table("Barang", "inventory");
        bool baru;
        String kodeLama;
   
        public FormTableBarang()
        {
            InitializeComponent();
            dgvBarang.DataSource = barang.getBs();
            tutup();
        }
        void buka()
        {
            unBind();
            txtKodeBarang.Enabled = true;
            txtNamaBarang.Enabled = true;
            txtHargaBeli.Enabled = true;
            txtHargaJual.Enabled = true;
            txtStok.Enabled = true;
            txtSatuan.Enabled = true;
            txtKodeBarang.Focus(); //--> kursor [indah
            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEnd.Enabled = false;
            btnPrint.Enabled = false;
            btnFind.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Visible = true;
            btnUndo.Visible = true;
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
            txtKodeBarang.Focus(); //--> kursor [indah
            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnEnd.Enabled = true;
            btnPrint.Enabled = true;
            btnFind.Enabled = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Visible = false;
            btnUndo.Visible = false;
            btnClose.Enabled = true;
        }
        void bind()
        {
            txtKodeBarang.DataBindings.Add("Text", barang.getBs(), "kodeBarang");
            txtNamaBarang.DataBindings.Add("Text", barang.getBs(), "namaBarang");
            txtSatuan.DataBindings.Add("Text", barang.getBs(), "satuan");
            txtStok.DataBindings.Add("Text", barang.getBs(), "stok");
            txtHargaJual.DataBindings.Add("Text", barang.getBs(),
            "hargaJual", true, DataSourceUpdateMode.Never, null, "#,###,###");
            txtHargaBeli.DataBindings.Add("Text", barang.getBs(), 
            "hargaBeli",true,DataSourceUpdateMode.Never,null,"#,###,###");
        }
        void unBind()
        {
            txtKodeBarang.DataBindings.Clear();
            txtNamaBarang.DataBindings.Clear();
            txtSatuan.DataBindings.Clear();
            txtStok.DataBindings.Clear();
            txtHargaJual.DataBindings.Clear();
            txtHargaBeli.DataBindings.Clear();
        }




         private void btnFind_Click(object sender, EventArgs e)
         {
             FormCari FrmCari = new FormCari(barang.getBs());
             FrmCari.ShowDialog();
             if (FrmCari.find())
             {
                 string kodecari = FrmCari.getKodeCari();
                 barang.cari("kodeBarang", kodecari);
             }
             else
             {
                 if (barang.getBs().Count != barang.getBs().Position + 1)
                     barang.getBs().MovePrevious();
                 {
                     
                 }
             }
             //MessageBox.Show(kodeCari);
             //int baris = barang.getBs().Find("Kode_Barang", kodeCari);
             //MessageBox.Show("Ada di baris :" + baris);
             /*if (baris < 0)
                 barang.getBs().Position = baris; //untuk pindah posisi//
             else
             {
                 //MessageBox.Show();
                 MessageBox.Show("kode : " + kodeCari + "tidak ditemukan..." , "Perhatian", 
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }*/
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
             baru = true;
         }

         private void btnEdit_Click(object sender, EventArgs e)
         {
             buka();
             baru = false;
             kodeLama = txtKodeBarang.Text;
         }

         private void btnSave_Click(object sender, EventArgs e)
         {
             //bs.MovePrevious();
             String sqlStr, kode, nama, beli, jual, stok, satuan;
             kode = txtKodeBarang.Text.Trim();
             nama = txtNamaBarang.Text.Trim();
             beli = txtHargaBeli.Text.Trim();
             jual = txtHargaJual.Text.Trim();
             stok = txtStok.Text.Trim();
             satuan = txtSatuan.Text.Trim();
             if (baru)
             {
                 if (barang.sudahAda("kodeBarang", kode))
                 {
                     MessageBox.Show("kode : " + kode + " wes ono");
                     txtKodeBarang.Focus();
                     return;
                 }
                 sqlStr = ("Insert into barang values('{0}', '{1}', '{2}', '{3}','{4}','{5}')");
                 sqlStr = string.Format(sqlStr, kode, nama, beli, jual, stok, satuan);
                 //MessageBox.Show(sqlStr);
             }
             else
             {
                 if(barang.bolehUpdate("kodeBarang
                 
                 sqlStr = "Update barang set kodeBarang='{0}', namaBarang='{1}', hargaBeli='{2}',";
                 sqlStr += "hargajual = '{3}', stok = '{4}', satuan = '{5}' where kodeBarang = '{6}'";
                 sqlStr = String.Format(sqlStr, kode, nama, beli, jual, stok, satuan, kodeLama);


             }
             barang.eksekusiSQL(sqlStr);
             tutup();
         }

         private void btnUndo_Click(object sender, EventArgs e)
         {
             tutup();
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

         private void btnDel_Click(object sender, EventArgs e)
         {
             // bs.MoveFirst();
             DialogResult jwb;
             jwb = MessageBox.Show("YAKIN DIHAPUS?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (jwb == DialogResult.Yes)
             {
                 String kodeBarang, strsql;
                 kodeBarang = txtKodeBarang.Text;
                 strsql = ("DELETE FROM barang WHERE kodeBarang'{0}'");
                 strsql = string.Format(strsql, kodeBarang);
                 barang.eksekusiSQL(strsql);
                 MessageBox.Show("Sudah dihapus");
             }
             else
             {
                 MessageBox.Show("Batal hapus");
             }
         }
        }
    }

    


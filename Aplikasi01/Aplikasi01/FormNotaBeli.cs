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
    public partial class FormNotaBeli : Form
    {
        public FormNotaBeli()
        {
            InitializeComponent();
            bindMaster();
            dgvItemNotaBeli.DataSource = detail.getBs();
        }
        Tabel notaBeli = new Tabel("View_Nota_Beli", "inventory_tigger");
        Tabel detail = new Tabel("View_Detail_Beli", "inventory_tigger");
        bool baru = false;

        //Tutup
        //Y:147 tingginya 261
        //buka
        //Y:253 tingginya 155
        void buka()
        {
            dgvItemNotaBeli.Top = 253;
            dgvItemNotaBeli.Height = 125;
            txtKodeSupplier.Enabled = true;
            txtKodeSupplier.DataBindings.Clear();// dilepas supaya tidak merubah data
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
            dgvItemNotaBeli.Top = 147;
            dgvItemNotaBeli.Height = 261;
            txtKodeSupplier.Enabled = false;
            txtKodeSupplier.DataBindings.Add("text", notaBeli.getBs(), "KodeSupplier");
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
        void tampilDetail()
        {
            String no = txtNoNotaBeli.Text.Trim();
            detail.getBs().Filter = "noNotaBeli=" + no;
            hitung();
        }
        void hitung()
        {
            int total, idx, brs = dgvItemNotaBeli.Rows.Count;
            total = 0;
            for (idx = 0; idx < brs; idx++)
            {
                //MessageBox.Show(dgvItemNotaBeli.Rows[idx].Cells[7].Value.ToString());
                total += int.Parse(dgvItemNotaBeli.Rows[idx].Cells[6].Value.ToString());
            }
            txtTotal.Text = total.ToString("###,###,###");

        }
        void bindMaster()
        {
            txtNoNotaBeli.DataBindings.Add("Text", notaBeli.getBs(), "noNotaBeli");
            txtTanggal.DataBindings.Add("Text", notaBeli.getBs(), "tanggal");
            txtKodeSupplier.DataBindings.Add("Text", notaBeli.getBs(), "kodeSupplier");
            txtNamaSupplier.DataBindings.Add("Text", notaBeli.getBs(), "namaSupplier");
            txtAlamat.DataBindings.Add("Text", notaBeli.getBs(), "alamat");
            txtKota.DataBindings.Add("Text", notaBeli.getBs(), "kota");
            txtTelpon.DataBindings.Add("Text", notaBeli.getBs(), "telpon");
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            notaBeli.getBs().MoveFirst();
            tampilDetail();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            notaBeli.getBs().MovePrevious();
            tampilDetail();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            notaBeli.getBs().MoveNext();
            tampilDetail();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            notaBeli.getBs().MoveLast();
            tampilDetail();
        }

        private void FormNotaBeli_Load(object sender, EventArgs e)
        {
            tampilDetail();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            String tgl = DateTime.Now.ToString();
            String strSQL = " INSERT INTO NotaBeli(tanggal) Values('" + tgl + "')";
            String noNota = notaBeli.eksekusiSQL_GETID(strSQL);
            int posisi = notaBeli.getBs().Find("noNotaBeli", noNota);
            notaBeli.getBs().Position = posisi;
            tampilDetail();
            buka();
            txtKodeSupplier.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buka();
            txtKodeSupplier.Focus(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tutup();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            tutup();
        }

        void hapus()
        {

            txtKodeBaranag.Text = "";
            txtNamaBarang.Text = "";
            txtQty.Text = "";
            txtHarga.Text = "";
            txtJumlah.Text = "";
            txtKodeBaranag.Focus();


        }
        private void txtKodeBaranag_Validated(object sender, EventArgs e)
        {
            if (txtKodeBaranag.Text.Length > 0)
            {
                Tabel barang = new Tabel("barang", "inventory_tigger");

                int brs = barang.getBs().Find("kodeBarang", txtKodeBaranag.Text.Trim());
                if (brs >= 0)
                {
                    barang.getBs().Position = brs;
                    txtNamaBarang.Text = ((DataRowView)barang.getBs().Current).Row["namaBarang"].ToString();
                    txtHarga.Text = ((DataRowView)barang.getBs().Current).Row["hargaBeli"].ToString();

                }
                else
                {
                    MessageBox.Show("Kode : " + txtKodeBaranag.Text + " tidak ditemukan");
                    txtKodeBaranag.Text = "";
                    txtKodeBaranag.Focus();
                }
            }

        }

        private void txtKodeBaranag_Enter(object sender, EventArgs e)
        {
            hapus();
            
        }

        private void txtKodeBaranag_TextChanged(object sender, EventArgs e)
        {
            if (txtKodeBaranag.Text.Length == 5)
            {
                txtQty.Focus();
            }
        }

        private void txtQty_Validated(object sender, EventArgs e)
        {
            txtJumlah.Text = (int.Parse(txtQty.Text) * int.Parse(txtHarga.Text)).ToString("###,###,###");
            txtJumlah.Focus();
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                String no,kd,qt,hg,sqlStr;
                no = txtNoNotaBeli.Text.Trim();
                kd = txtKodeBaranag.Text.Trim();
                qt = txtQty.Text.Trim();
                hg = txtHarga.Text.Trim();
                sqlStr = "INSERT INTO itemNotaBeli(noNotaBeli,kodeBarang,qty,harga) VALUES ('{0}','{1}','{2}','{3}')";
                sqlStr = String.Format(sqlStr, no, kd, qt, hg);
                //MessageBox.Show(sqlStr);
                detail.eksekusiSQL(sqlStr);
                hapus();
                hitung();
            }
        }

        private void dgvItemNotaBeli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                String barisHapus, kode, nama, qty, harga, jumlah,ket;
                int brs = dgvItemNotaBeli.SelectedCells[0].RowIndex;
               barisHapus = dgvItemNotaBeli.Rows[brs].Cells[1].Value.ToString().Trim();
               kode = dgvItemNotaBeli.Rows[brs].Cells[2].Value.ToString().Trim();
               nama = dgvItemNotaBeli.Rows[brs].Cells[3].Value.ToString().Trim();
               qty = dgvItemNotaBeli.Rows[brs].Cells[4].Value.ToString().Trim();
               harga = dgvItemNotaBeli.Rows[brs].Cells[5].Value.ToString().Trim();
               jumlah= dgvItemNotaBeli.Rows[brs].Cells[6].Value.ToString().Trim();
               // MessageBox.Show(dgvItemNotaBeli.Rows[brs].Cells[0].Value.ToString());
               ket = "Anda yakin akan menghapus ?\n";
                ket += "Kode\t: " + kode + "\n";
                ket += "Nama\t: " + nama + "\n";
                ket += "Qty\t: " + qty + "\n";
                ket += "Harga\t: " + harga + "\n";
                ket += "Jumlah\t: " + jumlah + "\n";
                DialogResult j = MessageBox.Show(ket, "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (j== DialogResult.Yes)
                {

                String sqlstr = "DELETE FROM itemNotaBeli WHERE idNotaBeli=" + barisHapus;
                detail.eksekusiSQL(sqlstr);
                }
            }

            if (e.KeyData == Keys.Back && btnSave.Visible)
            {
                String barisHapus, kode, nama, qty, harga, jumlah;
                int brs = dgvItemNotaBeli.SelectedCells[0].RowIndex;
                barisHapus = dgvItemNotaBeli.Rows[brs].Cells[1].Value.ToString().Trim();
                kode = dgvItemNotaBeli.Rows[brs].Cells[2].Value.ToString().Trim();
                nama = dgvItemNotaBeli.Rows[brs].Cells[3].Value.ToString().Trim();
                qty = dgvItemNotaBeli.Rows[brs].Cells[4].Value.ToString().Trim();
                harga = dgvItemNotaBeli.Rows[brs].Cells[5].Value.ToString().Trim();
                jumlah = dgvItemNotaBeli.Rows[brs].Cells[6].Value.ToString().Trim();

                txtKodeBaranag.Text = kode;
                txtNamaBarang.Text = nama;
                txtQty.Text = qty;
                txtHarga.Text = harga;
                txtJumlah.Text = jumlah;
                //String sqlstr = "DELETE FROM itemNotaBeli WHERE idNotaBeli=" + barisHapus;
                //detail.eksekusiSQL(sqlstr);
                txtKodeBaranag.Focus();
            }


        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void txtKodeSupplier_Validated(object sender, EventArgs e)
        {
            if (txtKodeSupplier.Text.Length > 0)
            {
                String strSQL, noNotaBaru = txtNoNotaBeli.Text.Trim();
                Tabel Supplier = new Tabel("Supplier", "inventory_tigger");
                int baris =  Supplier.getBs().Find("KodeSupplier",txtKodeSupplier.Text.Trim());
                if (baris >= 0)
                {
                    String noNotaBeli, kd, sqlStr;
                    noNotaBeli = txtNoNotaBeli.Text.Trim();
                    kd = txtKodeSupplier.Text.Trim();
                    sqlStr = "Update NotaBeli SET KodeSupplier='{0}' where noNotaBeli='{1}'";
                    sqlStr = String.Format(sqlStr, kd, noNotaBeli);
                    notaBeli.eksekusiSQL(sqlStr);
                    baris = notaBeli.getBs().Find("noNotaBeli", noNotaBaru);
                    notaBeli.getBs().Position = baris;
                }
                else
                {
                    //MessageBox.Show("KodeSupplier : " + txtKodeSupplier.Text.Trim() + " tidak ada !!");
                    FormCariSupplier fcs = new FormCariSupplier();
                    fcs.ShowDialog();
                    txtKodeSupplier.Text = fcs.KodeSupplier;
                    txtKodeSupplier.Focus();
                }
               
            }
        }

        private void txtKodeSupplier_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtKodeSupplier.Text.Length == 3 || e.KeyData == Keys.Enter) 
            txtKodeSupplier.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult jwb;
            jwb = MessageBox.Show("Hapus Nota no. " + txtNoNotaBeli.Text + " ? ",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jwb == DialogResult.Yes)
            {
                String nomornota = txtNoNotaBeli.Text.Trim();
                String strSQL = " delete From itemNotaBeli WHERE noNotaBeli='" + nomornota + "'";
                detail.eksekusiSQL(strSQL);

                strSQL = " delete From NotaBeli WHERE noNotaBeli='" + nomornota + "'";
                notaBeli.eksekusiSQL(strSQL);

                MessageBox.Show("Penghapus selesai", "informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                notaBeli.getBs().MoveLast();
                tampilDetail();
                
            }
            else
            {
                MessageBox.Show("penghapusan dibatalkan","informasi",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormCetakNotaBeli fcBeli = new FormCetakNotaBeli();
            fcBeli.getCetakNotaBeliBs().Filter = "noNotaBeli= " + txtNoNotaBeli.Text.Trim();
            fcBeli.ShowDialog();
            fcBeli.Dispose();
        }

    }

}

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
    public partial class FormNotaJual : Form
    {
        Tabel notaJual = new Tabel("NotaJual", "Inventoryku");
        Tabel detail = new Tabel("View_detail_jual", "Inventoryku");
        public FormNotaJual()
        {
            InitializeComponent();
            bind();
            dgvItemNotaJual.DataSource = detail.getBs();
        }
        void bind()
        {
            txtNoNotaJual.DataBindings.Add("text", notaJual.getBs(),"noNotaJual");
            txtTanggal.DataBindings.Add("text", notaJual.getBs(), "tanggal");

        }
        void buka()
        {
            dgvItemNotaJual.Top = 119;
            dgvItemNotaJual.Height = 125;
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
            
            dgvItemNotaJual.Top = 47;
            dgvItemNotaJual.Height = 261;
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
        void saring()
        {
           
            detail.getBs().Filter = "noNotaJual= " + txtNoNotaJual.Text.Trim();
            total();
            
        }
        void total()
        {
            int total, idx, brs = dgvItemNotaJual.Rows.Count;
            total = 0;
            for (idx = 0; idx < brs; idx++)
            {
                total += int.Parse(dgvItemNotaJual.Rows[idx].Cells[7].Value.ToString());
            }
            txtTotal.Text = total.ToString("###,###,###");

        }
        void tampilDetail()
        {
            String no = txtNoNotaJual.Text.Trim();
            detail.getBs().Filter = "noNotaJual=" + no;
            total();
        }
      
        private void btnNew_Click(object sender, EventArgs e)
        {
            String tgl = DateTime.Now.ToString();
            String strSQL = " insert into NotaJual(tanggal) values ('" + tgl + "')";
            String noNota = notaJual.eksekusiSQL_GETID(strSQL);
            int posisi = notaJual.getBs().Find("noNotaJual", noNota);
            notaJual.getBs().Position = posisi;
            tampilDetail();
            buka();
            txtKodeBaranag.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buka();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tutup();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            tutup();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            notaJual.getBs().MoveFirst();
            saring();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            notaJual.getBs().MovePrevious();
            saring();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            notaJual.getBs().MoveNext();
            saring();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            notaJual.getBs().MoveLast();
            saring();
        }

        private void txtNoNotaJual_TextChanged(object sender, EventArgs e)
        {
            //saring();
            //total();
            
        }

        private void txtKodeBaranag_Validated(object sender, EventArgs e)
        {
            
            Tabel Barang = new Tabel("barang", "Inventoryku");
            int baris = Barang.getBs().Find("kodeBarang", txtKodeBaranag.Text.Trim());
            if (baris >= 0)
            {
                Barang.getBs().Position = baris;
                txtNamaBarang.Text = ((DataRowView)Barang.getBs().Current).Row["namaBarang"].ToString();
                txtHarga.Text = ((DataRowView)Barang.getBs().Current).Row["hargaJual"].ToString();
                // current digunkan yaitu objek yang bisa diconvet yang dapat data rowview dan akhirnya punya rows
                txtQty.Focus();
            }
            else
            {
                MessageBox.Show("kode : " + txtKodeBaranag.Text + "tidak ditemukan");
                hapus();
            }
            
        }
        void hapus()
        {
            txtKodeBaranag.Text = " ";
            txtNamaBarang.Text = " ";
            txtHarga.Text = "0";
            dgvItemNotaJual.Focus();
        }

        private void txtKodeBaranag_TextChanged(object sender, EventArgs e)
        {
            if (txtKodeBaranag.Text.Length == 5)
                //mendapat kode barang yang valid , menampilkan nama barang dan 
                //harga barang bagi user
            {
                txtQty.Focus();
            }
            
        }

        private void txtQty_Validated(object sender, EventArgs e)
        {
            txtJumlah.Text = (int.Parse(txtQty.Text) * int.Parse(txtHarga.Text)).ToString();
            txtJumlah.Focus();
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                String no, kd, qt, hg, sqlStr;
                no = txtNoNotaJual.Text.Trim();
                kd = txtKodeBaranag.Text.Trim();
                qt = txtQty.Text.Trim();
                hg = txtHarga.Text.Trim();
                sqlStr = "INSERT INTO itemNotaJual(noNotaJual,kodeBarang,qty,harga) VALUES ('{0}','{1}','{2}','{3}')";
                sqlStr = String.Format(sqlStr, no, kd, qt, hg);
                //MessageBox.Show(sqlStr);
                detail.eksekusiSQL(sqlStr);
                hapus();
                total();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult jwb;
            jwb = MessageBox.Show(" Hapus Nota no : " + txtNoNotaJual.Text + " ? ",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jwb == DialogResult.Yes)
            {
                String nomornota = txtNoNotaJual.Text.Trim();
                String strSQL = " delete From itemNotaJual WHERE noNotajual='" + nomornota + "'";
                detail.eksekusiSQL(strSQL);

                strSQL = " delete From NotaJual WHERE noNotaJual='" + nomornota + "'";
                notaJual.eksekusiSQL(strSQL);

                MessageBox.Show("Penghapus selesai", "informasi", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                notaJual.getBs().MoveLast();
                tampilDetail();
            }
            else
            {
                MessageBox.Show("penghapusan dibatalkan", "informasi", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }

        private void dgvItemNotaJual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                String barisHapus, kode, nama, qty, harga, jumlah, ket;
                int brs = dgvItemNotaJual.SelectedCells[0].RowIndex;
                barisHapus = dgvItemNotaJual.Rows[brs].Cells[1].Value.ToString().Trim();
                kode = dgvItemNotaJual.Rows[brs].Cells[2].Value.ToString().Trim();
                nama = dgvItemNotaJual.Rows[brs].Cells[3].Value.ToString().Trim();
                qty = dgvItemNotaJual.Rows[brs].Cells[4].Value.ToString().Trim();
                harga = dgvItemNotaJual.Rows[brs].Cells[5].Value.ToString().Trim();
                jumlah = dgvItemNotaJual.Rows[brs].Cells[6].Value.ToString().Trim();
                // MessageBox.Show(dgvItemNotaBeli.Rows[brs].Cells[0].Value.ToString());
                ket = "Anda yakin akan menghapus ?\n";
                ket += "Kode\t: " + kode + "\n";
                ket += "Nama\t: " + nama + "\n";
                ket += "Qty\t: " + qty + "\n";
                ket += "Harga\t: " + harga + "\n";
                ket += "Jumlah\t: " + jumlah + "\n";
                DialogResult j = MessageBox.Show(ket, "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (j == DialogResult.Yes)
                {

                    String sqlstr = "DELETE FROM itemNotaJual WHERE idNotaJual=" + barisHapus;
                    detail.eksekusiSQL(sqlstr);
                }
            }
            if (e.KeyData == Keys.Back && btnSave.Visible)
            {
                String barisHapus, kode, nama, qty, harga, jumlah;
                int brs = dgvItemNotaJual.SelectedCells[0].RowIndex;
                barisHapus = dgvItemNotaJual.Rows[brs].Cells[1].Value.ToString().Trim();
                kode = dgvItemNotaJual.Rows[brs].Cells[2].Value.ToString().Trim();
                nama = dgvItemNotaJual.Rows[brs].Cells[3].Value.ToString().Trim();
                qty = dgvItemNotaJual.Rows[brs].Cells[4].Value.ToString().Trim();
                harga = dgvItemNotaJual.Rows[brs].Cells[5].Value.ToString().Trim();
                jumlah = dgvItemNotaJual.Rows[brs].Cells[6].Value.ToString().Trim();

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormCetakNotaJual fcJual = new FormCetakNotaJual();
            fcJual.getCetakNotaJualBs().Filter = "noNotaJual= " + txtNoNotaJual.Text.Trim();
            fcJual.ShowDialog();
            fcJual.Dispose();

        }
    }
}

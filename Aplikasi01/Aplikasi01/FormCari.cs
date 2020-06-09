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
    public partial class FormCari : Form
    {
        public FormCari(BindingSource bs)
        {
            InitializeComponent();
            this.bs = bs;
            dgvBarang.DataSource = this.bs;
        }
        public String kodenya;
        public Barang1 hasilpencarian;
        BindingSource bs;

        public bool find()
        {
            return rdFind.Checked;
        }

        public String getKodeCari()
        {
            return txtKodeCari.Text;
        }

        private void txtKodeCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Close();
        }

        private void rdFilter_CheckedChanged(object sender, EventArgs e)
        {
            txtKodeCari.Enabled = false;
            txtNamaBarang.Enabled = true;
            dgvBarang.Enabled = true;
            txtNamaBarang.Focus();
        }

        private void rdFind_CheckedChanged(object sender, EventArgs e)
        {
            txtKodeCari.Enabled = true;
            txtNamaBarang.Enabled = false;
            dgvBarang.Enabled = false;
            txtNamaBarang.Focus();
        }

        private void txtNamaBarang_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = "namaBarang LIKE '*" + txtNamaBarang.Text.Trim() + "*'";
        }

        private void txtNamaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                dgvBarang.Focus();
        }

        private void dgvBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int baris = dgvBarang.SelectedCells[0].RowIndex;
                kodenya = dgvBarang.Rows[baris].Cells[0].Value.ToString().Trim();
                hasilpencarian.kodebarang = dgvBarang.Rows[baris].Cells[1].Value.ToString().Trim();
                hasilpencarian.namabarang = dgvBarang.Rows[baris].Cells[2].Value.ToString().Trim();
                hasilpencarian.harga = dgvBarang.Rows[baris].Cells[3].Value.ToString().Trim();
                Close();
            }
                
        }
    }
}

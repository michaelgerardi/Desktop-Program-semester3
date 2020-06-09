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
    public partial class FormMenuUtama : Form
    {
        public FormMenuUtama(DataRowView pemakai)
        {
            InitializeComponent();
            this.dataSupplierToolStripMenuItem.Enabled = Boolean.Parse(pemakai.Row["setupBarang"].ToString());
            this.dataSupplierToolStripMenuItem.Enabled = Boolean.Parse(pemakai.Row["setupPemakai"].ToString());
            this.dataSupplierToolStripMenuItem.Enabled = Boolean.Parse(pemakai.Row["setupSupplier"].ToString());
            dataBarangToolStripMenuItem.Enabled = bool.Parse(pemakai.Row["setupBarang"].ToString());
            setupPemakaiToolStripMenuItem.Enabled = bool.Parse(pemakai.Row["setupPemakai"].ToString());
            pembelianToolStripMenuItem.Enabled = bool.Parse(pemakai.Row["pembelian"].ToString());
            penjualanToolStripMenuItem.Enabled = bool.Parse(pemakai.Row["penjualan"].ToString());
            laporanStockToolStripMenuItem.Enabled = bool.Parse(pemakai.Row["lapstock"].ToString());
            laporanSupplierToolStripMenuItem.Enabled = bool.Parse(pemakai.Row["lapsupp"].ToString());
            


        }

        private void daftarBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelBarang brg = new FormTabelBarang();
            brg.ShowDialog();
            brg.Dispose();
        }

        private void dataSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier fsl = new FormSupplier();
            fsl.ShowDialog();
            fsl.Dispose();
        }

        private void setupPemakaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetupPemakai fsp = new FormSetupPemakai();
            fsp.ShowDialog();
            fsp.Dispose();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotaBeli fbn = new FormNotaBeli();
            fbn.ShowDialog();
            fbn.Dispose();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotaJual fjn = new FormNotaJual();
            fjn.ShowDialog();
            fjn.Dispose();

        }

        private void laporanStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaringLapStok fsl = new FormSaringLapStok();
            fsl.ShowDialog();
            fsl.Dispose();
        }

        private void laporanSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaringSup SP = new FormSaringSup();
            SP.ShowDialog();
            SP.Dispose();
        }
    }
}

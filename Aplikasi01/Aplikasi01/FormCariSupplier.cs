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
    public partial class FormCariSupplier : Form
    {
        Tabel Supplier = new Tabel("Supplier", "inventory_tigger");
        public String KodeSupplier;
        public FormCariSupplier()
        {
            InitializeComponent();
            dgvSupplier.DataSource = Supplier.getBs();
        }

        private void txtNamaSupplier_TextChanged(object sender, EventArgs e)
        {
            Supplier.getBs().Filter = " NamaSupplier like '%" + txtNamaSupplier.Text.Trim() + "%'";
        }

        private void dgvSupplier_DoubleClick(object sender, EventArgs e)
        {
            int brs = dgvSupplier.SelectedCells[0].RowIndex;
            this.KodeSupplier = dgvSupplier.Rows[brs].Cells[0].Value.ToString().Trim();
            Close();// <-- form ditutup karena dibaca diform yang satunya
        }
    }
}

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
    public partial class FormCetakNotaBeli : Form
    {
        public FormCetakNotaBeli()
        {
            InitializeComponent();
        }
        public BindingSource getCetakNotaBeliBs()
        {
            return view_nota_beli_cetakBindingSource;
        }
        private void FormCetakNotaBeli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_tiggerDataSet.view_nota_beli_cetak' table. You can move, or remove it, as needed.
            this.view_nota_beli_cetakTableAdapter.Fill(this.inventory_tiggerDataSet.view_nota_beli_cetak);

            this.reportViewer1.RefreshReport();
        }
    }
}

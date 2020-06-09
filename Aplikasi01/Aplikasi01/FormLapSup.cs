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
    public partial class FormLapSup : Form
    {
        public FormLapSup()
        {
            InitializeComponent();
        }

        private void FormLapSup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_tiggerDataSet2.Supplier' table. You can move, or remove it, as needed.
            this.SupplierTableAdapter.Fill(this.inventory_tiggerDataSet2.Supplier);

            this.reportViewer1.RefreshReport();
        }
        public BindingSource getBindingSource()
        {
            return SupplierBindingSource;
        }

    }
}

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
    public partial class FormCetakNotaJual : Form
    {
        public FormCetakNotaJual()
        {
            InitializeComponent();
        }
        public BindingSource getCetakNotaJualBs()
        {
            return View_Master_Jual_CetakBindingSource;
        }

        private void FormCetakNotaJual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'InventorykuDataSet.View_Master_Jual_Cetak' table. You can move, or remove it, as needed.
            this.View_Master_Jual_CetakTableAdapter.Fill(this.InventorykuDataSet.View_Master_Jual_Cetak);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class FormCariSetupPemakai : Form
    {
        public FormCariSetupPemakai(BindingSource bs)
        {
            InitializeComponent();
            this.bs = bs;
            dgvCariPemakai.DataSource = bs;

        }
        BindingSource bs;
        public Pemakai1 hasil;
        public String kodenya;

        private void txtKodeCariUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Close();
        }

        private void txtKodeCariUsername_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = " userName LIKE '*" + txtKodeCariUsername.Text.Trim();
        }

        private void dgvCariPemakai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int baris = dgvCariPemakai.SelectedCells[0].RowIndex;
                kodenya = dgvCariPemakai.Rows[baris].Cells[0].Value.ToString().Trim();
                hasil.userName = dgvCariPemakai.Rows[baris].Cells[1].Value.ToString().Trim();
                hasil.password = dgvCariPemakai.Rows[baris].Cells[2].Value.ToString().Trim();
                Close();

            }
        }



    }
}

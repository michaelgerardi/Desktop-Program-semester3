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
    public partial class FormSaringLapStok : Form
    {
        Tabel barang1 = new Tabel("barang", "inventory_tigger");
        Tabel barang2 = new Tabel("barang", "inventory_tigger");

        public FormSaringLapStok()
        {
            InitializeComponent();
            cb01.DataSource = barang1.getBs();
            cb01.DisplayMember = "kodeBarang";
            barang1.getBs().MoveFirst();
            cb02.DataSource = barang2.getBs();
            cb02.DisplayMember = "kodeBarang";
            barang2.getBs().MoveLast();
            
        }

        private void btnCloset_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            String kd1, kd2;
            kd1 = cb01.Text.Trim();
            kd2 = cb02.Text.Trim();
            FormLapStok fLapStok = new FormLapStok();
            fLapStok.getBindingSource().Sort = "kodeBarang DESC";
            fLapStok.getBindingSource().Filter = "kodeBarang >='" + kd1 +
                "' AND kodeBarang<='" + kd2 + "'";
            fLapStok.ShowDialog();

        }
    }
}

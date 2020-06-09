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
    public partial class FormSaringSup : Form
    {
        Tabel supplier1 = new Tabel("supplier", "inventory_tigger");
        Tabel supplier2 = new Tabel("supplier", "inventory_tigger");
        public FormSaringSup()
        {
            InitializeComponent();
            cb01.DataSource = supplier1.getBs();
            cb01.DisplayMember = "kodeSupplier";
            supplier1.getBs().MoveFirst();
            cb02.DataSource = supplier2.getBs();
            cb02.DisplayMember = "kodeSupplier";
            supplier2.getBs().MoveLast();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        { 
            String kd1, kd2;
            kd1 = cb01.Text.Trim();
            kd2 = cb02.Text.Trim();
            FormLapSup fLapSup = new FormLapSup();
            fLapSup.getBindingSource().Sort = "kodeSupplier DESC";
            fLapSup.getBindingSource().Filter = "kodeSupplier >='" + kd1 +
                "' AND kodeSupplier <='" + kd2 + "'";
            fLapSup.ShowDialog();
        }

        private void btnCloset_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class FormSetupPemakai : Form
    {
        Tabel pemakai = new Tabel("usernya ", "inventory_tigger");
        bool baru;
        String userLama;
       
        public FormSetupPemakai()
        {
            InitializeComponent();
            bind();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void bind()
        {
            txtUsername.DataBindings.Add("text", pemakai.getBs(),"userName");
            checBarang.DataBindings.Add("Checked", pemakai.getBs(), "setupBarang");
            checSupplier.DataBindings.Add("checked", pemakai.getBs(), "setupSupplier");
            checPemakai.DataBindings.Add("checked", pemakai.getBs(), "setupPemakai");
            checBeli.DataBindings.Add("checked", pemakai.getBs(), "pembelian");
            checJual.DataBindings.Add("checked", pemakai.getBs(), "Penjualan");
            checLapStock.DataBindings.Add("checked", pemakai.getBs(), "lapstock");
            checLapSupp.DataBindings.Add("checked", pemakai.getBs(), "lapsupp");
        }
        void unbind()
        {
            txtUsername.DataBindings.Clear();
            checBarang.DataBindings.Clear();
            checSupplier.DataBindings.Clear();
            checPemakai.DataBindings.Clear();
            checBeli.DataBindings.Clear();
            checJual.DataBindings.Clear();
            checLapStock.DataBindings.Clear();
            checLapSupp.DataBindings.Clear();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            pemakai.getBs().MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pemakai.getBs().MovePrevious();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pemakai.getBs().MoveNext();

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            pemakai.getBs().MoveLast();
        }

        void bukak()
        {
            txtUsername.Enabled = true;
            txtPassword.Visible = true;
            txtKonFir.Visible = true;
            GbSetup.Enabled = true;
            GbTrans.Enabled = true;
            GbLap.Enabled = true;
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
            txtUsername.Enabled = false;
            txtPassword.Visible = false;
            txtKonFir.Visible = false;
            GbSetup.Enabled = false;
            GbTrans.Enabled = false;
            GbLap.Enabled = false;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sqlSTR, username,password, repass;
            bool brg, sup, pem, penjualan, pembelian, lapstock, lapdatasup;
            sqlSTR = "";
            username = txtUsername.Text;
            password = txtPassword.Text;
            repass = txtKonFir.Text;
            brg = checBarang.Checked;
            sup = checSupplier.Checked;
            pem = checPemakai.Checked;
            penjualan = checJual.Checked;
            pembelian = checBeli.Checked;
            lapstock = checLapStock.Checked;
            lapdatasup = checLapSupp.Checked;
            if (password == repass)
            {
                if (baru)
                {
                    sqlSTR = "Insert into usernya VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
                    sqlSTR = String.Format(sqlSTR, username, password, repass, brg, sup, pem, penjualan, pembelian, lapstock, lapdatasup);
                }
                else
                {
                    sqlSTR = "update usernya set userName = '{0}', password = '{1}',setupBarang = '{2}','setupSupplier = '{3}', pembelian ='{4}',penjualan = '{5}',";
                    sqlSTR += "lapstock = '{7}', lapsupp = '{8}' where userName ='{9}'";
                    sqlSTR = String.Format(sqlSTR, username, password, repass, brg, sup, pem, penjualan, pembelian, lapstock, lapdatasup);
                }
            }
            pemakai.eksekusiSQL(sqlSTR);
            tutup();
            
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bukak();
            baru = false;
            userLama = txtUsername.Text;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            tutup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult jawab;
            jawab = MessageBox.Show(" userName. " + txtUsername.Text + " ? ",
              "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (jawab == DialogResult.Yes)
            {
                String username = txtUsername.Text.Trim();
                String strsql = " delete from usernya where userName= '" + username + "'";
                pemakai.eksekusiSQL(strsql);

                MessageBox.Show("Penghapus selesai", "informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                pemakai.getBs().MoveLast();
            }
            else
            {
                MessageBox.Show("penghapusan dibatalkan", "informasi", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FormCariSetupPemakai frmcari =  new FormCariSetupPemakai(pemakai.getBs());
            frmcari.ShowDialog();
            pemakai.getBs().Filter = " ";
            pemakai.getBs().Position = pemakai.getBs().Find("userName", frmcari.kodenya);


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            baru = true;
            txtUsername.Text = " ";
            txtPassword.Text = "";
            txtKonFir.Text = "";
            checBarang.Checked = false;
            checPemakai.Checked = false;
            checSupplier.Checked = false;
            checJual.Checked = false;
            checBeli.Checked = false;
            checLapStock.Checked = false;
            checLapSupp.Checked = false;
            bukak();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}

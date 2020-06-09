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
    public partial class FormTableDosen : Form
    {
        Table dosen = new Table("Dosen", " akademik");
        bool baru;
        string kodelama;

        public FormTableDosen()
        {
            InitializeComponent();
            //dgvDosen.DataSource = dosen.getBs;
            tutup();
            
        }

        void bind()
        {
            txtnik.DataBindings.Add("Text", dosen.getBs(), "nik");
            txtNamaDosen.DataBindings.Add("Text", dosen.getBs(), "nama_dosen");
            txtkota.DataBindings.Add("Text", dosen.getBs(), "kota");
            txtAlamat.DataBindings.Add("Text", dosen.getBs(), "alamat");
        }
        void unBind()
        {
            txtnik.DataBindings.Clear();
            txtNamaDosen.DataBindings.Clear();
            txtkota.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
        }

        void buka()
        {
            unBind();
            txtnik.Enabled = true;
            txtNamaDosen.Enabled = true;
            txtAlamat.Enabled = true;
            txtkota.Enabled = true;
            txtnik.Focus(); //--> kursor [indah
            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEnd.Enabled = false;
            btnPrint.Enabled = false;
            btnFind.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Visible = true;
            btnUndo.Visible = true;
            btnClose.Enabled = false;

        }
        void tutup()
        {
            bind();
            txtnik.Enabled = false;
            txtNamaDosen.Enabled = false;
            txtAlamat.Enabled = false;
            txtkota.Enabled = false;
            txtnik.Focus(); //--> kursor [indah
            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnEnd.Enabled = true;
            btnPrint.Enabled = true;
            btnFind.Enabled = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Visible = false;
            btnUndo.Visible = false;
            btnClose.Enabled = true;
        }


    }

}

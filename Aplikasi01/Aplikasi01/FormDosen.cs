using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi01
{
    public partial class FormDosen : Form
    {
        DataTable dataDosen = new DataTable();

        public FormDosen()
        {
            InitializeComponent();
            isiTable();
            dgvDosen.DataSource = this.dataDosen;
        }

        void isiTable() 
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "akademik";
            strCon.IntegratedSecurity = true;
            SqlConnection kon = new SqlConnection(strCon.ToString());
            kon.Open();
            SqlCommand cmd = new SqlCommand("Select * from dosen", kon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(this.dataDosen);
            kon.Close();

        }
    }
}

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
    public partial class Ruang : Form
    {
        public Ruang()
        {
            InitializeComponent();
            isiRtbRuang();
        }

        void isiRtbRuang()
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "akademik";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select*from ruang", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    RtbRuang.Text += dr.GetValue(0).ToString() + "\t" + dr.GetValue(1) + 
                        "\t" + dr.GetValue(2) + "\t" +dr.GetValue(3) + "\n";
                }
            }else
                MessageBox.Show("Tidak ada data!");
            con.Close();
        }
    }
}

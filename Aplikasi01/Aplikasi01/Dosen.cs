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
    public partial class Dosen : Form
    {
        DataTable dataDosen = new DataTable(); //1
        public Dosen()
        {
            InitializeComponent();
            dgvDosen.DataSource = this.dataDosen; //2
            isiTabel();//12
        }
        void isiTabel()//3
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder(); //4
            strCon.DataSource = ".\\SQLEXPRESS";//5
            strCon.InitialCatalog = "akademik";//6
            strCon.IntegratedSecurity = true;//7
            SqlConnection kon = new SqlConnection(strCon.ToString()); //Klik kanan resolve (3)
            kon.Open();//11
            SqlCommand cmd = new SqlCommand("SELECT * From dosen", kon); //8
            SqlDataAdapter da = new SqlDataAdapter(cmd);//9
            da.Fill(this.dataDosen);//10
            kon.Close();//12


        }
    }
}

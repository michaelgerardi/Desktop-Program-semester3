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
    public partial class FormLogin : Form
    {
        Tabel user = new Tabel("usernya", "inventory_tigger");
        private int baris;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName, pwd,pwdAsli;
            userName = txtUsername.Text.Trim();
            pwd = txtPassword.Text.Trim();
            int baris =  user.getBs().Find("userName", userName);
            if(baris >=0)
            {
                user.getBs().Position = baris;
                DataRowView pemakai = (DataRowView)user.getBs().Current;
                pwdAsli = ((DataRowView)user.getBs().Current).Row["password"].ToString();
                //MessageBox.Show(pwdAsli);
                if (pwd == pwdAsli)
                {
                    FormMenuUtama mf = new FormMenuUtama(pemakai);
                    mf.ShowDialog();
                    mf.Dispose();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show(" Gagal Login ");
            }

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin.Focus();
        }
    }
}

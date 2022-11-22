using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Vui lòng điền tên đăng nhập!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassWord.Text))
            {
                errorProvider2.SetError(txtPassWord, "Vui lòng điền mật khẩu!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "addmind" && txtPassWord.Text =="123456789")
            {
                this.Hide();
                errorProvider1.Clear();
                errorProvider2.Clear();
                frmHome home = new frmHome();
                home.ShowDialog();
                this.Close();

            }
            else
            {
                errorProvider1.SetError(txtUserName, "Vui lòng điền tên đăng nhập!");
                errorProvider2.SetError(txtPassWord, "Vui lòng điền mật khẩu!");

            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

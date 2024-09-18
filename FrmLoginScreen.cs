using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusinnesLayer;

namespace Bank_project_CSharp_WindowsForm
{
    public partial class FrmLoginScreen : Form
    {
        public FrmLoginScreen()
        {
            InitializeComponent();
        }

        string UserName,Password;
        public clsUser User;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {     
            UserName = txtUserName.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindUserByUserNameAndID(UserName, Password);
            if (user != null)
            {
                FrmBankSystemManagement bankSystemManagement = new FrmBankSystemManagement(user);
                bankSystemManagement.ShowDialog();
            }
            else
            {
                MessageBox.Show("InCorrect UserName and Password!", "Failed Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            User  = user;
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chkPassword.Checked = false;
            txtUserName.Text = "UserName";      
            txtPassword.Text = "Password";
            txtPassword.PasswordChar = '\0';
            
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPassword.Checked) txtPassword.PasswordChar = '*';
            else
                txtPassword.PasswordChar = '\0';

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!chkPassword.Checked)
            {
                txtPassword.PasswordChar = '*';
                
            }
            Password = txtPassword.Text;
        }
    }
}

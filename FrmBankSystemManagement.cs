using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using DataBusinnesLayer;

namespace Bank_project_CSharp_WindowsForm
{
    public partial class FrmBankSystemManagement : Form
    {
        clsUser _User;
        public FrmBankSystemManagement(clsUser User)
        {
            InitializeComponent();
            _User = User;
        }

        private void FrmBankSystemManagement_Load(object sender, EventArgs e)
        {
            lbluserName.Text = _User.UserName;
            lblUserDate.Text = DateTime.Now.ToString("d/M/yyyy h:m:s");
          
        }

        private void _LoadUserControl(UserControl UserControl)
        {
            ContentPanel.Controls.Clear();

            UserControl.Dock = DockStyle.Fill;

            ContentPanel.Controls.Add(UserControl); 
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeControl homeControl = new HomeControl();
            _LoadUserControl(homeControl);
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            ManageClientsControl manageCliemtsControl = new ManageClientsControl();
            _LoadUserControl(manageCliemtsControl);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
           
             TransactionsControl transactionsControl = new TransactionsControl(_User);
            _LoadUserControl(transactionsControl);
         
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
             ManageUsersControl manageUsersControl = new ManageUsersControl();
            _LoadUserControl(manageUsersControl);
        }
    }
}

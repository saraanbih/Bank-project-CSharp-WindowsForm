using DataBusinnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_project_CSharp_WindowsForm
{
    public partial class ManageUsersControl : UserControl
    {
        public ManageUsersControl()
        {
            InitializeComponent();
        }

        private void ManageUsersControl_Load(object sender, EventArgs e)
        {
            dgvGetAllUsers.DataSource = clsUser.GetAllUsers();
        }
    }
}

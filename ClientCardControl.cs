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
    public partial class ClientCardControl : UserControl
    {
       
        public ClientCardControl()
        {
            InitializeComponent();
        }

        clsClient _Client;
        private void ClientCardControl_Load(object sender, EventArgs e)
        {
           
                txtSearchByAccountNumber.Text = "Search By Account Number";
                lblID.Text = "???";
                lblName.Text = "???";
                lblAccountNumber.Text = "???";
                lblAccountBalance.Text = "???";
        }

        public string IDText
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }

        // Property to set the Account Balance label text
        public string AccountBalanceText
        {
            get { return lblAccountBalance.Text; }
            set { lblAccountBalance.Text = value; }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _Client = clsClient.FindClientByAccountNumber(txtSearchByAccountNumber.Text);
            if(_Client != null)
            {
                lblID.Text = _Client.ID.ToString();
                lblName.Text = _Client.ClientName.ToString();
                lblAccountNumber.Text = _Client.AccountNumber.ToString();
                lblAccountBalance.Text = _Client.AccountBalance.ToString();
                lblPinCode.Text = _Client.PinCode.ToString();
            }
        }

        private void txtSearchByAccountNumber_Enter(object sender, EventArgs e)
        {
            txtSearchByAccountNumber.Text = "";
        }
       
    }
}

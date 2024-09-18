using DataBusinnesLayer;
using System;
using System.Windows.Forms;

namespace Bank_project_CSharp_WindowsForm
{
    public partial class ctrClientCard : UserControl
    {
        public ctrClientCard()
        {
            InitializeComponent();
            txtSearchByAccountNumber.Text = "Search By Account Number";
            lblID.Text = "???";
            lblName.Text = "???";
            lblPinCode.Text = "???";
            lblAccountNumber.Text = "???";
            lblAccountBalance.Text = "???";
        }
        clsClient _Client;

        private void btnFind_Click(object sender, EventArgs e)
        {
            _Client = clsClient.FindClientByAccountNumber(txtSearchByAccountNumber.Text);
            if (_Client != null)
            {
                lblID.Text = _Client.ID.ToString();
                lblName.Text = _Client.ClientName.ToString();
                lblPinCode.Text = _Client.PinCode.ToString();
                lblAccountNumber.Text = _Client.AccountNumber.ToString();
                lblAccountBalance.Text = _Client.AccountBalance.ToString();
            }
        }
    }
}

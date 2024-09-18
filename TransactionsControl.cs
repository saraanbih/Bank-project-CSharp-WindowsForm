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
    public partial class TransactionsControl : UserControl
    {
        clsUser _User;
        public TransactionsControl(clsUser user)
        {
            InitializeComponent();
            _User = user;
        }

        void _ResfreshData()
        {
            dgvTransactions.DataSource = clsTransactions.GetClientsInfo();
        }
        private void TransactionsControl_Load(object sender, EventArgs e)
        {
            _ResfreshData();
        }

        private void txtSearchByAccountNumber_Click(object sender, EventArgs e)
        {
            txtSearchByAccountNumber.Text = "";
        }

        private void txtSearchByAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchByAccountNumber.Text))
            {
                // When the search box is cleared, reset the data to show all clients
                dgvTransactions.DataSource = clsTransactions.GetClientsInfo();

                // If the search box is not focused, show the placeholder text
                if (!txtSearchByAccountNumber.Focused)
                {
                    txtSearchByAccountNumber.Text = "Search By Account Number";
                    txtSearchByAccountNumber.ForeColor = Color.Gray;
                }
            }
            else
            {
                // Perform the search based on the input
                dgvTransactions.DataSource = clsTransactions.GetClientInfoByAccountNumber(txtSearchByAccountNumber.Text);
                txtSearchByAccountNumber.ForeColor = Color.Black;  // Make sure text color is normal during search
            }
        }

        private void txtSearchByAccountNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchByAccountNumber.Text))
            {
                txtSearchByAccountNumber.Text = "Search By Account Number";
                // Optionally change text color to indicate it's a placeholder
                txtSearchByAccountNumber.ForeColor = Color.Gray;
            }
            dgvTransactions.DataSource = clsTransactions.GetClientsInfo();
        }
        clsClient _Client;
        private void brnDeposit_Click(object sender, EventArgs e)
        {
            if(txtSearchByAccountNumber.Text == "")
            {
               MessageBox.Show("You should enter Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSearchByAccountNumber.Text == "Search By Account Number")
            {
                MessageBox.Show("You should enter Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmDeposit deposit = new FrmDeposit(clsClient.FindClientByAccountNumber(txtSearchByAccountNumber.Text));
            deposit.ShowDialog();
            _ResfreshData();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (txtSearchByAccountNumber.Text == "")
            {
                MessageBox.Show("You should enter Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSearchByAccountNumber.Text == "Search By Account Number")
            {
                MessageBox.Show("You should enter Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmWithdraw withdraw = new FrmWithdraw(clsClient.FindClientByAccountNumber(txtSearchByAccountNumber.Text));
            withdraw.ShowDialog();
            _ResfreshData();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            FrmTransfer transfer = new FrmTransfer(_User);
            transfer.ShowDialog();
            _ResfreshData();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FrmTransferLog transferLog = new FrmTransferLog();
            transferLog.ShowDialog();
        }
    }
}

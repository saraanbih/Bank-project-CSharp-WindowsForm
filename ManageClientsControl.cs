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
    public partial class ManageClientsControl : UserControl
    {
        public ManageClientsControl()
        {
            InitializeComponent();
        }

        private void _RefreshAllClients()
        {
           dgvGetAllClients.DataSource = clsClient.GetAllClients();
        }
      

        private void ManageCliemtsControl_Load(object sender, EventArgs e)
        {
            _RefreshAllClients();
            dgvGetAllClients.ClearSelection();
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            FrmAddOREditClient frmAddOREditClient = new FrmAddOREditClient(-1);
            frmAddOREditClient.ShowDialog();
            _RefreshAllClients();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ClientID = (int)dgvGetAllClients.CurrentRow.Cells[0].Value;
            FrmAddOREditClient frmAddOREditClient = new FrmAddOREditClient(ClientID);
            frmAddOREditClient.ShowDialog();
            _RefreshAllClients();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Are you sure you want to delete Client with ID = {dgvGetAllClients.CurrentRow.Cells[0].Value}?",
                "Confirm Delete",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsClient.DeleteClient((int)dgvGetAllClients.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Client Deleted Successfully :-)", "Delete Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshAllClients();
                }
                else
                {
                    MessageBox.Show("Failed To Delete This Contact :-(", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearchByAccountNumber_Click(object sender, EventArgs e)
        {
            txtSearchByAccountNumber.Text = "";
        }

        // Handle the text changed event to filter the DataGridView based on the search input
        private void txtSearchByAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchByAccountNumber.Text))
            {
                // When the search box is cleared, reset the data to show all clients
                dgvGetAllClients.DataSource = clsClient.GetAllClients();

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
                dgvGetAllClients.DataSource = clsClient.GetClientByAccountNumber(txtSearchByAccountNumber.Text);
                txtSearchByAccountNumber.ForeColor = Color.Black;  // Make sure text color is normal during search
            }
        }

        private void txtSearchByAccountNumber_Enter(object sender, EventArgs e)
        {
            if (txtSearchByAccountNumber.Text == "Search By Account Number")
            {
                txtSearchByAccountNumber.Text = "";
                // Optionally change text color to normal
                txtSearchByAccountNumber.ForeColor = Color.Black;
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
            dgvGetAllClients.DataSource = clsClient.GetAllClients();
        }

       
    }
}

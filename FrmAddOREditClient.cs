using DataBusinnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_project_CSharp_WindowsForm
{
    public partial class FrmAddOREditClient : Form
    {
        int _ClientID;
        clsClient _Client;
        enum enMode { AddNew = 0,Update = 1 }
        enMode _Mode;
        public FrmAddOREditClient(int ID)
        {
            InitializeComponent();
            _ClientID = ID;
            if (ID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _LoadData()
        {
            if(_Mode == enMode.AddNew)
            {
                lblAddOREdit.Text = "Add New Contact";
                lblClientID.Text = "???";
                _Client  = new clsClient();
                return;
            }

            _Client = clsClient.FindClientByID(_ClientID);

            if (_Client == null)
            {

                MessageBox.Show("This Form will be closed because no client with ID = " + _ClientID);
                this.Close();
                return;
            }

            lblAddOREdit.Text = $"Edit Client With ID = {_ClientID}";
            lblClientID.Text= _ClientID.ToString();
            txtAccountNumber.Text = _Client.AccountNumber;
            txtClientName.Text = _Client.ClientName;
            txtEmail.Text = _Client.Email;
            txtPhone.Text = _Client.Phone;
            txtPinCode.Text = _Client.PinCode.ToString();
            txtAccountBalance.Text = _Client.AccountBalance.ToString();
        }

        private void FrmAddOREditClient_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void txtAccountNumber_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Text = "";
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Text = "";
        }

        private void txtClientName_Click(object sender, EventArgs e)
        {
            txtClientName.Text = "";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtPinCode_Click(object sender, EventArgs e)
        {
            txtPinCode.Text = "";
        }

        private void txtAccountBalance_Click(object sender, EventArgs e)
        {
            txtAccountBalance.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           _Client.ClientName = txtClientName.Text;
           _Client.Email = txtEmail.Text;
           _Client.Phone = txtPhone.Text;
            // Safely parsing PinCode
            if (int.TryParse(txtPinCode.Text, out int pinCode))
            {
                _Client.PinCode = pinCode;
            }
            else
            {
                // Handle error: invalid PinCode input
            }

            // Safely parsing AccountBalance
            if (decimal.TryParse(txtAccountBalance.Text, out decimal accountBalance))
            {
                _Client.AccountBalance = accountBalance;
            }
            else
            {
                // Handle error: invalid AccountBalance input
            }

            _Client.AccountNumber = txtAccountNumber.Text;           

            if (_Client.Save())
            {
                MessageBox.Show("Data Saved Successfully :-)","Success Edit",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Didn't Save Successfully.","Failed Edit",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            _Mode = enMode.Update;

            lblAddOREdit.Text = "Edit Client ID = " + _Client.ID;
            lblClientID.Text = _Client.ID.ToString();
        }

        
    }
}

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
    public partial class FrmWithdraw : Form
    {
        clsClient _Client;
        int _Amount;
        public FrmWithdraw(clsClient client)
        {
            InitializeComponent();
            _Client = client;
        }

        private void FrmWithdraw_Load(object sender, EventArgs e)
        {
            ctrClientCardWithoutFind1.IDText = _Client.ID.ToString();
            ctrClientCardWithoutFind1.NameText = _Client.ClientName.ToString();
            ctrClientCardWithoutFind1.PinCodeText = _Client.PinCode.ToString();
            ctrClientCardWithoutFind1.AccountNumberText = _Client.AccountNumber.ToString();
            ctrClientCardWithoutFind1.AccountBalanceText = _Client.AccountBalance.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            txtAmount.Text = "";
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtAmount.Text)) 
                _Amount = Convert.ToInt32(txtAmount.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(clsTransactions.Withdraw(_Client.ID,_Amount))
                MessageBox.Show("Withdraw Successfully :-)","Withdraw Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Withdraw Failed :-(", "Withdraw Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ctrClientCardWithoutFind1.AccountBalanceText = (_Client.AccountBalance - _Amount).ToString();

        }
    }
}

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
    public partial class FrmTransfer : Form
    {
        clsUser _User;
        public FrmTransfer(clsUser user)
        {
            InitializeComponent();
            _User = user;
        }

        decimal _Amount;

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
               _Amount = decimal.Parse(txtAmount.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int SenderID = int.Parse(clientCardControl1.IDText);
            int ReceiverID = int.Parse(clientCardControl2.IDText);
            clsClient ClientS = clsClient.FindClientByID(SenderID);
            clsClient ClientR = clsClient.FindClientByID(ReceiverID);
            
           
            if(clsTransactions.Transfer(SenderID,ReceiverID,_Amount,_User,ClientS,ClientR))
            {
                MessageBox.Show("Transfered Successfully :-)", "Transfer Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clientCardControl1.AccountBalanceText = (decimal.Parse(clientCardControl1.AccountBalanceText) - _Amount).ToString();
                clientCardControl2.AccountBalanceText = (decimal.Parse(clientCardControl2.AccountBalanceText) + _Amount).ToString();
            }
            else
                MessageBox.Show("Transfered Failed :-(", "Transfer Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

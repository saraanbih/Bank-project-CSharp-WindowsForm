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
    public partial class ctrClientCardWithoutFind : UserControl
    {
        public ctrClientCardWithoutFind()
        {
            InitializeComponent();
        }

        // Property to set the ID label text
        public string IDText
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }

        // Property to set the Name label text
        public string NameText
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        // Property to set the Account Number label text
        public string AccountNumberText
        {
            get { return lblAccountNumber.Text; }
            set { lblAccountNumber.Text = value; }
        }

        // Property to set the PinCode label text
        public string PinCodeText
        {
            get { return lblPinCode.Text; }
            set { lblPinCode.Text = value; }
        }

        // Property to set the Account Balance label text
        public string AccountBalanceText
        {
            get { return lblAccountBalance.Text; }
            set { lblAccountBalance.Text = value; }
        }

        
    }

}

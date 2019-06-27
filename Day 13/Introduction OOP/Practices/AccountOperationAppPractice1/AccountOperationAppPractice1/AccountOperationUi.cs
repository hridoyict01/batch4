using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account accountObj = new Account();
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        public void CreateButton_Click(object sender, EventArgs e)
        {
         
            accountObj.customerName = customerNameTextBox.Text;
            accountObj.accountNumber = accountNoTextBox.Text;
            customerNameTextBox.Clear();
            accountNoTextBox.Clear();
        }

        public void DipositButton_Click(object sender, EventArgs e)
        {
           
            int amount = Convert.ToInt32(amountTextBox.Text);
            accountObj.DepositAmount(amount);
            amountTextBox.Clear();

        }

        public void WithdrawButton_Click(object sender, EventArgs e)
        {
           
            int amount = Convert.ToInt32(amountTextBox.Text);
            accountObj.WithdrawAmount(amount);
            amountTextBox.Clear();
        }

        public void ReportButton_Click(object sender, EventArgs e)
        {
         
            string FullInfo = accountObj.GetInfo();
            MessageBox.Show(FullInfo);
        }
    }
    
}

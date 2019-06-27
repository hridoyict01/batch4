using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecondExam.BLL;

namespace SecondExam
{
    public partial class TransactionForm : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(amountTextBox.Text);
            string account = accountNubmerTextBox.Text;
            int result = _customerManager.Deposit(amount,account);
            if (result > 0)
            {
                MessageBox.Show("Deposite Successful");
            }
            else
            {
                MessageBox.Show("Failed to Deposite");
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(amountTextBox.Text);
            string account = accountNubmerTextBox.Text;
            //nt balance = _customerManager.Balance(account);
            int result = _customerManager.Withdraw(amount, account);
            if (result > 0)
            {
                MessageBox.Show("Withdraw Successful");
            }
            else
            {
                MessageBox.Show("Failed to Withdraw");
            }

        }
    }
}

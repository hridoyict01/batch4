using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecondExam.BLL;
using SecondExam.Models;

namespace SecondExam
{
    public partial class CustomerForm : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        private Customer customer;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            customer.AccountNumber = accountNumberTextBox.Text;
            customer.CustomerName = customerNameTextBox.Text;
            customer.Email = emailTextBox.Text;
            customer.Balance = 0;
            string date = openingDateTimePicker.Value.ToString("yyyy-MM-dd");
            customer.OpeingDate = date;
            int result;
            result = _customerManager.Save(customer);
            if (result > 0)
            {
                MessageBox.Show("New Customer Saved");
                customerNameTextBox.Clear();
                emailTextBox.Clear();
                accountNumberTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void accountNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string number = accountNumberTextBox.Text;
            int length = number.Length;
            if (length <= 7)
            {
                accountNumber.Text = "Must be at least eight character";
                
                this.Show();
            }
            else
            {
                accountNumber.Text = "";
            }
            
        }

//        private void accountNumberTextBox_Validating(object sender, CancelEventArgs e)
//        {
//            string number = accountNumberTextBox.Text;
//            int length = number.Length;
//            if (length<= 7)
//            {
//                accountNumber.Text = "Must be at least eight character";
//            }
//        }
    }
}

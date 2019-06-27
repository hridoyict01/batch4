using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
            this.Hide();
        }

        private void transactionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.ShowDialog();
            this.Hide();
        }

        private void saveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
            this.Hide();
        }
    }
}

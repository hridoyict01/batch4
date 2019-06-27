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
    public partial class SearchForm : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string accountNumber = accountNubmerTextBox.Text;
            showDataGridView.DataSource = _customerManager.ShowCustomer(accountNumber);
        }
    }
}

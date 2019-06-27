using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
       
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.name = employeeNameTextBox.Text;
            employee.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            double medical = Convert.ToDouble(medicalAllowanceTextBox.Text);
            double house = Convert.ToDouble(homeRentTextBox.Text);
            string output = employee.SalaryCalculation(house, medical);
            MessageBox.Show(output);

        }

        
    }
}

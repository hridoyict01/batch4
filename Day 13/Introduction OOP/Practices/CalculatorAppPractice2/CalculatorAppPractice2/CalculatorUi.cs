using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        Calculator calculator = new Calculator();
        public CalculatorUi()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            int result = calculator.Add(firstNumber, secondNumber);
            resultTextBox.Text = Convert.ToString(result);

        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {

            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            int result = calculator.Subtraction(firstNumber, secondNumber);
            resultTextBox.Text = Convert.ToString(result);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {

            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            int result = calculator.Multiplication(firstNumber, secondNumber);
            resultTextBox.Text = Convert.ToString(result);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {

            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int result = calculator.Division(firstNumber, secondNumber);
            resultTextBox.Text = Convert.ToString(result);
        }
    }
}

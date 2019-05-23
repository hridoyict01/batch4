using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayFormThirdClass
{
    public partial class HomeForm : Form
    {
        private const int size = 10;
        int [] number = new int[size];
        private int index = 0;
        private string message = "";
        public HomeForm()
        {
            InitializeComponent();
        }

        private void 
            
            Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            number[index] = Convert.ToInt32(inputTextBox.Text);
            index++;

            for (int index = this.index-1; index < size; index++)
            {
                if (number[index] != 0)
                {
                    message += "value is " + number[index] + " at index " + index + "\n";
                }
            }

            showRichTextBox.Text = message;

        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            message = "Reverse array: \n";
            for (int index = this.index-1; index >= 0; index--)
            {
                message += "value is " + number[index] + " at index " + index + "\n";
            }
            showRichTextBox.Text = message;
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            message = "Summation value is : ";
            for (int index = 0; index < this.index; index++)
            {
                sum = sum + number[index];
            }

            message += " " + sum;
            showRichTextBox.Text = message;
        }
    }
}

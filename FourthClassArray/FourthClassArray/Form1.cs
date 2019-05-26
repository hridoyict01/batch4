using System;
using System.Windows.Forms;

namespace FourthClassArray
{
    public partial class Form1 : Form
    {
        //Global array declaration
         const int size = 10;
         int[] number = new int[size];
          string message = "";
          private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            message = "";
            int newNumber = Convert.ToInt32(InputTextBox.Text);
            
                number[index] = newNumber;
           

            message = message + Display();
            showRichTextBox.Text = message;
            index++;
        }

        private string Display()
        {
            string message = "";
            for (int j = 0; j < number.Length; j++)
            {
                if (number[j] != 0)
                {
                    message = message + "Elemet is" + number[j].ToString() + "\n";
                }

                
            }
            return message;
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            string message = "";
            message = "Input values: ";
            message = message+Display();
            message = message+ "Reverse array: \n";

            for (int i = size - 1; i >= 0; i--)
            {
                if (number[i] != 0)
                {
                    message = message + "Reverse value: " + number[i] +"\n";
                }
            }
            showRichTextBox.Text = message;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FourthClassArray
{
    public partial class LIstForm : Form
    {
       
        List<int> numbers = new List<int>();
        List<string> names = new List<string>();
        public LIstForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(inutTextBox.Text);
           
            numbers.Add(input);
            names.Add(nameTextBox.Text);
//            numbers.Add(1);
//            numbers.Add(10);
//            numbers.Add(20);
//            numbers.Add(300);

             message = "Out\n";
             message =  Display();
            showRichTextBox.Text = message;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string message = "Output using show button: \n";
            message += Display();
            showRichTextBox.Text = message;

        }

        public string Display()
        {

        private string message;
        int index = 0;
            foreach (int number in numbers)
            {
                message +="Id:"+ number +"  Name: "+names[index] + "\n";
                index++;
            }
            return message;
        }
    }
}

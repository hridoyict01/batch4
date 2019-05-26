using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourthClassArray
{
    public partial class LIstForm : Form
    {
        List<int> numbers = new List<int>();
        public LIstForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(inutTextBox.Text);
           
            numbers.Add(input);
//            numbers.Add(1);
//            numbers.Add(10);
//            numbers.Add(20);
//            numbers.Add(300);

            string message = "Output \n";
            foreach (int number in numbers)
            {
                message += number + "\n";
            }

            showRichTextBox.Text = message;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string message = "Output using show button: \n";
            foreach (int number in numbers)
            {
                message += number + "\n";
            }
            showRichTextBox.Text = message;

        }
    }
}

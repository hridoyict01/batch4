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
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int[] number = new int [size];

            number[0] = 10;
            number[3] = 20;
            number[5] = 30;

            string message = "";
            for (int index = 0; index < size; index++)
            {
                if (number[index] != 0)
                {
                    message += "value is " + number[index] + " at index " + index + "\n";
                }
            }

            showRichTextBox.Text = message;
        }
    }
}

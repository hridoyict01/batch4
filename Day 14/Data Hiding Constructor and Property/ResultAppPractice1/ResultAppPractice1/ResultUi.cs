using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultAppPractice1
{
    public partial class ResultUi : Form
    {
        private Student student;
        public ResultUi()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int physics = Convert.ToInt16(physicsTextBox.Text);
            int chemistry = Convert.ToInt16(chemistryTextBox.Text);
            int math = Convert.ToInt16(mathTextBox.Text);

            student = new Student(physics, chemistry, math);

            averageTextBox.Text = student.Average().ToString();
            greadeLetterTextBox.Text = student.Grade();
        }
    }
}

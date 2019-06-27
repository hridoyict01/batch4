using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInformationAppWalkthrough2
{
    public partial class PersonInformationUi : Form
    {
        public PersonInformationUi()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Person personobbj = new Person();
            personobbj.FirstName = firstNameTextBox.Text;
            personobbj.MiddleName = middleNameTextBox.Text;
            personobbj.LastName = lastNameTextBox.Text;

            string fullName = personobbj.GetFullName();

            fullNameTextBox.Text = fullName;
        }
    }
}

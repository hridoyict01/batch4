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
        private Person person;
        public PersonInformationUi()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            person = new Person();
            //
            person.FirstName = firstNameTextBox.Text;
            person.MiddleName = middleNameTextBox.Text;
            person.LastName = lastNameTextBox.Text;
            //
            reverseNameTextBox.Text = person.FirstName;
            fullNameTextBox.Text = person.FullName;
        }
    }
}

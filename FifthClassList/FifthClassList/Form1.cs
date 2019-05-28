using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifthClassList
{
    public partial class HomeForm : Form
    {

        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();
        public HomeForm()
        {
            InitializeComponent();
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
           
            string user = userTextBox.Text;
            string name;
            string ageText = ageTextBox.Text;
            int age;
            bool ageConvert;
            ageConvert = int.TryParse(ageText, out age);
            userLabel.Text = "";

            if (!ageConvert)
            {
                MessageBox.Show("Age must be integer");
                return;
            }
 
            if (String.IsNullOrEmpty(user))
            {
                userLabel.Text = "User can't be empty";
                return;
            }

            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("User name cant not be empty");
                return;
            }

            if (UserExist(user))
            {
                userLabel.Text = "User found,please change the user number";
                return;
            }

            
            name = nameTextBox.Text;
            
            
            users.Add(user);
            names.Add(name);
            ages.Add(age);
            string message;
            message = Display();
            showRichTextBox.Text = message;
        }


        public string Display()
        {
            string output;
            output = "\t User \t Name \t Age \n";
            foreach (string user in users)
            {
                int index = 0;
                output +="\t"+ user+"\t" + names[index] + "\t" + ages[index]+"\n";
                index++;
            }
            return output;
        }

        public bool UserExist(string user)
        {
            bool exists = false;
            foreach (string userList in users)
            {
                if (userList == user)
                {
                    exists = true;
                }
                
            }

            return exists;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentProject
{
    public partial class DepartmentUI : Form
    {
        public DepartmentUI()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString =
                    @"Server=PC-301-30\SQLEXPRESS; Database =StudentDBHridoy; Integrated Security = true";
                SqlConnection con = new SqlConnection(connectionString);
                //
                string commandString = @"INSERT INTO Departments VALUES ('English','Eng')";
                SqlCommand sqlCommand = new SqlCommand(commandString, con);

                con.Open();
                int isExecuted = 0;
                isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Successful");
                }
                else
                {
                    MessageBox.Show("Failed bro, better luck next time");
                }
                con.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show("booooommmmmmmm........Error found" + exception.Message);
                Console.WriteLine(exception);
                throw;
            }
         

        }
    }
}

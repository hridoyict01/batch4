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
        class Department
        {
            public string Name { get; set; }
            public string Code { get; set; }
        }
        public DepartmentUI()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //            string name = "Managment & Information System";
            //            string code = "MGT";
            Department department = new Department
            {
                Name = nameTextBox.Text,
                Code = codeTextBox.Text
            };
            Insert(department);
            Show();

        }

        private void Insert(Department department)
        {
            try
            {
                string connectionString = @"Server=PC-301-30\SQLEXPRESS; Database =StudentDBHridoy; Integrated Security = true";
                SqlConnection con = new SqlConnection(connectionString);
                //
                string commandString = @"INSERT INTO Departments VALUES ('"+department.Name+"','"+department.Code+"')";
                SqlCommand sqlCommand = new SqlCommand(commandString, con);

                con.Open();
                int isExecuted = 0;
                isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    messageLabel.Text = "Addition Successful";
                    
                    messageLabel.BackColor = Color.Green;
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

       

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void Show()
        {
            showGridView.DataSource = null;
            string connectionString = @"Server=PC-301-30\SQLEXPRESS; Database =StudentDBHridoy; Integrated Security = true";
            SqlConnection con = new SqlConnection(connectionString);
            //
            string commandString = @"SELECT *FROM Departments";
            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                showGridView.DataSource = dataTable;
            }

            con.Close();
        }
    }
}

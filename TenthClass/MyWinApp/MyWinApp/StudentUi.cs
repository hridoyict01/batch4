using MyWinApp.Models;
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

namespace MyWinApp
{
    public partial class StudentUi : Form
    {
        private int ID = 0;
        string connectionString = @"Server=PC-301-30\SQLEXPRESS; Database =StudentsBITM; Integrated Security = true";
        SqlConnection con;
        private string commandString;
        private SqlCommand sqlCommand;

        private Student student;
        public StudentUi()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            LoadDistrict();
            DisplayStudents();
        }

        private void LoadDistrict()
        {
            commandString = @"SELECT *from Districts";
            con.Open();
            sqlCommand = new SqlCommand(commandString,con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            districtComboBox.Items.Insert(0,"Select District");
            if (dataTable.Rows.Count > 0)
            {
                districtComboBox.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No District name found!!!!");
            }
            con.Close();
        }

        private void InsertStudent(Student student)
        {
           
            commandString = @"INSERT INTO Students VALUES ('"+student.RollNo+"','"+student.Name+"',"+student.Age+" ,'"+student.Address+"',"+student.DistrictID+")";
            con.Open();
            sqlCommand = new SqlCommand(commandString, con);
            int isExecuted;
           isExecuted = sqlCommand.ExecuteNonQuery();
           if (isExecuted > 0)
           {
               MessageBox.Show("Record added");
           }
          
           else
           {
               MessageBox.Show("Addition not possible");
           }
           con.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            student = new Student
            {
                RollNo = rollNoTextBox.Text,
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                Age = Convert.ToInt16(ageTextBox.Text),
                DistrictID = Convert.ToInt16(districtComboBox.SelectedValue)
            };
            
            if (student.ID == 0)
            {
                InsertStudent(student);
            }
            else
            {
                MessageBox.Show("" + student.ID);
            }

            displayDataGridView.DataSource = null;
            DisplayStudents();
        }

        private void DisplayStudents()
        {
            //commandString = @"SELECT s.RollNo,s.Name,s.Address,s.Age,d.Name FROM Students AS s JOIN Districts as d ON s.DistrictID = d.ID";
            commandString = @"SELECT *FROM StudentView";
            con.Open();
            sqlCommand = new SqlCommand(commandString,con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count>0)
            {
                displayDataGridView.DataSource = dataTable;
            }
           con.Close();
        }

        private void displayDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt16(displayDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            rollNoTextBox.Text =(displayDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            nameTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            addressTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            ageTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            //districtComboBox.SelectedValue = Convert.ToInt16(displayDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
            districtComboBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
            SaveButton.Text = "Update";
        }
    }
}

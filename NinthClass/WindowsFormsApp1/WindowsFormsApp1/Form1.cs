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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = nametextbox1.Text;


            SqlConnection sqlconnection=new SqlConnection();
            string ConnectionString = @"Server=PC-301-30\SQLEXPRESS; Database=StudentsDB;Integrated Security=True";
            sqlconnection.ConnectionString = ConnectionString;

            SqlCommand sqlCommand=new SqlCommand();
            string commandString = @"INSERT INTO Student(Name) VALUES('ODF')";
            sqlCommand.CommandText = commandString;
            sqlCommand.Connection = sqlconnection;

            sqlconnection.Open();
            int executed = 0;
            executed = sqlCommand.ExecuteNonQuery();
            if (executed > 0)
            {
                MessageBox.Show("Saved Successfully!");

            }
            else
            {
                MessageBox.Show("Not Saved");
            }
            sqlconnection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

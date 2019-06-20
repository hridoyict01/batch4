using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWinApp.Models;

namespace MyWinApp.Repository
{
    
   public class StudentRepository
    {
        //Global declaration here
        string connectionString = @"Server=PC-301-30\SQLEXPRESS; Database =StudentDBBitm; Integrated Security = true";
        SqlConnection con;
        private string commandString;
        private SqlCommand sqlCommand;
        //All database related methods will be here
        public DataTable LoadDistrict()
        {
            con = new SqlConnection(connectionString);
            commandString = @"SELECT *from Districts";
            con.Open();
            sqlCommand = new SqlCommand(commandString, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        internal int InsertStudent(Student student)
        {
            con = new SqlConnection(connectionString);
            commandString = @"INSERT INTO Students (RollNo, Name, Age, Address, DistrictID) VALUES ('" + student.RollNo + "', '" + student.Name + "', " + student.Age + ", '" + student.Address + "'," + student.DistrictID + ")";
            sqlCommand = new SqlCommand(commandString, con);
            con.Open();
            int isExecuted;  
            isExecuted = sqlCommand.ExecuteNonQuery();
            return isExecuted;
        }

        public DataTable ShowStudents()
        {
            con = new SqlConnection(connectionString);
            commandString = @"Select *from StudentsView";
            sqlCommand = new SqlCommand(commandString, con);
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public int DeleteStudent(int Id)
        {
            con = new SqlConnection(connectionString);
            commandString = @"Delete from Students Where ID ="+Id+"";
            sqlCommand = new SqlCommand(commandString, con);
            con.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            return isExecuted;
        }

        public DataTable SearchStudent(string name)
        {
            con = new SqlConnection(connectionString);
            commandString = @"Select *from StudentsView where Name='"+name+"'";
            sqlCommand = new SqlCommand(commandString, con);
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        internal int EditStudent(Student student, int Id)
        {
            con = new SqlConnection(connectionString);
            commandString = @"UPDATE Students  SET RollNo = '"+student.RollNo+ "',Name ='" + student.Name + "', Age = "+student.Age+ ", Address = '" + student.Address + "', DistrictID =" + student.DistrictID + " WHERE ID =" + Id+"";
            sqlCommand = new SqlCommand(commandString, con);
            con.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            return isExecuted;
        }

    }
}

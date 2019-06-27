using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data;
using  System.Data.SqlClient;
using System.Windows.Forms;
using SecondExam.Models;

namespace SecondExam.Repository
{
    
    
    public  class CustomerRepositoy
    {
        string connectionString = @"Server=PC-301-30\SQLEXPRESS; Database =Bank; Integrated Security = true";
        private SqlConnection con;
        private string commandString;
        private SqlCommand sqlCommand;

        public DataTable ShowCustomer(string accountNumber)
        {
            con = new SqlConnection(connectionString);
            commandString = @"Select *from CustomerView where AccountNumber='" + accountNumber + "'";
            sqlCommand = new SqlCommand(commandString, con);
            DataTable dataTable = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                
                dataAdapter.Fill(dataTable);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Accoured and " + ex.Message);
            }

            return dataTable;
        }

        public int Deposit(decimal amount, string accountNumber)
        {
            int result = 0;
            con = new SqlConnection(connectionString);
            commandString = "update Customers set balance= balance+" + amount + " where AccountNumber = '" +
                            accountNumber + "'";
            sqlCommand = new SqlCommand(commandString, con);
            try
            {
                con.Open();
                 result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return result;
        }
        public int Withdraw(decimal amount, string accountNumber)
        {
            int result = 0;
            con = new SqlConnection(connectionString);
            commandString = "update Customers set balance= balance-" + amount + " where AccountNumber = '" +
                            accountNumber + "'";
            sqlCommand = new SqlCommand(commandString, con);
            try
            {
                con.Open();
                 result = sqlCommand.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return result;
        }

        public int Save(Customer customer)
        {
            con = new SqlConnection(connectionString);
            int isExecuted = 0;
            commandString = @"INSERT INTO Customers (CustomerName, AccountNumber, Email, OpeningDate,balance) VALUES ('" + customer.CustomerName + "', '" + customer.AccountNumber + "', '" + customer.Email + "', '" + customer.OpeingDate + "'," + customer.Balance + ")";
            sqlCommand = new SqlCommand(commandString, con);
            try
            {
                con.Open();

                isExecuted = sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return isExecuted;
        }

//        public decimal Balance(string account)
//        {
//            con = new SqlConnection(connectionString);
//            decimal isExecuted = 0;
//            commandString = @"Select balance from Customers where AccountNumber = '" + account + "'";
//            sqlCommand = new SqlCommand(commandString, con);
//            try
//            {
//                con.Open();
//
//                isExecuted = sqlCommand.e
//                con.Close();
//            }
//            catch (Exception exception)
//            {
//                MessageBox.Show(exception.Message);
//            }
//
//            return isExecuted;
//        }
    }
}

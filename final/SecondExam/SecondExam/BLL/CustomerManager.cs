using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondExam.Models;
using SecondExam.Repository;

namespace SecondExam.BLL
{
    
    public class CustomerManager
    {
        CustomerRepositoy _customerRepositoy = new CustomerRepositoy();

        public DataTable ShowCustomer(string accountNubmer)
        {
            return _customerRepositoy.ShowCustomer(accountNubmer);
        }

        public int Deposit(decimal amount, string accountNumber)
        {
            return _customerRepositoy.Deposit(amount, accountNumber);
        }
        public int Withdraw(decimal amount, string accountNumber)
        {
            return _customerRepositoy.Withdraw(amount, accountNumber);
        }

        public int Save(Customer customer)
        {
            return _customerRepositoy.Save(customer);
        }

//        public decimal Balance(string account)
//        {
//            return _customerRepositoy.Balance(account);
//        }
    }
}

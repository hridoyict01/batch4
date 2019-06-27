using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    class Account
    {
        public string customerName;
        public string accountNumber;
       
        public int currentBalance;

        public void DepositAmount(int amount)
        {

            currentBalance = currentBalance + amount;
           
        }
        public void WithdrawAmount(int amount)
        {

            currentBalance = currentBalance - amount;
            
        }

        public string GetInfo()
        {
            string FullInfo ="Customer Name: "+ customerName + " Account Number: " + accountNumber + " Account Balance: " + currentBalance;
            return FullInfo;
        }





    }
}

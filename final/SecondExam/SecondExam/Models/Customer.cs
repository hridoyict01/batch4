using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExam.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string AccountNumber { get; set; }
        public string Email { get; set; }
        
        public string OpeingDate { get; set; }

        public decimal Balance { get; set; }
    }
}

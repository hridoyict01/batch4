using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
  public  class Employee
    {
        public string name;
        public double basicAmount;

        public double getHouseRent(double basicAmount, double homeRent)
        {
            return (basicAmount * homeRent) / 100;
        }
        public double getMedicalAllowlance(double basicAmount, double medical)
        {
            return (basicAmount * medical) / 100;
        }

        public string SalaryCalculation( double home, double medical)
        {
            double totalSalary = basicAmount + getMedicalAllowlance(basicAmount, medical) + getHouseRent(basicAmount, home);
            return "Your Name: "+name+". Your salary is : " + totalSalary;
        }
    }
}

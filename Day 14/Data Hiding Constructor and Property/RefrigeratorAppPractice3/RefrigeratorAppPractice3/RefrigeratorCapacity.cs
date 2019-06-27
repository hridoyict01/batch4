using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class RefrigeratorCapacity
    {
        public double MaxWeight { get; set; }

        public double CurrentWeight { get; set; }

        public double RemainingWeight(double weight)
        {
            double result;
            CurrentWeight = CurrentWeight + weight;
            if (MaxWeight < CurrentWeight)
            {
                result = -1;
            }
            else
            {
                result =  MaxWeight - CurrentWeight;
            }

            return result;
        }



    }
}

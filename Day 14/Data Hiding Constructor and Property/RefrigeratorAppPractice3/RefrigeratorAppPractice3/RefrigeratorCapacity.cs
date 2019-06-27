using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class RefrigeratorCapacity
    {
        private double maxWeight;

        public double CurrentWeight { get; set; }

        public RefrigeratorCapacity(double maxWeight)
        {
            this.maxWeight = maxWeight;
        }

        public double RemainingWeight(double weight)
        {
            double reminingWeight;
            CurrentWeight = CurrentWeight + weight;
            reminingWeight = maxWeight - CurrentWeight;

            return reminingWeight;
        }



    }
}

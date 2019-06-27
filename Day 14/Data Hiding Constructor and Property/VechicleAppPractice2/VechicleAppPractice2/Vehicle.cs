using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    class Vehicle
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }

        public List<int> Speed { get; set; } = new List<int>();

        public double MinSpeed()
        {
            return Speed.Min();
        }
        public double MaxSpeed()
        {
            return Speed.Max();
        }
        public double AverageSpeed()
        {
            return Speed.Average();
        }
    }
}

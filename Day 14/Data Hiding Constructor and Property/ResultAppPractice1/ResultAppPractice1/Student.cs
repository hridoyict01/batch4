using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultAppPractice1
{
    class Student
    {
        
//        public int Physics { get; set; }
//        public int Chemistry { get; set; }
//        public int Math { get; set; }

        private int physics;
        private int chemistry;
        private int math;

        public Student(int physics, int chemistry, int math)
        {
            this.chemistry = chemistry;
            this.physics = physics;
            this.math = math;
        }



        public double Average()
        {
            double total = physics + chemistry + math;
           double  avg = total / 3;
            return avg;
        }

        public string Grade()
        {
            double avg = Average();
            if (avg >= 80)
            {
                return "A+";
            }
            else if (avg >= 70)
            {
                return "A";
            }
            else if (avg >= 60 )
            {
                return "A-";
            }
            else
            {
                return "Failed";
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformationAppWalkthrough2
{
    class Person
    {
        // Field init with property
//        private string firstName;
//        private string middleName;
//        private string lastName;
//
//
//        public string FirstName
//        {
//            get { return firstName; }
//            set { firstName = value; }
//        }
//
//        public string MiddleName
//        {
//            get { return middleName; }
//            set { middleName = value; }
//        }
//
//        public string LastName
//        {
//            get { return lastName; }
//            set { lastName = value; }
//        }
//
//        public string FullName
//        {
//            get { return GetFullName();  }
//        }
//
//        private string GetFullName()
//        {
//            return FirstName + " " + MiddleName + " " + LastName;
//        }
//       public string GetReverseName()
//        {
//            return null;
//        }

        //Auto implemented property Example

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return GetFullName(); }
        }

        private string GetFullName()
        {
            return "Mr. "+FirstName + " " + MiddleName + " " + LastName;
        }
        
    }
}

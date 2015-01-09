using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string Get1FullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            string reverseName="";
            foreach (char c in Get1FullName().Reverse())
            {
                reverseName += c;
            }
            return reverseName;
        }
    }
}

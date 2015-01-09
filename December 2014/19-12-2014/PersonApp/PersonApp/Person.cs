using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
        public string FirstName
        {
            set { firstName = value; }
        }
        public string MiddleName
        {
            set { middleName = value; }
        }

        public string LastName
        {
            set { lastName = value; }
        }
        public string Get1FullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            string reverseName="";
            foreach (char c in Get1FullName().Reverse())
                reverseName += c;
            return reverseName;
        }
    }
}

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

        public Person(string firstName)
        {
            this.firstName = firstName;
        }

        public Person(string firstName, string lastName): this(firstName)
        {
            this.lastName = lastName;
        }
        public Person(string firstName, string middleName, string lastName): this(firstName, lastName)
        {
            this.middleName = middleName;
        }

        public string Get1FullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            string reverseName="";
            foreach (char reverseCharacter in Get1FullName().Reverse())
                reverseName += reverseCharacter;
            return reverseName;
        }
    }
}

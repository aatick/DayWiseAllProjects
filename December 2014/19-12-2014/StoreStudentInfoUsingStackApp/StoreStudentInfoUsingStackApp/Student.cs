using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreStudentInfoUsingStackApp
{
    class Student
    {
        public string firstName;
        public string lastName;
        public int regNo;

        public string FullName
        {
            get { return firstName + " " + lastName; }
        }
    }
}

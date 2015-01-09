using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class StartUp
    {
        public static void Main()
        {
            Person aPerson=new Person("James");
            Console.WriteLine(aPerson.Get1FullName());
            Console.WriteLine(aPerson.GetReverseName());
            Console.ReadKey();
        }
    }
}

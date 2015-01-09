using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithUserDefinedType
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students=new Student[3];
            Student student1=new Student();
            Student student2=new Student();
            Student student3=new Student();
            
            student1.regNo = "1234";
            student1.firstName = "Rakib";
            student1.lastName = "Hasan";
            student2.regNo = "9807";
            student2.firstName = "Sharmin";
            student2.lastName = "Sultana";
            student3.regNo = "0087";
            student3.firstName = "Tania";
            student3.lastName = "Yeasmin";
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
            Console.WriteLine("Reg. No."+"    "+"Name");
            for(int i=1; i<=("Reg. No.").Length; i++)
                Console.Write("-");
            Console.Write("    ");
            for (int i = 1; i <= ("Name").Length; i++)
                Console.Write("-");
            Console.WriteLine();
            foreach (Student aStudent in students)
            {
                Console.Write(aStudent.regNo);
                for(int i=1; i<=("Reg. No.").Length-aStudent.regNo.Length; i++)
                    Console.Write(" ");
                Console.WriteLine("    "+aStudent.FullName);
            }
        }
    }
}

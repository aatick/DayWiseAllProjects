using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApp
{
    class Department
    {
        public int Code { set; get; }
        public string Name { set; get; }
        private List<Student> students;
        private const int MAX_NO_OFSTUDENTS = 15;

        public Department()
        {
                students = new List<Student>();
        }
        public Department(int code, string name):this()
        {
            Code = code;
            Name = name;
        }

        public void AddStudent(Student aStudent)
        {
            //if (students.Count >= MAX_NO_OFSTUDENTS)
            //    return "Overflow";

            if (IsRegNoExist(aStudent))
                throw new DuplicateRegNoException();
            students.Add(aStudent);
        }

        private bool IsRegNoExist(Student aStudent)
        {
            foreach (Student student in students)
            {
                if (student.RegNo == aStudent.RegNo)
                    return true;
            }
            return false;
        }

        public Student[] GetAllStudents()
        {
            return students.ToArray();
        }
    }

    class DuplicateRegNoException : Exception
    {
        public DuplicateRegNoException() : base("A Student with same RegNo already exist.")
        {
        }
    }
}

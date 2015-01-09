using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDepartmentAssociationInfoApp
{
    class Department
    {
        public string Code { set; get; }
        public string Name { set; get; }
        private Dictionary<string, Student> students;

        public Department(string code, string name):this()
        {
            Code = code;
            Name = name;
        }
        public Department()
        {
            students=new Dictionary<string, Student>();
        }

        public void AddStudent(Student aStudent,DepartmentList allDepartmentList)
        {
            foreach (Department aDepartment in allDepartmentList.GetAllDepartments())
            {
                foreach (Student student in aDepartment.GetAllStudents())
                {
                    if(student.RegNo==aStudent.RegNo)
                        throw new DuplicateRegNoexception();
                }
            }
            students.Add(aStudent.RegNo,aStudent);
        }
        public Student[] GetAllStudents()
        {
            return students.Values.ToArray();
        }
        
    }

    public class DuplicateRegNoexception : Exception
    {
        public DuplicateRegNoexception() : base("A student with same reg No is already Exist.")
        {
        }
    }
}

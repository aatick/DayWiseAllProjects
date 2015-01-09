using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDepartmentAssociationInfoApp
{
    class DepartmentList
    {
        private Dictionary<string, Department> departments;

        public DepartmentList()
        {
            departments=new Dictionary<string, Department>();
        }

        public void AddDepartment(Department aDepartment)
        {
            if (departments.ContainsKey(aDepartment.Code))
                throw new DuplicateDepartmentException();
            departments.Add(aDepartment.Code,aDepartment);
        }

        public Department[] GetAllDepartments()
        {
            return departments.Values.ToArray();
        }
    }

    class DuplicateDepartmentException : Exception
    {
        public DuplicateDepartmentException(): base("A department with same Code has already been existed.")
        {
        }
    }

    class DepartmentNotFoundException : Exception
    {
        public DepartmentNotFoundException() : base("Department is not Exist.")
        {
        }
    }
}

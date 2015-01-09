using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentEmployeeWebApp.DBManager.DAO
{
    public class Employee
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string Address { set; get; }
        public string PhoneNumber { set; get; }
        public Department EmployeeDepartment { set; get; }
        public bool IsConfirmed { set; get; }
    }
}
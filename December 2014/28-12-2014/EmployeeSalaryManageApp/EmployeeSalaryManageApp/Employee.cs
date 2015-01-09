using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryManageApp
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Salary EmployeeSalary { get; set; }

        public Employee(int id, string name, string email, Salary employeeSalary)
        {
            Id = id;
            Name = name;
            Email = email;
            EmployeeSalary = employeeSalary;
        }
    }
}

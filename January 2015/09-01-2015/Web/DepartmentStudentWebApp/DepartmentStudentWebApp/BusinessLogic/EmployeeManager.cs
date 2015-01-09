using DepartmentEmployeeWebApp.DBManager.DAL;
using DepartmentEmployeeWebApp.DBManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentEmployeeWebApp.BusinessLogic
{
    public class EmployeeManager
    {
        EmployeeGateWay anEmployeeGateWay = new EmployeeGateWay();
        public void Add(Employee anEmployee)
        {
            anEmployeeGateWay.Add(anEmployee);
        }
        public Employee[] GetEmployeesByDepartmentId(int id)
        {
            return anEmployeeGateWay.GetEmployees(id).ToArray();
        }
        public void Confirm(int employeeId)
        {
            anEmployeeGateWay.ConfirmEmployee(employeeId);
        }
    }
}
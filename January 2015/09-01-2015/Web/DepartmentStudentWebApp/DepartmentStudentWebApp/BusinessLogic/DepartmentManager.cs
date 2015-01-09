using DepartmentEmployeeWebApp.DBManager.DAL;
using DepartmentEmployeeWebApp.DBManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentEmployeeWebApp.BusinessLogic
{
    public class DepartmentManager
    {
        DepartmentGateWay aDepartmentGateWay = new DepartmentGateWay();
        public Department[] GetAllDepartments()
        {
            return aDepartmentGateWay.GetAllDepartments().ToArray();
        }
        public Department GetDepartmentById(int id)
        {
            return aDepartmentGateWay.GetDepartmentById(id);
        }
    }
}
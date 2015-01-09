using DepartmentEmployeeWebApp.DBManager.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DepartmentEmployeeWebApp.DBManager.DAL
{
    public class EmployeeGateWay
    {
        private DepartmentGateWay aDepartmentGateWay = new DepartmentGateWay();
        private const string connectionString = @"data source=LICT\SQLEXPRESS;initial catalog=UniversityDB;integrated security=true;";
        private SqlConnection aSqlConnection = new SqlConnection(connectionString);
        SqlCommand aSqlCommand;
        SqlDataReader aSqlDataReader;
        private string query = "";
        public void Add(Employee anEmployee)
        {
            query = "insert into tbl_employee values('" + anEmployee.FirstName + "','" + anEmployee.Address + "','" + anEmployee.PhoneNumber + "'," + anEmployee.EmployeeDepartment.Id + ")";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }
        public List<Employee> GetEmployees(int departmentId)
        {
            List<Employee> employees = new List<Employee>();
            query = "select * from tbl_employee where department_id=" + departmentId;
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlDataReader = aSqlCommand.ExecuteReader();
            while(aSqlDataReader.Read())
            {
                Employee anEmployee = new Employee();
                anEmployee.Id = Convert.ToInt32(aSqlDataReader["id"]);
                anEmployee.FirstName = aSqlDataReader["first_name"].ToString();
                anEmployee.Address = aSqlDataReader["employee_address"].ToString();
                anEmployee.PhoneNumber = aSqlDataReader["phone_Nnumber"].ToString();
                anEmployee.EmployeeDepartment = aDepartmentGateWay.GetDepartmentById(Convert.ToInt32(aSqlDataReader["department_id"]));
                anEmployee.IsConfirmed = Convert.ToBoolean(aSqlDataReader["IsConfirmed"]);
                employees.Add(anEmployee);
            }
            aSqlConnection.Close();
            return employees;
        }
        public void ConfirmEmployee(int employeeId)
        {
            query = "update tbl_employee set IsConfirmed='" + 1 + "' where id=" + employeeId;
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }
    }
}
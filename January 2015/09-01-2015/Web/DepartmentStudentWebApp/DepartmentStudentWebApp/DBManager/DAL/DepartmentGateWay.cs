using DepartmentEmployeeWebApp.DBManager.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DepartmentEmployeeWebApp.DBManager.DAL
{
    public class DepartmentGateWay
    {
        private const string connectionString=@"data source=LICT\SQLEXPRESS;initial catalog=UniversityDB;integrated security=true;";
        private SqlConnection aSqlConnection=new SqlConnection(connectionString);
        private SqlCommand aSqlCommand;
        SqlDataReader aSqlDataReader;
        private string query = "";
        public List<Department> GetAllDepartments()
        {
            List<Department> departments=new List<Department>();
            query="select * from tbl_department";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlDataReader=aSqlCommand.ExecuteReader();
            while(aSqlDataReader.Read())
            {
                Department aDepartment=new Department();
                aDepartment.Id=Convert.ToInt32(aSqlDataReader["id"]);
                aDepartment.Name=aSqlDataReader["name"].ToString();
                departments.Add(aDepartment);
            }
            aSqlConnection.Close();
            return departments;
        }
        public Department GetDepartmentById(int id)
        {
            query = "select * from tbl_department where id=" + id;
            Department aDepartment = new Department();
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlDataReader = aSqlCommand.ExecuteReader();
            while (aSqlDataReader.Read())
            {                
                aDepartment.Id = Convert.ToInt32(aSqlDataReader["id"]);
                aDepartment.Name = aSqlDataReader["name"].ToString();
            }
            aSqlConnection.Close();
            return aDepartment;
        }
    }
}
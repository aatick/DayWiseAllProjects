using DepartmentEmployeeWebApp.BusinessLogic;
using DepartmentEmployeeWebApp.DBManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DepartmentEmployeeWebApp.UI
{
    public partial class MainUI : System.Web.UI.Page
    {
        private DepartmentManager aDepartmentManager = new DepartmentManager();
        private EmployeeManager anEmployeeManager = new EmployeeManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                departmentDropdownList.DataSource = aDepartmentManager.GetAllDepartments().ToList();
                departmentDropdownList.DataTextField = "Name";
                departmentDropdownList.DataValueField = "Id";
                departmentDropdownList.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();
            anEmployee.FirstName = firstnameTextBox.Text;
            anEmployee.Address = addressTextBox.Text;
            anEmployee.PhoneNumber = phoneTextBox.Text;
            anEmployee.EmployeeDepartment = aDepartmentManager.GetDepartmentById(Convert.ToInt32(departmentDropdownList.SelectedItem.Value));
            anEmployeeManager.Add(anEmployee);
            ClientScript.RegisterStartupScript(this.GetType(),"MyMessage","alert('Employee Added.')",true);
        }

        protected void firstnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void makeConfirmation_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeUI.aspx");
        }
    }
}
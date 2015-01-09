using DepartmentEmployeeWebApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DepartmentEmployeeWebApp.UI
{
    public partial class EmployeeUI : System.Web.UI.Page
    {
        private DepartmentManager aDepartmentManager = new DepartmentManager();
        private EmployeeManager anEmployeeManager = new EmployeeManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                departmentDropdownList.DataSource = aDepartmentManager.GetAllDepartments().ToList();
                departmentDropdownList.DataTextField = "Name";
                departmentDropdownList.DataValueField = "Id";
                departmentDropdownList.DataBind();
                FillEmployeeDropdownList(Convert.ToInt32(departmentDropdownList.SelectedItem.Value));
            }
        }
        public void FillEmployeeDropdownList(int departmentId)
        {
            employeeDropdownList.DataSource = anEmployeeManager.GetEmployeesByDepartmentId(departmentId).ToList();
            employeeDropdownList.DataTextField = "FirstName";
            employeeDropdownList.DataValueField = "Id";
            employeeDropdownList.DataBind();
        }

        protected void confirmButton_Click(object sender, EventArgs e)
        {
            anEmployeeManager.Confirm(Convert.ToInt32(employeeDropdownList.SelectedItem.Value));
            ClientScript.RegisterStartupScript(this.GetType(), "MyMessage", "alert('Employee Confirmed.')", true);
        }

        protected void departmentDropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillEmployeeDropdownList(Convert.ToInt32(departmentDropdownList.SelectedItem.Value));
        }
    }
}
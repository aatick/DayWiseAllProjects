using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }
        
        private void showButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee = new Employee(employeeNameTextBox.Text,float.Parse(basicSalaryTextBox.Text),float.Parse(houseRentTextBox.Text),float.Parse(medicalAllowanceTextBox.Text));

            MessageBox.Show(employeeNameTextBox.Text+"Your Total Salary is: " + aEmployee.CalculateTotalSalary());
        }
    }
}

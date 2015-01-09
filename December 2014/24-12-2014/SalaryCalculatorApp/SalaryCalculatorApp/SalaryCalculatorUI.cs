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
            EmployeeSalary anEmployeeSalary = new EmployeeSalary(employeeNameTextBox.Text, double.Parse(basicSalaryTextBox.Text), double.Parse(houseRentTextBox.Text), double.Parse(medicalAllowanceTextBox.Text));

            MessageBox.Show(anEmployeeSalary.Name + ", Your Total Salary is: " + anEmployeeSalary.CalculateTotalSalary());
        }
    }
}

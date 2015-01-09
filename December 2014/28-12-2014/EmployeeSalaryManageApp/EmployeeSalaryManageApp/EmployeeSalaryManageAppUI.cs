using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryManageApp
{
    public partial class EmployeeSalaryManageAppUI : Form
    {
        public EmployeeSalaryManageAppUI()
        {
            InitializeComponent();
        }
        private Employee anEmployee;
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                anEmployee = new Employee(int.Parse(idTextBox.Text), nameTextBox.Text, emailTextBox.Text,
                    new Salary(double.Parse(basicSalaryTextBox.Text), double.Parse(medicalPercentageTextBox.Text),
                        double.Parse(conveyancePercentageTextBox.Text)));
                MessageBox.Show(@"Employee & Salary Information has been successfully saved.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(@"Please Enter all the field.");
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Invalid input!! Please Check all the field.");
            }
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            try
            {
                anEmployee.EmployeeSalary.Increase(double.Parse(increaseTextBox.Text));
                MessageBox.Show(@"Salary has been increased by " + increaseTextBox.Text + @" % of basic.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(@"Please Enter all the field.");
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Invalid input!! Please Check");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(@"Please Creat an Employee first.");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                noOfIncrementTextBox.Text = anEmployee.EmployeeSalary.NumberOfIncrements.ToString();
                basicDisplayTextBox.Text = anEmployee.EmployeeSalary.Basic.ToString();
                medicalAmountTextBox.Text = anEmployee.EmployeeSalary.MedicalAllowance.ToString();
                conveyanceAmountTextBox.Text = anEmployee.EmployeeSalary.ConveyanceAllowance.ToString();
                totalTextBox.Text = anEmployee.EmployeeSalary.TotalSalary.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(@"Please Creat an Employee first.");
            }
        }
    }
}

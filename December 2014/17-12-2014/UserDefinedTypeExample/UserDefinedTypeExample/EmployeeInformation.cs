using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public partial class EmployeeInformationUI : Form
    {
        public EmployeeInformationUI()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        Employee employee=new Employee();
        
        private void showButton_Click(object sender, EventArgs e)
        {
            employee.id = idTextBox.Text;
            employee.name = nameTextBox.Text;
            employee.salary = long.Parse(salaryTextBox.Text);
            MessageBox.Show("ID: " + employee.id + "\n" + "Name: " + employee.name + "\n" + "Salary: " + employee.salary);
            idTextBox.Clear();
            nameTextBox.Clear();
            salaryTextBox.Clear();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = employee.id;
            nameTextBox.Text = employee.name;
            salaryTextBox.Text = employee.salary.ToString();
        }
    }
}

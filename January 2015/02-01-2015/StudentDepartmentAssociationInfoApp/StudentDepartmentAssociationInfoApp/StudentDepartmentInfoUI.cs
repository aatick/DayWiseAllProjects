using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDepartmentAssociationInfoApp
{
    public partial class StudentDepartmentInfoUI : Form
    {
        public StudentDepartmentInfoUI()
        {
            InitializeComponent();
        }

        private DepartmentList departmentList = new DepartmentList();

        private void deptSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Department aDepartment = new Department(deptCodeTextBox.Text, deptNameTextBox.Text);
                departmentList.AddDepartment(aDepartment);
                FillComboBoxWithDepartmentName(studentDeptComboBox);
                FillComboBoxWithDepartmentName(selectDeptComboBox);
                MessageBox.Show(@"Department Saved.");
            }
            catch (DuplicateDepartmentException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void FillComboBoxWithDepartmentName(ComboBox aComboBox)
        {
            aComboBox.DataSource = null;
            aComboBox.DataSource = departmentList.GetAllDepartments();
            aComboBox.DisplayMember = "Name";
            aComboBox.ValueMember = "Code";
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Department aDepartment = (Department) studentDeptComboBox.SelectedItem;
                Student aStudent = new Student(studentRegNoTextBox.Text, studentNameTextBox.Text,studentEmailTextBox.Text);
                aDepartment.AddStudent(aStudent, departmentList);
                MessageBox.Show(@"Student Info Saved.");
            }
            catch (DuplicateRegNoexception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Department selectedDepartment = (Department) selectDeptComboBox.SelectedItem;
            string message = "Dept. Code: " + selectedDepartment.Code + "\tDept. Name: " + selectedDepartment.Name +
                             "\nStudent Info:\nReg No\t\tName\t\tEmail\n";
            foreach (Student aStudent in selectedDepartment.GetAllStudents())
                message += aStudent.RegNo + "\t\t" + aStudent.Name + "\t\t" + aStudent.Email + "\n";
            MessageBox.Show(message);
        }
    }
}

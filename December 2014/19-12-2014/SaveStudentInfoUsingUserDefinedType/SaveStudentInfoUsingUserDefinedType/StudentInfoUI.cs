using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveStudentInfoUsingUserDefinedType
{
    public partial class StudentInfoUI : Form
    {
        public StudentInfoUI()
        {
            InitializeComponent();
        }
        List<Student> studentList =new List<Student>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            int reg = 0;
                if (regNoTextBox.Text != string.Empty && firstNameTextBox.Text != string.Empty &&
                    lastNameTextBox.Text != string.Empty)
                {
                    try
                    {
                        reg = int.Parse(regNoTextBox.Text);
                        Student student1 = new Student();
                        student1.regNo = reg;
                        student1.firstName = firstNameTextBox.Text;
                        student1.lastName = lastNameTextBox.Text;
                        studentList.Add(student1);
                        MessageBox.Show("Student has been successfully added");
                    }
                    catch
                    {
                        MessageBox.Show(
                            "Invalid Reg. No. Reg. No. must not contain any character. only contains numbetrs.");
                    }
                }
                else
                {
                    MessageBox.Show("You must fill all the criteria.");
                }

        }

        string tempReg = "Registration No.";
        string tempName = "Name";
        private void showAllButton_Click(object sender, EventArgs e)
        {
            string formatString = string.Empty;
            formatString = tempReg + "\t" + tempName+"\n";
            for (int i = 1; i <= tempReg.Length; i++)
                formatString += "-";
            formatString += "\t";
            for (int i = 1; i <= tempName.Length; i++)
                formatString += "-";
            formatString += "\n";
            foreach (Student aStudent in studentList)
            {
                formatString += aStudent.regNo.ToString();
                for (int i = 1; i <= tempReg.Length - (aStudent.regNo).ToString().Length; i++)
                    formatString += "  ";
                formatString += "\t" + aStudent.FullName+"\n";
            }
            MessageBox.Show(formatString);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            studentList.Clear();
            MessageBox.Show("All students information has been deleted.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApp
{
    public partial class StudentInfoUI : Form
    {
        public StudentInfoUI()
        {
            InitializeComponent();
        }
        Student student=new Student();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            student.regNo = regTextBox.Text;
            student.firstName = firstNameTextBox.Text;
            student.lastName = lastNameTextBox.Text;
            MessageBox.Show(student.fullName+", Your Reg. No. is: "+student.regNo);
            regTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            regTextBox.Text = student.regNo;
            firstNameTextBox.Text = student.firstName;
            lastNameTextBox.Text = student.lastName;
        }
    }
}

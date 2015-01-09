using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        static string myConnectionString = @"data source=(localdb)\v11.0; initial catalog=UniversityDB; integrated security=true;";
        SqlConnection mySqlConnection = new SqlConnection(myConnectionString);
        private Department aDepartment;

        private void departmentSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                aDepartment = new Department(int.Parse(departmentCodeTextBox.Text), depatmentNameTextBox.Text);
                string query = "insert into Department values(" + aDepartment.Code + ",'" + aDepartment.Name + "')";
                mySqlConnection.Open();
                SqlCommand aSqlCommand = new SqlCommand(query, mySqlConnection);
                aSqlCommand.ExecuteNonQuery();
                MessageBox.Show(@"Department Created.");
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            mySqlConnection.Close();
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student(studentRegNoTextBox.Text,studentNameTextBox.Text,studentEmailTextBox.Text);
            try
            {
                aDepartment.AddStudent(aStudent);
                string query = "insert into Students values('" + aStudent.Name + "','" + aStudent.Email + "','" +
                               aStudent.RegNo + "'," + aDepartment.Code + ")";
                mySqlConnection.Open();
                SqlCommand aSqlCommand = new SqlCommand(query, mySqlConnection);
                aSqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Student Added.");
            }
            catch (DuplicateRegNoException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            string message = "Dept. Code: " + aDepartment.Code + "\tName: " + aDepartment.Name + "\nStudents Info:\nReg No\t\tName\t\tEmail\n";
            foreach (var aStudent in aDepartment.GetAllStudents())
            {
                message += aStudent.RegNo + "\t\t" + aStudent.Name + "\t\t" + aStudent.Email + "\n";
            }
            MessageBox.Show(message);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            showListView.Items.Clear();
              string  query =
                    "select std.name,std.id,std.email,std.reg_no,dept.name from Students std inner join Department dept on std.dept_id=dept.id";
             
                if (searchStudentIdTextBox.Text != string.Empty)
                    query = "select std.name,std.id,std.email,std.reg_no,dept.name from Students std inner join Department dept on std.dept_id=dept.id where std.id="+int.Parse(searchStudentIdTextBox.Text);
            
            mySqlConnection.Open();
            SqlCommand aSqlCommand = new SqlCommand(query, mySqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            while (aSqlDataReader.Read())
            {
                ListViewItem aListViewItem=new ListViewItem(aSqlDataReader[0].ToString());
                aListViewItem.SubItems.Add(aSqlDataReader[1].ToString());
                aListViewItem.SubItems.Add(aSqlDataReader[2].ToString());
                aListViewItem.SubItems.Add(aSqlDataReader[3].ToString());
                aListViewItem.SubItems.Add(aSqlDataReader[4].ToString());
                showListView.Items.Add(aListViewItem);
            }
            mySqlConnection.Close(); 
        }

        private void StudentInfoUI_Load(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection.Close();
            }
            catch { }
        }
    }
}

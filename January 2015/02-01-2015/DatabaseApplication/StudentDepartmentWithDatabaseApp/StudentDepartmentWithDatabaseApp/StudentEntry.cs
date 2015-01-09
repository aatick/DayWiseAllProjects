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

namespace StudentDepartmentWithDatabaseApp
{
    public partial class StudentEntry : Form
    {
        public StudentEntry()
        {
            InitializeComponent();
        }
        MyDatabase aDatabase=new MyDatabase();
        private void studentsaveButton_Click(object sender, EventArgs e)
        {
            ComboBoxItem department = (ComboBoxItem) deptComboBox.SelectedItem;
            ComboBoxItem course = (ComboBoxItem)courseNameComboBox.SelectedItem;
            string query = "insert into Students values('" + nameTextBox.Text + "','" + emailTextBox.Text + "','" +
                           regNoTextBox.Text + "'," + department.Value + ","+course.Value+")";
            new MyDatabase().ExecuteQuery(query);
            MessageBox.Show("Saved");
        }

        private void deptComboBox_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void StudentDeptUI_Load(object sender, EventArgs e)
        {
            aDatabase.FillComboBox("Department", deptComboBox);
            aDatabase.FillComboBox("Course", courseNameComboBox);
        }
    }
}

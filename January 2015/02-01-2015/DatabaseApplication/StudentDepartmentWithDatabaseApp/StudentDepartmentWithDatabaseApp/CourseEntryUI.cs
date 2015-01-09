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
    public partial class CourseEntryUI : Form
    {
        public CourseEntryUI()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "insert into Course values(" + int.Parse(courseIdTextBox.Text) + ",'" +
                           courseNameTextBox.Text + "')";
            new MyDatabase().ExecuteQuery(query);
            MessageBox.Show("Saved");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDepartmentWithDatabaseApp
{
    public partial class SearchStudentsUI : Form
    {
        public SearchStudentsUI()
        {
            InitializeComponent();
        }
        string query =
                "select std.id,std.name,std.reg_no,std.email,dept.name from Students std left join Department dept on std.dept_id=dept.id";
        MyDatabase aDatabase=new MyDatabase();
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text != string.Empty)
                query =
                    "select std.id,std.name,std.reg_no,std.email,dept.name,crs.name from Students std inner join Department inner join Course crs dept on std.dept_id=dept.id and std.course_id=crs.id where std.id=" +
                    int.Parse(searchTextBox.Text);
            aDatabase.FillListView(query, studentListView);
        }

        private void searchByDeptNameButton_Click(object sender, EventArgs e)
        {
            if (searchDeptNameComboBox.Text != string.Empty)
                query =
                    "select std.id,std.name,std.reg_no,std.email,dept.name,crs.name from Students std inner join Department inner join Course crs dept on std.dept_id=dept.id and std.course_id=crs.id where dept.name=" +
                    int.Parse(searchDeptNameComboBox.Text);
            aDatabase.FillListView(query, studentListView);
        }

        private void searchByCourseButton_Click(object sender, EventArgs e)
        {
            if (searchDeptNameComboBox.Text != string.Empty)
                query =
                    "select std.id,std.name,std.reg_no,std.email,dept.name,crs.name from Students std inner join Department inner join Course crs dept on std.dept_id=dept.id and std.course_id=crs.id where crs.name=" +
                    int.Parse(searchCourseNameComboBox.Text);
            aDatabase.FillListView(query, studentListView);
        }

        private void SearchStudentsUI_Load(object sender, EventArgs e)
        {
            aDatabase.FillComboBox("Department",searchDeptNameComboBox);
            aDatabase.FillComboBox("Course",searchCourseNameComboBox);
        }
    }
}

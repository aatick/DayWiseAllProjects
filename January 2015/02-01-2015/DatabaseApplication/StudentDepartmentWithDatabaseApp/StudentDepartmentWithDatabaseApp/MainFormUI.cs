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
    public partial class MainFormUI : Form
    {
        public MainFormUI()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StudentEntry().Show();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeptEntryUI().Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CourseEntryUI().Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchStudentsUI().Show();
            ;
        }
    }
}

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
    public partial class DeptEntryUI : Form
    {
        public DeptEntryUI()
        {
            InitializeComponent();
        }

        private void deptSaveButton_Click(object sender, EventArgs e)
        {
            string query = "insert into Department values(" + int.Parse(deptIdTextBox.Text) + ",'" +
                           deptnameTextBox.Text + "')";
            new MyDatabase().ExecuteQuery(query);
            MessageBox.Show("Saved.");
        }
    }
}

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
    public partial class MenuExampleUI : Form
    {
        public MenuExampleUI()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            new ViewUI().Show();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            new StudentInfoUI().Show();
        }
    }
}

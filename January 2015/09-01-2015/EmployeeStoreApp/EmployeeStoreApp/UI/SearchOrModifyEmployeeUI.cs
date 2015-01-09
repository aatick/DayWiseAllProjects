using System.Windows.Forms;
using EmployeeStoreApp.BusinessClass;
using EmployeeStoreApp.DBModule.DAO;

namespace EmployeeStoreApp.UI
{
    public partial class SearchOrModifyEmployeeUI : Form
    {
        public SearchOrModifyEmployeeUI()
        {
            InitializeComponent();
        }

        private EmployeeManager anEmployeeManager;
        private void searchButton_Click(object sender, System.EventArgs e)
        {
            anEmployeeManager = new EmployeeManager();
            resultView.Items.Clear();
            GetSelectedEmployeeInResultView(nameTextBox.Text != string.Empty
                ? anEmployeeManager.GetEmployeesByName(nameTextBox.Text)
                : anEmployeeManager.GetAllEmployees());
        }

        private void GetSelectedEmployeeInResultView(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                ListViewItem aListViewItem = new ListViewItem(employee.Serial.ToString());
                aListViewItem.SubItems.Add(employee.Name);
                aListViewItem.SubItems.Add(employee.Email);
                aListViewItem.Tag = employee;
                resultView.Items.Add(aListViewItem);
            }
        }


        private void resultView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                ResultViewContextMenuStrip.Show(resultView, e.Location);
        }

        private void ResultViewcontextMenuStrip_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void ResultViewcontextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == editToolStripMenuItem)
            {
                
            }
            else if (e.ClickedItem == deleteToolStripMenuItem)
            {
                ResultViewContextMenuStrip.Hide();
                ListViewItem aListViewItem = resultView.SelectedItems[0];
                Employee anEmployee = (Employee) aListViewItem.Tag;
                anEmployeeManager.RemoveEmployee(anEmployee);
                MessageBox.Show(@"Selected Employee has been removed.");
                resultView.Items.Remove(aListViewItem);
            }
        }
    }
}

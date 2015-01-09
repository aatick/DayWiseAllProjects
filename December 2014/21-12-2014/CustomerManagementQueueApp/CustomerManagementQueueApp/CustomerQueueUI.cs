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

namespace CustomerManagementQueueApp
{
    public partial class CustomerQueueUI : Form
    {
        public CustomerQueueUI()
        {
            InitializeComponent();
        }
        Customer aCustomer=new Customer();
        int waitingCustomerId = 0;
        enum CustomerStatuses
        {
            Waiting,
            Processing,
            Completed
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != string.Empty && complainTextBox.Text != string.Empty)
            {
                waitingCustomerListView.Items.Clear();
                aCustomer.AddNewCustomer(nameTextBox.Text, complainTextBox.Text, CustomerStatuses.Waiting.ToString());
                nameTextBox.Clear();
                complainTextBox.Clear();
                int serial = LoadListView();
                MessageBox.Show("Successfully Added.\nYour Serial is: " + serial);
            }
        }

        private int LoadListView()
        {
            List<Customer> customers = aCustomer.GetAllCustomersByStatus(CustomerStatuses.Waiting.ToString(),
                CustomerStatuses.Processing.ToString());
            int serialNo = 0;
            foreach(Customer newCustomer in customers)
            {
                serialNo = newCustomer.ID;
                ListViewItem listViewItem = new ListViewItem(newCustomer.ID.ToString());
                listViewItem.SubItems.Add(newCustomer.Name);
                listViewItem.SubItems.Add(newCustomer.Complain);
                listViewItem.SubItems.Add(newCustomer.Status);
                waitingCustomerListView.Items.Add(listViewItem);
            }
            return serialNo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer=new Timer();
            timer.Tick += timer_Tick;
            timer.Interval = 500;
            timer.Start();
            LoadListView();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            waitingCustomerListView.Items.Clear();
            LoadListView();
        }
        private void dequeueButton_Click(object sender, EventArgs e)
        {
            waitingCustomerListView.Items.Clear();
            if (dequeueNameTextBox.Text != string.Empty && dequeueComplainTextBox.Text != string.Empty)
                aCustomer.ChangeCustomerStatus(waitingCustomerId, CustomerStatuses.Completed.ToString());

            if (aCustomer.FindCustomerByStatus(CustomerStatuses.Waiting.ToString()))
            {
                Customer waitingCustomer = aCustomer.GetCustomerById(aCustomer.GetMinimumIdByStatus(CustomerStatuses.Waiting.ToString()));
                dequeueNameTextBox.Text = waitingCustomer.Name;
                dequeueComplainTextBox.Text = waitingCustomer.Complain;
                waitingCustomerId = waitingCustomer.ID;
                aCustomer.ChangeCustomerStatus(waitingCustomerId,CustomerStatuses.Processing.ToString());
                LoadListView();
            }
            else
            {
                dequeueNameTextBox.Clear();
                dequeueComplainTextBox.Clear();
                MessageBox.Show("There is no customer in waiting list.");
            }
            
        }

        private void CustomerQueueUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (aCustomer.FindCustomerByStatus(CustomerStatuses.Processing.ToString()))
            {
                MessageBox.Show("Customer service is on processing. you couldn't close.");
                e.Cancel = true;
            }
        }
    }
}

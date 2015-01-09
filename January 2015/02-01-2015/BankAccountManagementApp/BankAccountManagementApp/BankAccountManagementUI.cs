using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountManagementApp
{
    public partial class BankAccountManagementUI : Form
    {
        public BankAccountManagementUI()
        {
            InitializeComponent();
        }
        CustomerList customerList=new CustomerList();
        private void customerSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customer aCustomer = new Customer(nationalIdTextBox.Text, customerNameTextBox.Text,
                    customerMobileTextBox.Text, customerAddressTextBox.Text);
                customerList.AddCustomer(aCustomer);
                MessageBox.Show(@"Customer Info saved.");
                FillComboBoxWithCustomers(accountCustomerComboBox);
                FillComboBoxWithCustomers(transactionCustomerComboBox);
                FillComboBoxWithCustomers(reportCustomerComboBox);
            }
            catch (DuplicateNationalIdException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void accountSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customer selectedCustomer = (Customer)accountCustomerComboBox.SelectedItem;
                Account anAccount = new Account(accountNumberTextBox.Text, accountTypeComboBox.Text, selectedCustomer);
                selectedCustomer.AddAccount(anAccount,customerList);
                MessageBox.Show(@"Account Info Saved.");
            }
            catch (DuplicateAccountNumberException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            Account depositAccount = (Account) transactionAccountComboBox.SelectedItem;
            depositAccount.Deposit(double.Parse(transactionAmountTextBox.Text));
            MessageBox.Show(@"Deposit Successfull.");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            Account withdrawAccount = (Account)transactionAccountComboBox.SelectedItem;
            withdrawAccount.Withdraw(double.Parse(transactionAmountTextBox.Text));
            MessageBox.Show(@"Withdraw Successfull.");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Customer viewCustomer = (Customer) reportCustomerComboBox.SelectedItem;
            double totalBalance=0;
            string message = "Customer Name:" + viewCustomer.Name + "\nNational Id: " + viewCustomer.NationalId +
                             "\nAccounts: \nNumber\tType\tBalance\n";
            foreach (Account account in viewCustomer.GetAllAccounts())
            {
                message += account.Number + "\t" + account.Type + "\t" + account.Balance + "\n";
                totalBalance += account.Balance;
            }
            message += "Total: " + totalBalance;
            MessageBox.Show(message);
        }

        private void accountTypeComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem aListViewItem = new ListViewItem("Current");
            aListViewItem.SubItems.Add("Savings");
            aListViewItem.SubItems.Add("Fixed");
            accountTypeComboBox.DataSource = null;
            accountTypeComboBox.DataSource = aListViewItem.SubItems;
            accountTypeComboBox.DisplayMember = "Text";

        }
        private void FillComboBoxWithCustomers(ComboBox aComboBox)
        {
            aComboBox.DataSource = null;
            aComboBox.DataSource = customerList.GetAllCustomers().ToList();
            aComboBox.DisplayMember = "Name";
            aComboBox.ValueMember = "NationalId";
        }

        private void transactionCustomerComboBox_Click(object sender, EventArgs e)
        {
            
        }

        private void transactionAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void transactionCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void transactionCustomerComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void transactionCustomerComboBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void transactionCustomerComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Customer transactionCustomer = (Customer)transactionCustomerComboBox.SelectedItem;
            transactionCustomerComboBox.Text = transactionCustomer.Name;
            if (transactionCustomerComboBox != null)
            {
                transactionAccountComboBox.DataSource = null;
                transactionAccountComboBox.DataSource = transactionCustomer.GetAllAccounts().ToList();
                transactionAccountComboBox.DisplayMember = "Number";
                transactionAccountComboBox.ValueMember = "Type";
            }
        }
    }
    
}

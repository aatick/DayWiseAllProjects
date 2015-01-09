using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BankApplication
{
    public partial class BankApplicationUI : Form
    {
        public BankApplicationUI()
        {
            InitializeComponent();
        }

        private Customer aCustomer;
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                aCustomer = new Customer(nameTextBox.Text, emailTextBox.Text,
                    new Account(accountNoTextBox.Text, DateTime.Parse(openingDateTextBox.Text)));
                MessageBox.Show("New Customer has been successfully created.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Opening Date!! e.g. 12.12.2012 or 12/12/2012 etc.");
            }
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            try
            {
                aCustomer.BankAccount.Deposite(double.Parse(amountTextBox.Text));
                MessageBox.Show("Deposite Successfull.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please Enter all the field.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid amount!!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Create an account first.");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                aCustomer.BankAccount.Withdraw(double.Parse(amountTextBox.Text));
                MessageBox.Show("Withdrawn Successfull.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please Enter all the field.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid amount!!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Create an account first.");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                nameDisplayTextBox.Text = aCustomer.Name;
                emailDisplayTextBox.Text = aCustomer.Email;
                accountNoDisplayTextBox.Text = aCustomer.BankAccount.Number;
                openingDateDisplayTextBox.Text = aCustomer.BankAccount.OpeningDate.ToShortDateString();
                balanceTextBox.Text = aCustomer.BankAccount.Balance.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Create an account first.");
            }
        }
    }
}

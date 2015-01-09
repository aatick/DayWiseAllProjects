using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class AccountInfoUI : Form
    {
        public AccountInfoUI()
        {
            InitializeComponent();
        }
        
        Account anAccount=new Account();
        
        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount.AccountNumber = accountNumberTextBox.Text;
            anAccount.AccountName = accountNameTextBox.Text;
            MessageBox.Show("New Account has been created successfully.");
            transactionGroupBox.Enabled = true;
            reportButton.Enabled = true;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            anAccount.DepositAmount(double.Parse(amountTextBox.Text));
            MessageBox.Show(amountTextBox.Text + " Amount has been deposited successfully.\nYour Current Balance is: " + anAccount.Balance);
            amountTextBox.Clear();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            anAccount.WithdrawAmount(double.Parse(amountTextBox.Text));
            MessageBox.Show(amountTextBox.Text + " Amount has been withdrawn successfully.\nYour Current Balance is: " + anAccount.Balance);
            amountTextBox.Clear();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anAccount.AccountName + ", your account number is: " + anAccount.AccountNumber +
                            " and your balance is: " + anAccount.Balance);
        }

        private void AccountInfoUI_Load(object sender, EventArgs e)
        {
            transactionGroupBox.Enabled = false;
            reportButton.Enabled = false;
        }
    }
}

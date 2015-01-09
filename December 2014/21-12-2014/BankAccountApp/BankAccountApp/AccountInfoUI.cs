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
        Account newAccount=new Account();
        private void createButton_Click(object sender, EventArgs e)
        {
            newAccount.accountNumber = accountNumberTextBox.Text;
            newAccount.accountName = accountNameTextBox.Text;
            MessageBox.Show("New Account has been created successfully.");
            transactionGroupBox.Enabled = true;
            reportButton.Enabled = true;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            long newBalance = newAccount.DepositAmount(long.Parse(amountTextBox.Text));
            MessageBox.Show(amountTextBox.Text + " Amount has been deposited successfully.\nYour Current Balance is: " + newBalance);
            amountTextBox.Clear();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            newAccount.WithdrawAmount(long.Parse(amountTextBox.Text));
            amountTextBox.Clear();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(newAccount.accountName + ", your account number is: " + newAccount.accountNumber +
                            " and your balance is: " + newAccount.accountAmmount);
        }

        private void AccountInfoUI_Load(object sender, EventArgs e)
        {
            transactionGroupBox.Enabled = false;
            reportButton.Enabled = false;
        }
    }
}

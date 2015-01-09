using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    class Account
    {
        private string accountNumber;
        private string accountName;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void DepositAmount(double amount)
        {
            balance = Balance + amount;
        }

        public void WithdrawAmount(double amount)
        {
            balance = Balance - amount;
        }
    }
}

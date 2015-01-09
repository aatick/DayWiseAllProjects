using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementApp
{
    class Account
    {
        public string Number { set; get; }
        public string Type { set; get; }
        public double Balance { private set; get; }
        public Customer Customer { set; get; }

        public Account(string accountNo, string accountType, Customer aCustomer)
        {
            Number = accountNo;
            Type = accountType;
            Customer = aCustomer;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}

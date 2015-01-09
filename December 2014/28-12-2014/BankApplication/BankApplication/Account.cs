using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Account
    {
        public string Number { get; private set; }
        public DateTime OpeningDate { get; private set; }
        public double Balance { get; private set; }

        public Account(string accountNo, DateTime openingDate)
        {
            Number = accountNo;
            OpeningDate = openingDate;
        }
        public void Deposite(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}

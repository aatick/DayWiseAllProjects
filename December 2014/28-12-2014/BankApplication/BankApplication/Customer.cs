using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Customer
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Account BankAccount { get; private set; }

        public Customer(string customerName, string email, Account anAccount)
        {
            Name = customerName;
            Email = email;
            BankAccount = anAccount;
        }
    }
}

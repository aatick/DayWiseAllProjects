using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementApp
{
    class Customer
    {
        public string NationalId { set; get; }
        public string Name { set; get; }
        public string Mobile { set; get; }
        public string Address { set; get; }
        private Dictionary<string, Account> accounts;

        public Customer(string nationalId, string name, string mobile, string address):this()
        {
            NationalId = nationalId;
            Name = name;
            Mobile = mobile;
            Address = address;
        }

        public Customer()
        {
            accounts=new Dictionary<string, Account>();
        }

        public void AddAccount(Account anAccount,CustomerList customerList)
        {
            foreach (Customer customer in customerList.GetAllCustomers())
            {
                foreach (Account account in customer.GetAllAccounts())
                {
                    if(account.Number==anAccount.Number)
                        throw new DuplicateAccountNumberException();
                }
            }
            accounts.Add(anAccount.Number,anAccount);
        }

        public Account[] GetAllAccounts()
        {
            return accounts.Values.ToArray();
        }

        public Account GetAccount(string accountNumber)
        {
            return accounts[accountNumber];
        }
    }

    class DuplicateAccountNumberException : Exception
    {
        public DuplicateAccountNumberException() : base("An Account With same Account Number already exist.")
        {
        }
    }
}

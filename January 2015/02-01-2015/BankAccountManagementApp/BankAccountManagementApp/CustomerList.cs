using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementApp
{
    class CustomerList
    {
        private Dictionary<string, Customer> customers;

        public CustomerList()
        {
            customers=new Dictionary<string, Customer>();
        }
        public void AddCustomer(Customer aCustomer)
        {
            if(customers.ContainsKey(aCustomer.NationalId))
                throw new DuplicateNationalIdException();
            customers.Add(aCustomer.NationalId,aCustomer);
        }

        public Customer[] GetAllCustomers()
        {
            return customers.Values.ToArray();
        }

        public Customer GetCustomer(string customerNationalId)
        {
            return customers[customerNationalId];
        }

    }
    class DuplicateNationalIdException : Exception
    {
        public DuplicateNationalIdException()
            : base("A Customer With same National Id has already been existed.")
        {
        }
    }
}

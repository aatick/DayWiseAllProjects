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
        public string accountNumber;
        public string accountName;
        public long accountAmmount=0;

        public long DepositAmount(long amount)
        {
            accountAmmount += amount;
            return accountAmmount;
        }

        public string WithdrawAmount(long amount)
        {
            if (accountAmmount - amount < 0)
                return "You don't have enough money to withdraw.\nYour Current Balance is: " + accountAmmount;
            accountAmmount -= amount;
            return amount + " Amount has been Withdrawn successfully.\nYour Current Balance is: " + accountAmmount;
        }
    }
}

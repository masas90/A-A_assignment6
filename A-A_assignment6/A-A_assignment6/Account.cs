using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace A_A_assignment6
{
    class Account
    {
        public double balance = 0;
        public double amount = 0;

        public String deposit(double amount)
        {
            Contract.Requires(amount > 0);
            Contract.Ensures(Contract.OldValue(balance) + amount == balance);
            balance += amount;
            return "Balance: " + balance;
        }


        public String withdraw(double amount)
        {

            Contract.Requires(amount > 0);
            Contract.Requires(balance >= amount);
            Contract.Ensures(Contract.OldValue(balance).Equals(amount + balance));
            this.amount = amount;
            balance = balance - amount;

            return "Balance: " + balance;
        }
        public double getAmount { get { return amount; } }
        public double getBalance { get { return balance; } }
        //  [ContractInvariantMethod]
        //  private void invariant() {

        //    Contract.Invariant(getAmount <= getBalance);  

        // }
    
}
}

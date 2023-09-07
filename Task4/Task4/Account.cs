using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Account
    {
        protected string customerName;
        protected int accountNumber;
        protected string accountType;
        protected double balance; public Account(string customerName, int accountNumber, string accountType)
        {
            this.customerName = customerName;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.balance = 0;
        }
        public virtual void Deposit(double amount)
        {
            this.balance += amount;
            Console.WriteLine("Deposit of {0} made to account {1}. New balance is {2}", amount, this.accountNumber, this.balance);
        }
        public virtual void DisplayBalance()
        {
            Console.WriteLine("Account balance for account {0} is {1}", this.accountNumber, this.balance);
        }
        public virtual void CalculateInterest()
        {
            // This method is overridden in the saving subclass
        }
        public virtual void Withdraw(double amount)
        {
            this.balance -= amount;
            Console.WriteLine("Withdrawal of {0} made from account {1}. New balance is {2}", amount, this.accountNumber, this.balance);
        }
        public virtual void CheckMinimumBalance()
        {
            // This method is overridden in the current subclass
        }
    }
}


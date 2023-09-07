using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
   
   class Savings : Account
    {
        private double interestRate; public Savings(string customerName, int accountNumber, double interestRate) : base(customerName, accountNumber, "Savings")
        {
            this.interestRate = interestRate;
        }
        public override void CalculateInterest()
        {
            double interest = this.balance * (this.interestRate / 100);
            this.balance += interest;
            Console.WriteLine("Interest of {0} applied to account {1}. New balance is {2}", interest, this.accountNumber, this.balance);
        }
    }
}

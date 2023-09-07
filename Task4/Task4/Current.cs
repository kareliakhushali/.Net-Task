using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Current : Account
    {
        private double minimumBalance;
        private double serviceCharge; public Current(string customerName, int accountNumber, double minimumBalance) : base(customerName, accountNumber, "Current")
        {
            this.minimumBalance = minimumBalance;
            this.serviceCharge = 0;
        }
        public override void Deposit(double amount)
        {
            base.Deposit(amount);
            CheckMinimumBalance();
        }
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            CheckMinimumBalance();
        }
        public override void CheckMinimumBalance()
        {
            if (this.balance < this.minimumBalance)
            {
                this.serviceCharge = 50;
                this.balance -= this.serviceCharge;
                Console.WriteLine("Service charge of {0} applied to account {1} due to low balance. New balance is {2}", this.serviceCharge, this.accountNumber, this.balance);
            }
        }
    }
}

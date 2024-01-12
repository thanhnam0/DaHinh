using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    internal class SavingsAccount : Account
    {
        private double interestRate = 0.8;
        public SavingsAccount(double balance): base(balance) { }
        public double InterestRate
        {
            set { InterestRate = value; }
            get { return InterestRate; }
        }      
        public override bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            if (this.Balance - amount - amount * this.interestRate < 0)
            {
                return false;
            }

            this.Balance -= amount - amount * this.interestRate;
            return true;
        }

        public override bool Deposit(double amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            this.Balance += amount + amount * this.interestRate;
            return true;
        }
        public new void PrintBalance()
        {
            Console.WriteLine("so du trong tai khoan la: {0}", this.Balance);
        }
        
    }
}

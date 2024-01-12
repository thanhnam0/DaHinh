using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    internal class CheckingAccount : Account
    {
        public CheckingAccount(double balance) : base(balance) { }
        public override bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            if (this.Balance - amount < 0)
            {
                return false;
            }
            this.Balance -= amount;
            return true;
        }
        public override bool Deposit(double amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            this.Balance += amount;
            return true;
        }

        public new void PrintBalance()
        {
            Console.WriteLine("so du trong tai khoan la: {0}", this.Balance);
        }
        
    }
}

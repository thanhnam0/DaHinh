using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    internal class Account
    {
        private double balance;
       
        public Account(double balance)
        {
            Balance = balance;  
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public virtual bool Withdraw(double amount)
        {
            return true;
        }
        public virtual bool Deposit(double amount)
        {
            return false;
        } 
        public void PrintBalance()
        {
            Console.WriteLine("Balance: {0}", balance);
        }
        
        
    }
}

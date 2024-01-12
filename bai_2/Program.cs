using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new SavingsAccount(5000);
            ac1.Deposit(2500);
            ac1.PrintBalance();
            Account ac2 = new CheckingAccount(3000);
            ac1.Deposit(2000);
            ac1.PrintBalance();
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}

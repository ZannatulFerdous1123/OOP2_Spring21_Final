using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("CURRENT ACCOUNT");
            CurrentAccount c1 = new CurrentAccount();
            c1.balance=1000;
            c1.deposit(1000);
            c1.withdraw(1500);
            Console.WriteLine("**************************************");

            Console.WriteLine("SAVINGS ACCOUNT");
            SavingsAccount s1 = new SavingsAccount();
            s1.balance = 1000;
            s1.deposit(1000);
            s1.withdraw(1900);

            Console.WriteLine("**************************************");
            Console.WriteLine("OVER DRAFT ACCOUNT");
            Overdraft o1 = new Overdraft();
            o1.balance = 1000;
            o1.Limit = 100;
            o1.deposit(1000);
            o1.withdraw(1500);

        }
    }
}

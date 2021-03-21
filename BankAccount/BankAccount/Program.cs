using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SPECIAL SAVINGS ACCOUNT");
            SpecialSavings s1 = new SpecialSavings("jannat", "1234", 5, 10);
            SpecialSavings s2 = new SpecialSavings("momo", "1236", 5, 10);

            s1.ShowInfo();
            s1.Deposit(2);
            s1.Withdraw(4);
            s1.Transfer(s2, 5);

            Console.WriteLine("**************************************");
            Console.WriteLine("OVER DRAFT ACCOUNT");
            OverDraft o1 = new OverDraft("fahmi", "5678", 10, 3);
            OverDraft o2 = new OverDraft("nigar", "91011", 1, 3);

            o1.ShowInfo();
            o1.Deposit(2);
            o1.Withdraw(5);
            o1.Transfer(o2, 15);

        }
    }
}

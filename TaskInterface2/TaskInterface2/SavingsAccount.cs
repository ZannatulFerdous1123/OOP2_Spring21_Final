using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface2
{
    class SavingsAccount:IBasicBanking
    {
        public int balance { get; set; }

        public bool deposit(int amount)
        {
            balance  +=amount;
            Console.WriteLine("New balance after deposite is:" + balance);
            return true;
        }

        public bool withdraw(int amount)
        {
            if (amount <= 80 * balance/100)
            {
                balance -=amount;
                Console.WriteLine("New balance after withdraw is:" + balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
            return true;
        }
    }
}

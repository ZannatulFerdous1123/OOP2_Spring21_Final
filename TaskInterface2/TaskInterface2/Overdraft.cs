using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface2
{
    class Overdraft:IBasicBanking
    {
        public double Limit { get; set; }
        public double balance { get; set; }
        public bool deposit(int amount)
        {
            //balance += Limit + amount;
            balance +=amount;
            Console.WriteLine("New balance after deposite is:" + balance);
            return true;
        }

        public bool withdraw(int amount)
        {
            if (amount <= Limit + balance)
            {
                balance -= amount;
                Console.WriteLine("New balance after deposite is:" + balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance cannot withdraw money");
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class OverDraft:Account
    {
        public double Limit { get; set; }

        public OverDraft() { }
        public OverDraft(string accName, string accNo, double balance, double limit) : base(accName, accNo, balance)
        {
            Limit = limit;


        }
        public override void Deposit(double amount)
        {
            Balance += Limit + amount;
        }
        public override void Withdraw(double amount)
        {
            if (amount<=Limit+Balance)
            {
                Balance -= amount;
                Console.WriteLine("You have debited taka {0} by self", amount);
            }
            else
            {
                Console.WriteLine("Insufficient Balance cannot withdraw money");
            }
        }
        public override void Transfer(Account acc, double amount)
        {
            if (amount<=Limit+Balance)
            {
                this.Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("You have transfer taka {0} to {1}({2})", amount, acc.AccName, acc.AccNo);
            }
            else
            {
                Console.WriteLine("Cannot transfer you do not have sufficient Balance");
            }
        }

        new public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("LIMIT : " + Limit);
        }
    }
}





    


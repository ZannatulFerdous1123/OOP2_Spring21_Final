using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SpecialSavings : Account
    {
        public double OpeningBalance{get; set;}
        
           

        
        
        

    public SpecialSavings() { }
        public SpecialSavings(string accName, string accNo,  double balance,double openingBalance) : base(accName, accNo,balance)
        {
            OpeningBalance = openingBalance;
            

        }
        public override void Deposit(double amount)
        {
            Balance += OpeningBalance +amount;
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 20 * OpeningBalance/100)
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
            if (Balance - amount>= 20 * OpeningBalance / 100)
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
            Console.WriteLine("Openning balance:" + OpeningBalance);
        }
    }
}






    


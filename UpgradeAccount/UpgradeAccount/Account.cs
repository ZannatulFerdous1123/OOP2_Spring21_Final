using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpgradeAccount
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }
        Transaction[] listOfTransaction;
        public int totalNumberOfTransaction { get; set; }
        public Account() { }
        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
            listOfTransaction = new Transaction[10];
        }
        public void addTransaction(params Transaction[] listOfTransaction)
        {
            foreach (Transaction tran in listOfTransaction)
            {
                this.listOfTransaction[totalNumberOfTransaction++] = tran;
            }
        }
       public void ShowAllTransaction()
        {
            for (int i=0; i< totalNumberOfTransaction; i++)
            {
                listOfTransaction[i].ShowInfo();
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            listOfTransaction[totalNumberOfTransaction++] = new Transaction(this, this,  amount, "Self deposit");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);

        }
        virtual public void Withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                listOfTransaction[totalNumberOfTransaction++] = new Transaction(this, this, amount, "Self withdraw");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

         virtual public void Transfer(Account acc, double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                listOfTransaction[totalNumberOfTransaction++] = new Transaction(this,acc, amount, "tranfer");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }


    }
}
    


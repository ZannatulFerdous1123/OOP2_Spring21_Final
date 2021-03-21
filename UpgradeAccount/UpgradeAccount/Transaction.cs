using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpgradeAccount
{
    class Transaction
    {
       
            public Account Sender { get; set; }
            public Account Receiver { get; set; }
            public double amount { get; set; }
            public string additionalInfo { get; set; }


            public Transaction()
            {

            }

            public Transaction(Account Sender, Account Receiver, double amount, string additionalInfo)
            {
                this.Sender = Sender;
                this.Receiver = Receiver;
                this.amount = amount;
                this.additionalInfo = additionalInfo;
            }

            public void ShowInfo()
            {
            Console.WriteLine("Sender Id {0}", Sender.AccNo);
            Console.WriteLine("Receiver Id {0}", Receiver.AccNo);
            Console.WriteLine("Transaction amount is {0}", amount);
            Console.WriteLine("Type of Transaction {0}", additionalInfo);



        }


    }
    }



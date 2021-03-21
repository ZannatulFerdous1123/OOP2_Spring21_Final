using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpgradeAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Sender1 = new Account("jannat", "0000", 5000);
            Account Sender2 = new Account("momo", "333", 300);
            Account Receiver1 = new Account("Zannat", "111", 6000);
            Account Receiver2 = new Account("fahmi", "222", 150);
            

            Transaction T1 = new Transaction(Sender1, Receiver1, 500, "Send Money");
            Transaction T2 = new Transaction(Sender1, Receiver2, 100, "Recharge");
            Transaction T3 = new Transaction(Sender2, Receiver1, 1000, "Payment");

            Sender1.addTransaction(T1, T2, T3);
            Sender1.ShowAllTransaction();
            Sender1.ShowInfo();
            Sender1.Withdraw(100);
            Sender1.Transfer(Receiver2, 500);




        }
    }
}

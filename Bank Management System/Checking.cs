using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {
        public double minamount=0, maxamount=100000;



        public override void Withdraw(double amount)
        {

            if (this.minamount > base.balance - amount)
            {
                Console.WriteLine("Insufficient balance");
                base.printbalance();
            }
            else
            {

                base.balance -= amount;
                base.printbalance();
                base.transections++;

            }
        }
        public override void Deposit(double amount)
        {
            if (this.maxamount >= amount)
            {
                base.Deposit(amount);
                base.printbalance();
            }
            else
            {
                Console.WriteLine("You can deposit max 100000 at a time");
            }

        }
    }
}

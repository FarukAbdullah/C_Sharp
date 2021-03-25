using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings : Account
    {
        public double minamount=500, maxamount=50000;



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
            if(this.maxamount >= amount)
                {
                 base.Deposit(amount);
                 base.printbalance();
            }
            else
            {
                Console.WriteLine("You can deposit max 50000 at a time");
            }
            
        }
    }
}

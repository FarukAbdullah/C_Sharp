using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class Savings : Account
    {
        public double minamount = 0, maxamount = 2000;

        public override void Withdraw(double amount)
        {

            if (this.minamount > base.balance - amount)
            {
                Console.WriteLine("Insufficient balance");
                //base.printBalance();
            }
            else if(this.maxamount < amount)
            {
                Console.WriteLine("Reached Max limit");
            }
            else
            {
                base.balance -= amount;
               // Console.WriteLine("Successfully withdraw");
               // base.printBalance();
            }
        }
        public override void Deposit(double amount)
        {
                base.Deposit(amount);
                //Console.WriteLine("Successfully deposit");
                //base.printBalance();
                
        }
    }
}

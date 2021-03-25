using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class Current : Account
    {
        public double minamount = 500, maxamount = 5000;


        public override void Withdraw(double amount)
        {

            if (0 > base.balance - amount)
            {
                Console.WriteLine("Insufficient balance");
               // base.printBalance();
            }
            else if (this.maxamount < amount)
            {
                Console.WriteLine("Reached Max limit");
            }
            else
            {

                base.balance -= amount;
               // Console.WriteLine("Successfully Withdraw");
               // base.printBalance();              
            }
        }
        public override void Deposit(double amount)
        {
            if (this.minamount <= amount)
            {
                base.Deposit(amount);
                //Console.WriteLine("Successfully Deposit");
               // base.printBalance();
            }
            else
            {
                Console.WriteLine("You have to deposit at least 500TK at a time");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class Loan:Account
    {
        public override void Withdraw(double amount)
        {

            if (0 > base.balance - (amount+50))
            {
                Console.WriteLine("Insufficient balance");
               // base.printBalance();
            }
            else
            {

                base.balance -= amount+50;
                //Console.WriteLine("Successfully Withdraw");
                //base.printBalance();
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

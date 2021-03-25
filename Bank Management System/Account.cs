using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        protected String accountname, dateofbirth, address, accountnumber;
        protected double balance;
        protected int transections = 0;

        public Account()
        {

        }
        public Account(string aaccountNumber, string nname, string ddateOfBirth, string aaddress, double bbalance)
        {

            accountnumber = aaccountNumber;
            accountname = nname;
            dateofbirth = ddateOfBirth;
            address = aaddress;
            balance = bbalance;
        }
        public string Accountname
        {
            set { this.accountname = value; }
            get { return this.accountname; }
        }
        public string DateOfBirth
        {
            set { this.dateofbirth = value; }
            get { return this.dateofbirth; }
        }
        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public string Accountnumber
        {
            set { this.accountnumber = value; }
            get { return this.accountnumber; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public int Accounttransection
        {

            get { return this.transections; }
        }
        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && this.balance > amount)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount");
            }

        }
        public virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }




        public void Transfer(Account receiver, double amount)
        {
            int a = this.transections;
            this.Withdraw(amount);
            if (a != this.transections)
            { 
                receiver.Deposit(amount);
            }



        }

        public void printbalance()
        {
            Console.WriteLine("New Balance: "+this.Balance);
        }

        public void PrintAccountDetails()
        {
            Console.WriteLine("Account Name:{0}\nDate of Birth:{1}\nAddress:{2}\nAccount Number:{3}\nBalance:{4}", this.accountname, this.dateofbirth, this.address, this.accountnumber, this.balance);
        }
    }
}


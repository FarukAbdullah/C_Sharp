using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    struct Address
    {
        public string apartmentNumber;
        public string roadNo;
        public string district;
        public string country;

        public Address(string apartmentNumber, string roadNo, string district, string country)
        {
            this.apartmentNumber = apartmentNumber;
            this.roadNo = roadNo;
            this.district = district;
            this.country = country;
        }

        public void ShowAddress()
        {
            Console.WriteLine("ApartmentNumber: {0}", this.apartmentNumber);
            Console.WriteLine("Road no: {0}", this.roadNo);
            Console.WriteLine("District: {0}", this.district);
            Console.WriteLine("Country: {0}\n", this.country);

        }
    }


    class Account
    {
        protected String accountName;
        protected String accountID;
        protected double balance;
        public Address address;

        public Account() { }

        public Account(string accName, string accID, Address address, double bbalance)
        {
            this.accountName = accName;
            accountID = accID;
            this.SetAddress(address);
            this.balance = bbalance;
        }

        public Address GetAddress()
        {
            return this.address;
        }

        public void SetAddress(Address address)
        {
            this.address = address;
        }

        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public string AccountID
        {
            set { this.accountID = value; }
            get { return this.accountID; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && this.balance > amount)
            {
                this.balance -= amount;//balanace=balance-amount;
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

       public void AccTransfer(Account receiver, double amount)
        {
            
            this.Withdraw(amount);          
            receiver.Deposit(amount);
            Console.WriteLine("Successsfully Transfer ");
   
        }


        public void PrintAccountDetails()
        {
            Console.WriteLine("Account Name:{0}\nAccount Number:{1}\nBalance:{2}", this.accountName,this.accountID, this.balance);
            //this.address.ShowAddress();
        }

        public void printBalance()
        {
            Console.WriteLine("Balance: " + this.Balance);
        }

         public int count = 0;

        Account[] accounts ;

         public Account(int size)
        {
            this.accounts = new Account[size];
        }
       
        public void CreateAccount(Account account)
        {
            int i = 0; 
            while(i < accounts.Length)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    Console.WriteLine("\nAccount created successfully");
                    Console.WriteLine("Your account number is: " + accounts[i].AccountID);
                    count++;
                    break;
                }
                i++;
            }
        }


        public void PrintAccount()
        {
            int i = 0; 
            while(i < count)
            {
                accounts[i].PrintAccountDetails();
                Console.WriteLine();
                i++;
            }

        }

        public void printbalance(string accno)
        {
            int i = 0;
            while (i < count)
            {
                if (accounts[i].AccountID == accno)
                {
                    Console.WriteLine("Balance: " + accounts[i].Balance);
                    break;
                }
                i++;
            }
            
        }
        public void Accountdeposit(string accno, double ammount)
        {
            int i = 0; 
            while(i < count)
            {
                if (accounts[i].AccountID == accno)
                {
                    accounts[i].Deposit(ammount);
                    break;
                }
                i++;
            }
        }
        public void Accountwithdraw(string accno, double ammount)
        {
            int i = 0;
            while (i < count)
            {
                if (accounts[i].AccountID == accno)
                {
                    accounts[i].Withdraw(ammount);
                    break;
                }
                i++;
            }
        }
        public void Transfer(string accno, string accno2, double ammount)
        {
            int a = 0, b = 0,i = 0;
            while (i < count)
            {
                if (accounts[i].AccountID == accno)
                {
                    a = i;
                    break;
                }
                i++;
            }
        
            int j = 0; while(j < count)
            {
                if (accounts[j].AccountID == accno2)
                {

                    b = j;

                    break;
                }
                j++;
            }
            accounts[a].AccTransfer(accounts[b], ammount);
        }

        public void DeleteAccount(string accno)
        {
            int i = 0;
            while (i < count)
            {
                if (accounts[i].AccountID == accno)
                {
                    accounts[i].AccountID = null;
                    Console.WriteLine("Account deleted ");
                   // break;
                }
                else
                {
                    Console.WriteLine("Not Found ");
                    // break;
                }
                i++;
            }
        }

        public void SearchAccount(string accno)
        {
            int i = 0;
            while (i < count)
            {
                if (accounts[i].AccountID == accno)
                {
                    Console.WriteLine("Account Found ");
                    //break;
                }
                else
                {
                    Console.WriteLine("Not Found ");
                   // break;
                }
                i++;
            }
        }
    }
}

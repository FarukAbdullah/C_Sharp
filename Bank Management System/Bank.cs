using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Bank
    {
        public int count = 0;


        Account[] accounts;
        public Bank(int size)
        {
            this.accounts = new Account[size];

        }



        public void CreateAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    Console.WriteLine("\nAccount created successfully");
                    Console.WriteLine("Your account number is: " + accounts[i].Accountnumber);
                    count++;
                    break;
                }
            }
        }


        public void PrintAccount(string accountNumber)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accountNumber)
                {
                    accounts[i].PrintAccountDetails();
                    break;

                }

            }

        }
        public void Accountdeposit(string accno, double ammount)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accno)
                {
                    accounts[i].Deposit(ammount);
                    break;
                }
            }
        }
        public void Accountwithdraw(string accno, double ammount)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accno)
                {
                    accounts[i].Withdraw(ammount);
                    break;
                }
            }
        }
        public void Accounttransfer(string accno, string accno2, double ammount)
        {
            int a = 0, b = 0;
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accno)
                {
                    a = i;
                    break;
                }
            }
        
            for (int j = 0; j < count; j++)
            {
                if (accounts[j].Accountnumber == accno2)
                {

                    b = j;

                    break;
                }
            }
            accounts[a].Transfer(accounts[b], ammount);


        }



        public void Accountname(string accno, string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accno)
                {
                    accounts[i].Accountname = name;
                    break;
                }
            }
        }
        public void Accountshow(string accno)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accno)
                {
                    PrintAccount(accounts[i].Accountnumber);
                    Console.WriteLine("Number of Transsection is : " + accounts[i].Accounttransection);

                    break;
                }
            }
        }




    }
}

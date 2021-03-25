using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class FinancialAccount
    {
        public static void StartSystem()
        {
            Account acc = new Account(100);
            string input, input2, nam, num, balance0, account_number, ammount0, reciver_number,apno,rno,dist,country;
            int balance1 = 0, sran = 1000, cran = 1000, lran = 1000, ammount1;

            Label1:
            Console.WriteLine();
            Console.WriteLine("Services of a Bank:\n\n 1 Add new Account\n 2 search\n 3 show All Account Information\n 4 Delete Account\n 5 Deposit\n 6 Withdraw\n 7 Transfer\n 8 Check Balance\n 9 Exit ");
            Console.WriteLine();
            Console.Write("Enter choice: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    {
                        Console.WriteLine();
                        Console.WriteLine(" 1 Savings\n 2 Current\n 3 Loan\n 4 Exit");
                        Console.WriteLine();
                        Console.Write("Enter choice: ");
                        input2 = Console.ReadLine(); 
                            if (input2 == "4")
                            {
                                goto Label1;
                            }
                            else if (input2 == "1" || input2 == "2" || input2 == "3" )
                            {
                                Console.Write("Enter your name: ");
                                nam = Console.ReadLine();
                                Console.Write("Enter your Apartment Number: ");
                                apno = Console.ReadLine();
                                Console.Write("Enter your Road Number: ");
                                rno = Console.ReadLine();
                                Console.Write("Enter your District: ");
                                dist = Console.ReadLine();
                                Console.Write("Enter your Country: ");
                                country = Console.ReadLine();
                                Address a = new Address(apno, rno, dist, country);
                                acc.SetAddress(a);

                                
                            if (input2 == "1")
                            {
                                sran++;
                                num = "AS-" + sran.ToString();
                            }
                            else if (input2 == "2")
                            {
                                cran++;
                                num = "AC-" + cran.ToString();
                            }
                            else
                            {
                                lran++;
                                num = "AL-" + lran.ToString();
                            }
                                Console.Write("Enter balance: ");
                                balance0 = Console.ReadLine();
                                balance1 = Convert.ToInt32(balance0);

                                if (input2 == "1")
                                {
                                    Savings sab = new Savings();
                                    sab.AccountName = nam;
                                    Address ad = new Address(apno,rno,dist,country);
                                    acc.SetAddress(ad);
                                    sab.AccountID = num;
                                    sab.Balance = +balance1;
                                    acc.CreateAccount(sab);
                                    goto Label1;
                                }
                                else if (input2 == "2")
                                {
                                    Current ack = new Current();
                                    ack.AccountName = nam;
                                    Address ac = new Address(apno, rno, dist, country);
                                    acc.SetAddress(ac);
                                    ack.AccountID = num;
                                    ack.Balance = +balance1;
                                    acc.CreateAccount(ack);
                                    goto Label1;
                                }

                                else if (input2 == "3")
                                {
                                    Loan acl = new Loan();
                                    acl.AccountName = nam;
                                    Address al = new Address(apno, rno, dist, country);
                                    acc.SetAddress(al);
                                    acl.AccountID = num;
                                    acl.Balance = +balance1;
                                    acc.CreateAccount(acl);
                                    goto Label1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input\n ");
                            }
                            goto Label1;
                        }

                case "2":
                    {
                        Console.Write("Enter your account number: ");
                        account_number = Console.ReadLine();
                        acc.SearchAccount(account_number);
                        goto Label1;
                    }
                case "3":
                    {
                        acc.PrintAccount();
                        goto Label1;
                    } 
               case "4":
                    {
                         Console.Write("Enter your account number: ");
                         account_number = Console.ReadLine(); 
                         acc.DeleteAccount(account_number );
                         goto Label1;
                    }
               case "5":
                    {
                         Console.Write("Enter your account number: ");
                         account_number = Console.ReadLine(); 
                         Console.Write("Enter ammount: ");
                         ammount0 = Console.ReadLine();
                         ammount1 = Convert.ToInt32(ammount0);
                         acc.Accountdeposit(account_number, ammount1);
                         Console.Write("Successfully Deposit ");
                         goto Label1;
                    }
               case "6":
                    {
                        Console.Write("Enter your account number: ");
                        account_number = Console.ReadLine(); 
                        Console.Write("Enter ammount: ");
                        ammount0 = Console.ReadLine();
                        ammount1 = Convert.ToInt32(ammount0);
                        acc.Accountwithdraw(account_number, ammount1);
                        Console.Write("Successfully Withdraw ");
                        goto Label1;
                    }
               case "7":
                    {
                        Console.Write("Enter your account number: ");
                        account_number = Console.ReadLine(); 
                        Console.Write("Enter reciver account number: ");
                        reciver_number = Console.ReadLine();
                        Console.Write("Enter amount: ");
                        ammount0 = Console.ReadLine();
                        ammount1 = Convert.ToInt32(ammount0);
                        acc.Transfer(account_number, reciver_number, ammount1);
                        goto Label1;
                    }
               case "8":
                    {
                        Console.Write("Enter your account number: ");
                        account_number = Console.ReadLine();
                        acc.printbalance(account_number);
                        goto Label1;
                    }
               case "9":
                    {
                        break;
                    }
               default:
                    break;
                }
            }
        
        }
    }


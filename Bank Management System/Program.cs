using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

                string input, input2, nam, num, balance0, checkbrk0, account_number, dob0, add, ammount0, reciver_number;
                int balance1 = 0, sran = 100,cran=100, ammount1;

                Bank bank = new Bank(5);
               
            Label1:
                Console.WriteLine();
                Console.WriteLine("Services of a Bank:\n open\n account\n quit");
                Console.WriteLine();
                Console.Write("Enter choice: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "open":
                        {
                            Console.WriteLine();
                            Console.WriteLine(" savings\n checking\n quit");
                            Console.WriteLine();
                            Console.Write("Enter choice: ");
                            input2 = Console.ReadLine();

                            if (input2 == "quit")
                            {
                                goto Label1;
                            }
                            else if (input2 == "savings" || input2 == "checking")
                            {
                                Console.Write("Enter your name: ");
                                nam = Console.ReadLine();

                                Console.Write("Enter your Date of birth: ");
                                dob0 = Console.ReadLine();

                                Console.Write("Enter your address: ");
                                add = Console.ReadLine();

                                
                            if (input2 == "savings")
                            {
                                sran++;
                                num = "s-" + sran.ToString();
                            }
                            else
                            {
                                cran++;
                                num = "c-" + cran.ToString();
                            }
                              

                                Console.Write("Enter balance: ");
                                balance0 = Console.ReadLine();
                                balance1 = Convert.ToInt32(balance0);

                                if (input2 == "savings")
                                {
                                    Savings sab = new Savings();
                                    sab.Accountname = nam;
                                    sab.DateOfBirth = dob0;
                                    sab.Address = add;
                                    sab.Accountnumber = num;
                                    sab.Balance = +balance1;
                                    bank.CreateAccount(sab);
                                    goto Label1;
                                }
                                else if (input2 == "checking")
                                {
                                    Checking ack = new Checking();
                                    ack.Accountname = nam;
                                    ack.DateOfBirth = dob0;
                                    ack.Address = add;
                                    ack.Accountnumber = num;
                                    ack.Balance = +balance1;
                                    bank.CreateAccount(ack);
                                    goto Label1;
                                }
                            }
                            else
                            {
                                break;
                            }
                            goto Label1;
                        }
                   
                    case "account":
                        {
                            Console.Write("Enter your account number: ");
                            account_number = Console.ReadLine();

                        Label2:

                            Console.WriteLine();

                            Console.WriteLine(" deposit\n withdraw\n transfer\n change\n show\n quit");
                            Console.WriteLine();
                            Console.Write("Enter choice: ");
                            checkbrk0 = Console.ReadLine();
                            Console.WriteLine();

                            switch (checkbrk0)
                            {

                                case "quit":
                                break;

                                case "deposit":
                                    Console.Write("Enter ammount: ");
                                    ammount0 = Console.ReadLine();
                                    ammount1 = Convert.ToInt32(ammount0);
                                    bank.Accountdeposit(account_number, ammount1);
                                    goto Label2;

                                case "withdraw":
                                    Console.Write("Enter ammount: ");
                                    ammount0 = Console.ReadLine();
                                    ammount1 = Convert.ToInt32(ammount0);
                                    bank.Accountwithdraw(account_number, ammount1);
                                    goto Label2;

                                case "transfer":
                                    Console.Write("Enter reciver account number: ");
                                    reciver_number = Console.ReadLine();
                                    Console.Write("Enter amount: ");
                                    ammount0 = Console.ReadLine();
                                    ammount1 = Convert.ToInt32(ammount0);
                                    bank.Accounttransfer(account_number, reciver_number, ammount1);
                                    goto Label2;

                                case "change":
                                    Console.Write("Enter new name: ");
                                    reciver_number = Console.ReadLine();
                                    bank.Accountname(account_number, reciver_number);
                                    goto Label2;

                                case "show":
                                    bank.Accountshow(account_number);
                                    goto Label2;
                                default:
                                    break;

                            }
                        }
                        goto Label1;
                    case "quit":
                        break;





                }
            }


        }
    }

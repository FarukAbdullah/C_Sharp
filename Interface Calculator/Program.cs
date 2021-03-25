using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCalculator
{
    interface IBasicCalculator
    {
        void Addition(double a, double b);
        void Subtraction(double a, double b);
        void Multiplication(double a, double b);
        void Division(double a, double b);
    }
    interface IScientificCalculator
    {
        void XtoY(double x, double y);
        void Factorial(double n);
        void ConvertToBinary(int n);
    }
    class BasicCalculator : IBasicCalculator
    {
        public void Addition(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine("Addition: " + sum);
        }
        public void Subtraction(double a, double b)
        {
            double sub = a - b;
            Console.WriteLine("Subtraction: " + sub);
        }
        public void Multiplication(double a, double b)
        {
            double mul = a * b;
            Console.WriteLine("Multiplication: " + mul);
        }
        public void Division(double a, double b)
        {
            if(b!=0)
            {
                double div = a / b;
                Console.WriteLine("Division: " + div);
            }
            else
            {
                Console.WriteLine("Divide by 0 is not possible");
            }
        }
    }
    class ScientificCalculator : BasicCalculator, IBasicCalculator, IScientificCalculator
    {
       public void XtoY(double x, double y)
        {
            double result=1;
           while(y !=0)
            {
                result *= x;
                --y;
            }
            Console.WriteLine("Result: "+result);

        }
        public void Factorial(double n)
        {
            double fact=1;
            for(double i = n; i >= 1; i--)
            {
               fact = fact*i;
            }
            
            Console.WriteLine("Factorial: " + fact);
        }
        public void ConvertToBinary(int n)
        {
            int remainder;
            string result = string.Empty;
            while(n>0)
            {
                remainder = n % 2;
                n /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("In Binary: {0}" , result);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2;
            double a, b;
            BasicCalculator bc = new BasicCalculator();
            ScientificCalculator sc = new ScientificCalculator();

                Main:
                Console.WriteLine("Enter 1 for Basic Calculator");
                Console.WriteLine("Enter 2 for Scientific Calculator ");
                input1 = Console.ReadLine();
                Option:
                if (input1 =="1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter 1 for Addition");
                    Console.WriteLine("Enter 2 for Subtraction ");
                    Console.WriteLine("Enter 3 for Multiplication");
                    Console.WriteLine("Enter 4 for Division");
                    Console.WriteLine("Enter 5 for Exit");
                    input2 = Console.ReadLine();
                   
                    if (input2 == "1" )
                    {
                     Console.Write("Enter first number: ");
                     a = Convert.ToInt32(Console.ReadLine());
                     Console.Write("Enter second number: ");
                     b = Convert.ToInt32(Console.ReadLine());
                    bc.Addition(a, b);
                        goto Option;
                    }
                   
                    else if (input2 == "2")
                    {
                    Console.Write("Enter first number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    bc.Subtraction(a, b);
                        goto Option;
                    }
                   
                    else if (input2 == "3")
                    {
                    Console.Write("Enter first number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    bc.Multiplication(a, b);
                        goto Option;
                    }
               
                    else if (input2 == "4")
                    {
                    Console.Write("Enter first number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    bc.Division(a, b);
                        goto Option;
                    }
                    else if(input2=="5")
                    {
                        goto Main;
                    }
                    else
                    {
                        Console.WriteLine("Choose correct Input..");
                    }
                }
               
                else if (input1 == "2")
                {
            Option2:
                    Console.WriteLine();
                    Console.WriteLine("Enter 1 for Addition");
                    Console.WriteLine("Enter 2 for Subtraction ");
                    Console.WriteLine("Enter 3 for Multiplication");
                    Console.WriteLine("Enter 4 for Division");
                    Console.WriteLine("Enter 5 for Calculating XtoY");
                    Console.WriteLine("Enter 6 for n!");
                    Console.WriteLine("Enter 7 for Converting to Binary");
                    Console.WriteLine("Enter 8 for Exit");
                    input2 = Console.ReadLine();

                    if (input2 == "1")
                    {
                    Console.Write("Enter first number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    sc.Addition(a, b);
                        goto Option2;
                    }

                    else if (input2 == "2")
                    {
                    Console.Write("Enter first number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    sc.Subtraction(a, b);
                        goto Option2;
                    }

                    else if (input2 == "3")
                    {
                    Console.Write("Enter first number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    sc.Multiplication(a, b);
                        goto Option2;
                    }

                    else if (input2 == "4")
                    {
                    Console.Write("Enter first number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    sc.Division(a, b);
                        goto Option2;
                    }
                    else if (input2 == "5")
                    {
                    Console.Write("Enter base: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter power: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    sc.XtoY(a, b);
                        goto Option2;
                    }
                    else if (input2 == "6")
                    {
                    Console.Write("Enter a number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    sc.Factorial(a);
                        goto Option2;
                    }
                    else if (input2 == "7")
                    {
                    Console.Write("Enter a number: ");
                    int num = int.Parse(Console.ReadLine());
                    sc.ConvertToBinary(num);
                        goto Option2;
                    }
                    else if (input2 == "8")
                    {
                        goto Main;
                    }
                    else
                    {
                        Console.WriteLine("Choose correct Input..");
                    }

                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }

              Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=====Homework one======\n====by Vadim Bezhkov===\n======calculator=======");
                Console.WriteLine("+ - press eny key 1");
                Console.WriteLine("- - press eny key 2");
                Console.WriteLine("* - press eny key 3");
                Console.WriteLine("/ - press eny key 4");
                Console.WriteLine("% - press eny key 5");
                Console.WriteLine("√ - press eny key 6");
                Console.WriteLine("exit to program - press eny key 7");
                string chose = Console.ReadLine();
                Console.Clear();
                switch (chose)
                {
                    case "1":
                        Console.WriteLine("You CHOSE (1)");
                        Console.WriteLine("addition operation");
                        Console.WriteLine("prees any one number");
                        decimal number1 = Convert.ToDecimal(Console.ReadLine()); 
                        Console.WriteLine("prees any two number");
                        decimal number2 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"result one number + two number = {number1+number2}");
                        Console.WriteLine("CONTINUE PRESS ANY KEY...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":

                        Console.WriteLine("You CHOSE (2)");
                        Console.WriteLine("subtracting numbers");
                        Console.WriteLine("prees any one number");
                        decimal number3 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("prees any two number");
                        decimal number4 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"result one number - two number = {number3 - number4}");
                        Console.WriteLine("CONTINUE PRESS ANY KEY...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("You CHOSE (3)");
                        Console.WriteLine("multiplication of numbers");
                        Console.WriteLine("prees any one number");
                        decimal number5 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("prees any two number");
                        decimal number6 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"result one number - two number = {number5 * number6}");
                        Console.WriteLine("CONTINUE PRESS ANY KEY...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("You CHOSE (4)");
                        Console.WriteLine("quotient numbers");
                        Console.WriteLine("prees any one number");
                        decimal number7 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("prees any two number");
                        decimal number8 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"result one number - two number = {number7 / number8}");
                        Console.WriteLine("CONTINUE PRESS ANY KEY...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":

                        Console.WriteLine("You CHOSE (5)");
                        Console.WriteLine("procent");
                        Console.WriteLine("prees any one number");
                        decimal number9 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("prees any procent");
                        decimal number10 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"result  percentage of the number = {(number9 * number10)/100}");
                        Console.WriteLine("CONTINUE PRESS ANY KEY...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        Console.WriteLine("You CHOSE (5)");
                        Console.WriteLine("√");
                        Console.WriteLine("prees in t number");
                        decimal number11 = Convert.ToDecimal(Console.ReadLine());
                        double number12 = Math.Sqrt(5.25);
                       Console.WriteLine($"Root from number = {number12}");
                        Console.WriteLine("CONTINUE PRESS ANY KEY...");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case "7":

                        Environment.Exit(0);
                        break;
                }
            }

            Console.ReadKey();
            
        }
    }
}

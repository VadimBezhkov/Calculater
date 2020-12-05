using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //number input validation method
        static decimal check()
        {
            decimal number;
            while (true)
            {
                var input = Console.ReadLine();
                var condition = decimal.TryParse(input, out number);
                if (condition)

                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Error enter number");
                }

            }
        }
        static void Main(string[] args)
        {
            //array cell variable
            int si = 0;
            decimal[] result = new decimal[5];
            decimal[] signs = new decimal[100];

            while (true)
            {
                Console.Clear();

                // action menu
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=====Homework one======\n====by Vadim Bezhkov===\n======calculator=======");
                Console.WriteLine("+ - enter key 1");
                Console.WriteLine("- - enter key 2");
                Console.WriteLine("* - enter key 3");
                Console.WriteLine("/ - enter key 4");
                Console.WriteLine("% - enter key 5");
                Console.WriteLine("√ - enter key 6");
                Console.WriteLine("5 latest results of operations - enter key 7");
                Console.WriteLine("exit to program - enter key 8");
                Console.Write("enter key:");
                
                string chose = Console.ReadLine();
                Console.Clear();

                // vybor deystviya
                switch (chose)
                {
                    //addition operation
                    case "1":
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (1)");
                            Console.WriteLine("addition operation");
                            Console.WriteLine("Enter number A");
                            decimal number1 = check();

                            Console.WriteLine("Enter number B");
                            decimal number2 = check();
                            result[si] = number1 + number2;

                            // adding the result to the array
                            si = si + 1;

                            if (si>4)
                            {
                                si = 0;
                            }

                            Console.WriteLine($"result: {number1} + {number2} = {number1 + number2}");
                            Console.WriteLine("Do you want to repeat enter? yes \nto exit press any button and press enter");
                            String repeat = Console.ReadLine();

                            while (true)
                            {
                                if (repeat == "yes")
                                {

                                    if (si > 4)
                                    {
                                        si = 0;
                                    }

                                    goto case "1";
                                }

                                break;
                            }
                        }

                        break;
                    //subtracting numbers
                    case "2":
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (2)");
                            Console.WriteLine("subtracting numbers");
                            Console.WriteLine("Enter number A");
                            decimal number1 = check();

                            Console.WriteLine("Enter number B");
                            decimal number2 = check();
                            result[si] = number1 - number2;
                            si = si + 1;

                            if (si > 4)
                            {
                                si = 0;
                            }

                            Console.WriteLine($"result: {number1} - {number2} = {number1 - number2}");
                            Console.WriteLine("Do you want to repeat enter? yes \nto exit press any button and press enter");
                            String repeat = Console.ReadLine();

                            while (true)
                            {
                                if (repeat == "yes")
                                {

                                    if (si > 4)
                                    {
                                        si = 0;
                                    }

                                    goto case "2";
                                }
                                else
                                    break;
                            }  
                        }

                        break;
                    //multiplication of numbers
                    case "3":
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (3)");
                            Console.WriteLine("multiplication of numbers");
                            Console.WriteLine("Enter number A");
                            decimal number1 = check();

                            Console.WriteLine("Enter number B");
                            decimal number2 = check();
                            result[si] = number1 * number2;
                            si = si + 1;
                           
                            if (si > 4)
                            {
                                si = 0;
                            }

                            Console.WriteLine($"result: {number1} * {number2} = {number1 * number2}");
                            Console.WriteLine("Do you want to repeat enter? yes \nto exit press any button and press enter");
                            String repeat = Console.ReadLine();

                            while (true)
                            {
                                if (repeat == "yes")
                                {

                                    if (si > 4)
                                    {
                                        si = 0;
                                    }

                                    goto case "3";
                                }
                                else
                                    break;
                            }
                        } 
                        
                        break;
                    //quotient numbers
                    case "4":
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (4)");
                            Console.WriteLine("quotient numbers");
                            Console.WriteLine("Enter number A");
                            decimal number1 = check();

                            Console.WriteLine("Enter number B");
                            decimal number2 = check();
                            result[si] = number1 / number2;
                            si = si + 1;

                            if (si > 4)
                            {
                                si = 0;
                            }

                            Console.WriteLine($"result: {number1} / {number2} = {number1 / number2}");
                            Console.WriteLine("Do you want to repeat enter? yes \nto exit press any button and press enter");
                            String repeat = Console.ReadLine();

                            while (true)
                            {
                                if (repeat == "yes")
                                {

                                    if (si > 4)
                                    {
                                        si = 0;
                                    }

                                    goto case "4";
                                }
                                else
                                    break;
                            }
                        }

                        break;
                    //percentage of the number
                    case "5":
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (5)");
                            Console.WriteLine("procent");
                            Console.WriteLine("Enter number");
                            decimal number1 = check();

                            Console.WriteLine("enter any procent");
                            decimal number2 = check();
                            result[si] = (number1 / number2)/100;
                            si = si + 1;
                          
                            if (si > 4)
                            {
                                si = 0;
                            }

                            Console.WriteLine($"result:  {(number1 * number2) / 100}");
                            Console.WriteLine("Do you want to repeat enter? yes \nto exit press any button and press enter");
                            String repeat = Console.ReadLine();

                            while (true)
                            {
                                if (repeat == "yes")
                                {

                                    if (si > 4)
                                    {
                                        si = 0;
                                    }

                                    goto case "5";
                                }
                                else
                                    break;
                            }
                        }

                        break;
                    //root of number
                    case "6":
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (5)");
                            Console.WriteLine("√");
                            Console.WriteLine("Enter number ");
                            double number1;

                            while (true)
                            {
                                if (double.TryParse(Console.ReadLine(), out number1))
                                {
                                    break;
                                }
                                else Console.WriteLine("Error    :enter number");
                            }

                            double number2 = Math.Sqrt(number1);
                            Console.WriteLine($"Root from number = {number2}");
                            decimal number3 = Convert.ToDecimal(number2);
                            result[si] = number3;
                            si = si + 1;

                            if (si > 4)
                            {
                                si = 0;
                            }

                            Console.WriteLine("Do you want to repeat enter? yes \nto exit press any button and press enter");
                            String repeat = Console.ReadLine();

                            while (true)
                            {

                                if (repeat == "yes")
                                {

                                    if (si > 4)
                                    {
                                        si = 0;
                                    }

                                    goto case "6";
                                }
                                else
                                    break;
                            }
                        }

                        break;
                    //last 5 operations on numbers
                    case "7":
                        {
                            Console.WriteLine($"{result[0]}, {result[1]}, {result[2]}, {result[3]}, {result[4]}");
                            Console.ReadKey();
                        }

                        break;
                    //exit to programm
                    case "8":
                        {
                            Console.WriteLine("Exit programm y -yes n-no?");
                            String exit = Console.ReadLine();

                            if (exit == "n")
                            {
                                break;
                            }

                            else if (exit == "y")
                            {
                                Environment.Exit(0);
                            }

                            else
                            {
                                Console.Clear();
                                goto case "8";
                            }
                        }
                        
                        break;
                    //if no menu button is selected
                    default:
                        {
                            Console.WriteLine("Mistake. Make your choice \npress any button to continue");
                            Console.ReadKey();
                        }

                        break;
                }
            }
        }
    }
}

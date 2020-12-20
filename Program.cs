﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    enum Operation:byte
    {
        add=1,
        subtract,
        multiply,
        devide,
        percentage,
        root,
        result,
        exit
    }
    class Program
    {
        static int si = 0;
        static (double, double) number;
        static double result;
        static double[] resultmas = new double[5];
        //number input validation method
        static double Check()
        {
            double number;
            while (true)
            {
                var input = Console.ReadLine();
                var condition = double.TryParse(input, out number);
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
        // adding the result to the array
        static void Result(double result)
        {
            resultmas[si] = result;
            si = si + 1;

            if (si > 4)
            {
                si = 0;
            }

        }
        static void ActionMenu()
        {
            // action menu
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=====Homework one======\n====by Vadim Bezhkov===\n======calculator=======");
            Console.WriteLine("+ - enter key 1");
            Console.WriteLine("- - enter key 2");
            Console.WriteLine("* - enter key 3");
            Console.WriteLine("/ - enter key 4");
            Console.WriteLine("% - enter key 5");
            Console.WriteLine("√ - enter key 6");
            Console.WriteLine("5 results - enter key 7");
            Console.WriteLine("exit to program - enter key 8");
            Console.Write("enter key:");
        }
        static void PrintResult()
        {
            foreach (var item in resultmas)
            {
                Console.WriteLine($"result:{item}");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                ActionMenu();
                
                string chose = Console.ReadLine(); 
                byte choseEnum;
                Console.Clear();

                bool check = byte.TryParse(chose, out choseEnum);
                Operation op=(Operation)choseEnum;
                // choose action
                switch (op)
                {
                    //addition operation
                    case Operation.add:
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (1)");
                            Console.WriteLine("addition operation");

                            Console.WriteLine("Enter number A");
                            number.Item1 = Check();

                            Console.WriteLine("Enter number B");
                            number.Item2 = Check();

                            result = number.Item1 + number.Item2;
                            Result(result);

                            Console.WriteLine($"result: {result}");
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

                                    goto case Operation.add;
                                }

                                break;
                            }
                        }

                        break;
                    //subtracting numbers
                    case Operation.subtract:
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (2)");
                            Console.WriteLine("subtracting numbers");

                            Console.WriteLine("Enter number A");
                            number.Item1 = Check();

                            Console.WriteLine("Enter number B");
                            number.Item2 = Check();

                            result = number.Item1 - number.Item2;
                            Result(result);

                            Console.WriteLine($"result: {result}");
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

                                    goto case Operation.subtract;
                                }
                                else
                                    break;
                            }  
                        }

                        break;
                    //multiplication of numbers
                    case Operation.multiply:
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (3)");
                            Console.WriteLine("multiplication of numbers");

                            Console.WriteLine("Enter number A");
                            number.Item1 = Check();

                            Console.WriteLine("Enter number B");
                            number.Item2 = Check();

                            result = number.Item1 * number.Item2;
                            Result(result);

                            Console.WriteLine($"result: {result}");
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

                                    goto case Operation.multiply;
                                }
                                else
                                    break;
                            }
                        } 
                        
                        break;
                    //quotient numbers
                    case Operation.devide:
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (4)");
                            Console.WriteLine("quotient numbers");

                            Console.WriteLine("Enter number A");
                            number.Item1 = Check();

                            Console.WriteLine("Enter number B");
                            number.Item2 = Check();

                            result = number.Item1 / number.Item2;
                            Result(result);

                            Console.WriteLine($"result: {result}");
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

                                    goto case Operation.devide;
                                }
                                else
                                    break;
                            }
                        }

                        break;
                    //percentage of the number
                    case Operation.percentage:
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (5)");
                            Console.WriteLine("procent");

                            Console.WriteLine("Enter number");
                            number.Item1 = Check();

                            Console.WriteLine("enter any procent");
                            number.Item2 = Check();

                            result = (number.Item1 * number.Item2)/100;
                            Result(result);

                            Console.WriteLine($"result:  {result}");
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

                                    goto case Operation.percentage;
                                }
                                else
                                    break;
                            }
                        }

                        break;
                    //root of number
                    case Operation.root:
                        {
                            Console.ResetColor();
                            Console.WriteLine("You CHOSE (5)");
                            Console.WriteLine("√");

                            Console.WriteLine("Enter number ");
                            number.Item1 = Check();

                            result = Math.Sqrt(number.Item1);
                            Console.WriteLine($"Root from number = {result}");

                            Result(result);

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

                                    goto case Operation.root;
                                }
                                else
                                    break;
                            }
                        }

                        break;
                    //last 5 operations on numbers
                    case Operation.result:
                        {
                            PrintResult();
                            Console.ReadKey();
                        }

                        break;
                    //exit to programm
                    case Operation.exit:
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
                                goto case Operation.exit;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    enum Operation : byte
    {
        add = 1,
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
        static string info = "Do you want to repeat enter? yes \n" +
            "to exit press any button and press enter";
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
            //si = si + 1;
            resultmas[si++] = result;
            CheckForFilling();

        }
        //if more than five results
        static void CheckForFilling()
        {
            if (si > 4)
            {
                si = 0;
            }
        }

        // action menu
        static void ActionMenu()
        {
            Console.Clear();
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
        //displaying the last five results
        static void PrintResult()
        {
            foreach (var item in resultmas)
            {
                Console.WriteLine($"result:{item}");
            }
        }
        //input numbers
        static void Enternumbers()
        {
            Console.WriteLine("Enter number A");
            number.Item1 = Check();

            Console.WriteLine("Enter number B");
            number.Item2 = Check();
        }
        //user result output
        static void PrintResultInfo()
        {
            Console.WriteLine($"result: {result}");
            Console.WriteLine(info);
        }
        //add operation
        static double Add(double number1, double number2)
        {
            result = number1 + number2;
            return result;
        }
        //substract operation
        static double Subtract(double number1, double number2)
        {
            result = number1 - number2;
            return result;
        }
        //multiply operation
        static double Multiply(double number1, double number2)
        {
            result = number1 * number2;
            return result;
        }
        //devide operation
        static double Devide(double number1, double number2)
        {
            result = number1 / number2;
            return result;
        }
        //percentage operation
        static double Percentage(double number1, double number2)
        {
            result = (number1 * number2) / 100;
            return result;
        }
        //root operation
        static double Root(double number1)
        {
            result = Math.Sqrt(number1);
            return result;
        }
        //text output operation
        static void CustomWriteLine(string text)
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                ActionMenu();
                Operation op;
                Enum.TryParse(Console.ReadLine(), out op);
                // choose action
                switch (op)
                {
                    //addition operation
                    case Operation.add:
                        {
                            do
                            {
                                CustomWriteLine($"You CHOSE ({Operation.add})\naddition operation");
                                Enternumbers();
                                Add(number.Item1, number.Item2);
                                Result(result);
                                PrintResultInfo();

                            } while (Console.ReadLine() == "yes");
                            //Console.ResetColor();
                            //Console.WriteLine($"You CHOSE ({Operation.add})");
                            //Console.WriteLine("addition operation");

                            //Enternumbers();
                            //Add(number.Item1,number.Item2);
                            //Result(result);
                            //PrintResultInfo();

                            //String repeat = Console.ReadLine();

                            //while (true)
                            //{
                            //    if (repeat == "yes")
                            //    {
                            //        CheckForFilling();
                            //        goto case Operation.add;
                            //    }

                            //    break;
                            //}
                        }

                        break;
                    //subtracting numbers
                    case Operation.subtract:
                        {
                            do
                            {
                                CustomWriteLine($"You CHOSE ({Operation.subtract})\nsubtracting numbers");
                                Enternumbers();
                                Subtract(number.Item1, number.Item2);
                                Result(result);
                                PrintResultInfo();
                            }
                            while (Console.ReadLine() == "yes");
                        }

                        break;
                    //multiplication of numbers
                    case Operation.multiply:
                        {
                            do
                            {
                                CustomWriteLine($"You CHOSE ({Operation.multiply})\nmultiplication of numbers");
                                Enternumbers();
                                Multiply(number.Item1, number.Item2);
                                Result(result);
                                PrintResultInfo();
                            }
                            while (Console.ReadLine() == "yes");
                        }

                        break;
                    //quotient numbers
                    case Operation.devide:
                        {
                            do
                            {
                                CustomWriteLine($"You CHOSE ({Operation.devide})\nquotient numbers");
                                Enternumbers();
                                Devide(number.Item1, number.Item2);
                                Result(result);
                                PrintResultInfo();
                            }
                            while (Console.ReadLine() == "yes");
                        }

                        break;
                    //percentage of the number
                    case Operation.percentage:
                        {
                            do
                            {
                                CustomWriteLine($"You CHOSE ({Operation.percentage})\nprocent\nEnter number");
                                number.Item1 = Check();
                                Console.WriteLine("enter any procent");
                                number.Item2 = Check();

                                Percentage(number.Item1, number.Item2);
                                Result(result);
                                PrintResultInfo();
                            }
                            while (Console.ReadLine() == "yes");
                        }

                        break;
                    //root of number
                    case Operation.root:
                        {
                            do
                            {
                                Console.ResetColor();
                                Console.WriteLine($"You CHOSE ({Operation.root})\n√\nEnter number");
                                number.Item1 = Check();

                                Root(number.Item1);
                                Result(result);
                                PrintResultInfo();
                            }
                            while (Console.ReadLine() == "yes");
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
                            String exit;
                            do
                            {
                                Console.WriteLine("Exit programm y -yes n-no?");
                                exit = Console.ReadLine();

                                if (exit == "y")
                                {
                                    Environment.Exit(0);
                                }

                            } while (exit != "n");
                        }
                        break;
                    //if no menu button is selected
                    default:
                        {
                            Console.WriteLine("Mistake. Make your choice \n" +
                                "press any button to continue");
                            Console.ReadKey();
                        }

                        break;
                }
            }
        }
    }
}

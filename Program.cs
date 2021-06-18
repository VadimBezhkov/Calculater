using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using ConsoleApp2.Util;
using Autofac;

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
        appconfig,
        exit
    }
    class Program
    {
        public static (double, double) number;
        public static double result;
        static int si = 0;
        static double[] resultmas = new double[5];
        static string info = "Do you want to repeat enter? yes \n" +
            "to exit press any button and press enter";

        // action menu
        public static void ActionMenu()
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
            Console.WriteLine("print App.config - enter key 8");
            Console.WriteLine("exit to program - enter key 9");
            Console.Write("enter key:");
        }

        //number input validation method
        public static double Check()
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
        public static void Result(double result)
        {
            //si = si + 1;
            resultmas[si++] = result;
            CheckForFilling();

        }

        //if more than five results
        private static void CheckForFilling()
        {
            if (si > 4)
            {
                si = 0;
            }
        }

        //displaying the last five results
        public static void PrintResult()
        {
            foreach (var item in resultmas)
            {
                Console.WriteLine($"result:{item}");
            }
        }
        //input numbers
        public static void Enternumbers()
        {
            Console.WriteLine("Enter number A");
            number.Item1 = Program.Check();

            Console.WriteLine("Enter number B");
            number.Item2 = Program.Check();
        }

        //user result output
        public static void PrintResultInfo()
        {
            Console.WriteLine($"result: {result}");
            Console.WriteLine(typeof(IMember));
            Console.WriteLine(info);
        }
        public static void CustomWriteLine(string text)
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            var container = AutofacConfig.ConfigureContainer();
            ILifetimeScope scope = container.BeginLifetimeScope();
            IMember members = scope.Resolve<IMember>();

            while (true)
            {
                ActionMenu();
                Operation op;
                Enum.TryParse(Console.ReadLine(), out op);

                // choose action
                switch (op)
                {
                    case Operation.add:
                        {
                            do
                            {
                                CustomWriteLine($"You CHOSE ({Operation.add})\naddition operation");
                                Enternumbers();
                                members.Add(number.Item1, number.Item2);
                                Result(result);
                                PrintResultInfo();

                            } while (Console.ReadLine() == "yes");
                        }

                        break;
                    //subtracting numbers
                    case Operation.subtract:
                        {
                            do
                            {
                                CustomWriteLine($"You CHOSE ({Operation.subtract})\nsubtracting numbers");
                                Enternumbers();
                                members.Subtract(number.Item1, number.Item2);
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
                                members.Multiply(number.Item1, number.Item2);
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
                                members.Devide(number.Item1, number.Item2);
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

                                members.Percentage(number.Item1, number.Item2);
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

                                members.Root(number.Item1);
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
                    case Operation.appconfig:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            NameValueCollection sAll;
                            sAll = ConfigurationManager.AppSettings;

                            foreach (string s in sAll.AllKeys)
                            Console.WriteLine("Key: " + s + " Value: " + sAll.Get(s));
                            Console.WriteLine(new string('-', 52));
                            Console.WriteLine("press eny key");
                            Console.ReadLine();
                        }
                        Console.ResetColor();

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

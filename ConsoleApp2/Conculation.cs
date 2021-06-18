using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Conculation
    {
        private IMember members;

        public Conculation(IMember memb)
        {
            members = memb;
        }
        void Method(Operation op)
        {
            while (true)
            {

                // choose action
                switch (op)
                {
                    case Operation.add:
                        {
                            do
                            {
                                Program.CustomWriteLine($"You CHOSE ({Operation.add})\naddition operation");
                                Program.Enternumbers();
                                members.Add(Program.number.Item1, Program.number.Item2);
                                Program.Result(Program.result);
                                Program.PrintResultInfo();

                            } while (Console.ReadLine() == "yes");
                        }

                        break;
                    //subtracting numbers
                    case Operation.subtract:
                        {
                            do
                            {
                                Program.CustomWriteLine($"You CHOSE ({Operation.subtract})\nsubtracting numbers");
                                Program.Enternumbers();
                                members.Subtract(Program.number.Item1, Program.number.Item2);
                                Program.Result(Program.result);
                                Program.PrintResultInfo();
                            }
                            while (Console.ReadLine() == "yes");
                        }

                        break;
                    //multiplication of numbers
                    case Operation.multiply:
                        {
                            do
                            {
                                Program.CustomWriteLine($"You CHOSE ({Operation.multiply})\nmultiplication of numbers");
                                Program.Enternumbers();
                                members.Multiply(Program.number.Item1, Program.number.Item2);
                                Program.Result(Program.result);
                                Program.PrintResultInfo();
                            }
                            while (Console.ReadLine() == "yes");
                        }

                        break;
                    //quotient numbers
                    case Operation.devide:
                        {
                            do
                            {
                                Program.CustomWriteLine($"You CHOSE ({Operation.devide})\nquotient numbers");
                                Program.Enternumbers();
                                members.Devide(Program.number.Item1, Program.number.Item2);
                                Program.Result(Program.result);
                                Program.PrintResultInfo();
                            }
                            while (Console.ReadLine() == "yes");
                        }

                        break;
                    //percentage of the number
                    case Operation.percentage:
                        {
                            do
                            {
                                Program.CustomWriteLine($"You CHOSE ({Operation.percentage})\nprocent\nEnter number");
                                Program.number.Item1 = Program.Check();
                                Console.WriteLine("enter any procent");
                                Program.number.Item2 = Program.Check();

                                members.Percentage(Program.number.Item1, Program.number.Item2);
                                Program.Result(Program.result);
                                Program.PrintResultInfo();
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
                                Program.number.Item1 = Program.Check();

                                members.Root(Program.number.Item1);
                                Program.Result(Program.result);
                                Program.PrintResultInfo();
                            }
                            while (Console.ReadLine() == "yes");
                        }

                        break;
                    //last 5 operations on numbers
                    case Operation.result:
                        {
                            Program.PrintResult();
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

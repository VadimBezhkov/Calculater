using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Naturalsmembers:IMember
    {

     
        //add operation
        public double Add(double number1, double number2)
        {
            Program.result = number1 + number2;
            return Program.result;
        }
        //substract operation
        public double Subtract(double number1, double number2)
        {
            Program.result = number1 - number2;
            return Program.result;
        }
        //multiply operation
        public double Multiply(double number1, double number2)
        {
            Program.result = number1 * number2;
            return Program.result;
        }
        //devide operation
        public double Devide(double number1, double number2)
        {
            Program.result = number1 / number2;
            return Program.result;
        }
        //percentage operation
        public double Percentage(double number1, double number2)
        {
            Program.result = (number1 * number2) / 100;
            return Program.result;
        }
        //root operation
        public double Root(double number1)
        {
            Program.result = Math.Sqrt(number1);
            return Program.result;
        }
        //text output operation

    }
}

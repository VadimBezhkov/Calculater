using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ComplexMember : IMember
    {
        public double Add(double number1, double number2)
        {
            Program.result = Math.Sin(number1) + Math.Sin(number2);
            return Program.result;
        }

        public double Add(double number1, double number2, double member3, double member4)
        {
            Program.result = number1 + number2;
            return Program.result;
        }

        public ValueTuple<double, double> Add(ValueTuple<double,double> number1, ValueTuple<double, double> number2)
        {
            return new ValueTuple<double, double>(number1.Item1 + number2.Item1, number1.Item2 + number2.Item2);
        }

        public double Devide(double number1, double number2)
        {
            throw new NotImplementedException();
        }

        public double Multiply(double number1, double number2)
        {
            throw new NotImplementedException();
        }

        public double Percentage(double number1, double number2)
        {
            throw new NotImplementedException();
        }

        public double Root(double number1)
        {
            throw new NotImplementedException();
        }

        public double Subtract(double number1, double number2)
        {
            throw new NotImplementedException();
        }
    }
}

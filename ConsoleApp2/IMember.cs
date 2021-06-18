using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public interface IMember
    {
        double Add(double number1, double number2);
        double Subtract(double number1, double number2);
        double Multiply(double number1, double number2);
        double Devide(double number1, double number2);
        double Percentage(double number1, double number2);
        double Root(double number1);
    }
}

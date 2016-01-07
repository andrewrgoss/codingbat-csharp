using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SumDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDouble(1, 2));
            Console.WriteLine(SumDouble(3, 2));
            Console.WriteLine(SumDouble(2, 2));
            Console.ReadLine();
        }

        /*Given two int values, return their sum. However, if the two values are the same, then return double their sum.*/

        public static int SumDouble(int a, int b)
        {
            return a == b ? (a + b) * 2 : a + b; //The conditional operator (?:) returns one of two values depending on the value of a Boolean expression.// 
            //The following is the syntax for the conditional operator: condition ? first_expression : second_expression;

            //The condition must evaluate to true or false. If condition is true, first_expression is evaluated and becomes the result. If condition is false, second_expression is evaluated and becomes the result. Only one of the two expressions is evaluated.

            //https://msdn.microsoft.com/en-us/library/ty67wk28.aspx

            //my initial attempt:

            //if (a == b)
            //    return (a + b) * 2;
            //else
            //    return a + b;
        }
    }
}

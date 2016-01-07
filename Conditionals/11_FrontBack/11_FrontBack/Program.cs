using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_FrontBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FrontBack("code"));
            Console.WriteLine(FrontBack("a"));
            Console.WriteLine(FrontBack("ab"));
            Console.WriteLine(FrontBack("BostonRedSox"));
            Console.ReadLine();
        }

        /*Given a string, return a new string where the first and last chars have been exchanged.*/

        public static string FrontBack(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;

            //The conditional operator (?:) returns one of two values depending on the value of a Boolean expression.// 
            //The following is the syntax for the conditional operator: condition ? first_expression : second_expression;

            //The condition must evaluate to true or false. If condition is true, first_expression is evaluated and becomes the result. If condition is false, second_expression is evaluated and becomes the result. Only one of the two expressions is evaluated.

            //https://msdn.microsoft.com/en-us/library/ty67wk28.aspx
        }
    }
}

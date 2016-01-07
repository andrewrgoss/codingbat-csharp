using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Front3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Front3("Microsoft"));
            Console.WriteLine(Front3("Chocolate"));
            Console.WriteLine(Front3("at"));
            Console.ReadLine();
        }

        /*Given a string, we'll say that the front is the first 3 chars of the string. If the string length is less than 3, the front is whatever is there. Return a new string which is 3 copies of the front.*/

        public static string Front3(string str)
        {

            return str.Length < 3 ? str + str + str : str.Substring(0, 3) + str.Substring(0, 3) + str.Substring(0, 3);

            //The conditional operator (?:) returns one of two values depending on the value of a Boolean expression.// 
            //The following is the syntax for the conditional operator: condition ? first_expression : second_expression;

            //The condition must evaluate to true or false. If condition is true, first_expression is evaluated and becomes the result. If condition is false, second_expression is evaluated and becomes the result. Only one of the two expressions is evaluated.

            //https://msdn.microsoft.com/en-us/library/ty67wk28.aspx

            
            //My initial attempt:
            
            //string Front3;

            //if (str.Length > 2)
            //{
            //    Front3 = str.Substring(0, 3) + str.Substring(0, 3) + str.Substring(0, 3);
            //}
            //else
            //{
            //    Front3 = str.Substring(0, str.Length) + str.Substring(0, str.Length) + str.Substring(0, str.Length);
            //}
            //return Front3;
        }
    }
}

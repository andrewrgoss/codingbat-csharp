using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Closer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Closer(8, 13));
            Console.WriteLine(Closer(13, 8));
            Console.WriteLine(Closer(13, 7));
            Console.ReadLine();
        }

        /*Given 2 int values, return whichever value is nearest to the value 10, or return 0 in the event of a tie.*/

        public static int Closer(int a, int b)
        {
            const int compareValue = 10;

            //long data type: https://msdn.microsoft.com/en-us/library/ctetwysk(v=vs.120).aspx

            long distanceA = Math.Abs(compareValue - (long)a);
            long distanceB = Math.Abs(compareValue - (long)b);

            if (distanceA == distanceB)
            {
                return 0;
            }

            return distanceA > distanceB ? b : a;

            //The conditional operator (?:) returns one of two values depending on the value of a Boolean expression.// 
            //The following is the syntax for the conditional operator: condition ? first_expression : second_expression;

            //The condition must evaluate to true or false. If condition is true, first_expression is evaluated and becomes the result. If condition is false, second_expression is evaluated and becomes the result. Only one of the two expressions is evaluated.

            //https://msdn.microsoft.com/en-us/library/ty67wk28.aspx
        }
    }
}

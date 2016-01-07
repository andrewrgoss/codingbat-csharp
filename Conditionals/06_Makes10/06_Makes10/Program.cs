using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Makes10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Makes10(9, 10));
            Console.WriteLine(Makes10(9, 9));
            Console.WriteLine(Makes10(1, 9));
            Console.ReadLine();
        }

        /*Given two ints, a and b, return true if one if them is 10 or if their sum is 10.*/

        public static bool Makes10(int a, int b)
        {

            return a == 10 || b == 10 || (a + b == 10);

            //My initial attempt, which was correct but more efficient code above.
            
            //if (a == 10 || b == 10 || a + b == 10)
            //{
            //    return true;
            //}
            //return false;
        }
    }
}

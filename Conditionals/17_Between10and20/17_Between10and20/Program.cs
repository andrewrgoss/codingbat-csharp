using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Between10and20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Between10and20(12, 99));
            Console.WriteLine(Between10and20(21, 12));
            Console.WriteLine(Between10and20(8, 99));
            Console.WriteLine(Between10and20(10, 86));
            Console.WriteLine(Between10and20(4, 20));
            Console.ReadLine();
        }

        /*Given 2 int values, return true if either of them is in the range 10..20 inclusive.*/

        public static bool Between10and20(int a, int b)
        {
            return Enumerable.Range(10,20).Contains(a) || Enumerable.Range(10,20).Contains(b);
            //return (a >= 10 && a <= 20) || (b >= 10 && b <= 20);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_NearHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NearHundred(103));
            Console.WriteLine(NearHundred(90));
            Console.WriteLine(NearHundred(89));
            Console.ReadLine();
        }

        /*Given an int n, return true if it is within 10 of 100 or 200. Hint: Check out the C# Math class for absolute value.*/

        public static bool NearHundred(int n)
        {
            const int x = 100;
            const int y = 200;

            int i = 0;
            int j = 0;

            i = Math.Abs(n - x); //Returns the absolute value of a specified number, this cannot be negative.
            j = Math.Abs(n - y);

            if (i <= 10 || j <= 10)
            {
                return true;
            }
            return false;
        }
    }
}

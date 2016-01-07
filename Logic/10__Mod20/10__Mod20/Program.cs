using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10__Mod20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mod20(20)); // → false
            Console.WriteLine(Mod20(21)); // → true
            Console.WriteLine(Mod20(22)); // → true
            Console.WriteLine(Mod20(-60)); // → false
            Console.WriteLine(Mod20(41)); // → true
            Console.WriteLine(Mod20(42)); // → true
            Console.ReadLine();
        }

        /*Return true if the given non-negative number is 1 or 2 more than a multiple of 20. See also: Introduction to Mod*/

        public static bool Mod20(int n)
        {
            var result = Math.Abs(n) % 20;
            return result == 1 || result == 2;
        }
    }
}

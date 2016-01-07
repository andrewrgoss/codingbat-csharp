using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11__Mod35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mod35(3)); // → true
            Console.WriteLine(Mod35(10)); // → true
            Console.WriteLine(Mod35(15)); // → false
            Console.WriteLine(Mod35(33)); // → true
            Console.ReadLine();
        }

        /*Return true if the given non-negative number is a multiple of 3 or 5, but not both. Use the % "mod" operator*/

        public static bool Mod35(int n)
        {
            return Math.Abs(n) % 3 == 0 && Math.Abs(n) % 5 == 0 ? false : Math.Abs(n) % 3 == 0 || Math.Abs(n) % 5 == 0;
        }
    }
}

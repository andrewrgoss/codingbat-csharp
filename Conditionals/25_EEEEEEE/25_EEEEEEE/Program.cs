using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _25_EEEEEEE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GotE("Hello"));
            Console.WriteLine(GotE("Heelle"));
            Console.WriteLine(GotE("Heelele"));
            Console.ReadLine();
        }

        /*Return true if the given string contains between 1 and 3 'e' chars.*/

        public static bool GotE(string str)
        {
            var numE = 0;
            numE = Regex.Matches(str, "e").Count;

            return numE >= 1 && numE <= 3;
        }
    }
}

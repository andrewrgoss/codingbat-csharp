using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_BackAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BackAround("cat"));
            Console.WriteLine(BackAround("Hello"));
            Console.WriteLine(BackAround("a"));
            Console.ReadLine();
        }

        /*Given a string, take the last char and return a new string with the last char added at the front and back, so "cat" yields "tcatt". The original string will be length 1 or more.*/

        public static string BackAround(string str)
        {
            return str.Substring(str.Length - 1) + str + str.Substring(str.Length - 1);
        }
    }
}

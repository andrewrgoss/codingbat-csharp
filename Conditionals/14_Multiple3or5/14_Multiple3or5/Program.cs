using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Multiple3or5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiple3or5(3));
            Console.WriteLine(Multiple3or5(10));
            Console.WriteLine(Multiple3or5(8));
            Console.ReadLine();
        }

        /*Return true if the given non-negative number is a multiple of 3 or a multiple of 5. Use the % "mod" operator.*/

        public static bool Multiple3or5(int number)
        {
            return (number % 3) == 0 || (number % 5) == 0;
        }
    }
}

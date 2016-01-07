using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13__TwoIsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoIsOne(1, 2, 3)); // → true
            Console.WriteLine(TwoIsOne(3, 1, 2)); // → true
            Console.WriteLine(TwoIsOne(3, 2, 2)); // → false
            Console.ReadLine();
        }

        /*Given three ints, a b c, return true if it is possible to add two of the ints to get the third.*/

        public static bool TwoIsOne(int a, int b, int c)
        {
            return a + b == c || a + c == b || b + c == a;
        }
    }
}

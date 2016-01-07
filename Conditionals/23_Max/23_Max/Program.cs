using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max(1, 2, 3));
            Console.WriteLine(Max(1, 3, 2));
            Console.WriteLine(Max(3, 2, 1));
            Console.ReadLine();
        }

        /*Given three int values, a b c, return the largest.*/

        public static int Max(int a, int b, int c)
        {
            return MoreMath.Max(a, b, c);
        }

        public static class MoreMath
        {
            // This method only exists for consistency, so you can *always* call
            // MoreMath.Max instead of alternating between MoreMath.Max and Math.Max
            // depending on your argument count.
            public static int Max(int x, int y)
            {
                return Math.Max(x, y);
            }

            public static int Max(int x, int y, int z)
            {
                // Or inline it as x < y ? (y < z ? z : y) : (x < z ? z : x);
                // Time it before micro-optimizing though!
                return Math.Max(x, Math.Max(y, z));
            }

            public static int Max(int w, int x, int y, int z)
            {
                return Math.Max(w, Math.Max(x, Math.Max(y, z)));
            }

            public static int Max(params int[] values)
            {
                return Enumerable.Max(values);
            }
        }
    }
}

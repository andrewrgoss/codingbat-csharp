using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Make2
{
    class Program
    {
        static void Main(string[] args)
        {
            make2(new int[] { 4, 5 }, new int[] { 1, 2, 3 });
            make2(new int[] { 4 }, new int[] { 1, 2, 3 });
            make2(new int[] { }, new int[] { 1, 2 });
            Console.ReadLine();
        }

        /*Given 2 int arrays, a and b, return a new array length 2 containing, as much as will fit, the elements from a followed by the elements from b. The arrays may be any length, including 0, but there will be 2 or more elements available between the 2 arrays.*/

        public static int[] make2(int[] a, int[] b)
        {
            var c = new int[2];
            var i = 0;

            while (i < a.Length && i < c.Length)
            {
                c[i] = a[i];
                i++;
            }
            while ((i - a.Length) < b.Length && i < c.Length)
            {
                c[i] = b[i - a.Length];
                i++;
            }

            Console.Write("\nArray= ");
            // Print new array values
            for (int j = 0; j < c.Length; j++)
                if (j == c.Length - 1)
                {
                    Console.Write(c[j]);
                }
                else
                {
                    Console.Write(c[j] + ",");
                }

            return c;
        }
    }
}

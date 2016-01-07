using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_GetMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 2, 9 };
            int[] b = { 1, 4, 5 };

            GetMiddleClass FindMiddle = new GetMiddleClass();
            FindMiddle.GetMiddle(a, b);
            Console.ReadLine();
        }
    }

    class GetMiddleClass
    {
        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] c = { a[1], b[1] };

            for (int i = 0; i < c.Length; i++)
                if (i == c.Length - 1)
                {
                    Console.Write(c[i]);
                }
                else
                {
                    Console.Write(c[i] + ",");
                }

            return c;
        }
    }
}

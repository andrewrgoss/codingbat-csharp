using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_IcyHot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IcyHot(120, -1));
            Console.WriteLine(IcyHot(-1, 120));
            Console.WriteLine(IcyHot(2, 120));
            Console.ReadLine();
        }

        /*Given two temperatures, return true if one is less than 0 and the other is greater than 100.*/

        public static bool IcyHot(int temp1, int temp2)
        {
            const int x = 0;
            const int y = 100;

            return (temp1 < x || temp2 < x) && (temp1 > y || temp2 > y);
        }
    }
}

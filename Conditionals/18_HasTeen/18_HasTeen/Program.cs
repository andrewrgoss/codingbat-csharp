using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_HasTeen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasTeen(13, 20, 10));
            Console.WriteLine(HasTeen(20, 19, 10));
            Console.WriteLine(HasTeen(20, 10, 12));
            Console.ReadLine();
        }

        /*We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 3 int values, return true if 1 or more of them are teen.*/

        public static bool HasTeen(int a, int b, int c)
        {
            return (a > 12 && a < 20) || (b > 12 && b < 20) || (c > 12 && c < 20);

            //bool aBool;
            //bool bBool;
            //bool cBool;

            //aBool = Enumerable.Range(13, 19).Contains(a); --somehow this is returning true even though a is 20 in last sample, don't get how
            //bBool = Enumerable.Range(13, 19).Contains(b);
            //cBool = Enumerable.Range(13, 19).Contains(c);
            
            //return (Enumerable.Range(13, 19).Contains(a)) || (Enumerable.Range(13, 19).Contains(b)) || (Enumerable.Range(13, 19).Contains(c));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Unlucky1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Unlucky1(new int[] { 1, 3, 4, 5 }));
            Console.WriteLine(Unlucky1(new int[] { 2, 1, 3, 4, 5 }));
            Console.WriteLine(Unlucky1(new int[] { 1, 1, 1 }));
            Console.ReadLine();
        }

        /*We'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1. 
        Return true if the given array contains an unlucky 1 in the first 2 or last 2 positions in the array.*/

        public static bool Unlucky1(int[] numbers)
        {
            if (numbers[0].Equals(1) && numbers[1].Equals(3) ||
                numbers[numbers.Length - 2].Equals(1) &&
                numbers[numbers.Length - 1].Equals(3))
                return true;

            return numbers[1].Equals(1) && numbers[2].Equals(3);
        }
    }
}



        //public static bool Unlucky1(int[] numbers)
        //{
        //    for (var i = 0; i < numbers.Length - 1; i++)
        //    {
        //        if (numbers[i].Equals(1) && numbers[i + 1].Equals(3))
        //            return true;
        //    }
        //    return false;
        //}
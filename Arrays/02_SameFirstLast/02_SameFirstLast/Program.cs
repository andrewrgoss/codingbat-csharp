using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SameFirstLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and fill a single dimensional array with integers
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 19;
            //numbers[3] = 1;

            SameFirstLast(numbers);
            Console.ReadLine();
        }

        public static bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length >= 1 && (numbers[0] == numbers[numbers.Length-1]))
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Array value [{0}] = {1}", i, numbers[i]);
                    Console.WriteLine("Array length = {0}", numbers.Length);
                }

                Console.WriteLine("Validated as TRUE. Array length has a length of 1 or more, and the first and last element are equal.");
                return true;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Array value [{0}] = {1}", i, numbers[i]);
                    Console.WriteLine("Array length = {0}", numbers.Length);
                }
                Console.WriteLine("Validated as FALSE. Array length must have a length of 1 or more, and the first and last element must be equal.");
                return false;
            }
        }
    }
}

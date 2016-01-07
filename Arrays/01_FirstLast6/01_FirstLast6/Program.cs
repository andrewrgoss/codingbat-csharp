using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FirstLast6
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and fill a single dimensional array with 3 integers
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 6;

            firstLast6(numbers);
            Console.ReadLine();
        }

        public static bool firstLast6(int[] numbers)
        {
            if ((numbers[0] == 6 || numbers[numbers.Length - 1] == 6)) //check to see if the first element contains a 6, or if the last element contains a 6. Since arrays start at a position of 0, subtracting 1 from the length of the array.
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Array value [{0}] = {1}", i, numbers[i]);
                }

                Console.WriteLine("Validated as TRUE");
                return true;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Array value [{0}] = {1}", i, numbers[i]);
                }
                Console.WriteLine("Validated as FALSE");
                return false;
            }
        }
    }
}

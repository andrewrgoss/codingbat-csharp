using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_KeepLast
{
    class Program
    {
        static void Main(string[] args)
        {
            KeepLast(new[] { 4, 5, 6 });
            KeepLast(new[] { 1, 2 });
            KeepLast(new[] { 3 });
            Console.ReadLine();
        }
        
        /*Given an int array, return a new array with double the length where its last element is the same as the original array, and all the other elements are 0. The original array will be length 1 or more. Note: by default, a new int array contains all 0's. */
        public static int[] KeepLast(int[] numbers)
        {
            var arr = new int[numbers.Length * 2];
            arr[arr.Length - 1] = numbers[numbers.Length - 1];

            Console.Write("\nArray= ");
            // Print new array values
            for (int i = 0; i < arr.Length; i++)
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(arr[i] + ",");
                }

            return arr;
        }
    }
}

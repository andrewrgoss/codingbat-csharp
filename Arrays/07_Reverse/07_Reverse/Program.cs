using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {1,2,3};
            ReverseClass ReturnReverse = new ReverseClass();
            ReturnReverse.Reverse(myArray);
            Console.ReadLine();
        }
    }

    class ReverseClass
    {
        public int[] Reverse(int[] numbers)
        {
            Array.Reverse(numbers);
            Console.Write("Reversed array: ");

            //print array values
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ",");
            }
            return numbers;
        }
    }
}

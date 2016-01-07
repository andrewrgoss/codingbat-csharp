using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_HigherWins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 11, 3 };
            HigherWinsClass findHighestNum = new HigherWinsClass();
            findHighestNum.HigherWins(myArray);
            Console.ReadLine();
        }
    }

    class HigherWinsClass
    {
        public int[] HigherWins(int[] numbers)
        {
            int highNum = numbers.Max();

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = highNum;

            Console.Write("Highest array value: ");
            // Print modified array elements that contain the highest value in each
            for (int i = 0; i < numbers.Length; i++)
                if (i == numbers.Length-1)
                {
                    Console.Write(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + ",");
                }
            return numbers;
        }
    }
}

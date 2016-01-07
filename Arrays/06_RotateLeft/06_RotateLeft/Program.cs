using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RotateLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] RotateLeftArray = { 5, 11, 9};
            ArrayElements rotate = new ArrayElements();
            rotate.RotateLeft(RotateLeftArray);
            Console.ReadLine();
        }
    }

    class ArrayElements
    {
        public int[] RotateLeft(int[] numbers)
        {
            int first = 0;
            first = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
                numbers[i - 1] = numbers[i];
                
            numbers[numbers.Length - 1] = first;
            Console.Write("Rotated left: ");

            //print out each value of the array
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + ",");

            return numbers;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Fix23
{
    class Program
    {
        static void Main(string[] args)
        {
            Fix23(new int[] { 1, 2, 3 });
            Fix23(new int[] { 2, 3, 5 });
            Fix23(new int[] { 1, 2, 1 });
            Console.ReadLine();
        }

        /*Given an int array length 3, if there is a 2 in the array immediately followed by a 3, set the 3 element to 0. Return the changed array.*/

        public static int[] Fix23(int[] numbers)
        {
            if (numbers.Contains(2))
                Console.Write("\nArray= ");
                for (var i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i].Equals(2) && numbers[i + 1].Equals(3))
                        if (numbers[i+1] == 3)
                            numbers[i+1] = 0;
                }
                foreach (var item in numbers)
                {
                    Console.Write(item.ToString() + ",");
                }
                return numbers;
        }
    }
}

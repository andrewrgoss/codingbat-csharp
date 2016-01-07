using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and fill a single dimensional array with integers
            int[] array = new int[3];
            array[0] = 5;
            array[1] = 11;
            array[2] = 2;

            Calculator compute = new Calculator();
            compute.Sum(array);
            Console.ReadLine();
        }
    }
    class Calculator
    {
        public int Sum(int[] nums)
        {
            int computeResults = nums.Sum();
            //computeResults = nums[0] + nums[1] + nums[2];
            Console.WriteLine("The sum is: {0}", computeResults);
            return (computeResults);
        }
    }
}

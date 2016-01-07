using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HasEven
{
    /*Solution from https://github.com/bahagiga/CodingBat*/
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasEven(new[] { 2, 5 }));
            Console.WriteLine(HasEven(new[] { 4, 3 }));
            Console.WriteLine(HasEven(new[] { 7, 5 }));
            Console.ReadLine();
        }

        /* Given an int array , return true if it contains an even number (HINT: Use Mod (%)). */
        public static bool HasEven(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0) return true;
            }
            return false;
        }
    }
}

/*MY ATTEMPT*/

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _10_HasEven
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] HasEvenArray = { 2, 5 };
//            HasEvenClass checkForEvenNum = new HasEvenClass();
//            checkForEvenNum.HasEven(HasEvenArray);
//            Console.ReadLine();
//        }
//    }

//    class HasEvenClass
//    {
//        public bool HasEven(int[] numbers)
//        {
//            int odds = 0;
//            int evens = 0;

//            foreach (int i in numbers)
//            {
//                if (i % 2 == 0)
//                    evens++;
//                else
//                    odds++;
//            }
//            if (evens > 1)
//            {
//                Console.WriteLine("There are {0} even numbers", evens);
//                return true;
//            }
//            else if (evens > 0 && evens < 2)
//            {
//                Console.WriteLine("There is {0} even number", evens);
//                return true;
//            }
//            else
//            {
//                Console.WriteLine("There are {0} odd numbers", odds);
//                return false;
//            }
//        }
//    }
//}
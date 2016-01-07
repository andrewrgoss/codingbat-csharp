using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakePi
{
    class Program  
    {     
        static void Main(string[] args)
        {
            GetUserInput();
            Console.ReadLine();
        }

        static int GetUserInput()
        {
            bool valid = false;
            int number = 0;

            while (!valid)
            {
                Console.Write("Enter the number of digits of pi you would like displayed: ");
                if (int.TryParse(Console.ReadLine(), out number)) //if whatever is entered as a string can be converted to an integer, it will put it in as a number and pass it out. This method will return a boolean and populate a value for us
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("That is not an integer!");
                }
            }
            MakePi(number);
            return number;
        }

        public static int[] MakePi(int n)
        {
            double pi = Math.PI; //3.1415926535897931
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = (int)Math.Floor(pi);
                pi -= result[i];
                pi *= 10;
                Console.Write("{0}", result[i]);
            }
            return result;
        }
    }
}

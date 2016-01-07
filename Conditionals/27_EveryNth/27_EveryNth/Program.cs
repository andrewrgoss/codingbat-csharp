using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_EveryNth
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine(EveryNth("Miracle", 2)); // -> "Mrce"
            Console.WriteLine(EveryNth("abcdefg", 2)); // -> "aceg"
            Console.WriteLine(EveryNth("abcdefg", 3)); // -> "adg"
            Console.WriteLine(EveryNth("", 3));
            Console.ReadLine();
        }

        /*Given a non-empty string and an int N, return the string made starting with char 0, and then every Nth char of the string. So if N is 3, use char 0, 3, 6, ... and so on. N is 1 or more.*/

        public static string EveryNth(string str, int n)
        {
            string result = "";

            for (int i = 0; i < str.Length; i += n)
            {
                result += str[i]; // += is the addition operator. https://msdn.microsoft.com/en-us/library/sa7629ew(v=vs.120).aspx 

            }
            return result;
            
            //Initial attempt:
            
            //if (str != "" && n >= 1)
            //{
            //    for (int i = 0; str.Length > i; i++)
            //    {
            //        if (i == n)
            //        {
            //            finalString = finalString + Convert.ToString(str[i]);
            //        }
            //    }
            //    return Convert.ToString(str[0]) + finalString;    
            //}
            //return "Invalid entry!";       
        }
    }
}

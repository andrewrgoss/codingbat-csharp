using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_RemoveDel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDel("adelbc"));
            Console.WriteLine(RemoveDel("adelHello"));
            Console.WriteLine(RemoveDel("adedbc"));
            Console.ReadLine();
        }

        /*Given a string, if the string "del" appears starting at index 1, return a string where that "del" has been deleted. Otherwise, return the string unchanged.*/

        public static string RemoveDel(string str)
        {
            return str.Replace("del", null);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02__CanHazTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanHazTable(5, 10)); // → 2
            Console.WriteLine(CanHazTable(5, 2)); // → 0
            Console.WriteLine(CanHazTable(5, 5)); // → 1
            Console.ReadLine();
        }

        /*You and your date are trying to get a table at a restaurant. The parameter "you" is the stylishness of your clothes, in the range 0..10, and "date" is the stylishness of your date's clothes. The result getting the table is encoded as an int value with 0=no, 1=maybe, 2=yes. If either of you is very stylish, 8 or more, then the result is 2 (yes). With the exception that if either of you has style of 2 or less, then the result is 0 (no). Otherwise the result is 1 (maybe).*/

        public static int CanHazTable(int yourStyle, int dateStyle)
        {
            return (yourStyle <= 2 || dateStyle <= 2) ? 0 : (yourStyle >= 8 || dateStyle >= 8) ? 2 : 1;
            
            //if (yourStyle >= 8 && yourStyle > 2 || dateStyle >= 8 && dateStyle > 2)
            //    return 2;
            //else if (yourStyle <= 2 || dateStyle <= 2)
            //    return 0;
            //else
            //    return 1;
        }
    }
}

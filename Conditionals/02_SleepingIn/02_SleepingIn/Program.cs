using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SleepingIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanSleepIn(false, false));
            Console.WriteLine(CanSleepIn(true, false));
            Console.WriteLine(CanSleepIn(false, true));
            Console.WriteLine(CanSleepIn(true, true));
            Console.ReadLine();
        }

        /*The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on vacation. We sleep in if it is not a weekday or we're on vacation. Return true if we sleep in.*/

        public static bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (!isWeekday || isVacation)
                return true;

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12__AnswerCell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AnswerCell(false, false, false)); // → true
            Console.WriteLine(AnswerCell(false, false, true)); // → false
            Console.WriteLine(AnswerCell(true, false, false)); // → false
            Console.ReadLine();
        }

        /*Your cell phone rings. Return true if you should answer it. Normally you answer, except in the morning you only answer if it is your mom calling. In all cases, if you are asleep, you do not answer.*/

        public static bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep)
                return false;
            if (isMorning && !isMom)
                return false;
            return true;
        }
    }
}

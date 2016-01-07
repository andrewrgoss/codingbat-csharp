using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and fill a single dimensional array with integers
            int[] a = new int[3];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;

            //create and fill a single dimensional array with integers
            int[] b = new int[3];
            b[0] = 7;
            b[1] = 3;
            b[2] = 2;

            CommonEnd run = new CommonEnd();
            run.commonEnd(a, b);
            Console.ReadLine();
        }

        class CommonEnd
        {
            public bool commonEnd(int[] a, int[] b)
            {
                if (a.Length >=1 && b.Length >=1 && (a[0] == b[0] || a[a.Length-1] == b[b.Length-1]))
                {
                    Console.WriteLine("Validated as TRUE");
                    return true;
                }
                else
                {
                    Console.WriteLine("Validated as FALSE");
                    return false;
                }
            }      
        }
    }
}

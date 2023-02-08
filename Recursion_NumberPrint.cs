using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPrint_Recursion
{
    internal class Recursion_NumberPrint
    {
        static void Main(string[] args)
        {
            int sn, en;

            Console.WriteLine("Please Start Number");
            sn = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please End Number");
            en = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("------------------------------");

            PrintNumberRecursion(sn, en);

            Console.ReadKey();
        }

        static void PrintNumberRecursion(int sn, int en)
        {
            if(sn == en + 1)
            {
                return;
            }

            Console.WriteLine(sn);

            PrintNumberRecursion(sn + 1, en);
        }
    }
}

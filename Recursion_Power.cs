using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Power
{
    internal class Recursion_Power
    {
        static void Main(string[] args)
        {
            int a, b, c = 1, i = 1;

            Console.WriteLine("Enter First Number");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt16(Console.ReadLine());

            PrintPower(a, b, c, i);

            Console.ReadKey();
        }

        static void PrintPower(int a, int b, int c, int i)
        {
            if (i == b + 1)
            {
                Console.WriteLine(a + "^" + b + "= " + c);
                return;
            }

            c = c * a;

            PrintPower(a, b, c, i + 1);
        }
    }
}

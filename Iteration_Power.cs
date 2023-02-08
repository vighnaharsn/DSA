using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Iteration
{
    internal class Iteration_Power
    {
        static void Main(string[] args)
        {
            int a, b, c = 1, i;

            Console.WriteLine("Please Enter First Number = ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number = ");
            b = Convert.ToInt16(Console.ReadLine());

            for( i = 1; i <= b; i++)
            {
                c = c * a;
            }

            Console.WriteLine(a + "^" + b + "= " + c);
            Console.ReadKey();
        }
    }
}

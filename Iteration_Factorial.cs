using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Iteration
{
    internal class Iteration_Factorial
    {
        static void Main(string[] args)
        {
            int a, b, c = 1, i;
            Console.WriteLine("Please Enter Number = ");

            a = Convert.ToInt32(Console.ReadLine());

            b = a;

            for(i = 0; i < a; i++)
            {
                c = c * (b - i);              
            }

            Console.WriteLine("Factorial of " + a + " = " + c);
            Console.ReadKey();
        }
    }
}

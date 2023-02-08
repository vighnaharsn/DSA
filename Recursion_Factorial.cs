using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Factorial
{
    internal class Recursion_Factorial
    {
        static void Main(string[] args)
        {
            int a,i = 0, c = 1;

            Console.WriteLine("Please Enter Number");

            a = Convert.ToInt16(Console.ReadLine());

            PrintFactorial(a,i,c);

            Console.ReadKey();

        }
        static void PrintFactorial(int a, int i, int c)
        {
            int b;

            b = a;            

            if(i == a )
            {
                Console.WriteLine("Factorial of " + a + " = " + c);
                return;
            }

            c = c * (b - i);

            PrintFactorial(a, i + 1, c);
        }
    }
}

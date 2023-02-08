using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Iteration
{
    internal class Iteration_Prime
    {
        static void Main(string[] args)
        {
            int n, i, med = 0, flg = 0;

            Console.WriteLine("Please Enter Number");
            n = Convert.ToInt16(Console.ReadLine());

            med = n / 2;

            for (i = 2; i <= med; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(n + " is not prime number");
                    flg = 1;
                    break;
                }
            }

            if (flg == 0)
            {
                Console.WriteLine(n + " is prime number");
            }

            Console.ReadKey();


            //////int a, b, i, j, med = 0, flg;

            //////Console.WriteLine("Please Enter First Number");
            //////a = Convert.ToInt16(Console.ReadLine());

            //////Console.WriteLine("Please Enter Second Number");
            //////b = Convert.ToInt16(Console.ReadLine());

            //////for (j = a; j <= b; j++)
            //////{
            //////    flg = 0;
            //////    med = j / 2;

            //////    for (i = 2; i <= med; i++)
            //////    {
            //////        if (j % i == 0)
            //////        {
            //////            flg = 1;
            //////            break;
            //////        }                    
            //////    }
            //////    if(flg == 0)
            //////    {
            //////        Console.WriteLine(j);
            //////    }
            //////}
            //////Console.ReadKey();
        }
    }
}

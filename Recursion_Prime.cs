using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Prime
{
    internal class Recursion_Prime
    {
        static void Main(string[] args)
        {
            int inp, flg = 0, i = 2;

            Console.WriteLine("Please Enter Number");
            inp = Convert.ToInt16(Console.ReadLine());            

            Console.WriteLine("-----------------------------");          

            PrintPrime(inp, flg, i);
            
            Console.ReadKey();
        }
        static void PrintPrime(int inp, int flg, int i)
        {
            int med = inp / 2;

            if(i > med)
            {
                if(flg == 0)
                {
                    Console.WriteLine(inp + " Is Prime Number");
                    return;
                }
                else
                {
                    Console.WriteLine(inp + " Is Not Prime Number");
                    return;
                }
            }

            if(i <= med)
            {
                if (inp % i == 0)
                {
                    flg = 1;
                }
            }
            if(flg == 1)
            {
                i = med + 1;
                PrintPrime(inp, flg, i);
            }
            if(i <= med)
            {
                PrintPrime(inp, flg, i + 1);
            }            
        }
    }
}

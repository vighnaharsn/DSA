using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Fibonacci
{
    internal class Recursion_Fibonacci
    {
        static void Main(string[] args)
        {
            int inp, fn = 0, sn = 1, tn = 0, i = 2;

            Console.Write("Enter Number = ");
            inp = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(fn + "\n" + sn);

            PrintFibonacci(inp,fn,sn,tn,i);

            Console.ReadKey();
        }

        static void PrintFibonacci(int inp, int fn, int sn, int tn, int i)
        {           
            if(i == inp + 1)
            {                
                return;
            }

            tn = fn + sn;

            Console.WriteLine(tn);

            fn = sn;
            sn = tn;

            PrintFibonacci(inp, fn, sn, tn, i + 1);
        }
    }
}

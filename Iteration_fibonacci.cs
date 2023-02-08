using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inp, fn = 0, sn = 1, tn = 0, i;

            Console.WriteLine("Please Enter NUmber");
            inp = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(fn +"\n"+sn);

            for(i = 2; i <= inp; i++)
            {
                tn = fn + sn;

                Console.WriteLine(tn);

                fn = sn;
                sn = tn;                
            }

            Console.ReadKey();
        }
    }
}

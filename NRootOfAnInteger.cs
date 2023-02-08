using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRootOfAnInteger
{
    internal class NRootOfAnInteger
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter First Number = ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter Second Number = ");
            double m = Convert.ToDouble(Console.ReadLine());

            double rsl = NrootInt(n,m);

            Console.Write("The " + n + " root of " + m + " is = " + rsl);

            Console.ReadKey();
        }
        static double NrootInt(double n, double m)
        {
            double l = 1;
            double h = m; 
            double eps = 1e-6;

            while((h - l) > eps)
            {
                double mid = (l + h) / 2.0;

                if(Multiplication(mid, n) < m)
                {
                    l = mid;
                }
                else
                {
                    h = mid;
                }
            }

            return l;
        }
        static double Multiplication(double ml, double n)
        {
            double rsl = 1.0;

            for(int i = 0; i <= n; i++)
            {
                rsl = rsl * ml;
            }

            return rsl;
        }
    }
}

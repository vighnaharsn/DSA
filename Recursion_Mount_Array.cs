using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Moun_Array
{
    class Recursion_Mount_Array
    {
        static void Main(string[] args)
        {
            int[] num = { 20, 40, 60, 80, 100,70, 50, 30, 10 };

            int l = 0, h = num.Length - 1, m = 0;

            int rslt = MountArray(num, l, h, m);

            Console.WriteLine(rslt);

            Console.ReadKey();
        }
        static int MountArray(int[] num, int l, int h, int m)
        {
            if(l <= h)
            {
                m = (l + h) / 2;

                if(num[m] > num[m - 1] && num[m] > num[m + 1])
                {
                    return m;
                }
                if(num[m] < num[m - 1])
                {
                    return MountArray(num, l , h - 1, m);
                }
                else
                {
                    return MountArray(num, l + 1, h, m);
                }
            }
            return -1;
        }
    }
}

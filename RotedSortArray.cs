using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotedSortArray
{
    internal class RotedSortArray
    {
        static void Main(string[] args)
        {
            int[] num = { 7, 8, 9, 10, 1, 2, 3, 4, 5 };
            int l = 0, h = num.Length - 1;

            Console.Write("Please Enter Number = ");

            int n = Convert.ToInt32(Console.ReadLine());

            int rsl = RotdSorArr(num, l, h, n);

            if(rsl == -1)
            {
                Console.Write("Number is not Present");
            }
            else
            {
                Console.Write("Number " + n + " is present at Index " + rsl);
            }

            Console.ReadKey();
        }
        static int RotdSorArr(int[] num, int l, int h, int n)
        {
            while(l <= h)
            {
                int m = l + (h - l) / 2;

                if (num[m] == n)
                {
                    return m;
                }

                if (num[l] <= num[m]) /* left side is sorted*/
                {
                    if (num[l] <= n && n <= num[m])
                    {
                        h = m - 1;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
                else /* right side is sorted*/
                {
                    if (num[m] < n && n <= num[h])
                    {
                        l = m + 1;
                    }
                    else
                    {
                        h = m - 1;
                    }
                }
            }
            return -1;
        }
    }
}

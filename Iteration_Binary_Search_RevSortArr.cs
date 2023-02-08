using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Binary_Search_RevSortArr
{
    internal class Iteration_Binary_Search_RevSortArr
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int l = 0, h = num.Length - 1, m = 0;

            Console.WriteLine("Please Enter Number");

            int n = Convert.ToInt16(Console.ReadLine());

            int rlt = Binary_Search_RevSortArr(num, n, l , h, m);

            if(rlt == 1)
            {
                Console.WriteLine(n + " Is Present");
            }
            else
            {
                Console.WriteLine(n + " Is Not Present");
            }

            Console.ReadKey();
        }

        static int Binary_Search_RevSortArr(int[] num, int n, int l, int h, int m)
        {
            while(l <= h)
            {
                m = (l + h) / 2;

                if (num[m] == n)
                {
                    return 1;
                }
                if (num[m] < n)
                {
                    h = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            return -1;
        }
    }
}

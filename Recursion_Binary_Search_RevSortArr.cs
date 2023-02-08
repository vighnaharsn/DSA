using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Binary_Search_RevSortArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int n, l = 0, h = num.Length - 1;

            Console.WriteLine("Enter the Number");
            n = Convert.ToInt16(Console.ReadLine());

            int res = BinarySearchRevSortArr(num,n,l,h);

            if(res == 1)
            {
                Console.WriteLine(n + " Is Present");
            }
            else
            {
                Console.WriteLine(n + " Is Not Present");
            }

            Console.ReadKey();
        }


        static int BinarySearchRevSortArr(int[] num, int n, int l, int h)
        {
            if( l <= h)
            {
                int m = (l + h) / 2;

                if (num[m] == n)
                {
                    return 1;
                }

                if (num[m] < n)
                {
                    return BinarySearchRevSortArr(num, n, l, m - 1);
                }
                else
                {
                    return BinarySearchRevSortArr(num, n, m + 1, h);
                }
            }
            return -1;
        }
    }
}

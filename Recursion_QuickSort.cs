using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_QuickSort
{
    internal class Recursion_QuickSort
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 7, 8, 9, 1, 5, 0 };
            int l = 0, h = num.Length - 1;
            QuickSort(num, l, h);

            foreach(int n in num)
            {
                Console.Write(" " + n);
            }

            Console.ReadKey();
        }
        static void QuickSort(int[] num, int l, int h)
        {
            if(l < h)
            {
                int p = Partition(num, l, h); /* Getting the Pivot element. pivot element lies at correct position */
                QuickSort(num, l, p - 1);
                QuickSort(num, p + 1, h);
            }
        }
        static int Partition(int[] num, int l, int h)
        {
            int p = num[h]; /* keeping pivot as h element */
            int i = l;

            for (int j = l; j < h; j++)
            {
                if (num[j] < p)
                {
                    QuickSwap(num, i, j);
                    i++;
                }
            }
            QuickSwap(num, i, h);
            return (i);
        }
        static void QuickSwap(int[] num, int i, int j) /* Swapping i and j */
        {
            int temp = num[i];
            num[i]   = num[j];
            num[j]   = temp;
        }
    }
}

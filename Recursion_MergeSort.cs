using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_MergeSort
{
    internal class Recursion_MergeSort
    {
        public static void Main(string[] args)
        {
            int[] num = { 5, 9, 3, 7, 1, 4, 6, 8, 2 };
            int[] aux = new int[num.Length];           

            MergeSort(num, aux, 0, num.Length - 1);

            foreach (int a in num)
            {
                Console.Write(" " + a);
            }

            Console.ReadKey();
        }
        public static void MergeSort(int[] num, int[] aux, int l, int h)
        {
            if (l == h)
            {
                return;
            }

            int m = l + (h - l) / 2;

            MergeSort(num, aux, l, m); /* sorting left array */
            MergeSort(num, aux, m + 1, h); /* sorting right array */

            Merge(num, aux, l, m, h);
        }
        public static void Merge(int[] num, int[] aux, int l, int m, int h)
        {
            int i = l, j = m + 1, k = l;

            while (i <= m && j <= h)
            {
                if (num[i] <= num[j])
                {
                    aux[k] = num[i];
                    i++;
                }
                else
                {
                    aux[k] = num[j];
                    j++;
                }
                k++;
            }
            while (i <= m)
            {
                aux[k] = num[i];
                i++;
                k++;
            }
            while (j <= h)
            {
                aux[k] = num[j];
                j++;
                k++;
            }
            for (i = l; i <= h; i++)
            {
                num[i] = aux[i];
            }
        }        
    }
}

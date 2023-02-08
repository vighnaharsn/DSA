using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_SmallElemFind
{
    internal class K_SmallElemFind
    {
        static void Main(string[] args)
        {
            int[] ar1 = { 2, 3, 6, 7, 9 };
            int[] ar2 = { 1, 4, 8, 10 };

            /* 1,2,3,4,6,7,8,9,10 */

            int ar1L = ar1.Length;
            int ar2L = ar2.Length;

            int t = 5;

            int rsl = K_SmlEleFind(ar1, ar2, ar1L, ar2L, t);

            Console.Write("The Smallest K th No is = " + rsl);

            Console.ReadKey();
        }
        static int K_SmlEleFind(int[] ar1, int[] ar2, int ar1L, int ar2L, int t)
        {
            int i = 0, j = 0, k = 0;

            // Keep taking smaller of the current
            // elements of two sorted arrays and
            // keep incrementing k
            // use K to compare position not index. 

            while (i < ar1L && j < ar2L)
            {
                if (ar1[i] < ar2[j])
                {
                    k++;
                    if (k == t)

                    return ar1[i];
                    i++;
                }
                else
                {
                    k++;
                    if (k == t)
                    return ar2[j];
                    j++;
                }                                                                              
            }
            return -1;
        }
    }
}

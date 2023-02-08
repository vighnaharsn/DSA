using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SingleElementSortArray
{
    internal class SingleElementSortArray
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 2, 3, 3, 5, 5, 6, 6 };

            int l = 0, h = num.Length - 1;

            SglEleSrtArr(num, l, h);            
        }


        // A Binary Search based
        // method to find the element
        // that appears only once
        static void SglEleSrtArr(int[] num, int l, int h)
        {
            if (l > h)
            {
                return;
            }
            if (l == h)
            {
                Console.Write("Sigle Element is = " + num[l]);
                Console.ReadKey();
                return;
            }

            // Find the mdle point
            int m = (l + h) / 2;

            // If m is even and element
            // next to m is same as m
            // then output element lies on
            // right side, else on left side

            if (m % 2 == 0) /* right side */
            {
                if (num[m] == num[m + 1])
                {
                    SglEleSrtArr(num, m + 2, h);
                }
                else
                {
                    SglEleSrtArr(num, l, m);
                }
            }
            else
            if (m % 2 == 1) /* left side */
            {
                if (num[m] == num[m - 1])
                {
                    SglEleSrtArr(num, m + 1, h);
                }
                else
                {
                    SglEleSrtArr(num, l, m - 1);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MedianTwoSortArray
{
    internal class MedianTwoSortArray
    {
        static void Main(string[] args)
        {
            int[] ar1 = { 1, 4, 7, 10, 12 };
            int[] ar2 = { 2, 3, 6, 15, 20, 24, 30 };

            int ar1_l = ar1.Length;
            int ar2_l = ar2.Length;

            double rsl = Median(ar1, ar2, ar1_l, ar2_l);

            Console.Write("Median of Two Sorted Aarry is = " + rsl);

            Console.ReadKey();
        }
        static double Median(int[] ar1, int[] ar2, int ar1_l, int ar2_l)
        {
            if(ar1_l > ar2_l)
            {
                return Median(ar2, ar1, ar2_l, ar1_l);
            }

            int low = 0, high = ar1_l, medpos = ((ar1_l + ar2_l) + 1) / 2; /* +1 work for even as well as odd */

            while(low <= high)
            {
                int med1 = (low + high) >> 1 /* >> 1 OR  / 2 */;
                int med2 = medpos - med1;

                int l1 = (med1 == 0)     ? Int32.MinValue : ar1[med1 - 1];
                int l2 = (med2 == 0)     ? Int32.MinValue : ar2[med2 - 1];
                int r1 = (med1 == ar1_l) ? Int32.MaxValue : ar1[med1];
                int r2 = (med2 == ar2_l) ? Int32.MaxValue : ar2[med2];

                if(l1 <= r2 && l2 <= r1)
                {
                    if((ar1_l + ar2_l) % 2 != 0) /* for odd case */
                    {
                        return Math.Max(l1, l2);
                    }
                    else /* for even case */
                    {
                        return (Math.Max(l1, l2) + Math.Min(r1, r2)) / 2.0;
                    }
                }
                else
                if(l1 > r2)
                {
                    high = med1 - 1;
                }
                else
                {
                    low = med1 + 1;
                }
            }

            return 0.0;
        }
    }
}

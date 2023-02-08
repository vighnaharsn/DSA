using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumUsingTwoPointer
{
    internal class TwoSumUsingTwoPointer
    {
        static void Main(string[] args)
        {
            int[] num = { 5, 3, 7, 10, 15, 1, 2, 9 };
            int t = 25;

            Array.Sort(num);

            TwoSumTP(num, t);

            Console.ReadKey();
        }
        static void TwoSumTP(int[] num, int t)
        {
            int l = 0, h = num.Length - 1;

            while(l < h) /* can't use same element for twice that's why < */
            {
                if (num[l] + num[h] == t)
                {
                    Console.Write(l + " " + h);
                    return;
                }
                else
                if(num[l] + num[h] > t)
                {
                    h = h - 1;
                }
                else
                {
                    l = l + 1;
                }
            }
        }
    }
}

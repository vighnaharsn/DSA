using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_SortColor
{
    internal class Recursion_SortColor
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 0, 2, 1, 1, 0, 1, 1, 1, 2 };            

            int l = 0, h = num.Length - 1, i = l, j = i + 1;

            SortColor(num, l, h, i, j);

            foreach(int a in num)
            {
                Console.Write(" "+ a);
            }

            Console.ReadKey();
        }
        static void SortColor(int[] num, int l, int h, int i, int j)
        {
            if(l <= h && j <= h)
            {
                i = l;
                if (num[i] > num[j])
                {
                    Swap(num, i, j);
                    SortColor(num, l, h, i, j + 1);
                }                
            }
            if(j > h && l > h)
            {
                return;
            }
            SortColor(num, l + 1, h, i, l + 2);
        }
        static void Swap(int[] num, int i, int j)
        {
            int temp = num[i];
            num[i]   = num[j];
            num[j]   = temp;
        }
    }
}

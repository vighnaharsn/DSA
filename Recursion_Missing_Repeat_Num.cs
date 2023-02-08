using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Missing_Repeat_Num
{
    internal class Recursion_Missing_Repeat_Num
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 1, 3 };           

            int l = 0, h = num.Length - 1;

            int rsl  = Repeat_Num(num, l, h);
            int rsl1 = Missing_Num(num, l, h);            

            Console.Write(rsl + " " + rsl1);

            Console.ReadKey();
        }
        static int Repeat_Num(int[] num, int l, int h)
        {            
           for(int i = l; i <= h; i++)
           {
                for(int j = h; j <= h; j--)
                {
                    if (num[i] == num[j])
                    {
                        return num[i];
                    }
                }
            }
            return -1;
        }
        static int Missing_Num(int[] num, int l, int h)
        {
            int tot = (h + 1) * (h + 2) / 2;
            while(l < h)
            {
                tot -= num[l];
                l++;
            }

            return tot;            
        }
    }    
}

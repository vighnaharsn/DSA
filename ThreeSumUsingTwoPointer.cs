using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSumUsingTwoPointer
{
    internal class ThreeSumUsingTwoPointer
    {
        static void Main(string[] args)
        {
            ////int[] num = { 2, 0, -1, -2, -1, 0, -2, -1, 2, 0, 2 };
            int[] num = { 1, 4, 45, 6, 10, 8 };
            /* -2,-2,-1,-1,-1,0,0,0,2,2,2  sorted array*/
            int t = 13;
            Array.Sort(num);

            bool rsl = ThreeSumTP(num,t);

            if(!rsl)
            {
                Console.Write("-1");
            }

            Console.ReadKey();
        }
        static bool ThreeSumTP(int[] num, int t) /* most omptimise solution using Two Pointer for 3 Sum Problem */
        {            
            for(int i = 0; i <= num.Length - 1;i++)
            {
                int l = i + 1, h = num.Length - 1;

                while(l < h)
                {                   
                    if(num[l] + num[h] + num[i] == t)
                    {
                        Console.Write("[" + num[i] + " " + num[l] + " " + num[h] + "]");
                        return true;
                    }
                    else
                    if(num[l] + num[h] + num[i] < t)
                    {
                        l++;                        
                    }       
                    else
                    {
                        h--;
                    }
                }
            }
            return false;
        }
    }
}

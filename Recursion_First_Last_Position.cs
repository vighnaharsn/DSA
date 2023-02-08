using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_First_Last_Position
{
    internal class Recursion_First_Last_Position
    {
        static void Main(string[] args)
        {
            int[] num = { 5, 7, 7, 8, 8, 10 };

            int l = 0, h = num.Length - 1;             
            
            Console.WriteLine("Please Enter Number");

            int n = Convert.ToInt16(Console.ReadLine());

            int rlt  = FirstPosition(num, n ,l, h);
            int rlt1 = LastPosition(num, n, l, h);

            Console.WriteLine(rlt +","+ rlt1);            

            Console.ReadKey();
        }

        static int FirstPosition(int[] num, int n, int l, int h)
        {           
            while(l <= h)
            {                
                if (num[l] == n)
                {
                    return l;
                }
                if (num[l] < n)
                {
                    return FirstPosition(num, n, l + 1, h);
                }
                else
                {
                    return FirstPosition(num, n, l, h - 1);
                }                
            }
            return -1;
        }

        static int LastPosition(int[] num, int n, int l, int h)
        {
            while (h >= l)
            {                
                if (num[h] == n)
                {
                    return h;
                }
                if (num[h] < n)
                {
                    return LastPosition(num, n, l + 1, h);
                }
                else
                {
                    return LastPosition(num, n, l , h - 1);
                }
            }
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Binary_Search
{
    internal class Recursion_Binary_Search
    {
        static void Main(string[] args)
        {
            Recursion_Binary_Search rbs = new Recursion_Binary_Search();

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int n, l = 0, h = num.Length - 1;            

            Console.WriteLine("Please Enter Number");

            n = Convert.ToInt16(Console.ReadLine());

            int res = rbs.BinarySearch(num, n, l, h);

            if(res == -1)
            {                
                Console.WriteLine(n + " Is  Not Present");
            }
            else
            {
                Console.WriteLine(n + " Is Present");
            }

            Console.ReadKey();
        }

        int BinarySearch(int[] num, int n, int l, int h)
        {           
            if(l <= h)
            {
                int m = (l + h) / 2;

                if (num[m] == n)
                {
                   return 1;                   
                }
                if (num[m] < n)
                {                    
                    return BinarySearch(num, n, m + 1, h);
                }
                else
                {                  
                    return BinarySearch(num, n, l, m - 1);
                }
            }
            return -1;
        }
    }
}

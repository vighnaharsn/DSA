using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Binary_Search
{
    internal class Iteration_Binary_Search
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int n;
           
            Console.WriteLine("Please Enter Number");
            n = Convert.ToInt16(Console.ReadLine());

           int rel = BinarySearch(num, n);

            if(rel == 1)
            {
                Console.WriteLine(n + " Is Present");
            }
            else
            {
                Console.WriteLine(n + " Is Not Present");
            }

            Console.ReadKey();
        }

        public static int BinarySearch(int[] num, int n)
        {
            int l = 0, h = num.Length - 1, m = 0;

            while (l <= h)
            {
                m = (l + h) / 2;

                if (num[m] == n)
                {
                    return 1;
                }
                if (num[m] < n) /* If n is smaller then ignore right side */
                {
                    l = m + 1;
                }
                else /* If n is greater then ignore left side */
                {
                    h = m - 1;
                }
            }
            return -1;
        }
    }
}

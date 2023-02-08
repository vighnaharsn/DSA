using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootSquareFind
{
    internal class RootSquareFind
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number = ");
            int inp = Convert.ToInt32(Console.ReadLine());

            int rst = RootSquare(inp);

            Console.WriteLine("Square Root of "+ inp + " is = " + rst);

            Console.ReadKey();
        }
        static int RootSquare(int inp)
        {
            int str = 0, end = inp, ans = 0;           

            while (str <= end)
            {
                int m = (str + end) / 2;

                if (m * m == inp)
                {
                    return m;
                }
                if(m * m > inp)
                {
                    end = m - 1;                    
                }
                else
                {
                    ans = m;     /* we want to take ler bound */
                    str = m + 1;                    
                }
            }                       
            return ans;
        }
    }
}

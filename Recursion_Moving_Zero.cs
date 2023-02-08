using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Moving_Zero
{
    class Recursion_Moving_Zero
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 0, 3, 12, 0, 1 };

            int i = 0, z = 0;

            MovingZero(num, i, z);

            foreach(int a in num)
            {
                Console.Write(" " + a);
            }

            Console.ReadKey();
        }

        static void MovingZero(int[]num, int i, int z)
        {
            if(i <= num.Length - 1)
            {
                if(num[i] != 0)
                {
                    Swap(num, i, z);
                    z++;
                }
                MovingZero(num, i + 1, z);
            }
        }
        static void Swap(int[] num, int i, int z)
        {
            int temp = num[i];
            num[i]   = num[z];
            num[z]   = temp;
        }
    }
}

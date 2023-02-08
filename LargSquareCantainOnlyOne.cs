using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargSquareCantainOnlyOne
{
    internal class LargSquareCantainOnlyOne
    {
        /*
         Logic : use auxilary array to store the maximum length of square side that we have at any index location.
                 (using extra space is a better apporoch than having extra time complexity in the algo that we suggest)
         */
        static void Main(string[] args)
        {            
            char[,] mtra = {
                             { '1', '0', '1', '0', '0' },
                             { '1', '0', '1', '1', '1' },
                             { '1', '1', '1', '1', '1' },
                             { '1', '0', '0', '1', '0' }

                             ////{ '0', '1', '1', '1', '0' },
                             ////{ '1', '1', '1', '1', '1' },
                             ////{ '0', '1', '1', '1', '0' },
                             ////{ '1', '0', '1', '0', '1' }
                           };

            int rsl = MaxSqrCantainOne(mtra);

            Console.Write(rsl);

            Console.ReadKey();
        }

        static int MaxSqrCantainOne(char[,] mtra)
        {            
            /* Base Condition */    
            if (mtra.Length == 0) return 0;

            int row = mtra.GetLength(0), col = mtra.GetLength(1), rsl = 0;

            int[,] mtrb =  new int[row + 1, col + 1];/* we taking one extra row and col and put 0 there */

            for(int i = 1; i <= row; i++)
            {
                for(int j = 1; j <= col; j++)
                {
                    if (mtra[i-1,j-1] == '1')
                    {
                        mtrb[i, j] = Math.Min(Math.Min(mtrb[i, j - 1], mtrb[i - 1, j - 1]), mtrb[i - 1, j]) + 1;

                        rsl = Math.Max(mtrb[i, j], rsl);
                    }
                }
            }

            return rsl * rsl;
        }
    }
}

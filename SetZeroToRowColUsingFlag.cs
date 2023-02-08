using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetZeroToRowColUsingFlag
{
    /*
        Logic : whenever of any index [row,col], we get 0 then simply mtrx[row,0] = 0 and mtrx[0,col] = 0 
        TC : o(mn)
     */
    internal class SetZeroToRowColUsingFlag
    {
        static void Main(string[] args)
        {
            int[,] mtrx = {
                            { 0,1,2,0 },
                            { 3,4,5,2 },                            
                            { 1,3,1,5 }
                          };

            int[,] rslt = SetZeroToRowCol(mtrx);

            for(int row = 0; row < mtrx.GetLength(0); row++)
            {
                for(int col = 0; col < mtrx.GetLength(1); col++)
                {
                    Console.Write(mtrx[row,col] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static int[,] SetZeroToRowCol(int[,] mtrx)
        {
            int row_no_0 = 0;
            int col_no_0 = 0;

            for(int row = 0; row < mtrx.GetLength(0); row++)
            {
                if (mtrx[row,0] == 0) /* checking mtrx[0,0] == 0 or not if 0 then set col_no_0 = 1 */
                {
                    col_no_0 = 1;
                }
                for(int col = 1; col < mtrx.GetLength(1); col++)
                {
                    if (mtrx[row,col] == 0)
                    {
                        mtrx[row, 0] = 0; /* making first row 0 */
                        mtrx[0, col] = 0; /* making first col 0 */
                    }
                }
            }

            for(int row = 1; row < mtrx.GetLength(0); row++) /* iterate through matrxi start from mtrx[1,1] */
            {
                for(int col = 1; col < mtrx.GetLength(1); col++)
                {
                    if (mtrx[row,0] == 0 || mtrx[0,col] == 0) /* flag or marker */
                    {
                        mtrx[row, col] = 0;
                    }
                }
            }

            if (mtrx[0,0] == 0) /* if matrix first row and col is  0 */
            {
                for(int col = 0; col < mtrx.GetLength(1); col++)
                {
                    mtrx[0, col] = 0; /* making first row 0 */
                }
            }

            if(col_no_0 == 1)
            {
                for(int col = 0; col < mtrx.GetLength(0); col++)
                {
                    mtrx[col, 0] = 0; /* making particular col is 0 */
                }
            }
            return mtrx;
        }
    }
}

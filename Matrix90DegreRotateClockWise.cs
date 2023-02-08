using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix90DegreRotateClockWise
{
    /*
     Logic : 1) First transpose the matrix (Transpose of matrix means convert row into col and col into row) as per  fisrt for loop.
             2) swap First col with Last col and Second col with Second Last col.
     */
    internal class Matrix90DegreRotateClockWise
    {
        static void Main(string[] args)
        {
            int[,] mtrx = {
                            { 5,1,9,11 },
                            { 2,4,8,10 },
                            { 13,3,6,7 },
                            { 15,14,12,16 }
                        };

            int[,] rslt = MtrxRotate90D(mtrx);

            for(int r = 0; r < rslt.GetLength(0); r++)
            {
                for(int c = 0; c < rslt.GetLength(1); c++)
                {
                    Console.Write(rslt[r, c] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static int[,] MtrxRotate90D(int[,] mtrx)
        {
            for(int r = 0; r < mtrx.GetLength(0); r++)
            {
                for(int c = r; c < mtrx.GetLength(1); c++)
                {
                    int temp   = mtrx[r,c];
                    mtrx[r, c] = mtrx[c, r];
                    mtrx[c,r]  = temp;
                }
            }

            for(int r = 0; r < mtrx.GetLength(0); r++) /* getting row length here for swap */
            {
                int left = 0, right = mtrx.GetLength(0) - 1; /* using Two Pointer Approch for Swap (left and right are pointer here) */

                while (left < right)
                {                    
                    Swap(mtrx,r,left,right);
                    left++;
                    right--;
                }
            }
            
            return mtrx;
        }
        static void Swap(int[,] mtrx, int r, int left, int right)
        {
            int temp      = mtrx[r,left];
            mtrx[r,left]  = mtrx[r, right]; 
            mtrx[r,right] = temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMinPathSumUsingDP
{
    /* Dynamic Programin approch for Matrix 
        TC o(mn) SC o(mn)
     */
    internal class FindingMinPathSumUsingDP
    {
        static void Main(string[] args)
        {
            int[,] mtrx = {
                            { 1,3,1 },
                            { 1,5,1 },                          
                            { 4,2,1 }
                          };

            int rslt = MinPathSum(mtrx);

            Console.Write(rslt);

            Console.ReadKey();
        }

        static int MinPathSum(int[,] mtrx)
        {
            int row = mtrx.GetLength(0);
            int col = mtrx.GetLength(1);

            int[,] dp = new int[row, col];

            dp[0, 0] = mtrx[0, 0]; /* putting value in DP array from given matrix of [0,0] index */

            for(int i = 1; i < row; i++) /* filling value in first row (right side from [0,0] index) */
            {
                dp[i, 0] = dp[i - 1, 0] + mtrx[0, i];
            }

            for (int i = 1; i < col; i++) /* filling value in first col (down side from [0,0] index) */
            {
                dp[0,i] = dp[0,i - 1] + mtrx[i,0];
            }

            for(int i = 1; i < row; i++)
            {
                for(int j = 1; j < col; j++)
                {
                    dp[i,j] = Math.Min(dp[i - 1, j], dp[i,j-1]) + mtrx[i,j]; /* taking min index value from DP array (checking digonal values) and add with mtrix index */
                }
            }

            return dp[row - 1,col - 1]; /* return last row and col index from dp array */
        }
    }
}

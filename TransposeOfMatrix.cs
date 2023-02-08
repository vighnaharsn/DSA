using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransposeOfMatrix
{
    internal class TransposeOfMatrix
    {
        /*
            Transpose of matrix means convert row into col and col into row.
            Logic : Swap Matrix[i,j] with Matrix[j,i] over the diagonal.
            TC = o(n2) SC = o(n)
         */
        static void Main(string[] args)
        {
            int[,] mtrx = { 
                            ////{   2,  4, -1 }, 
                            ////{ -10,  5, 11 }, 
                            ////{  18, -7,  6 }


                            { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 }
                          };        

            int[,] rslt = TransposMtrx(mtrx);

            int row = rslt.GetLength(0);
            int col = rslt.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for(int c = 0; c < col; c++)
                {
                    Console.Write(rslt[r,c] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static int[,] TransposMtrx(int[,] mtrx)
        {
            int len = mtrx.Length;

            for(int i = 0; i < mtrx.GetLength(0); i++)
            {
                for(int j = i; j < mtrx.GetLength(1); j++)
                {
                    int temp  = mtrx[i,j];
                    mtrx[i,j] = mtrx[j,i];
                    mtrx[j,i] = temp;
                }
            }
            return mtrx;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTargetNumFromMatrix
{
            /*
            Logic : 1) start from first row last col and then compare the element which needs to be search 't' with the matrix element.
                    2) if t == mtrx[i,j] {here in matrix i is row and j is col} return i,j
                    3) if( mtrx[i,j] > t) then move to previous col (j--) other wise move to next row (i++).
                    4) TC = o(max(m,n))
            */
    internal class FindTargetNumFromMatrix
    {
        static void Main(string[] args)
        {
            int[,] mat = { 
                            { 10, 20, 30, 40 }, 
                            { 15, 25, 35, 45 }, 
                            { 27, 29, 37, 48 }, 
                            { 32, 33, 39, 50 } 
                         };

            int t   = 33;
            int row = 4;
            int col = 4;

            FindNumMatrx(mat, row, col, t);

            Console.ReadKey();
        }
        static void FindNumMatrx(int[,] mat,int row, int col, int t)
        {
            /* Set index for Top Right from where we want to start (we started from Top Right becuase matrix is sorted in increasing order Row As well col therefore)*/
            int r = 0; int c = col - 1; 
             
            while(r < row && c >= 0) /* cheking Matrix Boundry */
            {
                if (mat[r, c] == t)
                {
                    Console.Write(t + " is found at " + r + " " + c);
                    return;
                }
                if (mat[r, c] > t) /*if Target is less then move to previous column*/
                {
                    c--;
                }
                else /*if Target is greater then move to next row */
                {
                    r++;
                }
            }
            Console.Write("Element Not Found");
            return;
        }
    }
}

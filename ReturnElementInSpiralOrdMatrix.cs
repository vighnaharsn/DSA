using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnElementInSpiralOrdMatrix
{
    /*
     Logic : 1) start from first row and first col and movie till the last col in the first row.
             2) once step one is completed move to the second row, after moving to the second row, iterate til end of row of the matrix in the last col.
             3) once step no. 2 is completed you need to move to the second last col, and print all the element which are present in the row and this continues.
             TC = o(m,n), SC = (mn)
     */
    internal class ReturnElementInSpiralOrdMatrix
    {
        static void Main(string[] args)
        {
            int[,] mtrx = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } }; /* Spiral Order Output = 1 2 3 4 8 12 11 10 9 5 6 7 */

            List<int> l = SpialOrdMtx(mtrx);

            foreach(int a in l)
            {
                Console.Write(" " +a);
            }

            Console.ReadKey();
        }

        static List<int> SpialOrdMtx(int[,] mtrx)
        {
            List<int> rslt = new List<int>();

            if (mtrx.GetLength(0) == 0 || mtrx.GetLength(1) == 0) /* Chekiing Matrix has Row or Column and return low or column */
            {
                return rslt;
            }
            int top    = 0;
            int bottom = mtrx.GetLength(0) - 1; /* Getting Row Lenght */
            int left   = 0;
            int right  = mtrx.GetLength(1) - 1; /* Getting Column Lenght */

            while (true)
            {
                for(int i = left; i <= right; i++) rslt.Add(mtrx[top, i]);
                top++;
              
                if(left > right || top > bottom) break;

                for (int i = top; i <= bottom; i++) rslt.Add(mtrx[i, right]);
                right--;
                
                if (left > right || top > bottom) break;

                for (int i = right; i >= left; i--) rslt.Add(mtrx[bottom, i]);
                bottom--;
                
                if (left > right || top > bottom) break;

                for (int i = bottom; i >= top; i--) rslt.Add(mtrx[i, top]);

                if (left > right || top > bottom) break;
            }
            return rslt;
        }
        
    }
}

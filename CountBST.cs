using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountBST
{
    internal class CountBST
    {
        static void Main(string[] args)
        {
            int[] num = { 20, 10, 30 };
            int len = num.Length;
            NoOfBST(num, len);

            Console.ReadKey();
        }
        static void NoOfBST(int[] num, int len)
        {
            int i, k;

            for(k = 0;k < len; k++)
            {
                int s = 0;

                // Count the number of element
                // less than current element
                // in arr[k]


                for (i = 0; i < len; i++)
                {
                    if (num[i] < num[k])
                    {
                        s += 1;
                    }
                }

                // Here s = number of node in left
                // BST and (n-s-1) = number of node
                // in right BST
                // Find number of BST using elements
                // in left BST

                int catalan_leftBST = catalan(s);

                // Find number of BST using elements
                // in right BST

                int catalan_rightBST = catalan(len - s - 1);

                // Find total number of BST
                int totBST = catalan_leftBST * catalan_rightBST;

                Console.Write(totBST + " ");                
            }            
        }
        static int fact(int n1)
        {
            int fact = 1;

            while(n1 > 1)
            {
                fact *= n1;
                n1   -= 1;
            }
            return fact;
        }

        // Find nth catalan number
        static int catalan(int n2)
        {
            return fact(2 * n2) / (fact(n2) * fact(n2 + 1));
        }
    }
}

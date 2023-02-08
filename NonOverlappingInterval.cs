using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonOverlappingInterval
{
    internal class NonOverlappingInterval
    {
        public class interval
        {
            public int begin;
            public int end;

            public interval(int begin, int end) 
            {
                this.begin = begin;
                this.end   = end;
            }
        }
        static void Main(string[] args)
        {
            int[][] arr = {new int[] { 1, 5 }, new int[] { 2, 3 }, new int[] { 4, 6 }, new int[] { 7, 8 }, new int[] { 8, 10 }, new int[] { 12, 15 } };

            int len = arr.Length;

            FindInterval(arr, len);
        }

        static void FindInterval(int[][] arr, int len)
        {
            if(len <= 0)
            {
                return;
            }

            List<interval> ilen = new List<interval>();

            Array.Sort(arr, new Comparison<int[]>((a,b) => a[0] - b[0]));

            for(int i = 1; i < len; i++)
            {
                int preEnd   = arr[i - 1][1];
                int CurStart = arr[i][0];

                if(preEnd < CurStart)
                {
                    interval interval = new interval (preEnd, CurStart);
                    ilen.Add(interval);
                }
            }

            for(int i = 0; i < ilen.Count; i++)
            {
                Console.WriteLine("[" + ilen[i].begin + ", " + ilen[i].end + "]");
            }
            Console.ReadKey();
        }
    }
}

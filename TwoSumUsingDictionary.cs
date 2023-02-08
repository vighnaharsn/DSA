using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumUsingDictionary
{
    internal class TwoSumUsingDictionary
    {       
        static void Main(string[] args)
        {
            int[] num = { 2, 3, 3, 6 };
            int t = 6;

            bool rsl = TwoSumHP(num,t);   
            
            if(!rsl)
            {
                Console.Write("-1");
            }

            Console.ReadKey();
        }
        static bool TwoSumHP(int[] num, int t)
        {
            Dictionary<int,int> hm  = new Dictionary<int,int>(); /* most omptimise solution */

            for(int i = 0; i < num.Length; i++)
            {
                int b = t - num[i];
                if (hm.ContainsValue(b))
                {
                   int f = i,s = 0;
                   foreach(var j in hm)
                   {
                        if(j.Value == b)
                        {
                            s = j.Key;
                        }
                   }
                   Console.Write(s + " " + f);
                   return true;
                }
                hm.Add(i,num[i]);
            }
            return false;
        }
    }
}

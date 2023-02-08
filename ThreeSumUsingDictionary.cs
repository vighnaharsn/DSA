using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSumUsingDictionary
{
    internal class ThreeSumUsingDictionary
    {
        static void Main(string[] args)
        {
            ////int[] num = { -1, 0, 1, 2, 1, 4, -1 };
            int[] num = { 1, 4, 45, 6, 10, 8 };
            int t = 22;

            Dictionary<int,int> hm = new Dictionary<int,int>();

            for(int i = 0; i < num.Length; i ++)
            {                
                if (!(hm.ContainsKey(num[i])))
                {
                    hm.Add(num[i],1);                    
                }
                else
                {
                    hm[num[i]] += 1;                                                            
                }
            }

           bool r = ThreeSum(num,hm,t);

            if (!r)
            {
                Console.Write("-1");
            }

            Console.ReadKey();
        }
        static bool ThreeSum(int[] num, Dictionary<int,int> hm, int t)
        {            
            for(int i = 0; i < num.Length - 1; i++)
            {
                hm[num[i]]--;
                for(int j = i + 1; j < num.Length; j++)
                {
                    hm[num[j]]--;

                    int c = t - (num[i] + num[j]);

                    bool rslt = hm.ContainsKey(c);

                    if(rslt)
                    {
                        if (num[i] + num[j] + c == t)
                        {
                            Console.Write("[" + num[i] + "," + num[j] + "," + c + "]");
                            return true;
                        }
                    }
                    hm[num[j]]++;
                }
                hm[num[i]]++;
            }
            return false;
        }
    }
}

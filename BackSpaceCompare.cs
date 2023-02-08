using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace BackSpaceCompare
{
    internal class BackSpaceCompare
    {
        static void Main(string[] args)
        {
            string a = "ab#d";
            string b = "ac#d";

            bool rslt = BkSpceComp(a, b);

            if(rslt)
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }

            Console.ReadKey();
        }

        public static bool BkSpceComp(string a, string b)
        {
            Stack<char> c1 = new Stack<char>();
            Stack<char> c2 = new Stack<char>();

            char[] ch1 = a.ToCharArray();
            char[] ch2 = b.ToCharArray();

            for(int i =0; i < ch1.Length; i++)
            {
                if (ch1[i] == '#')
                {
                    if(c1.Count != 0)
                    {
                        c1.Pop();
                        continue;
                    }
                    
                }
                c1.Push(ch1[i]);
            }

            for(int j =0; j < ch2.Length; j++)
            {
                if (ch2[j] == '#')
                {
                    if (c2.Count != 0)
                    {
                        c2.Pop();
                        continue;
                    }                    
                }
                c2.Push(ch2[j]);
            }

            string rsl1 = "";
            string rsl2 = "";

            while(c1.Count != 0)
            {
                rsl1 += c1.Pop();
            }
            while (c2.Count != 0)
            {
                rsl2 += c2.Pop();
            }

            return rsl1.Equals(rsl2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNestingDepth
{
    internal class MaxNestingDepth
    {
        static void Main(string[] args)
        {
            string s = "(1+(2*3)+((8)/4))+1";

            int rslt = MaxNestDepth(s);

            Console.Write(rslt);

            Console.ReadKey();
        }
        static int MaxNestDepth(string s)
        {
            Stack<string> h = new Stack<string>();
            int maxNumParentheses = 0;
            char[] ch = s.ToCharArray();

            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '(')
                {
                    h.Push("(");
                    maxNumParentheses = Math.Max(maxNumParentheses, h.Count());
                }
                else
                if (ch[i] == ')')
                {
                    h.Pop();
                }
            }

            return maxNumParentheses;
        }
    }
}

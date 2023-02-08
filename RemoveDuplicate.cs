using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicate
{
    /*
        You are given a string s consisting of lowercase English letters. A duplicate removal consists of choosing two adjacent and equal letters and removing them. 
        We repeatedly make duplicate removals on s until we no longer can. Return the final string after all such duplicate removals have been made. 
        It can be proven that the answer is unique.

        Explanation: 
        For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  
        The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".
     */
    internal class RemoveDuplicate
    {
        static void Main(string[] args)
        {
            string str = "abbaca";

            string rslt = RmvDuplicate(str);

            Console.Write(rslt);

            Console.ReadKey();
        }
        static string RmvDuplicate(string str)
        {            
            Stack<char> stk = new Stack<char>();

            char[] ch = str.ToCharArray();            

            for(int i = 0; i < ch.Length; i++)
            {                
                if(!stk.Any() || stk.Peek() != ch[i])
                {
                    stk.Push(ch[i]);
                }
                else
                {
                    stk.Pop();
                }
            }

            char[] arr = new char[stk.Count()];

            for(int i = stk.Count(); i > 0; i--) /* reverse the char stk to Char arr */
            {
                arr[i - 1] = stk.Pop();                
            }

            string rsl = GetString(arr);
            return rsl;
        }
        static string GetString(char[] arr) /* convert Char to String */
        {
            string s = new string(arr);

            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodedString
{
    /*
        Given an encoded string, return its decoded string. The encoding rule is: k[encoded_string], 
        where the encoded_string inside the square brackets is being repeated exactly k times. 
        Note that k is guaranteed to be a positive integer.
        Input: s = "3[a]2[bc]"
        Output: "aaabcbc"

        Input: s = "3[a2[c]]"
        Output: "accaccacc"
     */
    internal class DecodedString
    {
        static void Main(string[] args)
        {
            string str = "3[a]2[bc]";

            string rsl = DecodString(str);

            Console.Write(rsl);

            Console.ReadKey();
        }
        static string DecodString(string str)
        {
            string res = "";

            Stack<int> CountStack = new Stack<int>();

            Stack<string> ResStack = new Stack<string>();

            int idx = 0;

            while (idx < str.Length)
            {
                if (char.IsDigit(str[idx]))
                {
                    int count = 0;

                    while (char.IsDigit(str[idx]))
                    {
                        count = 10 * count + (str[idx] - '0');
                        idx++;
                    }
                    CountStack.Push(count);
                }
                else
                if (str[idx] == '[')
                {
                    ResStack.Push(res);
                    res = "";
                    idx++;
                }
                else
                if (str[idx] == ']')
                {
                    StringBuilder temp = new StringBuilder(ResStack.Pop());

                    int RepetTimes = CountStack.Pop();
                    
                    for(int i = 0; i < RepetTimes; i++)
                    {
                        temp.Append(res);
                    }

                    res = temp.ToString();

                    idx++;
                }
                else
                {
                    res += str[idx++];
                }
            }

            return res;
        }
    }
}

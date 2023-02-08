using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidInputString
{
    internal class ValidInputString
    {
        static void Main(string[] args)
        {
            string str = "()[]{}";

            bool rslt = ValInpStr(str);

            if(rslt)
            {
                Console.Write("Input String Is Valid");
            }
            else
            {
                Console.Write("Input String Is In-Valid");
            }

            Console.ReadKey();
        }

        static bool ValInpStr(string str)
        {
            // Create a new stack to store the characters.

            Stack<char> stk= new Stack<char>();

            // convert string into char array and access the characters using for each loop.
            char[] ch = str.ToCharArray();

            for(int i = 0; i < ch.Length; i++)
            {
                switch(ch[i]) // check ch
                {
                    // open bracket then push it in stack.
                    // close bracket then pop the item and compare.

                    case '(':
                    case '{':
                    case '[':
                        stk.Push(ch[i]);
                        break;

                    case ')':
                        if(!stk.Any() || stk.Pop() != '(')
                        {
                            // if the stack is empty then it means string have no open bracket.
                            // hence it is invalid.

                            return false;
                        }
                        break;
                    case '}':
                        if (!stk.Any() || stk.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (!stk.Any() || stk.Pop() != '[')
                        {
                            return false;
                        }
                        break;
                }
            }

            // After the loop we have to check one more condition.
            // return true only if the stack is empty.
            // if stack is not empty that means we have unused brackets.


            return !stk.Any();
        }
    }
}

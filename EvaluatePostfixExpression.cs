using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EvaluatePostfixExpression
{
    /*
        evaluate a given postfix expression efficiently

        82/ will evaluate to 4 (8/2)
 
        138*+ will evaluate to 25 (1+8*3)
 
        545*+5/ will evaluate to 5 ((5+4*5)/5)

     */
    internal class EvaluatePostfixExpression
    {
        static void Main(string[] args)
        {
           string exp = "138*+";

           int a = EvalPostExp(exp);

            Console.WriteLine(a);

            Console.ReadKey();
        }
        public static int EvalPostExp(string exp)
        {
            // base case
            if (exp == null || exp.Length == 0)
            {
                return -1;
            }

            // create an empty stack
            Stack<int> st = new Stack<int>();

            // Convert to Char Array to loop
            char[] ch = exp.ToCharArray();

            int x = 0, y = 0;

            for(int i = 0; i < ch.Length; i++)
            {
                // if the current character is an operand, push it into the stack
                if (char.IsDigit(ch[i]))
                {
                    st.Push(ch[i] - '0');
                }
                else // if the current character is an operator
                {
                    // remove the top two elements from the stack

                    x = st.Pop();
                    y = st.Pop();
                }

                // evaluate the expression 'x op y', and push the
                // result back to the stack

                if (ch[i] == '+')
                {
                    st.Push(y + x);
                }
                else
                if (ch[i] == '-')
                {
                    st.Push(y - x);
                }
                else
                if (ch[i] == '*')
                {
                    st.Push(y * x);
                }
                else
                if (ch[i] == '/')
                {
                    st.Push(y / x);
                }

            }

            // At this point, the stack is left with only one element, i.e.,
            // expression result

            return st.Pop();
        }
    }   
}

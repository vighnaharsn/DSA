using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertInfixToPostfix
{
    class ConvertInfixToPostfix
    {
        /*
            Given an infix expression, convert it to the postfix expression. Assume that the infix expression is a string of tokens without any whitespace.

            Input:  (A+B)*(C/D)
            Output: AB+CD/*

         */
        static void Main(string[] args)
        {
            string str = "(A+B)*(C/D)";

            string rslt = ConvInfToPost(str);

            Console.Write(rslt);

            Console.ReadKey();
        }


        // Utility function to return precedence of the given operator.
        // Note that higher is the precedence, lower is its value

        static int Perc(char c)
        {
            // Multiplication and division
            if (c == '*' || c == '/')
            {
                return 3;
            }
            // Addition and subtraction
            if (c == '+' || c == '-')
            {
                return 4;
            }
            // Bitwise AND
            if (c == '&')
            {
                return 8;
            }
            // Bitwise XOR (exclusive or)
            if (c == '^')
            {
                return 9;
            }
            // Bitwise OR (inclusive or)
            if (c == '|')
            {
                return 10;
            }

            // add more operators if needed
            return int.MaxValue;
        }

        // Utility function to check if a given token is an operand
        public static bool isOperand(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9');
        }

        // Function to convert an infix expression to a postfix expression.
        // This function expects a valid infix expression

        static string ConvInfToPost(string str)
        {
            if(str == null || str.Length == 0)
            {
                return str;
            }

            // create an empty stack for storing operators
            Stack<char> stk = new Stack<char>();

            char[] ch = str.ToCharArray();

            string postfix = "";

            for(int i = 0; i < ch.Length; i++)
            {
                // Case 1. If the current token is an opening bracket '(',
                // push it into the stack

                if (ch[i] == '(')
                {
                    stk.Push(ch[i]);
                }
                else
                if(ch[i] == ')')              // Case 2. If the current token is a closing bracket ')'
                {
                    // pop tokens from the stack until the corresponding opening
                    // bracket '(' is removed. Append each operator at the end
                    // of the postfix expression

                    while (stk.Peek() != '(')
                    {
                        postfix += stk.Pop();
                    }
                    stk.Pop();
                }
                // Case 3. If the current token is an operand, append it at the end
                // of the postfix expression

                else
                if (isOperand(ch[i]))
                {
                    postfix += ch[i];
                }
                // Case 4. If the current token is an operator
                else
                {
                    // remove operators from the stack with higher or equal precedence
                    // and append them at the end of the postfix expression

                    while (stk.Count() != 0 && Perc(ch[i]) >= Perc(stk.Peek()))
                    {
                        postfix += stk.Pop();
                    }
                    stk.Push(ch[i]);                 // finally, push the current operator on top of the stack
                }
            }

            // append any remaining operators in the stack at the end
            // of the postfix expression

            while (stk.Count != 0)
            {
                postfix += stk.Pop();
            }

            return postfix; // return the postfix expression
        }
    }
}

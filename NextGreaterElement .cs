using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGreaterElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 4, 5, 2, 25 };

            int[] rslt = NextGreaterElement(num);

            for(int i =0; i< rslt.Length;i++)
            {
                Console.Write(rslt[i] + " ");
            }

            Console.ReadKey();
        }
        static int[] NextGreaterElement(int[] num)
        {
            // base case
            if (num == null)
            {
                return num;
            }

            int[] rsl = { -1, -1, -1, -1 };

            // create an empty stack
            Stack<int> s = new Stack<int>();

            for(int i = 0; i < num.Length; i++)
            {
                // loop till we have a greater element on top or stack becomes empty.
                // Keep popping elements from the stack smaller than the current
                // element, and set their next greater element to the current element

                while (s.Count != 0 && num[s.Peek()] < num[i])
                {
                    rsl[s.Pop()] = num[i];
                }
                // push current "index" into the stack
                s.Push(i);
            }

            return rsl;
        }
    }
}

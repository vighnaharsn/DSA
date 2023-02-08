using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ReturnMinElementConstTime
{
    class ReturnMinElementConstTime
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack();
            
            s.Push(3);
            s.Push(5);
            s.getMin();
            s.Push(2);
            s.Push(1);
            s.getMin();
            s.Pop();
            s.getMin();
            s.Pop();
            s.Peek();

            Console.ReadKey();
        }
    }

    public class MyStack
    {
        public Stack s;
        public int minEle;

        // Constructor
        public MyStack() { s = new Stack(); }

        // Prints minimum element of MyStack
        public void getMin()
        {
            // Get the minimum number
            // in the entire stack
            if (s.Count == 0)
                Console.WriteLine("Stack is empty");

            // variable minEle stores the minimum
            // element in the stack.
            else
                Console.WriteLine("Minimum Element in the "
                                  + " stack is: " + minEle);
        }

        // prints top element of MyStack
        public void Peek()
        {
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empty ");
                return;
            }

            int t = (int)s.Peek(); // Top element.

            Console.Write("Top Most Element is: ");

            // If t < minEle means minEle stores
            // value of t.
            if (t < minEle)
                Console.WriteLine(minEle);
            else
                Console.WriteLine(t);
        }

        // Removes the top element from MyStack
        public void Pop()
        {
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.Write("Top Most Element Removed: ");
            int t = (int)s.Pop();

            // Minimum will change as the minimum element
            // of the stack is being removed.
            if (t < minEle)
            {
                Console.WriteLine(minEle);
                minEle = 2 * minEle - t;
            }

            else
                Console.WriteLine(t);
        }

        // Insert new number into MyStack
        public void Push(int x)
        {
            if (s.Count == 0)
            {
                minEle = x;
                s.Push(x);
                Console.WriteLine("Number Inserted: " + x);
                return;
            }

            // If new number is less than original minEle
            if (x < minEle)
            {
                s.Push(2 * x - minEle);
                minEle = x;
            }

            else
                s.Push(x);

            Console.WriteLine("Number Inserted: " + x);
        }
    }
}

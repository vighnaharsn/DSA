using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNodeList
{
    internal class ReverseNodeList
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(0);
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);

            LinkedListNode<int> tail = list.Last;            
            
            foreach (int a in list)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();

            ReverseNode(tail);

            Console.ReadKey();
        }
        static void ReverseNode(LinkedListNode<int> tail)
        {
            while(tail != null)
            {
                Console.Write(tail.Value + " ");
                tail = tail.Previous;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMiddleNodeUsingTP
{
    /*
     Logic :  Move slow pointer by one node
              Move fast pointer by two node
              TC : o(n) where n is the nodes in the linked list
     */
    internal class FindMiddleNodeUsingTP
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(10);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(7);

            LinkedListNode<int> head = list.First;

            var rslt = MiddleNode(head);

            foreach(int a in list)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();

            Console.WriteLine("The Middle Node is = " + rslt.Value);

            Console.ReadKey();
        }

        static LinkedListNode<int> MiddleNode(LinkedListNode<int> head)
        {
            LinkedListNode<int> slow = head, fast = head; /* slow is pointer one and fast is pointer two */

            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            
            return slow;
        }
    }
}

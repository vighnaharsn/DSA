using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoList
{
    internal class MergeTwoList
    {
        static void Main(string[] args)
        {
            LinkedList<int> listA = new LinkedList<int>();

            listA.AddLast(1);
            listA.AddLast(2);
            listA.AddLast(5);          

            LinkedListNode<int> headA = listA.First;

            LinkedList<int> listB = new LinkedList<int>();

            listB.AddLast(2);
            listB.AddLast(3);
            listB.AddLast(4);

            LinkedListNode<int> headB = listB.First;

            MrgTwoLst(headA, headB);
            
            Console.ReadKey();
        }

        static void MrgTwoLst(LinkedListNode<int> headA, LinkedListNode<int> headB)
        {
            if (headA == null)
            {
                while(headB != null)
                {
                    Console.Write(headB.Value + " ");
                    headB = headB.Next;
                }
                return;
            }
            if (headB == null)
            {
                while (headA != null)
                {
                    Console.Write(headA.Value + " ");
                    headA = headA.Next;
                }
                return;
            }           

            while (true)
            {
                if (headA != null && headB != null)
                {
                    if (headA.Value < headB.Value)
                    {
                        Console.Write(headA.Value + " ");
                        headA = headA.Next;
                    }
                    else
                    {
                        Console.Write(headB.Value + " ");
                        headB = headB.Next;
                    }
                }
                else
                if (headA != null && headB == null)
                {
                    Console.Write(headA.Value);
                    headA = headA.Next;
                }
                else
                if (headA == null && headB != null)
                {
                    Console.Write(headB.Value);
                    headB = headB.Next;
                }                
            }           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindInterSectOfTwoNode
{
    /*
      Logic : First find out length NodeA and NodeB
              If NodeA > NodeB then move pointer of NodeA no. of diff Node ahead.
              If NodeB > NodeA then move pointer of NodeB no. of diff Node ahead.
              Then check if NodeA = NodeB then return the result
                
              TC: O(max(m,n) where m,n is the no of nodes in L.L A,B respectively.
              SC: O(1) 
     */
    internal class FindInterSectOfTwoNode
    {
        static void Main(string[] args)
        {
            LinkedList<string> listA = new LinkedList<string>();

            listA.AddLast("a1");
            listA.AddLast("a2");
            listA.AddLast("c1");
            listA.AddLast("c2");
            listA.AddLast("c3");            

            LinkedListNode<string> headA = listA.First;

            LinkedList<string> listB = new LinkedList<string>();

            listB.AddLast("b1");
            listB.AddLast("b2");
            listB.AddLast("b3");
            listB.AddLast("c1");
            listB.AddLast("c2");
            listB.AddLast("c3");

            LinkedListNode<string> headB = listB.First;

            var rslt = InterSectNode(headA,headB);


            foreach(string a in listA)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();

            foreach (string b in listB)
            {
                Console.Write(b + " ");
            }

            Console.WriteLine();

            Console.WriteLine("The Inter Sect Node is = " + rslt.Value);

            Console.ReadKey();
        }

        static LinkedListNode<string> InterSectNode(LinkedListNode<string> headA,LinkedListNode<string> headB)
        {
            int lenA = 0, lenB = 0;
            
            LinkedListNode<string> currA  = headA, currB = headB;

            while (currA != null) 
            {
                lenA++;  /* calculating length of CurrA */
                currA = currA.Next; /* move current pointer of currA to the next node */
            }
            while (currB != null) 
            {
                lenB++; /* calculating length of CurrB */
                currB = currB.Next; /* move current pointer of currB to the next node */
            }

            currA = headA;
            currB = headB;

            if(lenA > lenB)
            {
                for(int i = 0; i < lenA-lenB; i++)
                {
                    currA = currA.Next; /* moving CurrA pointer no. of diff. step ahead */
                }
            }
            else
            {
                for (int i = 0; i < lenB-lenA; i++)
                {
                    currB = currB.Next; /* moving CurrB pointer no. of diff. step ahead */
                }
            }

            while(currA.Value != currB.Value)
            {
                currA = currA.Next;
                currB = currB.Next;
            }

            return currA;
        }
    }
}

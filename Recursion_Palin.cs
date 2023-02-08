using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Palin
{
    internal class Recursion_Palin
    {
        static void Main(string[] args)
        {
            string str, rev = "";int i;

            Console.WriteLine("Please Enter String");
            str = Console.ReadLine().ToLower();

            i = str.Length - 1;

            PrintPalin(str, rev, i);

            Console.ReadKey();
        }

        static void PrintPalin(string str, string rev, int i)
        {            
            if(i < 0)
            {
                if(rev == str)
                {
                    Console.WriteLine("Palindrome");
                }
                else
                {
                    Console.WriteLine("Not Palindrome");
                }
                return;
            }

            rev += str[i];

            PrintPalin(str, rev, i - 1);
        }
    }
}

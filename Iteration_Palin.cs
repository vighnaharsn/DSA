using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palin_Iteration
{
    internal class Iteration_Palin
    {
        static void Main(string[] args)
        {
            //////int a, rem, rev = 0, act;
            //////Console.WriteLine("Please Enter Number");
            //////a = Convert.ToInt16(Console.ReadLine());
            //////act = a;

            //////while(a != 0)
            //////{
            //////    rem = a % 10;
            //////    a   = a / 10;
            //////    rev = rev * 10 + rem;                
            //////}

            //////if(act == rev)
            //////{
            //////    Console.WriteLine(act + " is palinedrome numner");
            //////}
            //////else
            //////{
            //////    Console.WriteLine(act + " is Not palinedrome numner");
            //////}

            //////Console.ReadKey();
            ///

            string str, rev = "";

            Console.WriteLine("Please Enter String");

            str = Console.ReadLine().ToLower();

            for(int i = str.Length -1; i >= 0; i--)
            {
                rev += str[i];
            }

            if(rev == str)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

            Console.ReadKey();
        }
    }
}

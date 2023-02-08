using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDupliFromStr
{
    internal class RemoveDupliFromStr
    {
        static void Main(string[] args)
        {
            string str = "axxbyyczz";

            string rsl = RmvDuplStr(str);

            Console.Write("String After remove duplicate is = " + rsl);

            Console.ReadKey();
        }

        static string RmvDuplStr( string s)
        {
            int[] ascii_str = new int[26]; /* create empty int array size of 26 (a-z) */
            string str = "";

            for(int i = 0; i < s.Length; i++)
            {
                if (ascii_str[s[i] - 'a'] == 0)
                {
                    str += s[i];
                    ascii_str[s[i] - 'a'] += 1;
                }
            }

            return str;
        }
    }
}

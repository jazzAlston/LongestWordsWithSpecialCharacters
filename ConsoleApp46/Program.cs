using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestWord("ready[[[ go! steady"));
        }
        public static string LongestWord(string str)
        {
            StringBuilder sb = new StringBuilder();
            var list = new List<string>();
            string[] words = str.Split(' ');

            foreach (string word in words)
            {
                foreach (char c in word)
                {
                    if (c >= 65 && c <= 90 || c >= 97 && c <= 122)
                    {
                        sb.Append(c);
                    }
                }
                list.Add((sb.ToString()));
                sb.Clear();
            }

            string longest = list[0];


            foreach (var item in list)
            {
                if (item.Length > longest.Length)
                {
                    longest = item;
                }
            }
            return longest;
        }
    }
}

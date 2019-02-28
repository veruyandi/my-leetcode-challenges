using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challanges_Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution1 newSol = new Solution1();
            Console.WriteLine(newSol.LengthOfLongestSubstring("abcabcadlk")); // 6
            Console.WriteLine(newSol.LengthOfLongestSubstring("abcabcd")); //4
            Console.WriteLine(newSol.LengthOfLongestSubstring("bbbbb")); //1
            Console.WriteLine(newSol.LengthOfLongestSubstring("abba")); //2
            Console.WriteLine(newSol.LengthOfLongestSubstring("pwewkfcw")); //5

        }
    }
}

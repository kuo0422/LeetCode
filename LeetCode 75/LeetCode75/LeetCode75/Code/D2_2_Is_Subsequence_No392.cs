using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.Code
{
    internal class D2_2_Is_Subsequence_No392
    {
        public bool IsSubsequence(string s, string t)
        {
            int i = 0, j = 0;
            for (; i < t.Length && j < s.Length; i++)
            {
                if (s[j] == t[i])
                {
                    j++;
                }
            }

            return j == s.Length;
        }

        internal void PrintResult(string data, string data2, bool result)
        {
            Console.WriteLine($"Input: s = \"{data}\", t = \"{data2}\"");
            Console.WriteLine($"Output: {result}");
        }

        internal string[] GetInitialData()
        {
            return new string[] { "abc", "ahbgdc" };
        }
    }
}
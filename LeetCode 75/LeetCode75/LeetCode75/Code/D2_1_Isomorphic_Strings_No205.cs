using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.Code
{
    internal class D2_1_Isomorphic_Strings_No205
    {
        public bool IsIsomorphic(string s, string t)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < s.Length; i++)
            {
                if (ht.Contains(s[i]))
                {
                    if ((char)ht[s[i]] != t[i])
                    {
                        return false;
                    }
                }
                else if (ht.ContainsValue(t[i]))
                {
                    return false;
                }
                else
                {
                    ht.Add(s[i], t[i]);
                }
            }
            return true;
        }

        internal void PrintResult(string data, string data2, bool result)
        {
            Console.WriteLine($"Input: s = \"{data}\", t = \"{data2}\"");
            Console.WriteLine($"Output: {result}");
        }

        internal string[] GetInitialData()
        {
            return new string[] { "egg", "add" };
        }
    }
}
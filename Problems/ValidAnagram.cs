using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructureV1.Problems
{
    public static class ValidAnagram
    {
        public static void RunCode()
        {
            string s = "anagram";
            string t = "nagaram";
            var result = SolutionV1(s, t);
            Console.WriteLine($"ValidAnagram Answer: {result}");
        }

        private static bool Solution(string s, string t)
        {
            HashSet<char> chars = new HashSet<char>();

            foreach (var c in s)
            {
                chars.Add(c);
            }

            foreach (var c in t)
            {
                if (!chars.Contains(c))
                {
                    return false;
                }
            }
            
            return true;
        }

        private static bool SolutionV1(string s, string t)
        {
            HashSet<char> chars = new HashSet<char>();


            for(int i = 0; i < s.Length; i++)
            {
                chars.Add(s[i]);
            }

            for(int l = 0; l < t.Length; l++)
            {
                if (!chars.Contains(t[l]))
                {
                    return false;
                }
            }
            
            return true;
        }

        private static bool SolutionAI(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var sArray = s.ToCharArray();
            var tArray = t.ToCharArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            return sArray.SequenceEqual(tArray);
        }
    }
}
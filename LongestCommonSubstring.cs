using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    internal class LongestCommonSubstring
    {
        
            public string LongSub(string s)
            {
                if (string.IsNullOrEmpty(s))
                    return "";

                int maxLength = 0, start = 0;
                string longestSubstring = "";
                HashSet<char> charSet = new HashSet<char>();

                for (int end = 0; end < s.Length; end++)
                {
                    while (charSet.Contains(s[end]))
                    {
                        charSet.Remove(s[start]);
                        start++;
                    }
                    charSet.Add(s[end]);

                    if (end - start + 1 > maxLength)
                    {
                        maxLength = end - start + 1;
                        longestSubstring = s.Substring(start, maxLength);
                    }
                }

                return longestSubstring;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Enter a string to find the longest substring without repeating characters: ");
                string input=Console.ReadLine();
            LongestCommonSubstring obj = new LongestCommonSubstring();
                string str = obj.LongSub(input);
                Console.WriteLine("Longest Substring: " + str);
                Console.ReadLine();
            }
        
    }
}

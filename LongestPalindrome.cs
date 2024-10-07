using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    internal class LongestPalindrome
    {
        public string LongestPalindromeString(string s)
        {
            if (s.Length <= 1)
            {
                return s;
            }

            int maxLen = 1;
            string maxStr = s.Substring(0, 1);

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + maxLen; j <= s.Length; j++)
                {
                    if (j - i > maxLen && IsPalindrome(s.Substring(i, j - i)))
                    {
                        maxLen = j - i;
                        maxStr = s.Substring(i, j - i);
                    }
                }
            }

            return maxStr;
        }

        
        private bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }



        static void Main(string[] args)
        {
            LongestPalindrome obj = new LongestPalindrome();

            Console.WriteLine("Enter a string to find the longest palindromic substring:");
            string input = Console.ReadLine();  

            string result = obj.LongestPalindromeString(input);  

            Console.WriteLine($"The longest palindromic substring is: {result}");
            Console.ReadLine();
        }
    }
}

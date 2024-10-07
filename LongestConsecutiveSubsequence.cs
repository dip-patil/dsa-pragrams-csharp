using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    internal class LongestConsecutiveSubsequence
    {
       public static int FindLongestConsecutiveSubsequence(int[] arr)
        {
            HashSet<int> numSet = new HashSet<int>(arr);
            int maxLength = 0;

            foreach (var num in arr)
            {
                
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    
                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                   
                    maxLength = Math.Max(maxLength, currentStreak);
                }
            }

            return maxLength;
        }

        static void Main(string[] args)
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 }; 
            int longestStreak = FindLongestConsecutiveSubsequence(arr);

            Console.WriteLine($"The length of the longest consecutive subsequence is: {longestStreak}");
            Console.ReadLine();
        }
    }
}

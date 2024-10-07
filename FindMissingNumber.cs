using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    internal class FindMissingNumber
    {
        public static int FindMissingNumberFromArray(int[] arr)
        {
            int n = arr.Length + 1; 
            int expectedSum = n * (n + 1) / 2; 
            int actualSum = 0;

            
            foreach (var number in arr)
            {
                actualSum += number;
            }

            
            return expectedSum - actualSum;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 6 }; 
            int missingNumber = FindMissingNumberFromArray(arr);

            Console.WriteLine($"The missing number is: {missingNumber}");
            Console.ReadLine();
        }
    }
}

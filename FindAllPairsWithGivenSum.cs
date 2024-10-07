using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    internal class FindAllPairsWithGivenSum
    {
        public static List<(int, int)> FindPairsWithSum(int[] arr, int target)
        {
            var pairs = new List<(int, int)>();
            var seenNumbers = new HashSet<int>();

            foreach(var number in arr)
            {
                int complement = target - number;

               
                if (seenNumbers.Contains(complement))
                {
                    pairs.Add((complement, number));
                }

                
                seenNumbers.Add(number);
            }

            return pairs;
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 3, 5, 6 };
            int target = 7;

            List<(int, int)> result = FindPairsWithSum(arr, target);

            Console.WriteLine("Output: " + string.Join(", ", result));
            Console.ReadLine();
        }
    }
}

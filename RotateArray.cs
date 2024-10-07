using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    internal class RotateArray
    {
        


        public static int[] Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;
            int[] rotated = new int[n];

            for (int i = 0; i < n; i++)
            {
                rotated[(i + k) % n] = nums[i];
            }

            for (int i = 0; i < n; i++)
            {
                nums[i] = rotated[i];
            }
            return rotated;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 }; 
            int k = 2;
            int[] res;
            Console.WriteLine("Original array: " + string.Join(", ", arr));
            Rotate(arr, k);
            Console.WriteLine("Rotated array: " + string.Join(", ", arr));

            Console.ReadLine();
        }
    }
}

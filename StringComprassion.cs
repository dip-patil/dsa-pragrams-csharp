using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    internal class StringComprassion
    {
        // Method to compress the given string
        public string CompressString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";

            StringBuilder compressed = new StringBuilder();
            int countConsecutive = 0;

            for (int i = 0; i < s.Length; i++)
            {
                countConsecutive++;

                
                if (i + 1 >= s.Length || s[i] != s[i + 1])
                {
                    compressed.Append(s[i]);
                    compressed.Append(countConsecutive);
                    countConsecutive = 0;  // Reset counter
                }
            }

            
            string compressedString = compressed.ToString();
            return compressedString;
        }

        static void Main(string[] args)
        {
            StringComprassion obj = new StringComprassion();

            Console.WriteLine("Enter a string to compress:");
            string input = Console.ReadLine(); 

            string compressedOutput = obj.CompressString(input);  

            Console.WriteLine($"Original: {input} -> Compressed: {compressedOutput}");  
            Console.ReadLine();
        }
    }
}

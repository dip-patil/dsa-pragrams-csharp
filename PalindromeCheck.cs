using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    

    class PalindromeCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it is a palindrome: ");
            string input = Console.ReadLine();

            
            if (IsPalindrome(input))
            {
                Console.WriteLine($"\"{input}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\"{input}\" is not a palindrome.");
            }
            Console.ReadLine();
        }

        static bool IsPalindrome(string input)
        {
            
            string cleanedInput = "";
            foreach (char c in input.ToLower())
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleanedInput += c;
                }
            }

            
            int length = cleanedInput.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (cleanedInput[i] != cleanedInput[length - i - 1])
                {
                    return false;  
                }
            }
            return true; 
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    internal class StringRotation
    {
        public bool IsRotation(string s1, string s2)
        {
            
            if (s1.Length != s2.Length || string.IsNullOrEmpty(s1))
                return false;

            
            string concatenated = s1 + s1;

            
            return concatenated.Contains(s2);
        }

        static void Main(string[] args)
        {
            StringRotation obj = new StringRotation();

            Console.WriteLine("Enter the first string:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string s2 = Console.ReadLine();

            bool result = obj.IsRotation(s1, s2);

            if (result)
            {
                Console.WriteLine($"{s2} is a rotation of {s1}");
            }
            else
            {
                Console.WriteLine($"{s2} is NOT a rotation of {s1}");
            }

            Console.ReadLine();
        }
    }
}

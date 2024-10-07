using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
   

    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to reverse: ");

            
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int reversedNumber = Reverse(number);
                Console.WriteLine($"The reversed number is: {reversedNumber}");
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
            Console.ReadLine();
        }

        static int Reverse(int number)
        {
            int reverse = 0;

            while (number != 0)
            {
                int remainder = number % 10;  
                reverse = reverse * 10 + remainder;  
                number /= 10;  
            }

            return reverse;
        }
    }

}

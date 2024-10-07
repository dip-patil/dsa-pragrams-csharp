using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    

    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is a prime number:");

            int number = int.Parse(Console.ReadLine());
            if (number > 1)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} is a Prime Number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a Prime Number.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer greater than 1.");
            }
            Console.ReadLine();
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }

}

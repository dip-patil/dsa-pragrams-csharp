using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    using System;

    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms in the Fibonacci series: ");

            int numberOfTerms=int.Parse(Console.ReadLine());    


            if (numberOfTerms > 0)
            {
                Console.WriteLine($"Fibonacci series with {numberOfTerms} terms:");
                PrintFibonacciSeries(numberOfTerms);
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
            Console.ReadLine();
        }

        static void PrintFibonacciSeries(int terms)
        {
            int first = 0, second = 1, next;

            for (int i = 1; i <= terms; i++)
            {
                Console.Write(first + " ");

                next = first + second;  
                first = second;         
                second = next;                      }
            Console.WriteLine();
        }
    }

}

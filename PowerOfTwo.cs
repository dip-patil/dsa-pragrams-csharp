using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    

    class PowerOfTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the power value N (0 <= N < 31): ");

            int N=int.Parse(Console.ReadLine());
            if (N >= 0 && N < 31)
            {
                PrintPowersOfTwo(N);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer between 0 and 30.");
            }
            Console.ReadLine();
        }

        static void PrintPowersOfTwo(int N)
        {
            Console.WriteLine($"Powers of 2 from 0 to {N}:");
            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine($"2^{i} = {Math.Pow(2, i)}");
            }
        }
    }

}

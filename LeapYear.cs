using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems_CSharp
{
    

    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 4-digit year: ");

             int year=int.Parse(Console.ReadLine());

            if (year >= 1000 && year <= 9999)
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine($"{year} is a Leap Year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid 4-digit year.");
            }
            Console.ReadLine();
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }


}

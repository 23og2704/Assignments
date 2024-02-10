using System;
namespace A113
{
    internal class Program
    {
        static bool LeapYear(int year)
        {
            bool divisibleBy4 = year % 4 == 0;
            bool divisibleBy100 = year % 100 == 0;
            bool divisibleBy400 = year % 400 == 0;
            return (divisibleBy4 && !divisibleBy100) || divisibleBy400;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if (LeapYear(year))
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is NOT a leap year");
            }
            Console.ReadKey();
        }
    }
}

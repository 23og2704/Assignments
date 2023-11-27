using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter a number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int second = int.Parse(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine("first");
            } else if (second > first)
            {
                Console.WriteLine("second");
            }
            Console.ReadKey();
            */
            /*
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 5000)
            {
                Console.WriteLine("Too big");
            } else if (num < 1000)
            {
                Console.WriteLine("Too small");
            }else
            {
                Console.WriteLine("Correct");
            }
            Console.ReadKey();
            */
            Console.WriteLine("Enter the diameter of the pizza: ");
            int diameter = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the total number of slices: ");
            int slices = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of slices eaten: ");
            int slices_eaten = int.Parse(Console.ReadLine());
            double radius = diameter / 2;
            double volume = Math.PI * Math.Pow(radius, 2) * 2 * slices_eaten / slices;
            Console.WriteLine($"{volume}cm^3 of pizza eaten");
            Console.ReadKey();
        }
    }
}

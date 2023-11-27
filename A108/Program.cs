using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int average = 0;
            int[] fibonacci = new int[31];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            for (int i = 0;i < fibonacci.Length;i++)
            {
                Console.WriteLine($"{i + 1} : {fibonacci[i]}");
                average = average + fibonacci[i];
            }
            Console.WriteLine($"Average/Mean = {average / fibonacci.Length}");
            Console.ReadKey();




            /*
            Console.WriteLine("How many values would you like to enter: ");
            int noValues = int.Parse(Console.ReadLine());
            int[] values = new int[noValues];
            for (int i = 0; i < noValues; i++) 
            {
                Console.Write($"Enter the {i + 1} value: ");
                values[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Smallest value: {values.Min()}");
            Console.ReadKey();
            */
        }
    }
}

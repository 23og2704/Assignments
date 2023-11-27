using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesxt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int ans = 0;
            int loop = 0;
            string choice = Console.ReadLine();
            Console.WriteLine(choice);
            switch (choice)
            {
                case "s":
                    loop = 1;
                    for (int i = 1; 0 <= num + 1; i++)
                    {
                        ans = ans + i;
                    }
                    Console.WriteLine("Sum of all the numbers to 5 = ");
                    break;
                case "f":
                    loop = 1;
                    ans = 1;
                    for (int i = 1; 0 <= num + 1; i++)
                    {
                        ans = ans * i;
                    }
                    Console.WriteLine("the Factorial for 5 = ");
                    break;
                default:
                    Console.WriteLine("that is not a valid answer");
                    loop = 0;
                    break;

            }
        }
    }
}

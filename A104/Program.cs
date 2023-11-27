using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace A104
{
    internal class Program
    {
        /*
        static void sum(int num) 
        {
            int result = 0;
            for (int i = 1; i <= num; i++)
            {
                result += i;
            }
            Console.WriteLine($"The sum of all numbers up to {num} is {result}.");
        }
        static void factor(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            Console.WriteLine($"The factorial of {num} is {result}.");
        }
        static void questions()
        {
            bool valid = false;

            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Would you like the sum (s) of all numbers up to {num} or the factorial (f) of {num}: ");
            char choice = char.Parse(Console.ReadLine());
            while (valid == false)
            {
                if (choice == 's')
                {
                    sum(num);
                    valid = true;
                }
                else if (choice == 'f')
                {
                    factor(num);
                    valid = true;
                }
                else
                {
                    Console.WriteLine($"Would you like the sum (s) of all numbers up to {num} or the factorial (f) of {num}: ");
                    choice = char.Parse(Console.ReadLine());
                    valid = false;
                }
             }
        }
        */
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            Console.WriteLine("Enter number of sides for die: ");
            int sides = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of rolls of die: ");
            int rolls = int.Parse(Console.ReadLine());
            sides++;
            Console.WriteLine("Rolls: \n");
            for (int i = 0; rolls > i; i++)
            {
                Console.WriteLine(rnd.Next(1, sides));
            }
            Console.ReadKey();
            
            /*
            questions();
            Console.ReadKey();
            */
        }
    }
}

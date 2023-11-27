using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JoeCode
{
    internal class Program
    {

        static void Menu(string Q)
        {
            Console.Clear();
            switch (Q)
            {
                case "1":
                    nsideddice();
                    break;
                case "2":
                    Factsum();
                    break;
                default:
                    break;
            }



        }
        static void nsideddice()
        {
            Random rnd = new Random();
            Console.WriteLine("Welcome to the n sided die");
            Console.WriteLine();
            Console.WriteLine("How many sides would you like your die to have?");
            int sides = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("How many times would you like to roll your die?");
            int rolls = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Here are your rolls:");
            for (int i = 0; i < rolls; i++)
            {
                int roll = rnd.Next(0, sides + 1);
                Console.WriteLine(roll);
            }
            Console.ReadKey();
        }
        static void Factsum()
        {
            int loop = 0;
            int ans = 0;
            Console.WriteLine("Welcome to Sum or Factorial");
            Console.WriteLine();
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Would you like to sum all the numbers up to 5 or find the factorial of 5?");
            while (loop == 0)
            {
                Console.WriteLine("Enter s for sum or f for factorial");
                string choice = Console.ReadKey(true).KeyChar.ToString();
                Console.WriteLine(choice);
                switch (choice)
                {
                    case "s":
                        loop = 1;
                        for (int i = 1; 0 < num; i++)
                        {
                            ans = ans + i;
                        }
                        Console.WriteLine("Sum of all the numbers to 5 = ");
                        break;
                    case "f":
                        loop = 1;
                        for (int i = 1; 0 < num; i++)
                        {
                            ans = ans * i;
                            Console.WriteLine($"{i} {ans}");
                        }
                        Console.WriteLine("the Factorial for 5 = ");
                        break;
                    default:
                        Console.WriteLine("that is not a valid answer");
                        break;

                }
                Console.Write(ans);
                Console.WriteLine("Bye!");
                Console.ReadKey();
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Which code would you like to run?");
            Menu(Console.ReadLine());
        }
    }
}


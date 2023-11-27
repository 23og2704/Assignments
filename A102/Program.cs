using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace A102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter the traffic lights colour: ");
            string lights = Console.ReadLine();
            switch (lights)
            {
                case "Red":
                    Console.WriteLine("RedAmber");
                    break;
                case "RedAmber":
                    Console.WriteLine("Green");
                    break;
                case "Green":
                    Console.WriteLine("Amber");
                    break;
                case "Amber":
                    Console.WriteLine("Red");
                    break;
                default: 
                    Console.WriteLine("Invalid colour");
                    break;
            }
            Console.ReadKey();
            */

            int score = 0;
            string ans = "";
            Console.WriteLine("General Knowledge Quiz\n");
            Console.WriteLine("Who wrote the play Romeo and Juliet?\n" +
                "A. Charles Dickens\n" +
                "B. William Shakespeare\n" +
                "C. Jane Austen\n" +
                "D. Mark Twain");
            ans = Console.ReadLine();
            if (ans == "B")
            {
                score += 1;
                Console.WriteLine("Correct!");
            }else
            {
                Console.WriteLine($"Incorrect the answer was not {ans}, it was B");
            }
            Console.WriteLine("Which company made the iPhone?\n" +
                "A. Samsung\n" +
                "B. Microsoft\n" +
                "C. Apple\n" +
                "D. Google");
            ans = Console.ReadLine();
            if (ans == "C")
            {
                score += 1;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect the answer was not {ans}, it was C");
            }
            Console.WriteLine("What is the chemical symbol for water?\n" +
                "A. Wo\n" +
                "B. H2O\n" +
                "C. CO2\n" +
                "D. O2");
            ans = Console.ReadLine();
            if (ans == "B")
            {
                score += 1;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect the answer was not {ans}, it was B");
            }
            Console.WriteLine($"The quiz is over, you scored {score} / 3, thanks for playing!");
            Console.ReadKey();
        }
    }
}

using System;

namespace A109
{
    internal class Program
    {
        static bool checkStats(int[] scores)
        {
            int total = 0;
            foreach (int score in scores)
            {
                switch (score)
                {
                    case 8:
                        total += 0;
                        break;
                    case 9:
                        total += 1;
                        break;
                    case 10:
                        total += 2;
                        break;
                    case 11:
                        total += 3;
                        break;
                    case 12:
                        total += 4;
                        break;
                    case 13:
                        total += 5;
                        break;
                    case 14:
                        total += 7;
                        break;
                    case 15:
                        total += 9;
                        break;
                }
            }
            return total == 27;
        }
        static void Main(string[] args)
        {
            
            string[] stats = { "Strength", "Dexterity", "Consitution", "Intelligence", "Wisdom", "Charisma" };
            int[] scores = new int[6];
            bool valid;

            do
            {
                valid = true;
                for (int i = 0; i < stats.Length; i++)
                {
                    do
                    {
                        
                        int userInput;
                        Console.WriteLine($"Enter a score for {stats[i]}: ");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput >= 8 && userInput <= 15)
                        {
                            scores[i] = userInput;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid score, enter new number.\n");
                        }
                    } while (true);

                }
                Console.WriteLine();
                for (int i = 0; i < scores.Length; i++)
                {
                    Console.WriteLine($"{stats[i]} has a score of {scores[i]}");
                }
                if (!checkStats(scores))
                {
                    Console.WriteLine("Invalid score, must add up to 27.");
                    valid = false;
                } else
                {
                    Console.WriteLine("Valid score, total points of 27.");

                }

                Console.ReadKey();



            } while (Console.ReadLine() == "y");

            Console.WriteLine("Do you want to run program again? (y/n): ");
            


     
        }
    }
}

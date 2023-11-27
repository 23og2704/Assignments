using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A107
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int PlayerOneScore = 0;
            int PlayerTwoScore = 0;
            Console.WriteLine("How many games? ");
            int NoOfGamesInMatch = int.Parse(Console.ReadLine());
            for (int NoOfGamesPlayed = 1; NoOfGamesPlayed < NoOfGamesInMatch; NoOfGamesPlayed++)
            {
                Console.WriteLine("Did Player One win the game (enter Y or N)?");
                char PlayerOneWinsGame = char.Parse(Console.ReadLine());
                if (PlayerOneWinsGame == 'Y')
                {
                    PlayerOneScore = PlayerOneScore + 1;
                } else
                {
                    PlayerTwoScore = PlayerTwoScore + 1;
                }
            }
            Console.WriteLine(PlayerOneScore);
            Console.WriteLine(PlayerTwoScore);
            /*
            Console.WriteLine("The first few prime numbers are: ");
            for (int Count1 = 2; Count1 < 50; Count1++) 
            {
                int Count2 = 2;
                string Prime = "Yes";
                while (Count2 * Count2 <= Count1) 
                {
                    if (Count1 % Count2 == 0)
                    {
                        Prime = "No";
                    }
                    Count2 = Count2 + 1;
                }
                if (Prime == "Yes")
                {
                    Console.WriteLine(Count1);
                }
            }
            */
            Console.ReadKey();
        }
    }
}

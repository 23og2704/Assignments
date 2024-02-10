using System;
using System.Collections.Generic;
using System.IO;

namespace A113___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>(File.ReadAllLines("A113HighScores.txt"));
            int highScore = 0;
            string highScoreName = "";
            string findDate = "25/12/2019";
            int dateScore = 0;
            int bobPlays = 0;
            int totalScore = 0;
            int numPlayers = 0;
            int leapHighScore = 0;
            foreach (string l in lines)
            {
                string[] sections = l.Split(' ');
                string playerName = sections[0].Trim('[', ']');
                int score = int.Parse(sections[1]);
                string date = sections[2];
                int year = int.Parse(sections[2].Substring(6, 4));
                int day = int.Parse(sections[2].Substring(0, 2));
                int month = int.Parse(sections[2].Substring(3, 2));
                if (score > highScore)
                {
                    highScore = score;
                    highScoreName = playerName;
                }
                if (date == findDate)
                {
                    dateScore = score;
                }
                if (playerName == "BoB")
                {
                    bobPlays++;
                }
                if (year == 2020)
                {
                    totalScore += score;
                    numPlayers++;
                }
                if (day == 29 && month == 2)
                {
                    if (score > leapHighScore)
                    {
                        leapHighScore = score;
                    }
                }
            }
            Console.WriteLine($"Player {highScoreName} has the highest score of {highScore}");
            Console.WriteLine($"The highest score on the 25/12/2019 was {dateScore}");
            Console.WriteLine($"User BoB has played {bobPlays} times!");
            Console.WriteLine($"The average score for players in 2020 was {totalScore / numPlayers}");
            Console.WriteLine($"The highest score on a leap day was {leapHighScore}");
            Console.ReadKey();
        }
    }
}



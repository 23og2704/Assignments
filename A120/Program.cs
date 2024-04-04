using System;
namespace A120
{
    internal class Program
    {
        static void makeBoard()
        {
            Random rnd = new Random();
            int[,] Board = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Board[i, j] = rnd.Next(10, 100);
                }
            }
            calcBoard(Board);
        }

        static void calcBoard(int[,] Board)
        {
            int greatestRowTotal = 0;
            int greatestRowRef = 0;
            int greatestColTotal = 0;
            int greatestColRef = 0;
            for (int i = 0; i < 5; i++)
            {
                int rowTotal = 0;
                for (int j = 0; j < 5; j++)
                {
                    rowTotal += Board[i, j];
                }
                if (rowTotal > greatestRowTotal)
                {
                    greatestRowTotal = rowTotal;
                    greatestRowRef = i;
                }
            }
            for (int j = 0; j < 5; j++)
            {
                int colTotal = 0;
                for (int i = 0; i < 5; i++)
                {
                    colTotal += Board[i, j];
                }
                if (colTotal > greatestColTotal)
                {
                    greatestColTotal = colTotal;
                    greatestColRef = j;
                }
            }
            displayBoard(Board, greatestRowRef, greatestColRef);
        }
        static void displayBoard(int[,] Board, int greatestRowRef, int greatestColRef)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.ResetColor();
                    if (i == greatestRowRef && j == greatestColRef)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (i == greatestRowRef)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (j == greatestColRef)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    Console.Write(Board[i, j]);
                    Console.ResetColor();
                    Console.Write(" | ");
                }
                int rowTotal = 0;
                for (int j = 0; j < 5; j++)
                {
                    rowTotal += Board[i, j];
                }
                if (i == greatestRowRef)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(rowTotal);
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            makeBoard();
            Console.ReadKey();
        }
    }
}
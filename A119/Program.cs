using System;
namespace A119
{
    internal class Program
    {
        static void placePieces(char[,] Board)
        {
            bool success = false;
            do
            {
                success = true;
                try
                {
                    Console.WriteLine("Enter the row for the rook: ");
                    int rookRow = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the column for the rook: ");
                    int rookCol = int.Parse(Console.ReadLine());
                    Board[rookRow, rookCol] = 'R';

                    Console.WriteLine("How many pawns would you like to enter: ");
                    int pawnCount = int.Parse(Console.ReadLine());
                    for (int i = 0; i < pawnCount; i++)
                    {
                        Console.WriteLine($"Enter the row for pawn number {i + 1}: ");
                        int pawnRow = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Enter the column for pawn number {i + 1}: ");
                        int pawnCol = int.Parse(Console.ReadLine());
                        Board[pawnRow, pawnCol] = 'P';
                    }
                    printBoard(Board);
                    rookTakeCheck(Board, rookRow, rookCol);
                } catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("\nInvalid input, you must enter an integer between 0-7!\n");
                    success = false;
                } catch (InvalidCastException ex)
                {
                    Console.WriteLine("\nInvalid input, you must enter an integer between 0-7!\n");
                    success = false;
                } catch (FormatException ex)
                {
                    Console.WriteLine("\nInvalid input, you must enter an integer between 0-7!\n");
                    success = false;
                }
            } while (success == false);   
        }
        static char[,] createBoard()
        {
            char[,] Board = new char[8, 8];
            for (int Row = 0; Row < 8; Row++)
            {
                for (int Column = 0; Column < 8; Column++)
                {
                    Board[Row, Column] = '-';
                }
            }
            return Board;
        }
        static void printBoard(char[,] Board)
        {
            for (int Column = 0; Column < 8; Column++)
            {
                Console.Write(" " + Column + "  ");
            }
            Console.WriteLine();
            for (int Row = 0; Row < 8; Row++)
            {
                Console.Write(Row + " ");
                for (int Column = 0; Column < 8; Column++)
                {
                    if (Board[Row, Column] == '-')
                    {
                        Console.Write(" ");
                    }
                    else if (Board[Row, Column] == 'R')
                    {
                        Console.Write("R");
                    }
                    else if (Board[Row, Column] == 'P')
                    {
                        Console.Write("P");
                    }
                    if (Column != 7)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void rookTakeCheck(char[,] Board, int Row, int Column)
        {
            for (int i =  0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Board[i, j] == 'P' && (Row == i || Column == j))
                    {
                        Console.WriteLine($"The pawn at coordinate ({j}, {i}) can be taken by the rook.");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            placePieces(createBoard());
            Console.ReadKey();
        }
    }
}

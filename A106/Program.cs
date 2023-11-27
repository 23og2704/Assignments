using System;

namespace A106
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to the game of 21 (Blackjack)!");
            Blackjack();
            Console.ReadKey();

        }
        static void Blackjack()
        {
            string[] cards = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            Random rnd = new Random();
            int playerScore = 0;
            int dealerScore = 0;
            for (int i = 0; i < 2; i++)
            {
                playerScore += GetCardValue(cards[rnd.Next(cards.Length)]);
                dealerScore += GetCardValue(cards[rnd.Next(cards.Length)]);
            }
            Console.WriteLine($"Your initial score: {playerScore}");
            Console.WriteLine($"Dealer's face-up card: {cards[rnd.Next(cards.Length)]}");
            while (playerScore < 21)
            {
                Console.Write("Do you want to stick or twist? (s/t): ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                choice = choice.ToLower();
                if (choice == "t")
                {
                    int cardValue = GetCardValue(cards[rnd.Next(cards.Length)]);
                    playerScore += cardValue;
                    Console.WriteLine($"You drew: {cardValue}");
                    Console.WriteLine($"Your total score: {playerScore}");
                }
                else if (choice == "s")
                {
                    break;
                }
            }
            while (dealerScore < 17)
            {
                int cardValue = GetCardValue(cards[rnd.Next(cards.Length)]);
                dealerScore += cardValue;
            }
            Console.WriteLine($"Dealer's total score: {dealerScore}");
            if (playerScore > 21 || (dealerScore <= 21 && dealerScore > playerScore))
            {
                Console.WriteLine("Dealer wins, you went bust!");
            }
            else if (dealerScore > 21 || (playerScore <= 21 && playerScore > dealerScore))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
        static int GetCardValue(string card)
        {
            if (card == "Ace")
            {
                Console.Write("Do you want the Ace to be 1 or 11? ");
                int aceValue = int.Parse(Console.ReadLine());
                if (aceValue == 1 || aceValue == 11)
                { 
                return aceValue;
                } else
                {
                    return 1;
                };
            }
            if (card == "Jack" || card == "Queen" || card == "King")
            {
                return 10;
            }
            return int.Parse(card);
        }
        static void test()
        {
            int total = 0;
            Random rnd = new Random();
            Console.WriteLine("How many cards do you want to generate? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
                string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
                string Suit = suits[rnd.Next(suits.Length)];
                string Value = values[rnd.Next(values.Length)];
                int cardValue = 0;
                if (Value == "Jack" || Value == "Queen" || Value == "King")
                {
                    cardValue = 10;
                }
                else if (Value == "Ace")
                {
                    cardValue = 11;
                }
                else
                {
                    cardValue = int.Parse(Value);
                }
                Console.WriteLine($"Card {i + 1}: {Suit} - {Value} ");
                total += cardValue;
            }
            Console.WriteLine($"Total value of {n} cards: {total}");
            Console.ReadKey();
        }
    }
}

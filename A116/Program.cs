using System;
namespace A116
{
    internal class Program
    {
        static bool Isogram(string word)
        {
            int[] count = new int[26];
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    int index = c - 'a';
                    count[index]++;
                }
            }
            int targetCount = 0;
            foreach (int num in count)
            {
                if (num > 0)
                {
                    targetCount = num;
                    break;
                }
            }
            foreach (int num in count)
            {
                if (num != 0 && num != targetCount)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a lowercase string of letters: ");
            string word = Console.ReadLine();
            Console.WriteLine(Isogram(word));
            Console.ReadKey();
        }
    }
}

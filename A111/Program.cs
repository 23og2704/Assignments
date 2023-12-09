using System;
using System.Collections.Generic;

namespace A111
{
    internal class Program
    {
        static int CountCharsInList(List<string> chars, string vowel)
        {
            int count = 0;
            foreach (var c in chars)
            {
                if (c.ToLower() == vowel) count++;
            }
            return count;
        }
        static List<string> StringToList(string word)
        {
            List<string> strings = new List<string> ();
            for (int i = 0; i < word.Length; i++)
            {
                strings.Add(word[i].ToString());
            }
            return strings;
        }
        static void Main(string[] args)
        {
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };
            Console.WriteLine("Enter a phrase: ");
            string word = Console.ReadLine();
            List<string> strings = StringToList(word);
            foreach (string v in vowels)
            {
                Console.WriteLine($"Number of '{v}' in phrase \"{word}\" = {CountCharsInList(strings, v)}");
            }
            Console.ReadKey();
        }
    }
}


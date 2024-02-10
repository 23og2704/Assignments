using System;
using System.Collections.Generic;
using System.IO;

namespace A112
{
    internal class Program
    {
        static int countChars(string chars, string vowel)
        {
            int count = 0;
            foreach (var c in chars)
            {
                if (c.ToString().ToLower() == vowel) count++;
            }
            return count;
        }
        static string removeChars(string line, string vowel)
        {
            string result = "";
            foreach (char c in line)
            {
                if (char.ToLower(c) != char.ToLower(vowel[0]))
                {
                    result += c;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string writeLine = "";
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };
            using (StreamReader sr = new StreamReader("A112 - Grinch2.txt"))
            {
                using (StreamWriter sw = new StreamWriter("vowels.txt", false))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string newLine = line;

                        foreach (string v in vowels)
                        {
                            writeLine = $"There are {countChars(line, v)} {v}'s in the file";
                            sw.WriteLine(writeLine);  
                        }
                        foreach (string v in vowels)
                        {
                            newLine = removeChars(newLine, v);
                        }
                        sw.WriteLine(newLine);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

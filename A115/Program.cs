using System;
using System.Linq;
namespace A115
{
    internal class Program
    {
        static string decrypter(string letter)
        {
            char[] result = new char[letter.Length];
            for (int i = 0; i < letter.Length; i++)
            {
                char original = letter[i];
                if (char.IsLetter(original))
                {
                    char newChar = (char)(original - 1);
                    newChar = char.ToLower(newChar); 
                    result[i] = newChar;
                }
                else
                {
                    result[i] = original;
                }
            }
            return new string(result);
        }
        static string LetterChange(string letter)
        {
            string vowels = "aeiou";
            char[] result = new char[letter.Length];
            for (int i = 0; i < letter.Length; i++)
            {
                char original = letter[i];
                if (char.IsLetter(original))
                {
                    char newChar = (char)(original + 1);

                    if (vowels.Contains(newChar))
                    {
                        newChar = char.ToUpper(newChar);
                    }
                    result[i] = newChar;
                }
                else
                {
                    result[i] = original;
                }
            }
            return new string (result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to encrypt: ");
            string encryptWord = Console.ReadLine();
            Console.WriteLine($"Encrypted : {LetterChange(encryptWord)}\n");
            Console.WriteLine("Enter string to decrypt: ");
            string decryptWord = Console.ReadLine();
            Console.WriteLine($"Decrypted : {decrypter(decryptWord)}");
            Console.ReadKey();
        }
    }
}

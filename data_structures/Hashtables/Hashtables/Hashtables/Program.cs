using System;
using Hashtables.Classes;
namespace Hashtables
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my hash table implementation!");
            Hashtable datHashTable = new Hashtable(1023);
            datHashTable.Add("cat", ConvertChar("cat"));
            datHashTable.Add("dog", ConvertChar("dog"));
            datHashTable.Add("supercalifragilisticexpialidocious",
                ConvertChar("supercalifragilisticexpialidocious"));
            datHashTable.Add("Mississippi", ConvertChar("Mississippi"));
            Console.WriteLine("Thank you for watching. Press any key to exit.");
            Console.ReadKey();
        }

        public static int ConvertChar(string word)
        {
            int value = 0;
            for (int i = 0; i < word.Length; i++)
            {
                value += word[i];
            }
            return value;
        }
    }
}

using System;
using System.Text.RegularExpressions;
using Repeated_Word.Classes;

namespace Repeated_Word
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Whiteboard Challenge 31!");

            //string datString1 = "I like bacon, eggs, and bacon again!";
            //RepeatedWord(datString1);

            //string datString2 = "eggs bacon sausage eggs bacon sausage";
            //RepeatedWord(datString2);

            string datString3 = "It was the best of times, it was the worst of times";
            RepeatedWord(datString3);
            Console.WriteLine("\nThank you for watching. Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datText"></param>
        /// <returns></returns>
        public static string RepeatedWord(string datText)
        {
            string filteredStr = Regex.Replace(datText.ToLower(), @"[^\w\s]", "");
            string[] strArray = filteredStr.Split(' ');

            Hashtable datHashTable = new Hashtable(1024);

            foreach (string word in strArray)
            {
                if (datHashTable.Contains(word))
                {
                    Console.WriteLine($"Found an existing word: {word}");
                    return word;
                }
                datHashTable.Add(word, 1);
            }

            return null;
        }
    }
}

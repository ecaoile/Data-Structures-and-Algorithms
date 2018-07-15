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
            Console.WriteLine(datHashTable.ConvertChar("cat"));
            Console.WriteLine("Thank you for watching. Press any key to exit.");
            Console.ReadKey();
        }

        //public static int ConvertChar()
        //{
        //    int value = 0;
        //    string word = 
        //}
    }
}

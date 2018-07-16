using System;
using Hashtables.Classes;
namespace Hashtables
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my hash table implementation!");
            Hashtable datHashTable = new Hashtable(1024);
            datHashTable.Add("cat", 42);
            datHashTable.Add("dog", 555);
            datHashTable.Add("supercalifragilisticexpialidocious",
                1111);
            datHashTable.Add("Mississippi", 1234);

            Console.WriteLine("\nNow let's try to find values for keys");
            datHashTable.Find("cat");
            datHashTable.Find("dog");
            datHashTable.Find("supercalifragilisticexpialidocious");

            Console.WriteLine("\nFinally, let's force some collisions!");
            datHashTable.Add("god", 777);
            datHashTable.Add("gas", 666);
            datHashTable.Add("fat", 444);

            Console.WriteLine("\nLet's see if we can find their values.");
            datHashTable.Find("god");
            datHashTable.Find("gas");
            datHashTable.Find("fat");

            Console.WriteLine("\nThank you for watching. Press any key to exit.");
            Console.ReadKey();
        }
    }
}

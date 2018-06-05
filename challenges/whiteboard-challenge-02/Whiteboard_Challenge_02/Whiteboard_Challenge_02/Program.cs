using System;

namespace Whiteboard_Challenge_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = new int[] { 1, 2, 3 };
            
            // expected match at index 1
            BinarySearch(firstArr, 2);
            // no match expected -> return -1
            BinarySearch(firstArr, 5);

            int[] secondArr = new int[] { 1, 2, 3, 4, 5, 6 };

            // expected match at index 3
            BinarySearch(secondArr, 4);
            // no match expected -> return -1
            BinarySearch(secondArr, 555);

            Console.WriteLine("Thank you for playing! Press any button to quit.");
            Console.ReadLine();
        }

        public static int BinarySearch(int[] array, int key)
        {
            Console.WriteLine("\nRunning BinarySearch function...");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    Console.WriteLine($"Match with key of {key} find at index {i}.");
                    return i;
                }
            }
            Console.WriteLine($"No match with key {key} found! Returning -1");
            return -1;
        }
    }
}
